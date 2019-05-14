namespace BitmapFilters
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.grbInput = new System.Windows.Forms.GroupBox();
            this.picSource = new System.Windows.Forms.Panel();
            this.grbOutput = new System.Windows.Forms.GroupBox();
            this.picOutput = new System.Windows.Forms.Panel();
            this.btnLoadSource = new System.Windows.Forms.Button();
            this.crtLine = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbChart = new System.Windows.Forms.GroupBox();
            this.grbResult = new System.Windows.Forms.GroupBox();
            this.picResult = new System.Windows.Forms.Panel();
            this.rdbLinearContrast = new System.Windows.Forms.RadioButton();
            this.rdbSolarise = new System.Windows.Forms.RadioButton();
            this.rdbGammaCorrection = new System.Windows.Forms.RadioButton();
            this.rdbDissection = new System.Windows.Forms.RadioButton();
            this.pnlFilterControls = new System.Windows.Forms.Panel();
            this.lblYminValue = new System.Windows.Forms.Label();
            this.lblYmin = new System.Windows.Forms.Label();
            this.trcYmin = new System.Windows.Forms.TrackBar();
            this.lblYmaxValue = new System.Windows.Forms.Label();
            this.lblYmax = new System.Windows.Forms.Label();
            this.trcYmax = new System.Windows.Forms.TrackBar();
            this.lblGammaValue = new System.Windows.Forms.Label();
            this.lblSettings = new System.Windows.Forms.Label();
            this.trcX1 = new System.Windows.Forms.TrackBar();
            this.lblGamma = new System.Windows.Forms.Label();
            this.trcGamma = new System.Windows.Forms.TrackBar();
            this.lblX1 = new System.Windows.Forms.Label();
            this.lblX1Value = new System.Windows.Forms.Label();
            this.trcX2 = new System.Windows.Forms.TrackBar();
            this.lblX2 = new System.Windows.Forms.Label();
            this.lblX2Value = new System.Windows.Forms.Label();
            this.lblY2Value = new System.Windows.Forms.Label();
            this.trcY1 = new System.Windows.Forms.TrackBar();
            this.lblY1 = new System.Windows.Forms.Label();
            this.lblY2 = new System.Windows.Forms.Label();
            this.lblY1Value = new System.Windows.Forms.Label();
            this.trcY2 = new System.Windows.Forms.TrackBar();
            this.grbRadioButtons = new System.Windows.Forms.GroupBox();
            this.btnSaveResult = new System.Windows.Forms.Button();
            this.rdbHistogramHyperbolization = new System.Windows.Forms.RadioButton();
            this.rdbHistogramEqualization = new System.Windows.Forms.RadioButton();
            this.grbHistogram = new System.Windows.Forms.GroupBox();
            this.crtHistogram = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grbInput.SuspendLayout();
            this.grbOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtLine)).BeginInit();
            this.grbChart.SuspendLayout();
            this.grbResult.SuspendLayout();
            this.pnlFilterControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcYmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcYmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcX1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGamma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcX2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcY1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcY2)).BeginInit();
            this.grbRadioButtons.SuspendLayout();
            this.grbHistogram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.crtHistogram)).BeginInit();
            this.SuspendLayout();
            // 
            // grbInput
            // 
            this.grbInput.Controls.Add(this.picSource);
            this.grbInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbInput.Location = new System.Drawing.Point(12, 12);
            this.grbInput.Name = "grbInput";
            this.grbInput.Size = new System.Drawing.Size(206, 224);
            this.grbInput.TabIndex = 0;
            this.grbInput.TabStop = false;
            this.grbInput.Text = "Исходное изображение";
            // 
            // picSource
            // 
            this.picSource.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picSource.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picSource.Location = new System.Drawing.Point(3, 21);
            this.picSource.Name = "picSource";
            this.picSource.Size = new System.Drawing.Size(200, 200);
            this.picSource.TabIndex = 0;
            this.picSource.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picSource_MouseClick);
            // 
            // grbOutput
            // 
            this.grbOutput.Controls.Add(this.picOutput);
            this.grbOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbOutput.Location = new System.Drawing.Point(224, 12);
            this.grbOutput.Name = "grbOutput";
            this.grbOutput.Size = new System.Drawing.Size(206, 224);
            this.grbOutput.TabIndex = 1;
            this.grbOutput.TabStop = false;
            this.grbOutput.Text = "Полутоновое изображение";
            // 
            // picOutput
            // 
            this.picOutput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picOutput.Location = new System.Drawing.Point(3, 21);
            this.picOutput.Name = "picOutput";
            this.picOutput.Size = new System.Drawing.Size(200, 200);
            this.picOutput.TabIndex = 0;
            this.picOutput.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picOutput_MouseClick);
            // 
            // btnLoadSource
            // 
            this.btnLoadSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadSource.Location = new System.Drawing.Point(6, 136);
            this.btnLoadSource.Name = "btnLoadSource";
            this.btnLoadSource.Size = new System.Drawing.Size(186, 40);
            this.btnLoadSource.TabIndex = 2;
            this.btnLoadSource.Text = "Открыть";
            this.btnLoadSource.UseVisualStyleBackColor = true;
            this.btnLoadSource.Click += new System.EventHandler(this.btnLoadSource_Click);
            // 
            // crtLine
            // 
            chartArea1.Name = "ChartArea1";
            this.crtLine.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.crtLine.Legends.Add(legend1);
            this.crtLine.Location = new System.Drawing.Point(6, 20);
            this.crtLine.Name = "crtLine";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Частота попадания яркостей";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.crtLine.Series.Add(series1);
            this.crtLine.Size = new System.Drawing.Size(472, 200);
            this.crtLine.TabIndex = 4;
            this.crtLine.Text = "chart1";
            // 
            // grbChart
            // 
            this.grbChart.Controls.Add(this.crtLine);
            this.grbChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbChart.Location = new System.Drawing.Point(648, 242);
            this.grbChart.Name = "grbChart";
            this.grbChart.Size = new System.Drawing.Size(484, 224);
            this.grbChart.TabIndex = 2;
            this.grbChart.TabStop = false;
            this.grbChart.Text = "График преобразования";
            this.grbChart.Visible = false;
            // 
            // grbResult
            // 
            this.grbResult.Controls.Add(this.picResult);
            this.grbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbResult.Location = new System.Drawing.Point(436, 12);
            this.grbResult.Name = "grbResult";
            this.grbResult.Size = new System.Drawing.Size(206, 224);
            this.grbResult.TabIndex = 1;
            this.grbResult.TabStop = false;
            this.grbResult.Text = "Результат";
            // 
            // picResult
            // 
            this.picResult.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picResult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picResult.Location = new System.Drawing.Point(3, 21);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(200, 200);
            this.picResult.TabIndex = 0;
            this.picResult.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picResult_MouseClick);
            // 
            // rdbLinearContrast
            // 
            this.rdbLinearContrast.AutoSize = true;
            this.rdbLinearContrast.Enabled = false;
            this.rdbLinearContrast.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbLinearContrast.Location = new System.Drawing.Point(6, 19);
            this.rdbLinearContrast.Name = "rdbLinearContrast";
            this.rdbLinearContrast.Size = new System.Drawing.Size(176, 17);
            this.rdbLinearContrast.TabIndex = 0;
            this.rdbLinearContrast.TabStop = true;
            this.rdbLinearContrast.Text = "- линейное контрастирование";
            this.rdbLinearContrast.UseVisualStyleBackColor = true;
            this.rdbLinearContrast.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdbSolarise
            // 
            this.rdbSolarise.AutoSize = true;
            this.rdbSolarise.Enabled = false;
            this.rdbSolarise.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbSolarise.Location = new System.Drawing.Point(6, 38);
            this.rdbSolarise.Name = "rdbSolarise";
            this.rdbSolarise.Size = new System.Drawing.Size(97, 17);
            this.rdbSolarise.TabIndex = 1;
            this.rdbSolarise.TabStop = true;
            this.rdbSolarise.Text = "- соляризация";
            this.rdbSolarise.UseVisualStyleBackColor = true;
            this.rdbSolarise.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdbGammaCorrection
            // 
            this.rdbGammaCorrection.AutoSize = true;
            this.rdbGammaCorrection.Enabled = false;
            this.rdbGammaCorrection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbGammaCorrection.Location = new System.Drawing.Point(6, 57);
            this.rdbGammaCorrection.Name = "rdbGammaCorrection";
            this.rdbGammaCorrection.Size = new System.Drawing.Size(121, 17);
            this.rdbGammaCorrection.TabIndex = 2;
            this.rdbGammaCorrection.TabStop = true;
            this.rdbGammaCorrection.Text = "- гамма коррекция";
            this.rdbGammaCorrection.UseVisualStyleBackColor = true;
            this.rdbGammaCorrection.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdbDissection
            // 
            this.rdbDissection.AutoSize = true;
            this.rdbDissection.Enabled = false;
            this.rdbDissection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbDissection.Location = new System.Drawing.Point(6, 75);
            this.rdbDissection.Name = "rdbDissection";
            this.rdbDissection.Size = new System.Drawing.Size(115, 17);
            this.rdbDissection.TabIndex = 3;
            this.rdbDissection.TabStop = true;
            this.rdbDissection.Text = "- препарирование";
            this.rdbDissection.UseVisualStyleBackColor = true;
            this.rdbDissection.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // pnlFilterControls
            // 
            this.pnlFilterControls.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilterControls.Controls.Add(this.lblYminValue);
            this.pnlFilterControls.Controls.Add(this.lblYmin);
            this.pnlFilterControls.Controls.Add(this.trcYmin);
            this.pnlFilterControls.Controls.Add(this.lblYmaxValue);
            this.pnlFilterControls.Controls.Add(this.lblYmax);
            this.pnlFilterControls.Controls.Add(this.trcYmax);
            this.pnlFilterControls.Controls.Add(this.lblGammaValue);
            this.pnlFilterControls.Controls.Add(this.lblSettings);
            this.pnlFilterControls.Controls.Add(this.trcX1);
            this.pnlFilterControls.Controls.Add(this.lblGamma);
            this.pnlFilterControls.Controls.Add(this.trcGamma);
            this.pnlFilterControls.Controls.Add(this.lblX1);
            this.pnlFilterControls.Controls.Add(this.lblX1Value);
            this.pnlFilterControls.Controls.Add(this.trcX2);
            this.pnlFilterControls.Controls.Add(this.lblX2);
            this.pnlFilterControls.Controls.Add(this.lblX2Value);
            this.pnlFilterControls.Controls.Add(this.lblY2Value);
            this.pnlFilterControls.Controls.Add(this.trcY1);
            this.pnlFilterControls.Controls.Add(this.lblY1);
            this.pnlFilterControls.Controls.Add(this.lblY2);
            this.pnlFilterControls.Controls.Add(this.lblY1Value);
            this.pnlFilterControls.Controls.Add(this.trcY2);
            this.pnlFilterControls.Location = new System.Drawing.Point(198, 15);
            this.pnlFilterControls.Name = "pnlFilterControls";
            this.pnlFilterControls.Size = new System.Drawing.Size(423, 203);
            this.pnlFilterControls.TabIndex = 18;
            this.pnlFilterControls.Visible = false;
            // 
            // lblYminValue
            // 
            this.lblYminValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYminValue.Location = new System.Drawing.Point(378, 128);
            this.lblYminValue.Name = "lblYminValue";
            this.lblYminValue.Size = new System.Drawing.Size(40, 23);
            this.lblYminValue.TabIndex = 37;
            this.lblYminValue.Text = "0";
            this.lblYminValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYmin
            // 
            this.lblYmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYmin.Location = new System.Drawing.Point(10, 128);
            this.lblYmin.Name = "lblYmin";
            this.lblYmin.Size = new System.Drawing.Size(53, 23);
            this.lblYmin.TabIndex = 36;
            this.lblYmin.Text = "Ymin";
            this.lblYmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcYmin
            // 
            this.trcYmin.AutoSize = false;
            this.trcYmin.BackColor = System.Drawing.Color.LightGray;
            this.trcYmin.Location = new System.Drawing.Point(69, 128);
            this.trcYmin.Maximum = 254;
            this.trcYmin.Name = "trcYmin";
            this.trcYmin.Size = new System.Drawing.Size(303, 23);
            this.trcYmin.TabIndex = 35;
            this.trcYmin.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcYmin.Scroll += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // lblYmaxValue
            // 
            this.lblYmaxValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYmaxValue.Location = new System.Drawing.Point(378, 71);
            this.lblYmaxValue.Name = "lblYmaxValue";
            this.lblYmaxValue.Size = new System.Drawing.Size(40, 23);
            this.lblYmaxValue.TabIndex = 34;
            this.lblYmaxValue.Text = "0";
            this.lblYmaxValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblYmax
            // 
            this.lblYmax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblYmax.Location = new System.Drawing.Point(10, 70);
            this.lblYmax.Name = "lblYmax";
            this.lblYmax.Size = new System.Drawing.Size(53, 23);
            this.lblYmax.TabIndex = 33;
            this.lblYmax.Text = "Ymax";
            this.lblYmax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcYmax
            // 
            this.trcYmax.AutoSize = false;
            this.trcYmax.BackColor = System.Drawing.Color.LightGray;
            this.trcYmax.Location = new System.Drawing.Point(69, 70);
            this.trcYmax.Maximum = 255;
            this.trcYmax.Minimum = 1;
            this.trcYmax.Name = "trcYmax";
            this.trcYmax.Size = new System.Drawing.Size(303, 23);
            this.trcYmax.TabIndex = 32;
            this.trcYmax.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcYmax.Value = 1;
            this.trcYmax.Scroll += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // lblGammaValue
            // 
            this.lblGammaValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGammaValue.Location = new System.Drawing.Point(378, 99);
            this.lblGammaValue.Name = "lblGammaValue";
            this.lblGammaValue.Size = new System.Drawing.Size(40, 23);
            this.lblGammaValue.TabIndex = 31;
            this.lblGammaValue.Text = "0";
            this.lblGammaValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGammaValue.Visible = false;
            // 
            // lblSettings
            // 
            this.lblSettings.AutoSize = true;
            this.lblSettings.Location = new System.Drawing.Point(175, 9);
            this.lblSettings.Name = "lblSettings";
            this.lblSettings.Size = new System.Drawing.Size(79, 16);
            this.lblSettings.TabIndex = 28;
            this.lblSettings.Text = "Настройки";
            // 
            // trcX1
            // 
            this.trcX1.AutoSize = false;
            this.trcX1.BackColor = System.Drawing.Color.LightGray;
            this.trcX1.Location = new System.Drawing.Point(45, 37);
            this.trcX1.Maximum = 255;
            this.trcX1.Name = "trcX1";
            this.trcX1.Size = new System.Drawing.Size(327, 23);
            this.trcX1.TabIndex = 16;
            this.trcX1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcX1.Scroll += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // lblGamma
            // 
            this.lblGamma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGamma.Location = new System.Drawing.Point(9, 96);
            this.lblGamma.Name = "lblGamma";
            this.lblGamma.Size = new System.Drawing.Size(30, 23);
            this.lblGamma.TabIndex = 30;
            this.lblGamma.Text = "γ";
            this.lblGamma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblGamma.Visible = false;
            // 
            // trcGamma
            // 
            this.trcGamma.AutoSize = false;
            this.trcGamma.BackColor = System.Drawing.Color.LightGray;
            this.trcGamma.Location = new System.Drawing.Point(45, 99);
            this.trcGamma.Minimum = -9;
            this.trcGamma.Name = "trcGamma";
            this.trcGamma.Size = new System.Drawing.Size(327, 23);
            this.trcGamma.TabIndex = 29;
            this.trcGamma.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcGamma.Visible = false;
            this.trcGamma.Scroll += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // lblX1
            // 
            this.lblX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX1.Location = new System.Drawing.Point(9, 37);
            this.lblX1.Name = "lblX1";
            this.lblX1.Size = new System.Drawing.Size(30, 23);
            this.lblX1.TabIndex = 19;
            this.lblX1.Text = "X1";
            this.lblX1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblX1Value
            // 
            this.lblX1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX1Value.Location = new System.Drawing.Point(378, 37);
            this.lblX1Value.Name = "lblX1Value";
            this.lblX1Value.Size = new System.Drawing.Size(40, 23);
            this.lblX1Value.TabIndex = 22;
            this.lblX1Value.Text = "0";
            this.lblX1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcX2
            // 
            this.trcX2.AutoSize = false;
            this.trcX2.BackColor = System.Drawing.Color.LightGray;
            this.trcX2.Location = new System.Drawing.Point(45, 71);
            this.trcX2.Maximum = 255;
            this.trcX2.Name = "trcX2";
            this.trcX2.Size = new System.Drawing.Size(327, 23);
            this.trcX2.TabIndex = 17;
            this.trcX2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcX2.Scroll += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // lblX2
            // 
            this.lblX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX2.Location = new System.Drawing.Point(9, 70);
            this.lblX2.Name = "lblX2";
            this.lblX2.Size = new System.Drawing.Size(30, 23);
            this.lblX2.TabIndex = 20;
            this.lblX2.Text = "X2";
            this.lblX2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblX2Value
            // 
            this.lblX2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblX2Value.Location = new System.Drawing.Point(378, 70);
            this.lblX2Value.Name = "lblX2Value";
            this.lblX2Value.Size = new System.Drawing.Size(40, 23);
            this.lblX2Value.TabIndex = 23;
            this.lblX2Value.Text = "0";
            this.lblX2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY2Value
            // 
            this.lblY2Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY2Value.Location = new System.Drawing.Point(378, 162);
            this.lblY2Value.Name = "lblY2Value";
            this.lblY2Value.Size = new System.Drawing.Size(40, 23);
            this.lblY2Value.TabIndex = 27;
            this.lblY2Value.Text = "0";
            this.lblY2Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcY1
            // 
            this.trcY1.AutoSize = false;
            this.trcY1.BackColor = System.Drawing.Color.LightGray;
            this.trcY1.Location = new System.Drawing.Point(45, 128);
            this.trcY1.Maximum = 255;
            this.trcY1.Name = "trcY1";
            this.trcY1.Size = new System.Drawing.Size(327, 23);
            this.trcY1.TabIndex = 18;
            this.trcY1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcY1.Scroll += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // lblY1
            // 
            this.lblY1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY1.Location = new System.Drawing.Point(9, 127);
            this.lblY1.Name = "lblY1";
            this.lblY1.Size = new System.Drawing.Size(30, 23);
            this.lblY1.TabIndex = 21;
            this.lblY1.Text = "Y1";
            this.lblY1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY2
            // 
            this.lblY2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY2.Location = new System.Drawing.Point(9, 162);
            this.lblY2.Name = "lblY2";
            this.lblY2.Size = new System.Drawing.Size(30, 23);
            this.lblY2.TabIndex = 26;
            this.lblY2.Text = "Y2";
            this.lblY2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblY1Value
            // 
            this.lblY1Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblY1Value.Location = new System.Drawing.Point(378, 128);
            this.lblY1Value.Name = "lblY1Value";
            this.lblY1Value.Size = new System.Drawing.Size(40, 23);
            this.lblY1Value.TabIndex = 24;
            this.lblY1Value.Text = "0";
            this.lblY1Value.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trcY2
            // 
            this.trcY2.AutoSize = false;
            this.trcY2.BackColor = System.Drawing.Color.LightGray;
            this.trcY2.Location = new System.Drawing.Point(45, 163);
            this.trcY2.Maximum = 255;
            this.trcY2.Name = "trcY2";
            this.trcY2.Size = new System.Drawing.Size(327, 23);
            this.trcY2.TabIndex = 25;
            this.trcY2.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trcY2.Scroll += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // grbRadioButtons
            // 
            this.grbRadioButtons.Controls.Add(this.btnSaveResult);
            this.grbRadioButtons.Controls.Add(this.rdbHistogramHyperbolization);
            this.grbRadioButtons.Controls.Add(this.rdbHistogramEqualization);
            this.grbRadioButtons.Controls.Add(this.rdbDissection);
            this.grbRadioButtons.Controls.Add(this.pnlFilterControls);
            this.grbRadioButtons.Controls.Add(this.rdbLinearContrast);
            this.grbRadioButtons.Controls.Add(this.rdbGammaCorrection);
            this.grbRadioButtons.Controls.Add(this.rdbSolarise);
            this.grbRadioButtons.Controls.Add(this.btnLoadSource);
            this.grbRadioButtons.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbRadioButtons.Location = new System.Drawing.Point(15, 242);
            this.grbRadioButtons.Name = "grbRadioButtons";
            this.grbRadioButtons.Size = new System.Drawing.Size(627, 224);
            this.grbRadioButtons.TabIndex = 2;
            this.grbRadioButtons.TabStop = false;
            this.grbRadioButtons.Text = "Тип преобразования";
            // 
            // btnSaveResult
            // 
            this.btnSaveResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveResult.Location = new System.Drawing.Point(6, 178);
            this.btnSaveResult.Name = "btnSaveResult";
            this.btnSaveResult.Size = new System.Drawing.Size(186, 40);
            this.btnSaveResult.TabIndex = 21;
            this.btnSaveResult.Text = "Сохранить";
            this.btnSaveResult.UseVisualStyleBackColor = true;
            this.btnSaveResult.Click += new System.EventHandler(this.btnSaveResult_Click);
            // 
            // rdbHistogramHyperbolization
            // 
            this.rdbHistogramHyperbolization.AutoSize = true;
            this.rdbHistogramHyperbolization.Enabled = false;
            this.rdbHistogramHyperbolization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbHistogramHyperbolization.Location = new System.Drawing.Point(6, 114);
            this.rdbHistogramHyperbolization.Name = "rdbHistogramHyperbolization";
            this.rdbHistogramHyperbolization.Size = new System.Drawing.Size(186, 17);
            this.rdbHistogramHyperbolization.TabIndex = 20;
            this.rdbHistogramHyperbolization.TabStop = true;
            this.rdbHistogramHyperbolization.Text = "- гиперболизация гистограммы";
            this.rdbHistogramHyperbolization.UseVisualStyleBackColor = true;
            this.rdbHistogramHyperbolization.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // rdbHistogramEqualization
            // 
            this.rdbHistogramEqualization.AutoSize = true;
            this.rdbHistogramEqualization.Enabled = false;
            this.rdbHistogramEqualization.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rdbHistogramEqualization.Location = new System.Drawing.Point(6, 94);
            this.rdbHistogramEqualization.Name = "rdbHistogramEqualization";
            this.rdbHistogramEqualization.Size = new System.Drawing.Size(169, 17);
            this.rdbHistogramEqualization.TabIndex = 19;
            this.rdbHistogramEqualization.TabStop = true;
            this.rdbHistogramEqualization.Text = "- эквализация гистограммы";
            this.rdbHistogramEqualization.UseVisualStyleBackColor = true;
            this.rdbHistogramEqualization.CheckedChanged += new System.EventHandler(this.OnCheckChangedEventHandler);
            // 
            // grbHistogram
            // 
            this.grbHistogram.Controls.Add(this.crtHistogram);
            this.grbHistogram.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grbHistogram.Location = new System.Drawing.Point(648, 12);
            this.grbHistogram.Name = "grbHistogram";
            this.grbHistogram.Size = new System.Drawing.Size(484, 224);
            this.grbHistogram.TabIndex = 5;
            this.grbHistogram.TabStop = false;
            this.grbHistogram.Text = "Гистограмма распределения яркости";
            this.grbHistogram.Visible = false;
            // 
            // crtHistogram
            // 
            chartArea2.Name = "ChartArea1";
            this.crtHistogram.ChartAreas.Add(chartArea2);
            this.crtHistogram.Cursor = System.Windows.Forms.Cursors.Hand;
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.crtHistogram.Legends.Add(legend2);
            this.crtHistogram.Location = new System.Drawing.Point(6, 20);
            this.crtHistogram.Name = "crtHistogram";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Частота попадания яркостей";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.UInt32;
            this.crtHistogram.Series.Add(series2);
            this.crtHistogram.Size = new System.Drawing.Size(472, 200);
            this.crtHistogram.TabIndex = 4;
            this.crtHistogram.Text = "chart1";
            this.crtHistogram.MouseClick += new System.Windows.Forms.MouseEventHandler(this.crtHistogram_MouseClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1144, 479);
            this.Controls.Add(this.grbHistogram);
            this.Controls.Add(this.grbRadioButtons);
            this.Controls.Add(this.grbResult);
            this.Controls.Add(this.grbChart);
            this.Controls.Add(this.grbOutput);
            this.Controls.Add(this.grbInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторная работа №4";
            this.grbInput.ResumeLayout(false);
            this.grbOutput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtLine)).EndInit();
            this.grbChart.ResumeLayout(false);
            this.grbResult.ResumeLayout(false);
            this.pnlFilterControls.ResumeLayout(false);
            this.pnlFilterControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trcYmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcYmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcX1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcGamma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcX2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcY1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trcY2)).EndInit();
            this.grbRadioButtons.ResumeLayout(false);
            this.grbRadioButtons.PerformLayout();
            this.grbHistogram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.crtHistogram)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbInput;
        private System.Windows.Forms.Panel picSource;
        private System.Windows.Forms.GroupBox grbOutput;
        private System.Windows.Forms.Panel picOutput;
        private System.Windows.Forms.Button btnLoadSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtLine;
        private System.Windows.Forms.GroupBox grbChart;
        private System.Windows.Forms.GroupBox grbResult;
        private System.Windows.Forms.Panel picResult;
        private System.Windows.Forms.RadioButton rdbDissection;
        private System.Windows.Forms.RadioButton rdbGammaCorrection;
        private System.Windows.Forms.RadioButton rdbSolarise;
        private System.Windows.Forms.RadioButton rdbLinearContrast;
        private System.Windows.Forms.Panel pnlFilterControls;
        private System.Windows.Forms.Label lblY2Value;
        private System.Windows.Forms.Label lblY2;
        private System.Windows.Forms.TrackBar trcY2;
        private System.Windows.Forms.Label lblY1Value;
        private System.Windows.Forms.Label lblX2Value;
        private System.Windows.Forms.Label lblX1Value;
        private System.Windows.Forms.Label lblY1;
        private System.Windows.Forms.Label lblX2;
        private System.Windows.Forms.Label lblX1;
        private System.Windows.Forms.TrackBar trcY1;
        private System.Windows.Forms.TrackBar trcX2;
        private System.Windows.Forms.TrackBar trcX1;
        private System.Windows.Forms.GroupBox grbRadioButtons;
        private System.Windows.Forms.Label lblSettings;
        private System.Windows.Forms.Label lblGammaValue;
        private System.Windows.Forms.Label lblGamma;
        private System.Windows.Forms.TrackBar trcGamma;
        private System.Windows.Forms.RadioButton rdbHistogramHyperbolization;
        private System.Windows.Forms.RadioButton rdbHistogramEqualization;
        private System.Windows.Forms.GroupBox grbHistogram;
        private System.Windows.Forms.DataVisualization.Charting.Chart crtHistogram;
        private System.Windows.Forms.Button btnSaveResult;
        private System.Windows.Forms.Label lblYminValue;
        private System.Windows.Forms.Label lblYmin;
        private System.Windows.Forms.TrackBar trcYmin;
        private System.Windows.Forms.Label lblYmaxValue;
        private System.Windows.Forms.Label lblYmax;
        private System.Windows.Forms.TrackBar trcYmax;
    }
}

