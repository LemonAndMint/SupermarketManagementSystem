using SupermarketManagementSystem.database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
  public partial class SubFormPesin : Form
  {
    public SubFormPesin()
    {
      InitializeComponent();
    }
    DataTable table = new DataTable();
    private void SubFormPesin_Load_1(object sender, EventArgs e)
    {
      table.Columns.Add("Barcode No", typeof(int));
      table.Columns.Add("Product No", typeof(int));
      table.Columns.Add("Unit Input Price", typeof(int));
      table.Columns.Add("Amount", typeof(int));

      dataGridView1.DataSource = table;
    }
    private void button1_Click(object sender, EventArgs e)
    {
      hesapla();
    }

     public void hesapla()
     {
            int toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
            }
            label5.Text = toplam.ToString();
      }


        private void urun_barkod(object sender, KeyEventArgs e)
        {

            
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void urun_barkod1_TextChanged_1(object sender, KeyEventArgs e)
        {
        if (e.KeyCode == Keys.Enter)
            {
                try
                {

                    int barcode = Convert.ToInt32(urun_barkod1.Text);
                    Product product = Product.getProductbyBarcode(barcode);

                    if (product == null)
                    {
                        MessageBox.Show("Bu Barkoda Ait Ürün Bulunmamaktadır", "ERROR");
                    }
                    else
                    {

                        table.Rows.Add(barcode, product.product_no, product.unit_input_price, product.amount);
                        dataGridView1.DataSource = table;
                        urun_barkod1.Text = "";
                        //hesapla();
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "FRMARKETOTOMASYONU");

                }

            }
        }
        

    }
}