namespace Test_1
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnAddAbonnent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnStartMåling = new System.Windows.Forms.Button();
            this.alarmsystemDataSet = new Test_1.AlarmsystemDataSet();
            this.alarmerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarmerTableAdapter = new Test_1.AlarmsystemDataSetTableAdapters.AlarmerTableAdapter();
            this.alarmHistorikk = new Test_1.AlarmHistorikk();
            this.alarmerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.alarmerTableAdapter1 = new Test_1.AlarmHistorikkTableAdapters.AlarmerTableAdapter();
            this.alarmsystemDataSet1 = new Test_1.AlarmsystemDataSet1();
            this.målingerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.målingerTableAdapter = new Test_1.AlarmsystemDataSet1TableAdapters.MålingerTableAdapter();
            this.abonenterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.alarmsystemDataSet2 = new Test_1.AlarmsystemDataSet2();
            this.abonenterTableAdapter = new Test_1.AlarmsystemDataSet2TableAdapters.AbonenterTableAdapter();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.cboAlarmType = new System.Windows.Forms.ComboBox();
            this.btnAddAlarm = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnAlarmHistory = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.checkBoxTemp = new System.Windows.Forms.CheckBox();
            this.checkBoxBevegelse = new System.Windows.Forms.CheckBox();
            this.checkBoxSabotasje = new System.Windows.Forms.CheckBox();
            this.checkBoxKommunikasjon = new System.Windows.Forms.CheckBox();
            this.checkBoxMail = new System.Windows.Forms.CheckBox();
            this.txtPostNum = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.txtTempLimMax = new System.Windows.Forms.TextBox();
            this.txtTempLimMin = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnOpenHovedMeny = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmHistorikk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsystemDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.målingerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonenterBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsystemDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(615, 103);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 0;
            // 
            // btnAddAbonnent
            // 
            this.btnAddAbonnent.Location = new System.Drawing.Point(173, 271);
            this.btnAddAbonnent.Name = "btnAddAbonnent";
            this.btnAddAbonnent.Size = new System.Drawing.Size(167, 23);
            this.btnAddAbonnent.TabIndex = 1;
            this.btnAddAbonnent.Text = "Legg til abonnent";
            this.btnAddAbonnent.UseVisualStyleBackColor = true;
            this.btnAddAbonnent.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 336);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // btnStartMåling
            // 
            this.btnStartMåling.Location = new System.Drawing.Point(290, 362);
            this.btnStartMåling.Name = "btnStartMåling";
            this.btnStartMåling.Size = new System.Drawing.Size(75, 23);
            this.btnStartMåling.TabIndex = 3;
            this.btnStartMåling.Text = "start";
            this.btnStartMåling.UseVisualStyleBackColor = true;
            this.btnStartMåling.Click += new System.EventHandler(this.btnStartMåling_Click);
            // 
            // alarmsystemDataSet
            // 
            this.alarmsystemDataSet.DataSetName = "AlarmsystemDataSet";
            this.alarmsystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alarmerBindingSource
            // 
            this.alarmerBindingSource.DataMember = "Alarmer";
            this.alarmerBindingSource.DataSource = this.alarmsystemDataSet;
            // 
            // alarmerTableAdapter
            // 
            this.alarmerTableAdapter.ClearBeforeFill = true;
            // 
            // alarmHistorikk
            // 
            this.alarmHistorikk.DataSetName = "AlarmHistorikk";
            this.alarmHistorikk.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alarmerBindingSource1
            // 
            this.alarmerBindingSource1.DataMember = "Alarmer";
            this.alarmerBindingSource1.DataSource = this.alarmHistorikk;
            // 
            // alarmerTableAdapter1
            // 
            this.alarmerTableAdapter1.ClearBeforeFill = true;
            // 
            // alarmsystemDataSet1
            // 
            this.alarmsystemDataSet1.DataSetName = "AlarmsystemDataSet1";
            this.alarmsystemDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // målingerBindingSource
            // 
            this.målingerBindingSource.DataMember = "Målinger";
            this.målingerBindingSource.DataSource = this.alarmsystemDataSet1;
            // 
            // målingerTableAdapter
            // 
            this.målingerTableAdapter.ClearBeforeFill = true;
            // 
            // abonenterBindingSource
            // 
            this.abonenterBindingSource.DataMember = "Abonenter";
            this.abonenterBindingSource.DataSource = this.alarmsystemDataSet2;
            // 
            // alarmsystemDataSet2
            // 
            this.alarmsystemDataSet2.DataSetName = "AlarmsystemDataSet2";
            this.alarmsystemDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // abonenterTableAdapter
            // 
            this.abonenterTableAdapter.ClearBeforeFill = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(496, 343);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 86);
            this.textBox2.TabIndex = 4;
            // 
            // cboAlarmType
            // 
            this.cboAlarmType.FormattingEnabled = true;
            this.cboAlarmType.Location = new System.Drawing.Point(611, 298);
            this.cboAlarmType.Name = "cboAlarmType";
            this.cboAlarmType.Size = new System.Drawing.Size(121, 21);
            this.cboAlarmType.TabIndex = 5;
            // 
            // btnAddAlarm
            // 
            this.btnAddAlarm.Location = new System.Drawing.Point(611, 339);
            this.btnAddAlarm.Name = "btnAddAlarm";
            this.btnAddAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnAddAlarm.TabIndex = 6;
            this.btnAddAlarm.Text = "Add alarm";
            this.btnAddAlarm.UseVisualStyleBackColor = true;
            this.btnAddAlarm.Click += new System.EventHandler(this.btnAddAlarm_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(470, 465);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(319, 173);
            this.listBox1.TabIndex = 7;
            // 
            // btnAlarmHistory
            // 
            this.btnAlarmHistory.Location = new System.Drawing.Point(294, 497);
            this.btnAlarmHistory.Name = "btnAlarmHistory";
            this.btnAlarmHistory.Size = new System.Drawing.Size(170, 79);
            this.btnAlarmHistory.TabIndex = 8;
            this.btnAlarmHistory.Text = "Få alarm historikk";
            this.btnAlarmHistory.UseVisualStyleBackColor = true;
            this.btnAlarmHistory.Click += new System.EventHandler(this.btnAlarmHistory_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(824, 465);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 9;
            // 
            // checkBoxTemp
            // 
            this.checkBoxTemp.AutoSize = true;
            this.checkBoxTemp.Checked = true;
            this.checkBoxTemp.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTemp.Location = new System.Drawing.Point(173, 150);
            this.checkBoxTemp.Name = "checkBoxTemp";
            this.checkBoxTemp.Size = new System.Drawing.Size(80, 17);
            this.checkBoxTemp.TabIndex = 10;
            this.checkBoxTemp.Text = "Temperatur";
            this.checkBoxTemp.UseVisualStyleBackColor = true;
            // 
            // checkBoxBevegelse
            // 
            this.checkBoxBevegelse.AutoSize = true;
            this.checkBoxBevegelse.Checked = true;
            this.checkBoxBevegelse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxBevegelse.Location = new System.Drawing.Point(173, 174);
            this.checkBoxBevegelse.Name = "checkBoxBevegelse";
            this.checkBoxBevegelse.Size = new System.Drawing.Size(76, 17);
            this.checkBoxBevegelse.TabIndex = 11;
            this.checkBoxBevegelse.Text = "Bevegelse";
            this.checkBoxBevegelse.UseVisualStyleBackColor = true;
            // 
            // checkBoxSabotasje
            // 
            this.checkBoxSabotasje.AutoSize = true;
            this.checkBoxSabotasje.Checked = true;
            this.checkBoxSabotasje.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSabotasje.Location = new System.Drawing.Point(173, 197);
            this.checkBoxSabotasje.Name = "checkBoxSabotasje";
            this.checkBoxSabotasje.Size = new System.Drawing.Size(73, 17);
            this.checkBoxSabotasje.TabIndex = 12;
            this.checkBoxSabotasje.Text = "Sabotasje";
            this.checkBoxSabotasje.UseVisualStyleBackColor = true;
            // 
            // checkBoxKommunikasjon
            // 
            this.checkBoxKommunikasjon.AutoSize = true;
            this.checkBoxKommunikasjon.Checked = true;
            this.checkBoxKommunikasjon.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxKommunikasjon.Location = new System.Drawing.Point(173, 220);
            this.checkBoxKommunikasjon.Name = "checkBoxKommunikasjon";
            this.checkBoxKommunikasjon.Size = new System.Drawing.Size(100, 17);
            this.checkBoxKommunikasjon.TabIndex = 13;
            this.checkBoxKommunikasjon.Text = "Kommunikasjon";
            this.checkBoxKommunikasjon.UseVisualStyleBackColor = true;
            // 
            // checkBoxMail
            // 
            this.checkBoxMail.AutoSize = true;
            this.checkBoxMail.Checked = true;
            this.checkBoxMail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMail.Location = new System.Drawing.Point(173, 243);
            this.checkBoxMail.Name = "checkBoxMail";
            this.checkBoxMail.Size = new System.Drawing.Size(45, 17);
            this.checkBoxMail.TabIndex = 14;
            this.checkBoxMail.Text = "Mail";
            this.checkBoxMail.UseVisualStyleBackColor = true;
            // 
            // txtPostNum
            // 
            this.txtPostNum.Location = new System.Drawing.Point(173, 124);
            this.txtPostNum.Name = "txtPostNum";
            this.txtPostNum.Size = new System.Drawing.Size(192, 20);
            this.txtPostNum.TabIndex = 15;
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(173, 20);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(192, 20);
            this.txtMail.TabIndex = 16;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(173, 46);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(192, 20);
            this.txtFname.TabIndex = 17;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(173, 72);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(192, 20);
            this.txtLname.TabIndex = 18;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(173, 98);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(192, 20);
            this.txtPhone.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Fornavn";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(114, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Etternavn";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Telefon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(102, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Postnummer";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(534, 101);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 25;
            this.btnSendMail.Text = "Send mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // txtTempLimMax
            // 
            this.txtTempLimMax.Location = new System.Drawing.Point(740, 68);
            this.txtTempLimMax.Name = "txtTempLimMax";
            this.txtTempLimMax.Size = new System.Drawing.Size(192, 20);
            this.txtTempLimMax.TabIndex = 26;
            // 
            // txtTempLimMin
            // 
            this.txtTempLimMin.Location = new System.Drawing.Point(740, 46);
            this.txtTempLimMin.Name = "txtTempLimMin";
            this.txtTempLimMin.Size = new System.Drawing.Size(192, 20);
            this.txtTempLimMin.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 28;
            this.label6.Text = "Grense maks";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(674, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Grense min";
            // 
            // btnOpenHovedMeny
            // 
            this.btnOpenHovedMeny.Location = new System.Drawing.Point(897, 197);
            this.btnOpenHovedMeny.Name = "btnOpenHovedMeny";
            this.btnOpenHovedMeny.Size = new System.Drawing.Size(167, 23);
            this.btnOpenHovedMeny.TabIndex = 30;
            this.btnOpenHovedMeny.Text = "Åpne hovedMeny";
            this.btnOpenHovedMeny.UseVisualStyleBackColor = true;
            this.btnOpenHovedMeny.Click += new System.EventHandler(this.btnOpenHovedMeny_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 650);
            this.Controls.Add(this.btnOpenHovedMeny);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTempLimMin);
            this.Controls.Add(this.txtTempLimMax);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtLname);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtPostNum);
            this.Controls.Add(this.checkBoxMail);
            this.Controls.Add(this.checkBoxKommunikasjon);
            this.Controls.Add(this.checkBoxSabotasje);
            this.Controls.Add(this.checkBoxBevegelse);
            this.Controls.Add(this.checkBoxTemp);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAlarmHistory);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnAddAlarm);
            this.Controls.Add(this.cboAlarmType);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnStartMåling);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnAddAbonnent);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.alarmsystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmHistorikk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsystemDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.målingerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.abonenterBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alarmsystemDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnAddAbonnent;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnStartMåling;
        private AlarmsystemDataSet alarmsystemDataSet;
        private System.Windows.Forms.BindingSource alarmerBindingSource;
        private AlarmsystemDataSetTableAdapters.AlarmerTableAdapter alarmerTableAdapter;
        private AlarmHistorikk alarmHistorikk;
        private System.Windows.Forms.BindingSource alarmerBindingSource1;
        private AlarmHistorikkTableAdapters.AlarmerTableAdapter alarmerTableAdapter1;
        private AlarmsystemDataSet1 alarmsystemDataSet1;
        private System.Windows.Forms.BindingSource målingerBindingSource;
        private AlarmsystemDataSet1TableAdapters.MålingerTableAdapter målingerTableAdapter;
        private AlarmsystemDataSet2 alarmsystemDataSet2;
        private System.Windows.Forms.BindingSource abonenterBindingSource;
        private AlarmsystemDataSet2TableAdapters.AbonenterTableAdapter abonenterTableAdapter;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.ComboBox cboAlarmType;
        private System.Windows.Forms.Button btnAddAlarm;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnAlarmHistory;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox checkBoxTemp;
        private System.Windows.Forms.CheckBox checkBoxBevegelse;
        private System.Windows.Forms.CheckBox checkBoxSabotasje;
        private System.Windows.Forms.CheckBox checkBoxKommunikasjon;
        private System.Windows.Forms.CheckBox checkBoxMail;
        private System.Windows.Forms.TextBox txtPostNum;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.TextBox txtTempLimMax;
        private System.Windows.Forms.TextBox txtTempLimMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnOpenHovedMeny;
    }
}

