using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Threading;
using Test_1_DLL;

namespace Test_1
{
    
    public partial class Form1 : Form
    {
        //string AlarmConfig = ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString;
        Database database = new Database(ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString);
        Mail mail = new Mail(ConfigurationManager.ConnectionStrings["Alarm"].ConnectionString);
        //string comboBoxSQL = @"SELECT Mailaddresse
        //                        FROM Abonenter
        //                        ORDER BY Mailaddresse";
        List<string> dataListFromSQL = new List<string>();
        
        public Form1()
        {

            InitializeComponent();
            //ImportToComboBox(comboBoxSQL);
            //database.AddAbonnent("123", "123", "123", 123, "1234");
            database.ImportAbonnentMailFromDatabase();//Metode for å importere data fra en tabell og inn til en list.
            AddListToComboBox(database.DataList, comboBox1);
            database.GetAlarmTyper();
            AddListToComboBox(database.DataList, cboAlarmType);
            //database.AddAlarmGrenseToDatabase(1, "TempHøy", 25);
            //database.AddAlarmGrenseToDatabase(2, "TempLav", 15);
            //database.AddAlarmGrenseToDatabase(3, "Sabotasje", 99);
            //database.AddAlarmGrenseToDatabase(4,"Brudd", 222);
            //database.AddAlarmTyper(1, "Temp");
            //database.AddAlarmTyper(2, "Bevegelse");
            //database.AddAlarmTyper(3, "Sabotasje");
            //database.AddAlarmTyper(4, "Kommunikasjon");
            //database.AddAlarmTyper(5, "Mail");
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //DeleteFromDatabase();
            //database.DeleteFromDatabase(comboBox1.Text);//Metode for å slette valgt text i combobox
            //comboBox1.Items.Clear();
            //comboBox1.Text = "";
            //database.ImportAbonnentMailFromDatabase();
            //AddListToComboBox(database.dataList);
            //ImportToComboBox(comboBoxSQL);
            //database.UpdateAlarmGrense(1, "TempHøy", 30);
            //database.UpdateAlarmGrense(2, "TempLav", 10);
            //database.UpdateAlarmGrense(3, "Sabotasje", 98);
            //database.UpdateAlarmGrense(4, "Brudd", 111);
            //textBox2.Text = database.GetAlarmGrense(1, "TempHøy") + "\n";
            //textBox2.AppendText(database.GetAlarmGrense(2, "TempLav") + "\n");
            //textBox2.AppendText(database.GetAlarmGrense(3, "Sabotasje") + "\n");
            //textBox2.AppendText(database.GetAlarmGrense(4, "Brudd") + "\n");
            string mailaddresse = "", forNavn = "", etterNavn = "", phoneNumber = "", postAddresse = "";
            bool temperatur, bevegelse, sabotasje, kommunikasjon, mail;
            mailaddresse = txtMail.Text;
            forNavn = txtFname.Text;
            etterNavn = txtLname.Text;
            phoneNumber = txtPhone.Text;
            postAddresse = txtPostNum.Text;
            bevegelse = CheckBoxCheked(checkBoxBevegelse);
            mail = CheckBoxCheked(checkBoxMail);
            sabotasje = CheckBoxCheked(checkBoxSabotasje);
            kommunikasjon = CheckBoxCheked(checkBoxKommunikasjon);
            temperatur = CheckBoxCheked(checkBoxTemp);
            database.AddAbonnent(mailaddresse, forNavn, etterNavn, phoneNumber, postAddresse);
            database.AlarmAbonnering(mailaddresse, 1, temperatur);
            database.AlarmAbonnering(mailaddresse, 2, bevegelse);
            database.AlarmAbonnering(mailaddresse, 3, sabotasje);
            database.AlarmAbonnering(mailaddresse, 4, kommunikasjon);
            database.AlarmAbonnering(mailaddresse, 5, mail);
            txtFname.Clear();
            txtMail.Clear();
            txtLname.Clear();
            txtPhone.Clear();
            txtPostNum.Clear();
            checkBoxBevegelse.Checked = true;
            checkBoxKommunikasjon.Checked = true;
            checkBoxMail.Checked = true;
            checkBoxSabotasje.Checked = true;
            checkBoxTemp.Checked = true;    
        }
        public bool CheckBoxCheked(CheckBox box)
        {
            bool i;
            if (box.Checked)
            {
                i = true;
            }
            else
            {
                i = false;
            }
            return i;
        }
        /// <summary>
        /// Metode for å legge list data inn i en combobox.
        /// </summary>
        /// <param name="ts"></param>
        void AddListToComboBox(List<string> ts, ComboBox cbo)
        {
            for (int i = 0; i < ts.Count; i++)
            {
                cbo.Items.Add(ts[i]);
            }
        }
        //void ImportToComboBox(string sqlQuery)
        //{
        //    comboBox1.Items.Clear();
        //    try
        //    {
        //        SqlConnection conAlarm = new SqlConnection(AlarmConfig);
        //        SqlCommand sql = new SqlCommand(sqlQuery, conAlarm);
        //        sql.CommandType = CommandType.Text;
        //        conAlarm.Open();
        //        SqlDataReader dr = sql.ExecuteReader();
        //        while (dr.Read())
        //        {
        //            sqlQuery = dr[0].ToString();
        //            comboBox1.Items.Add(sqlQuery);
        //        }
        //    }
        //    catch (SqlException exce)
        //    {
        //        MessageBox.Show(exce.Message);

        //    }
        //}
        //void DeleteFromDatabase()
        //{
        //    string mail;
        //    mail = comboBox1.Text;
        //    try
        //    {
        //        SqlConnection conAlarm = new SqlConnection(AlarmConfig);
        //        SqlCommand sql = new SqlCommand("DeleteAbonnent", conAlarm);
        //        sql.CommandType = CommandType.StoredProcedure;
        //        conAlarm.Open();
        //        sql.Parameters.Add(new SqlParameter("@Mail", mail));
        //        sql.ExecuteNonQuery();
        //        conAlarm.Close();
        //        ImportToComboBox(comboBoxSQL);
        //    }
        //    catch (SqlException exce)
        //    {
        //        MessageBox.Show(exce.Message);

        //    }
        //}

        private void btnStartMåling_Click(object sender, EventArgs e)
        {
            double max = 30, min = 10;
            double temp = 0.0;
            string alarmBeskrivelse = "";
            if (txtTempLimMax.Text != null)
            {
                double.TryParse(txtTempLimMax.Text, out max);
            }
            if (txtTempLimMin.Text != null)
            {
                double.TryParse(txtTempLimMin.Text, out min);
            }
            temp = Convert.ToDouble(textBox1.Text);
            DateTime time = DateTime.Now;
            database.AddMålingToDatabase(time, temp);
            database.GetAlarmId();
            int alarmCount = Convert.ToInt32(database.DataList.Last());
            database.GetTempId();
            int målingCount = Convert.ToInt32(database.DataList.Last());
            if (temp > max)
            {
                alarmBeskrivelse = "Jeg svetter ihjel!!!";
                database.AddAlarmsToDatabase(alarmBeskrivelse, 1, 1,time);
                database.AddTempAlarm(målingCount, alarmCount, "Høy", temp);
                
            }
            else if (temp < min)
            {
                alarmBeskrivelse = "Jeg fryser ihjell!!";
                database.AddAlarmsToDatabase(alarmBeskrivelse, 2, 1,time);
                database.AddTempAlarm(målingCount, alarmCount, "Lav", temp);
                
            }
        }
        public void teller()
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'alarmsystemDataSet2.Abonenter' table. You can move, or remove it, as needed.
            this.abonenterTableAdapter.Fill(this.alarmsystemDataSet2.Abonenter);
            // TODO: This line of code loads data into the 'alarmsystemDataSet1.Målinger' table. You can move, or remove it, as needed.
            //this.målingerTableAdapter.Fill(this.alarmsystemDataSet1.Målinger);

        }

        private void btnAddAlarm_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlarmHistory_Click(object sender, EventArgs e)
        {
            database.GetAlarmHistory();
            for (int i = 0; i < database.DataList.Count; i++)
            {
                listBox1.Items.Add(database.DataList[i]);
            }
        }

        private void btnSendMail_Click(object sender, EventArgs e)
        {
            //string mottakker = "";
            database.ImportAbonnentMailFromDatabase();
            for (int i = 0; i < database.DataList.Count; i++)
            {
                try
                {
                    mail.MailSetup(database.DataList[i], "Test", "Test");
                }
                catch (Exception exce)
                {
                    MessageBox.Show(exce.Message);
                }
            }

            
            
        }

        private async void btnOpenHovedMeny_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(Count);
            task.Start();
            int count = await task;
            textBox2.AppendText(count.ToString());
        }
        private int Count()
        {

            int count = 0;
            count = cboAlarmType.Items.Count;
            Thread.Sleep(5000);
            return count;
        }
        

    }
}
