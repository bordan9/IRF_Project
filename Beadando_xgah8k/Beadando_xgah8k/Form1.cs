using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Beadando_xgah8k
{
    public partial class Form1 : Form
    {
        webshop_database1Entities context = new webshop_database1Entities();
        List<Rendeles> rendeles;

        Random rng = new Random();

        public Form1()
        {
            InitializeComponent();
            rendeles = context.Rendeles.ToList();

            Diagramfeltoltes();
        }

        public void Diagramfeltoltes()
        {
            var szurt = from x in rendeles
                        group x by x.Datum into Datumok
                        select new
                        {
                            Napok = Datumok.Key.Date,
                            Darabszám = Datumok.Count()
                        };

            dataGridView1.DataSource = szurt.ToList();

            chart1.DataSource = szurt.ToList();

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "Napok";
            series.YValueMembers = "Darabszám";
            series.BorderWidth = 3;
            series.Color = Color.Orange;

            var legend = chart1.Legends[0];
            legend.Enabled = false;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }

        private void designedButton1_Click(object sender, EventArgs e)
        {
            int nap = rng.Next(1, 30);
            int honap = 12;
            int ev = 2020;

            disabledTextBox1.Text = ev + "." + honap + "." + nap;

            var szurt = from x in rendeles
                        where x.Datum.Day == nap
                        group x by x.Datum into Datumok
                        select new
                        {
                            napok = Datumok.Key.Date,
                            darabszam = Datumok.Count()
                        };

            var darabszam = (from y in szurt
                             select y.darabszam).First().ToString();

            disabledTextBox2.Text = darabszam;
        }

        private void designedButton2_Click(object sender, EventArgs e)
        {
            disabledTextBox1.Clear();
            disabledTextBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
