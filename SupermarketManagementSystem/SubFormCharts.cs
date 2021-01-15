using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        public SubFormCharts()
        {
            InitializeComponent();
        }

        public void KarHesaplama() // bu metot grafiklerin metotu. ürünler database'e eklendiğinde kontrol edilecek......
        {



            float kar = 0;
            float zarar = 0;

            for (int i = 11; i < 87; i++)
            {
                float girdi_fiyati = Product.getProductbyProductNo(i).unit_input_price;
                float satis_fiyati = Product.getProductbyProductNo(i).prize;
            
                if((satis_fiyati - girdi_fiyati) > 0)
                {
                    kar = satis_fiyati - girdi_fiyati;
                    urunbazli.Series["Kar"].Points.AddXY(i, kar);
                }
                else if((satis_fiyati - girdi_fiyati) < 0)
                {
                    zarar = satis_fiyati - girdi_fiyati;
                    urunbazli.Series["Zarar"].Points.AddXY(i, zarar);
                }
                
            }
            urunbazli.Titles.Add("Ürün Bazlı Grafik");


        }

        private void urunbazli_Click(object sender, EventArgs e)
        {

        }
    }
}
