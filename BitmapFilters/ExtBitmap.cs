using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace BitmapFilters
{
    public static class ExtBitmap
    {
        /*
         * Возвращает копию входного изображения с пикселями формата 32bppArgb
         */
        private static Bitmap GetArgbCopy(Image sourceImage)
        {
            Bitmap bmpNew = new Bitmap(sourceImage.Width, sourceImage.Height, PixelFormat.Format32bppArgb);

            using (Graphics graphics = Graphics.FromImage(bmpNew))
            {
                graphics.DrawImage(sourceImage, new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), new Rectangle(0, 0, bmpNew.Width, bmpNew.Height), GraphicsUnit.Pixel);
                graphics.Flush();
            }

            return bmpNew;
        }
        /*
         * Преобразует изображение в grayscale (полутон, оттенки серого)
         */
        public static Bitmap CopyAsGrayscale(this Image sourceImage)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            System.Runtime.InteropServices.Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            float rgb = 0;

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                rgb = byteBuffer[k] * 0.071f; //Blue
                rgb += byteBuffer[k + 1] * 0.707f; //Green
                rgb += byteBuffer[k + 2] * 0.222f; //Red

                byteBuffer[k] = (byte)rgb;
                byteBuffer[k + 1] = byteBuffer[k];
                byteBuffer[k + 2] = byteBuffer[k];

                byteBuffer[k + 3] = 255;
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;

            return bmpNew;
        }
        /*
         * Функция, выполняющая линейное контрастирование, соляризацию 
         * или гамма коррекцию изображения, в зависимости от установленного режима (mode)
         */
        public static Bitmap Conversion(this Image sourceImage, string mode, float x1, float x2, float y1, float y2, float gamma)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            float y = 0;
            float i = 0;
            float q = 0;
            float r = 0;
            float g = 0;
            float b = 0;
            
            // Вычисляем значения необходимого преобразования яркости для всех возможных значений яркости
            byte[] conversionValues = new byte[256]; //Массив для хранения преобразованных значений яркости
            for (int x = 0; x < 255; x++) 
            {
                //Если необходимо выполнить линейное контрастирование изображения
                if (mode == "LinearContrast")
                {
                    conversionValues[x] = (byte)(y1 + ((y2 - y1) / (x2 - x1)) * (x - x1));
                }
                //Если необходимо выполнить соляризацию изображения
                else if (mode == "Solarise") 
                {
                    conversionValues[x] = (byte)(y1 - 4 * (y2 - y1) * (((x - x1) * (x - x2)) / ((x2 - x1) * (x2 - x1))));
                }
                //Если необходимо выполнить гамма коррекцию изображения
                else if (mode == "GammaCorrection") 
                {
                    conversionValues[x] = (byte)(255f * Math.Pow((x / 255f), gamma));
                }
                //Если необходимо выполнить препарирование изображения
                else if(mode == "Dissection")
                {
                    if (x <= x1)
                    {
                        conversionValues[x] = (byte)y1;
                    }
                    else if ((x > x1) && (x <= (byte)(x1 + ((x2 - x1) / 2f))))
                    {
                        conversionValues[x] = (byte)(y1 + ((0f - y1) / ((x1 + (x2 - x1) / 2f) - x1)) * (x - x1));
                    }
                    else if ((x > (byte)(x1 + ((x2 - x1) / 2f))) && (x <= x2))
                    {
                        conversionValues[x] = (byte)((y2 / (x2 - (x1 + (x2 - x1) / 2f))) * (x - (x1 + (x2 - x1) / 2f)));
                    }
                    else if (x > x2)
                    {
                        conversionValues[x] = (byte)y2;
                    }
                }
            }

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                //Переводим из RGB в YIQ, чтобы получить компоненту яркости "Y" пикселей изображения
                y = byteBuffer[k + 2] * 0.3f + byteBuffer[k + 1] * 0.59f + byteBuffer[k] * 0.11f;
                i = byteBuffer[k + 2] * 0.6f - byteBuffer[k + 1] * 0.28f - byteBuffer[k] * 0.32f;
                q = byteBuffer[k + 2] * 0.21f - byteBuffer[k + 1] * 0.52f + byteBuffer[k] * 0.31f;
                /*
                 * Т.к. мы уже определили преобразованные значения яркости для всех возможных значений исходной яркости,
                 * то нет необходимости преобразовывать значение "Y" снова,
                 * просто запишем в него значение, индекс которого равен текущему значению Y
                 */
                y = conversionValues[(byte)y];                
                /*
                 * Значение яркости текущего пикселя преобразовано, 
                 * теперь переводим его цвет из цветовой модели YIQ обратно в цветовую модель RGB
                 */
                r = y + 0.956f * i + 0.623f * q;
                g = y - 0.272f * i - 0.648f * q;
                b = y - 1.105f * i + 1.705f * q;

                byteBuffer[k + 2] = (byte)r;
                byteBuffer[k + 1] = (byte)g;
                byteBuffer[k] = (byte)b;
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;
            conversionValues = null;

            return bmpNew;
        }
        /*
         * Возвращает массив, содержащий количество пикселей с соответствующим значением яркости.
         * Индекс элемента массива - это значение яркости, а значение элемента массива - это количество пикселей с таким значением яркости.
         * Этот массив необходим для построения гистограммы распределения яркости изображения.
         */
        public static int[] GetBrightnessValuesCount(this Image sourceImage)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            System.Runtime.InteropServices.Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            int[] brightnessValuesCount = new int[256];
            float y = 0;

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                y = byteBuffer[k + 2] * 0.3f + byteBuffer[k + 1] * 0.59f + byteBuffer[k] * 0.11f;
                brightnessValuesCount[(int)y]++;
            }

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;


            return brightnessValuesCount;
        }
        /*
         * Функция, выполняющая эквализацию гистограммы
         */
        public static Bitmap HistogramEqualization(this Image sourceImage, float ymax, float ymin)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            float y = 0;
            float i = 0;
            float q = 0;
            float r = 0;
            float g = 0;
            float b = 0;
            float[] conversionValues = new float[256];
            float[] brightnessValuesCount = new float[256];
            float Fx = 0;

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                y = byteBuffer[k + 2] * 0.3f + byteBuffer[k + 1] * 0.59f + byteBuffer[k] * 0.11f;
                brightnessValuesCount[(int)y]++;
            }
            for (int j = 0; j < conversionValues.Length; j++)
            {
                Fx = 0;
                for (int k = 0; k < j; k++)
                {
                    Fx += brightnessValuesCount[k] / (sourceImage.Width * sourceImage.Height);
                }
                conversionValues[j] = ymin + Fx * (ymax - ymin);
            }

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                y = byteBuffer[k + 2] * 0.3f + byteBuffer[k + 1] * 0.59f + byteBuffer[k] * 0.11f;
                i = byteBuffer[k + 2] * 0.6f - byteBuffer[k + 1] * 0.28f - byteBuffer[k] * 0.32f;
                q = byteBuffer[k + 2] * 0.21f - byteBuffer[k + 1] * 0.52f + byteBuffer[k] * 0.31f;
                
                y = conversionValues[(byte)y];
                
                r = y + 0.956f * i + 0.623f * q;
                g = y - 0.272f * i - 0.648f * q;
                b = y - 1.105f * i + 1.705f * q;
                
                byteBuffer[k + 2] = (byte)r;
                byteBuffer[k + 1] = (byte)g;
                byteBuffer[k] = (byte)b;
            }
            
            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;
            conversionValues = null;
            brightnessValuesCount = null;

            return bmpNew;
        }
        /*
         * Функция, выполняющая гиперболизацию гистограммы
         */
        public static Bitmap HistogramHyperbolization(this Image sourceImage, float ymax, float ymin)
        {
            Bitmap bmpNew = GetArgbCopy(sourceImage);
            BitmapData bmpData = bmpNew.LockBits(new Rectangle(0, 0, sourceImage.Width, sourceImage.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

            IntPtr ptr = bmpData.Scan0;

            byte[] byteBuffer = new byte[bmpData.Stride * bmpNew.Height];

            Marshal.Copy(ptr, byteBuffer, 0, byteBuffer.Length);

            float y = 0;
            float i = 0;
            float q = 0;
            float r = 0;
            float g = 0;
            float b = 0;
            float[] conversionValues = new float[256];
            float[] brightnessValuesCount = new float[256];
            float Fx = 0;

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                y = byteBuffer[k + 2] * 0.3f + byteBuffer[k + 1] * 0.59f + byteBuffer[k] * 0.11f;
                brightnessValuesCount[(int)y]++;
            }
            for (int j = 0; j < conversionValues.Length; j++)
            {
                Fx = 0;
                for (int k = 0; k < j; k++)
                {
                    Fx += brightnessValuesCount[k] / (sourceImage.Width * sourceImage.Height);
                }
                conversionValues[j] = (float)(ymin * Math.Pow((ymax / ymin), Fx));
            }

            for (int k = 0; k < byteBuffer.Length; k += 4)
            {
                y = byteBuffer[k + 2] * 0.3f + byteBuffer[k + 1] * 0.59f + byteBuffer[k] * 0.11f;
                i = byteBuffer[k + 2] * 0.6f - byteBuffer[k + 1] * 0.28f - byteBuffer[k] * 0.32f;
                q = byteBuffer[k + 2] * 0.21f - byteBuffer[k + 1] * 0.52f + byteBuffer[k] * 0.31f;

                y = conversionValues[(byte)y];

                r = y + 0.956f * i + 0.623f * q;
                g = y - 0.272f * i - 0.648f * q;
                b = y - 1.105f * i + 1.705f * q;

                byteBuffer[k + 2] = (byte)r;
                byteBuffer[k + 1] = (byte)g;
                byteBuffer[k] = (byte)b;
            }

            Marshal.Copy(byteBuffer, 0, ptr, byteBuffer.Length);

            bmpNew.UnlockBits(bmpData);

            bmpData = null;
            byteBuffer = null;
            conversionValues = null;

            return bmpNew;
        }
    }
}