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

namespace SupermarketManagementSystem
{
    public partial class SubFormCharts : Form
    {
        public float prize { get; set; }
        public float unit_input_price { get; set; }
        public SubFormCharts()
        {
            InitializeComponent();
        }

        /*public void KarHesaplama() // bu metot grafiklerin metotu. 
        {

            


        }*/

      

        public void SubFormCharts_Load(object sender, EventArgs e)
        {                
                var objChart = urunbazli.ChartAreas[0];

                objChart.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisX.LabelStyle.Format = "";
                objChart.AxisX.LabelStyle.IsEndLabelVisible = true;
                objChart.AxisX.Minimum = 0;
                objChart.AxisX.Maximum = 51;
                objChart.AxisX.Interval = 1;

                objChart.AxisY.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
                objChart.AxisY.LabelStyle.Format = "";
                objChart.AxisY.LabelStyle.IsEndLabelVisible = true;
                objChart.AxisY.Minimum = -1.5;
                objChart.AxisY.Maximum = 1.5;
                objChart.AxisY.Interval = 0.2;

                float kar = 0;
                float zarar = 0;

            for (int j = 0; j < 9; j++)
            {
                int temp = DebitSale.getDebitSale(j).barcode;
                float satis = Product.getProductbyBarcode(temp).prize;
                int temp2 = DebitSale.getDebitSale(j).barcode;
                float giris = Product.getProductbyBarcode(temp2).unit_input_price;

                for (int i = 1; i < 51; i++)
                {

                    //float girdi_fiyati = Product.getProductbyBarcode(i).unit_input_price;
                    //float satis_fiyati = Product.getProductbyBarcode(i).prize;

                    if ((satis - giris) > 0)
                    {
                        kar = satis - giris;
                        urunbazli.Series["Kar"].Points.AddXY(i, kar);
                    }
                    else if ((satis - giris) < 0)
                    {
                        zarar = satis - giris;
                        urunbazli.Series["Zarar"].Points.AddXY(i, zarar);
                    }

                }
                //cmd.CommandType = CommandType.StoredProcedure;

                //cmd.Parameters.AddWithValue("@unit_input_price", unit_input_price);
                //cmd.Parameters.AddWithValue("@prize", prize);
            }
        }
    }
}