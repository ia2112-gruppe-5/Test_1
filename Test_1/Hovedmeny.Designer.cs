namespace Test_1
{
    partial class Hovedmeny
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.listBoxAlarmHistory = new System.Windows.Forms.ListBox();
            this.chartTemp = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnAddAbonnent = new System.Windows.Forms.Button();
            this.btnAlterAbonnent = new System.Windows.Forms.Button();
            this.btnTempIntervals = new System.Windows.Forms.Button();
            this.btnAlarmGrenser = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.listBoxNewAlarms = new System.Windows.Forms.ListBox();
            this.btnAckAlarm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboArduinoInterval = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tmrTemp = new System.Windows.Forms.Timer(this.components);
            this.btnTest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxAlarmHistory
            // 
            this.listBoxAlarmHistory.FormattingEnabled = true;
            this.listBoxAlarmHistory.Location = new System.Drawing.Point(471, 36);
            this.listBoxAlarmHistory.Name = "listBoxAlarmHistory";
            this.listBoxAlarmHistory.ScrollAlwaysVisible = true;
            this.listBoxAlarmHistory.Size = new System.Drawing.Size(597, 108);
            this.listBoxAlarmHistory.TabIndex = 0;
            // 
            // chartTemp
            // 
            this.chartTemp.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.Name = "ChartArea1";
            this.chartTemp.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartTemp.Legends.Add(legend1);
            this.chartTemp.Location = new System.Drawing.Point(12, 284);
            this.chartTemp.Name = "chartTemp";
            this.chartTemp.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.MarkerBorderColor = System.Drawing.Color.Black;
            series1.MarkerBorderWidth = 5;
            series1.MarkerColor = System.Drawing.Color.Black;
            series1.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Diamond;
            series1.Name = "Temperatur";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
            series1.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            this.chartTemp.Series.Add(series1);
            this.chartTemp.Size = new System.Drawing.Size(1056, 424);
            this.chartTemp.TabIndex = 1;
            this.chartTemp.Text = "chart1";
            // 
            // btnAddAbonnent
            // 
            this.btnAddAbonnent.Location = new System.Drawing.Point(13, 13);
            this.btnAddAbonnent.Name = "btnAddAbonnent";
            this.btnAddAbonnent.Size = new System.Drawing.Size(190, 23);
            this.btnAddAbonnent.TabIndex = 2;
            this.btnAddAbonnent.Text = "Legg til abonnenter";
            this.btnAddAbonnent.UseVisualStyleBackColor = true;
            this.btnAddAbonnent.Click += new System.EventHandler(this.btnAddAbonnent_Click);
            // 
            // btnAlterAbonnent
            // 
            this.btnAlterAbonnent.Location = new System.Drawing.Point(13, 42);
            this.btnAlterAbonnent.Name = "btnAlterAbonnent";
            this.btnAlterAbonnent.Size = new System.Drawing.Size(190, 23);
            this.btnAlterAbonnent.TabIndex = 3;
            this.btnAlterAbonnent.Text = "Endre abonnenter";
            this.btnAlterAbonnent.UseVisualStyleBackColor = true;
            this.btnAlterAbonnent.Click += new System.EventHandler(this.btnAlterAbonnent_ClickAsync);
            // 
            // btnTempIntervals
            // 
            this.btnTempIntervals.Location = new System.Drawing.Point(12, 71);
            this.btnTempIntervals.Name = "btnTempIntervals";
            this.btnTempIntervals.Size = new System.Drawing.Size(191, 23);
            this.btnTempIntervals.TabIndex = 4;
            this.btnTempIntervals.Text = "Endre lagringsinterval for temperatur";
            this.btnTempIntervals.UseVisualStyleBackColor = true;
            this.btnTempIntervals.Click += new System.EventHandler(this.btnTempIntervals_ClickAsync);
            // 
            // btnAlarmGrenser
            // 
            this.btnAlarmGrenser.Location = new System.Drawing.Point(13, 100);
            this.btnAlarmGrenser.Name = "btnAlarmGrenser";
            this.btnAlarmGrenser.Size = new System.Drawing.Size(190, 23);
            this.btnAlarmGrenser.TabIndex = 5;
            this.btnAlarmGrenser.Text = "Endre alarm grenser";
            this.btnAlarmGrenser.UseVisualStyleBackColor = true;
            this.btnAlarmGrenser.Click += new System.EventHandler(this.btnAlarmGrenser_ClickAsync);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(13, 205);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(190, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Lukk program";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // listBoxNewAlarms
            // 
            this.listBoxNewAlarms.FormattingEnabled = true;
            this.listBoxNewAlarms.Location = new System.Drawing.Point(471, 170);
            this.listBoxNewAlarms.Name = "listBoxNewAlarms";
            this.listBoxNewAlarms.ScrollAlwaysVisible = true;
            this.listBoxNewAlarms.Size = new System.Drawing.Size(597, 108);
            this.listBoxNewAlarms.TabIndex = 10;
            // 
            // btnAckAlarm
            // 
            this.btnAckAlarm.Location = new System.Drawing.Point(13, 176);
            this.btnAckAlarm.Name = "btnAckAlarm";
            this.btnAckAlarm.Size = new System.Drawing.Size(190, 23);
            this.btnAckAlarm.TabIndex = 12;
            this.btnAckAlarm.Text = "Anerkjenn alarm";
            this.btnAckAlarm.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(405, 196);
            this.label1.MaximumSize = new System.Drawing.Size(60, 60);
            this.label1.MinimumSize = new System.Drawing.Size(60, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 60);
            this.label1.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(471, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Alarm historikk";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(471, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nye alarmer";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(213, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Velg lese intervall fra Arduino";
            // 
            // cboArduinoInterval
            // 
            this.cboArduinoInterval.FormattingEnabled = true;
            this.cboArduinoInterval.Items.AddRange(new object[] {
            "1 sekund",
            "5 sekund",
            "10 sekund",
            "30 sekund",
            "1 minutt"});
            this.cboArduinoInterval.Location = new System.Drawing.Point(12, 149);
            this.cboArduinoInterval.Name = "cboArduinoInterval";
            this.cboArduinoInterval.Size = new System.Drawing.Size(191, 21);
            this.cboArduinoInterval.TabIndex = 17;
            this.cboArduinoInterval.SelectedIndexChanged += new System.EventHandler(this.cboArduinoInterval_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tmrTemp
            // 
            this.tmrTemp.Interval = 1000;
            this.tmrTemp.Tick += new System.EventHandler(this.tmrTemp_Tick);
            // 
            // btnTest
            // 
            this.btnTest.Location = new System.Drawing.Point(209, 13);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(137, 23);
            this.btnTest.TabIndex = 19;
            this.btnTest.Text = "Send test mail";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // Hovedmeny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1080, 720);
            this.Controls.Add(this.btnTest);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboArduinoInterval);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAckAlarm);
            this.Controls.Add(this.listBoxNewAlarms);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAlarmGrenser);
            this.Controls.Add(this.btnTempIntervals);
            this.Controls.Add(this.btnAlterAbonnent);
            this.Controls.Add(this.btnAddAbonnent);
            this.Controls.Add(this.chartTemp);
            this.Controls.Add(this.listBoxAlarmHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hovedmeny";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hovedmeny";
            ((System.ComponentModel.ISupportInitialize)(this.chartTemp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxAlarmHistory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTemp;
        private System.Windows.Forms.Button btnAddAbonnent;
        private System.Windows.Forms.Button btnAlterAbonnent;
        private System.Windows.Forms.Button btnTempIntervals;
        private System.Windows.Forms.Button btnAlarmGrenser;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ListBox listBoxNewAlarms;
        private System.Windows.Forms.Button btnAckAlarm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboArduinoInterval;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrTemp;
        private System.Windows.Forms.Button btnTest;
    }
}