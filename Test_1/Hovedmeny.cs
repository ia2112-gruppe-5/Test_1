using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Test_1_DLL;
using System.Windows.Forms.DataVisualization.Charting;

namespace Test_1
{
    public partial class Hovedmeny : Form
    {
        #region Objekter og variabler
        /// <summary>
        /// Database objekt, med tilkoblings stringen som parameter i constructoren.
        /// </summary>
        Database database = new Database(ConfigurationManager.
            ConnectionStrings["Alarm"].ConnectionString);
        /// <summary>
        /// Objekt av typen mail, for å kunne sende mail.
        /// </summary>
        Mail mail = new Mail(ConfigurationManager.
            ConnectionStrings["Alarm"].ConnectionString);
        Random rand = new Random();
        int viewcount = 0, count = 0,interval = 0;
        int mViewCount = 60;
        private bool flag;
        private bool start = true;
        #endregion

        #region Hovedmeny Constructor
        public Hovedmeny()
        {
            InitializeComponent();
            InitializeGraph();
            AddAlarmsToListBox();
            cboArduinoInterval.SelectedIndex = 0;
            interval = setInterval();
        }
        #endregion

        #region Chart data
        private void cboArduinoInterval_SelectedIndexChanged(object sender, EventArgs e)
        {
            interval = setInterval();
            tmrTemp.Interval = SetTick(interval);
        }
        public void InitializeGraph()
        {
            chartTemp.ChartAreas[0].AxisX.MajorGrid.LineColor = Color.Blue;
            chartTemp.ChartAreas[0].AxisY.MajorGrid.LineColor = Color.Red;
            chartTemp.ChartAreas[0].AxisY.Interval = 5.0;
            chartTemp.ChartAreas[0].AxisX.Interval = 1;
            chartTemp.ChartAreas[0].AxisY.Minimum = -25;
            chartTemp.ChartAreas[0].AxisY.Maximum = 50;
            chartTemp.Series[0].Color = Color.Black;
            chartTemp.Series[0].XValueType = ChartValueType.DateTime;
            chartTemp.ChartAreas[0].AxisX.LabelStyle.Format = "dd-MM-yyyy hh:mm:ss";
            chartTemp.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Seconds;
            chartTemp.ChartAreas[0].AxisX.IntervalOffset = 1;
        }
        /// <summary>
        /// Bruke litt av koden fra denne nettsiden https://stackoverflow.com/questions/36685827/how-to-set-minimum-and-maximum-values-for-date-time-chart-using-c
        /// for å få chartet til å bli som jeg ville.
        /// Endret litt på den til vårt bruk.
        /// </summary>
        public void AddData()
        {
            while (true)
            {
                if (flag)
                {
                    flag = false;
                    DateTime timeStamp = DateTime.Now;
                    double valueY;
                    valueY = rand.Next(20, 25);
                    AddNewPoint(timeStamp, chartTemp.Series[0], valueY, interval);
                    count++;
                }
                Thread.Sleep(1);
            }
        }
        /// <summary>
        /// Metode for å legge til nye punkter i chartet.
        /// Noe av denne koden er også hentet ifra nedsiden nevnt ovenfor.
        /// </summary>
        /// <param name="timeStamp"></param>
        /// <param name="series"></param>
        /// <param name="temp"></param>
        /// <param name="interval"></param>
        public void AddNewPoint(DateTime timeStamp, Series series, double temp, int interval)
        {
            double max = 0.0;
            if (chartTemp.InvokeRequired)
            {
                BeginInvoke((Action)(() =>
                {
                    chartTemp.Series[0].Points.AddXY(timeStamp.ToOADate(), temp);
                    if ((count % interval) == 0)
                    {
                        mViewCount += interval;
                        viewcount += interval;

                        chartTemp.ChartAreas[0].AxisX.Minimum = DateTime.FromOADate(series.Points[count - 1].XValue).ToOADate();
                        chartTemp.ChartAreas[0].AxisX.Maximum = DateTime.FromOADate(series.Points[count - 1].XValue).AddMinutes(0.5).ToOADate();
                        max = chartTemp.ChartAreas[0].AxisX.Maximum;
                    }

                    if (count >= interval)
                    {
                        if ((count >= viewcount) || (count <= mViewCount))
                        {
                            chartTemp.Series[0].Points[0].AxisLabel = DateTime.FromOADate(chartTemp.Series[0].Points[count - 1].XValue).ToString();
                            chartTemp.ChartAreas[0].AxisX.ScaleView.Position = max;
                        }
                    }

                    chartTemp.Update();
                    chartTemp.ChartAreas[0].RecalculateAxesScale();

                }));
            }

        }
        /// <summary>
        /// Brukt for å sette intervalet til chartet.
        /// </summary>
        /// <returns></returns>
        private int setInterval()
        {
            int val = 0;
            if (cboArduinoInterval.SelectedIndex == 0)
            {
                val = 30;
            }
            else if (cboArduinoInterval.SelectedIndex == 1)
            {
                val = 6;
            }
            else if (cboArduinoInterval.SelectedIndex == 2)
            {
                val = 3;
            }
            else if (cboArduinoInterval.SelectedIndex == 3)
            {
                val = 1;
            }
            else if (cboArduinoInterval.SelectedIndex == 4)
            {
                val = 1;
            }
            return val;
        }
        /// <summary>
        /// Metode for å sette ticket til tmrTemp, som styrer innlesningen av data til chartet.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private int SetTick(int i)
        {
            int tick = 0;
            if (i == 30)
            {
                tick = 1000;
            }
            else if (i == 6)
            {
                tick = 5000;
            }
            else if (i == 3)
            {
                tick = 10000;
            }
            return tick;
        }
        #endregion

        #region Buttonevents
        public void AddAlarmsToListBox()
        {
            listBoxAlarmHistory.Items.Clear();
            
            for (int i = 0; i < database.GetAlarmHistory().Count; i++)
            {
                listBoxAlarmHistory.Items.Add(database.GetAlarmHistory()[i]);
            }
        }
        /// <summary>
        /// Lukker hele programmet dersom man velger yes, velger man no fortsetter programmet som normalt.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Er du sikker på at du vil avslutte?", "Avslutt program", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }
        /// <summary>
        /// Click event for å åpne legg til abonnent formet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAddAbonnent_Click(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Legg_til_abonnent abonnent = new Legg_til_abonnent();
                abonnent.ShowDialog();
            });
        }
        /// <summary>
        /// Click event for å åpne endre abonnent formet.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAlterAbonnent_ClickAsync(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Endre_abonnenter abonnent = new Endre_abonnenter();
                abonnent.ShowDialog();
            });
        }
        /// <summary>
        /// Click event for å åpne temperatur interval formet, der kan man endre
        /// lese og lagrinsinterval for temperatur.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnTempIntervals_ClickAsync(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Temperaturinterval temperaturinterval = new Temperaturinterval();
                temperaturinterval.ShowDialog();
            });
        }
        /// <summary>
        /// Click event for å åpne alarm grense formet, her kan man endre alarmgrensene.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void btnAlarmGrenser_ClickAsync(object sender, EventArgs e)
        {
            await Task.Run(() =>
            {
                Alarmgrenser alarmgrenser = new Alarmgrenser();
                alarmgrenser.ShowDialog();
            });
        }
        /// <summary>
        /// Click event for å starte inn lesning av data fra arduino.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            if (start)
            {
                chartTemp.ChartAreas[0].AxisX.Minimum = DateTime.Now.ToOADate();
                chartTemp.ChartAreas[0].AxisX.Maximum = DateTime.Now.AddMinutes(0.5).ToOADate();
                start = false;
            }
            tmrTemp.Start();
            await Task.Run(() => { AddData(); });

        }
        #endregion

        #region Timere
        private void tmrTemp_Tick(object sender, EventArgs e)
        {
            flag = true;
        }

        #endregion

        #region Test region
        private void btnTest_Click(object sender, EventArgs e)
        {
            mail.SendMail("Test", "Test");
        }

        #endregion
    }

}
