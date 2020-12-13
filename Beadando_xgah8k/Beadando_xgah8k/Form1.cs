using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            Adatrendezes();
        }

        public void Adatrendezes()
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
        }
    }
}
