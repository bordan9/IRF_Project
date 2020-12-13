using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        public Form1()
        {
            InitializeComponent();
            rendeles = context.Rendeles.ToList();

            Diagramfeltoltes();
        }

        public void Diagramfeltoltes()
        {
            var szurt = from x in rendeles
                        where x.Datum.Month == 12
                        group x by x.Datum into Datumok
                        select new
                        {
                            napok = Datumok.Key.Date,
                            darabszam = Datumok.Count()
                        };

            dataGridView1.DataSource = szurt.ToList();

            chart1.DataSource = szurt.ToList();

            var series = chart1.Series[0];
            series.ChartType = SeriesChartType.Line;
            series.XValueMember = "napok";
            series.YValueMembers = "darabszam";
            series.BorderWidth = 3;

            var legend = chart1.Legends[0];
            legend.Enabled = false;

            var chartArea = chart1.ChartAreas[0];
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.Enabled = false;
            chartArea.AxisY.IsStartedFromZero = false;
        }
    }
}
