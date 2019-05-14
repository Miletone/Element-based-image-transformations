using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Drawing.Imaging;

namespace BitmapFilters
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        /*
         * Обработчик кнопки открытия изображения
         */
        private void btnLoadSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog(); //Запустить диалоговое окно открытия изображения
            ofd.Title = "Выберите изображение"; //Изменить заголовок диалогового окна открытия изображения 
            ofd.Filter = "Bitmap Images(*.bmp)|*.bmp|Jpeg Images(*.jpg)|*.jpg|Png Images(*.png)|*.png"; //Определить список форматов изображений, которые можно открыть

            //Если на диалоговом окне открытия изображения нажата кнопка "OK"
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader streamReader = new StreamReader(ofd.FileName); //Открыть поток чтения для открываемого изображения
                Bitmap sourceBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream); //Считать изображение
                streamReader.Close(); //Закрыть поток чтения изображения

                picSource.BackgroundImage = sourceBitmap; //Отобразить исходное изображение
                picOutput.BackgroundImage = picSource.BackgroundImage.CopyAsGrayscale(); //Отобразить исходное изображение как полутоновое
                picResult.BackgroundImage = null; //Удалить результирующее изображение
                grbChart.Visible = false; //Скрыть на экране groupBox, содержащий график
                grbRadioButtons.Visible = true; //Отобразить на экране радиокнопки
                //Сделать радиокнопку линейного констрастирования доступной и неактивной
                rdbLinearContrast.Enabled = true;
                rdbLinearContrast.Checked = false;
                //Сделать радиокнопку соляризации доступной и неактивной
                rdbSolarise.Enabled = true;
                rdbSolarise.Checked = false;
                //Сделать радиокнопку гамма коррекции доступной и неактивной
                rdbGammaCorrection.Enabled = true;
                rdbGammaCorrection.Checked = false;
                //Сделать радиокнопку препарирования доступной и неактивной
                rdbDissection.Enabled = true;
                rdbDissection.Checked = false;
                //Сделать радиокнопку эквализации гистограммы доступной и неактивной
                rdbHistogramEqualization.Enabled = true;
                rdbHistogramEqualization.Checked = false;
                //Сделать радиокнопку гиперболизации гистограммы доступной и неактивной
                rdbHistogramHyperbolization.Enabled = true;
                rdbHistogramHyperbolization.Checked = false;
                pnlFilterControls.Visible = false; //Сделать панель настроек невидимой 
                SetHistogram(); //Показать гистограмму полутонового изображения
            }
        }
        /*
         * Обработчик кнопки сохранения изображения
         */
        private void btnSaveResult_Click(object sender, EventArgs e)
        {
            if (picResult.BackgroundImage != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Укажите имя и путь файла";
                sfd.Filter = "Bitmap Images(*.bmp)|*.bmp";

                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ImageFormat imgFormat = ImageFormat.Bmp;
                    StreamWriter streamWriter = new StreamWriter(sfd.FileName, false);
                    picResult.BackgroundImage.Save(streamWriter.BaseStream, imgFormat);
                    streamWriter.Flush();
                    streamWriter.Close();
                }
            }
        }
        /*
         * Функция-обработчик изменения состояния радиокнопок и панелей прокрутки
         */
        private void OnCheckChangedEventHandler(object sender, EventArgs e)
        {
            //Если исходное изображение открыто - можно выполнять преобразования, иначе - ничего не выполнять
            if (picSource.BackgroundImage != null)
            {
                SetScroll(); //Вывести на экран текущие значения панелей прокрутки
                //Если активирована радиокнопка линейного контрастирования
                if (rdbLinearContrast.Checked == true)
                {
                    //Вывести на экран панели прокрутки, необходимые для настройки линейного контрастирования, а остальные панели прокрутки сделать невидимыми
                    ShowScroll(true, false, false);
                    //Преобразовать полутоновое изображение функцией линейного контрастирования и вывести его на экран
                    picResult.BackgroundImage = picOutput.BackgroundImage.Conversion(
                        "LinearContrast", (float)trcX1.Value, (float)trcX2.Value, (float)trcY1.Value, (float)trcY2.Value, 0);
                }
                //Если активирована радиокнопка соляризации
                else if (rdbSolarise.Checked == true)
                {
                    //Вывести на экран панели прокрутки, необходимые для настройки соляризации, а остальные панели прокрутки сделать невидимыми
                    ShowScroll(true, false, false);
                    //Преобразовать полутоновое изображение функцией соляризации и вывести его на экран
                    picResult.BackgroundImage = picOutput.BackgroundImage.Conversion(
                        "Solarise", (float)trcX1.Value, (float)trcX2.Value, (float)trcY1.Value, (float)trcY2.Value, 0);
                }
                //Если активирована радиокнопка гамма коррекции
                else if (rdbGammaCorrection.Checked == true)
                {
                    //Вывести на экран панели прокрутки, необходимые для настройки гамма коррекции, а остальные панели прокрутки сделать невидимыми
                    ShowScroll(false, true, false);
                    //Преобразовать полутоновое изображение функцией гамма коррекции и вывести его на экран
                    picResult.BackgroundImage = picOutput.BackgroundImage.Conversion(
                        "GammaCorrection", (float)trcX1.Value, (float)trcX2.Value, (float)trcY1.Value, (float)trcY2.Value, Convert.ToSingle(lblGammaValue.Text));
                }
                //Если активирована радиокнопка препарирования
                else if (rdbDissection.Checked == true)
                {
                    //Вывести на экран панели прокрутки, необходимые для настройки препарирования, а остальные панели прокрутки сделать невидимыми
                    ShowScroll(true, false, false);
                    //Преобразовать полутоновое изображение функцией препарирования и вывести его на экран
                    picResult.BackgroundImage = picOutput.BackgroundImage.Conversion(
                        "Dissection", (float)trcX1.Value, (float)trcX2.Value, (float)trcY1.Value, (float)trcY2.Value, 0);
                }
                //Если активирована радиокнопка эквализации гистограммы
                else if (rdbHistogramEqualization.Checked == true) 
                {
                    //Вывести на экран панели прокрутки, необходимые для настройки эквализации гистограммы, а остальные панели прокрутки сделать невидимыми
                    ShowScroll(false, false, true);
                    //Преобразовать полутоновое изображение функцией эквализации гистограммы и вывести его на экран
                    picResult.BackgroundImage = picOutput.BackgroundImage.HistogramEqualization((float)trcYmax.Value, (float)trcYmin.Value);
                }
                //Если активирована радиокнопка гиперболизации гистограммы
                else if (rdbHistogramHyperbolization.Checked == true) 
                {
                    //Вывести на экран панели прокрутки, необходимые для настройки гиперболизации гистограммы, а остальные панели прокрутки сделать невидимыми
                    ShowScroll(false, false, true);
                    //Преобразовать полутоновое изображение функцией гиперболизации гистограммы и вывести его на экран
                    picResult.BackgroundImage = picOutput.BackgroundImage.HistogramHyperbolization((float)trcYmax.Value, (float)trcYmin.Value);
                }
                SetChart(); //Настроить график для выбранной функции преобразования полутонового изображения
                SetHistogram(); //Показать гистограмму распределения яркости
            }
        }
        /*
         * Функция отображения и настройки параметров графика функции преобразования полутонового изображения
         */
        private void SetChart() 
        {
            this.grbChart.Visible = true; //Сделать график видимым на экране
            this.crtLine.Series[0].Points.Clear(); //Удалить старые данные на графике
            this.crtLine.ChartAreas[0].AxisX.Minimum = 0; //Установить минимальное значение оси X
            this.crtLine.ChartAreas[0].AxisY.Minimum = 0; //Установить минимальное значение оси Y
            this.crtLine.ChartAreas[0].AxisX.Maximum = 255; //Установить максимальное значение оси X
            this.crtLine.ChartAreas[0].AxisY.Maximum = 255; //Установить максимальное значение оси Y
            this.crtLine.ChartAreas[0].AxisX.Title = "X"; //Добавить подпись оси X
            this.crtLine.ChartAreas[0].AxisY.Title = "Y"; //Добавить подпись оси Y
            //Настройка графика для линейного контрастирования
            if (rdbLinearContrast.Checked == true)
            {
                grbChart.Text = "График линейного контрастирования изображения"; //Изменить заголовок графика
                //Изменить тип графика
                this.crtLine.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Заполнение графика новыми данными
                this.crtLine.Series[0].Points.AddXY((byte)trcX1.Value, (byte)trcY1.Value);
                this.crtLine.Series[0].Points.AddXY((byte)trcX2.Value, (byte)trcY2.Value);
            }
            //Настройка графика для соляризации
            else if (rdbSolarise.Checked == true) 
            {
                grbChart.Text = "График соляризации изображения"; //Изменить заголовок графика
                // Изменить тип графика
                this.crtLine.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                //Заполнение графика новыми данными (добавляем новые точки)
                this.crtLine.Series[0].Points.AddXY((byte)trcX1.Value, (byte)trcY1.Value);
                this.crtLine.Series[0].Points.AddXY((byte)(trcX1.Value + (trcX2.Value - trcX1.Value) / 2), (byte)trcY2.Value);
                this.crtLine.Series[0].Points.AddXY((byte)trcX2.Value, (byte)trcY1.Value);
            }
            //Настройка графика для гамма коррекции
            else if (rdbGammaCorrection.Checked == true) 
            {
                grbChart.Text = "График гамма коррекции изображения"; //Изменить заголовок графика
                // Изменить тип графика
                this.crtLine.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
                //Заполнение графика новыми данными (добавляем новые точки)
                for (int i = 0; i < 255; i++)
                {
                    this.crtLine.Series[0].Points.AddXY((byte)i, (byte)(255f * Math.Pow(((float)i / 255f), Convert.ToSingle(lblGammaValue.Text))));
                }
            }
            //Настройка графика для препарирования
            else if (rdbDissection.Checked == true) 
            {
                grbChart.Text = "График препарирования изображения"; //Изменить заголовок графика
                // Изменить тип графика
                this.crtLine.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                //Заполнение графика новыми данными (добавляем новые точки)
                this.crtLine.Series[0].Points.AddXY(0, (byte)trcY1.Value);
                this.crtLine.Series[0].Points.AddXY((byte)trcX1.Value, (byte)trcY1.Value);
                this.crtLine.Series[0].Points.AddXY((byte)(trcX1.Value + (trcX2.Value - trcX1.Value) / 2), 0);
                this.crtLine.Series[0].Points.AddXY((byte)trcX2.Value, (byte)trcY2.Value);
                this.crtLine.Series[0].Points.AddXY(255, (byte)trcY2.Value);
            }
            //Если активирована эквализация гистограммы - скрываем график
            else if (rdbHistogramEqualization.Checked == true) 
            {
                this.grbChart.Visible = false; //Сделать график невидимым на экране
            }
            //Если активирована гиперболизация гистограммы - скрываем график
            else if (rdbHistogramHyperbolization.Checked == true)
            {
                this.grbChart.Visible = false; //Сделать график невидимым на экране
            }
        }
        /*
         * Функция отображения и настройки параметров гистограммы
         */
        private void SetHistogram()
        {
            this.grbHistogram.Visible = true; //Сделать гистограмму видимой на экране
            this.crtHistogram.Series[0].Points.Clear(); //Удалить старые данные на гистограмме
            this.crtHistogram.ChartAreas[0].AxisX.Minimum = 0; //Установить минимальное значение оси X
            this.crtHistogram.ChartAreas[0].AxisY.Minimum = 0; //Установить минимальное значение оси Y
            this.crtHistogram.ChartAreas[0].AxisX.Maximum = 255; //Установить максимальное значение оси X
            this.crtHistogram.ChartAreas[0].AxisX.Title = "I"; //Добавить подпись оси X
            this.crtHistogram.ChartAreas[0].AxisY.Title = "H(I)"; //Добавить подпись оси Y
            //Настройка гистограммы для распределения яркости результирующего изображения
            if (picResult.BackgroundImage != null)
            {
                grbHistogram.Text = "Гистограмма распределения яркости результирующего изображения"; //Изменить заголовок гистограммы
                //Получить массив, хранящий количество вхождений яркостей пикселей в промежуток [0...255]
                int[] brightnessValuesCount = picResult.BackgroundImage.GetBrightnessValuesCount();

                this.crtHistogram.ChartAreas[0].AxisY.Maximum = brightnessValuesCount.Max<int>(); //Установить максимальное значение оси Y
                //Заполнение гистограммы новыми данными
                for (int i = 0; i < brightnessValuesCount.Length; i++) 
                {
                    this.crtHistogram.Series[0].Points.AddXY(i, brightnessValuesCount[i]);
                }
                brightnessValuesCount = null; //Удалить массив количества вхождений яркостей пикселей
            }
            //Настройка гистограммы для распределения яркости полутонового изображения
            else if (picOutput.BackgroundImage != null)
            {
                grbHistogram.Text = "Гистограмма распределения яркости полутонового изображения"; //Изменить заголовок гистограммы
                //Получить массив, хранящий количество вхождений яркостей пикселей в промежуток [0...255]
                int[] brightnessValuesCount = picOutput.BackgroundImage.GetBrightnessValuesCount();
                this.crtHistogram.ChartAreas[0].AxisY.Maximum = brightnessValuesCount.Max<int>(); //Установить максимальное значение оси Y
                //Заполнение гистограммы новыми данными
                for (int i = 0; i < brightnessValuesCount.Length; i++)
                {
                    this.crtHistogram.Series[0].Points.AddXY(i, brightnessValuesCount[i]);
                }
                brightnessValuesCount = null; //Удалить массив количества вхождений яркостей пикселей
            }
        }
        /*
         * Функция, которая выводит на экран текущие значения панелей прокрутки
         */
        private void SetScroll()
        {
            lblX1Value.Text = trcX1.Value.ToString(); //Вывести на экран значение панели прокрутки "X1"
            lblX2Value.Text = trcX2.Value.ToString(); //Вывести на экран значение панели прокрутки "X2"
            lblY1Value.Text = trcY1.Value.ToString(); //Вывести на экран значение панели прокрутки "Y1"
            lblY2Value.Text = trcY2.Value.ToString(); //Вывести на экран значение панели прокрутки "Y2"
            //Если значение панели прокрутки "γ" меньше нуля
            if (trcGamma.Value < 0) 
            {
                /*
                 * По умолчанию значения панели прокрутки имеют вид [..., -3, -2, -1, 0, 1, 2, 3, 4, ...],
                 * а нам необходимо, чтобы панель прокрутки принимала значения вида [..., 1/3, 1/2, 0, 1, 2, 3, 4, ...],
                 * поэтому те значения панели прокрутки "γ", которые больше или равны нулю мы оставляем нетронутыми,
                 * а те, которые меньше нуля делаем положительными, уменьшаем на единицу,
                 * затем, делим единицу на полученное значение панели прокрутки и выводим результат на экран
                 */
                int value = Math.Abs(trcGamma.Value - 1); //Делаем значение положительным и уменьшаем на единицу
                lblGammaValue.Text = (1f / value).ToString(); //Делим единицу на полученное значение и выводим результат на экран
            }
            //Если значение панели прокрутки "γ" больше или равно нулю
            else 
            {
                lblGammaValue.Text = trcGamma.Value.ToString(); //Выводим его на экран без изменений
            }
            //Корректируем значения Ymin и Ymax, чтобы Ymin не было больше или равно Ymax
            if (trcYmin.Value >= trcYmax.Value)
                trcYmax.Value = trcYmin.Value + 1;
            lblYmaxValue.Text = trcYmax.Value.ToString(); //Вывести на экран значение панели прокрутки "Ymax"
            lblYminValue.Text = trcYmin.Value.ToString(); //Вывести на экран значение панели прокрутки "Ymin"
        }
        /*
         * Функция, которая выводит на экран нужные панели прокрутки, а остальные панели прокрутки делает невидимыми
         */
        private void ShowScroll(bool showX1X2Y1Y2, bool showGamma, bool showYmaxWmin)
        {
            pnlFilterControls.Visible = true; //Сделать видимой панель, на которой расположены панели прокрутки
            /*
             * Для настройки параметров линейного контрастирования, соляризации и препарирования необходимы одни и те же панели прокрутки,
             * поэтому, список элементов, которые нужно вывести на экран (или скрыть), для этих преобразований, совпадает  
             */
            //Выводим на экран панели прокрутки, необходимые для настройки линейного контрастирования, соляризации и препарирования
            if (showX1X2Y1Y2 == true) 
            {
                lblX1Value.Visible = true; lblX2Value.Visible = true;
                lblY1Value.Visible = true; lblY2Value.Visible = true;
                lblX1.Visible = true; lblX2.Visible = true;
                lblY1.Visible = true; lblY2.Visible = true;
                trcX1.Visible = true; trcX2.Visible = true;
                trcY1.Visible = true; trcY2.Visible = true;
                lblGammaValue.Visible = false; lblGamma.Visible = false; trcGamma.Visible = false;
                lblYmax.Visible = false; trcYmax.Visible = false; lblYmaxValue.Visible = false;
                lblYmin.Visible = false; trcYmin.Visible = false; lblYminValue.Visible = false;
            }
            //Выводим на экран панели прокрутки, необходимые для настройки гамма коррекции
            else if (showGamma == true) 
            {
                lblX1Value.Visible = false; lblX2Value.Visible = false;
                lblY1Value.Visible = false; lblY2Value.Visible = false;
                lblX1.Visible = false; lblX2.Visible = false;
                lblY1.Visible = false; lblY2.Visible = false;
                trcX1.Visible = false; trcX2.Visible = false;
                trcY1.Visible = false; trcY2.Visible = false;
                lblGammaValue.Visible = true; lblGamma.Visible = true; trcGamma.Visible = true;
                lblYmax.Visible = false; trcYmax.Visible = false; lblYmaxValue.Visible = false;
                lblYmin.Visible = false; trcYmin.Visible = false; lblYminValue.Visible = false;
            }
            //Выводим на экран панели прокрутки, необходимые для настройки эквализации и гиперболизации гистограммы
            else if (showYmaxWmin == true)
            {
                lblX1Value.Visible = false; lblX2Value.Visible = false;
                lblY1Value.Visible = false; lblY2Value.Visible = false;
                lblX1.Visible = false; lblX2.Visible = false;
                lblY1.Visible = false; lblY2.Visible = false;
                trcX1.Visible = false; trcX2.Visible = false;
                trcY1.Visible = false; trcY2.Visible = false;
                lblGammaValue.Visible = false; lblGamma.Visible = false; trcGamma.Visible = false;
                lblYmax.Visible = true; trcYmax.Visible = true; lblYmaxValue.Visible = true;
                lblYmin.Visible = true; trcYmin.Visible = true; lblYminValue.Visible = true;
            }
        }
        /*
         * Функция-обработчик нажатия кнопкой мыши на исходное изображение
         */
        private void picSource_MouseClick(object sender, MouseEventArgs e)
        {
            //Если присутствует исходное изображение
            if (picSource.BackgroundImage != null)
            {
                //Создаём модальное окно, помещаем в него исходное изображение и изменяем заголовок этого окна
                ShowImageForm ImageForm = new ShowImageForm(picSource.BackgroundImage, "Исходное изображение");
                //Открывем, созданное модальное окно
                ImageForm.ShowDialog(this);
            }
        }
        /*
         * Функция-обработчик нажатия кнопкой мыши на полутоновое изображение
         */
        private void picOutput_MouseClick(object sender, MouseEventArgs e)
        {
            //Если присутствует полутоновое изображение
            if (picOutput.BackgroundImage != null)
            {
                //Создаём модальное окно, помещаем в него полутоновое изображение и изменяем заголовок этого окна
                ShowImageForm ImageForm = new ShowImageForm(picOutput.BackgroundImage, "Полутоновое изображение");
                //Открывем, созданное модальное окно
                ImageForm.ShowDialog(this);
            }
        }
        /*
         * Функция-обработчик нажатия кнопкой мыши на результирующее изображение
         */
        private void picResult_MouseClick(object sender, MouseEventArgs e)
        {
            //Если присутствует результирующее изображение
            if (picResult.BackgroundImage != null)
            {
                //Создаём модальное окно, помещаем в него результирующее изображение и изменяем заголовок этого окна
                ShowImageForm ImageForm = new ShowImageForm(picResult.BackgroundImage, "Результирующее изображение");
                //Открывем, созданное модальное окно
                ImageForm.ShowDialog(this);
            }
        }
        /*
         * Функция-обработчик нажатия кнопкой мыши на гистограмму распределения яркости
         * Если на экране изображена гистограмма распределения яркости результирующего изображения,
         * то один клик кнопки мыши изменит её на гистограмму распределения яркости полутонового изображения
         * и наоборот.
         */
        private void crtHistogram_MouseClick(object sender, MouseEventArgs e)
        {
            //Если результирующее изображение выведено на экран 
            if (picResult.BackgroundImage != null)
            {
                if (grbHistogram.Text == "Гистограмма распределения яркости результирующего изображения")
                {
                    grbHistogram.Text = "Гистограмма распределения яркости полутонового изображения"; //Изменить заголовок гистограммы
                    this.crtHistogram.Series[0].Points.Clear(); //Удалить старые данные на гистограмме
                    //Получить массив, хранящий количество вхождений яркостей пикселей в промежуток [0...255]
                    int[] brightnessValuesCount = picOutput.BackgroundImage.GetBrightnessValuesCount();
                    this.crtHistogram.ChartAreas[0].AxisY.Maximum = brightnessValuesCount.Max<int>(); //Установить максимальное значение оси Y
                    //Заполнение гистограммы новыми данными
                    for (int i = 0; i < brightnessValuesCount.Length; i++)
                    {
                        this.crtHistogram.Series[0].Points.AddXY(i, brightnessValuesCount[i]);
                    }
                    brightnessValuesCount = null; //Удалить массив количества вхождений яркостей пикселей
                }
                else if (grbHistogram.Text == "Гистограмма распределения яркости полутонового изображения") 
                {
                    grbHistogram.Text = "Гистограмма распределения яркости результирующего изображения"; //Изменить заголовок гистограммы
                    this.crtHistogram.Series[0].Points.Clear(); //Удалить старые данные на гистограмме
                    //Получить массив, хранящий количество вхождений яркостей пикселей в промежуток [0...255]
                    int[] brightnessValuesCount = picResult.BackgroundImage.GetBrightnessValuesCount();
                    this.crtHistogram.ChartAreas[0].AxisY.Maximum = brightnessValuesCount.Max<int>(); //Установить максимальное значение оси Y
                    //Заполнение гистограммы новыми данными
                    for (int i = 0; i < brightnessValuesCount.Length; i++)
                    {
                        this.crtHistogram.Series[0].Points.AddXY(i, brightnessValuesCount[i]);
                    }
                    brightnessValuesCount = null; //Удалить массив количества вхождений яркостей пикселей
                }
            }
        }
    }
}