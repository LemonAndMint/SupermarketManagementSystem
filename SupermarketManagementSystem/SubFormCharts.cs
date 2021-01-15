using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SupermarketManagementSystem.database;
using SupermarketManagementSystem.database.sale;

namespace SupermarketManagementSystem
{
    public partial class SubFormCharts : Form
    {
        public float price { get; set; }
        public float unit_input_price { get; set; }
        public SubFormCharts()
        {
            InitializeComponent();
        }

        /*public void KarHesaplama() // bu metot grafiklerin metotu. 
        {
<<<<<<< HEAD



            float kar = 0;
            float zarar = 0;
=======
>>>>>>> 38a83eb38d4889f1c79cfa3076eaedfd01407528

            


        }*/

      

        public void SubFormCharts_Load(object sender, EventArgs e)
        {                   
            
            List<DebitSale> debtSoldProducts = DebitSale.getallDSale();
            int sayi = debtSoldProducts.Count;

            List<CashSale> cashSoldProducts = CashSale.getallCSale();
            int sayim = cashSoldProducts.Count;

            var objChart = urunbazli.ChartAreas[0];

                objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisX.LabelStyle.Format = "";
                objChart.AxisX.LabelStyle.IsEndLabelVisible = true;
                objChart.AxisX.Minimum = 0;
                objChart.AxisX.Maximum = sayi+sayim+5;
                objChart.AxisX.Interval = 1;

                objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisY.LabelStyle.Format = "";
                objChart.AxisY.LabelStyle.IsEndLabelVisible = true;
                objChart.AxisY.Minimum = -1.5;
                objChart.AxisY.Maximum = 1.5;
                objChart.AxisY.Interval = 0.2;



                DebitSale.getallDSale();
                CashSale.getallCSale();

            for (int j = 0; j < (sayi+sayim) ; j++)
            {
                float kar = 0;
                float zarar = 0;

                float satis = debtSoldProducts[j].price;
                float giris = debtSoldProducts[j].unit_input_price;

                //float satisim = cashSoldProducts[j].price;
                //float girisim = cashSoldProducts[j].unit_input_price;

                if ((satis - giris) > 0)
                {
                    kar = satis - giris;
                    urunbazli.Series["Kar"].Points.AddXY(j, kar);
                }
                else if ((satis - giris) < 0)
                {
                     zarar = satis - giris;
                     urunbazli.Series["Zarar"].Points.AddXY(j, zarar);
                }
                /*else if((satisim - girisim) > 0 && satis == null)
                {
                    kar = satisim - girisim;
                    urunbazli.Series["Kar"].Points.AddXY(j, kar);
                }
                else if((satisim - girisim) < 0 && satis == null)
                {
                    zarar = satisim - girisim;
                    urunbazli.Series["Zarar"].Points.AddXY(j, zarar);
                }
                else if((satis - giris) > 0 && (satisim - girisim) > 0)
                {
                    kar = (satisim - girisim) + (satis - giris);
                    urunbazli.Series["Kar"].Points.AddXY(j, kar);
                }
                else if((satis - giris) < 0 && (satisim - girisim) < 0)
                {
                    zarar = (satisim - girisim) + (satis + giris);
                    urunbazli.Series["Zarar"].Points.AddXY(j, zarar);
                }
                else if((satis - giris) > 0 && (satisim - girisim) < 0)
                {
                    if((satis - giris) > (satisim - girisim))
                    {
                        kar = (satis - giris) - (satisim - girisim);
                        urunbazli.Series["Kar"].Points.AddXY(j, kar);
                    }
                    else if((satis - giris) < (satisim - girisim))
                    {
                        zarar = (satisim - girisim) - (satis - giris);
                        urunbazli.Series["Zarar"].Points.AddXY(j, zarar);
                    }
                }
                else if((satis - giris) < 0 && (satisim - girisim) > 0)
                {
                    if ((satis - giris) > (satisim - girisim))
                    { 
                        zarar = (satis - giris) -(satisim - girisim) ;
                        urunbazli.Series["Zarar"].Points.AddXY(j, zarar);
                      
                    }
                    else if ((satis - giris) < (satisim - girisim))
                    {
                        kar = (satisim - girisim) - (satis - giris);
                        urunbazli.Series["Kar"].Points.AddXY(j, kar);
                    }
                }*/
            }
        }

        private void urunbazli_Click(object sender, EventArgs e)
        {

        }
    }
}