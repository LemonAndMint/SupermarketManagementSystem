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
    private void SubFormPesin_Load(object sender, EventArgs e)
    {
      table.Columns.Add("Product Id", typeof(int));
      table.Columns.Add("Barcode", typeof(long));
      //table.Columns.Add("Unit Price(TL)", typeof(float));ss

      dataGridView1.DataSource = table;

    }
    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        //long barcode = Convert.ToInt64(urun_barkod1.Text);
        //long barcode = Convert.ToInt64(urun_barkod1.Text);
        Product product = Product.getProductbyBarcode(2);

        if (product == null)
        {
          //MessageBox.Show("Bu Barkoda Ait Ürün Bulunmamaktadır", "ERROR");
        }
        else
        {

          table.Rows.Add(product.product_no);
          table.Rows.Add(product.barcode);
          dataGridView1.DataSource = table;

        }


      }


      catch (Exception EX)
      {
        MessageBox.Show(EX.Message, "FRMARKETOTOMASYONU");

      }

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void urun_barkod1_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void urun_barkod_KeyDown(object sender, KeyEventArgs e)
    {
      /*if (e.KeyCode == Keys.Enter)
      {
        try
        {
          //long barcode = Convert.ToInt64(urun_barkod1.Text);
          //long barcode = Convert.ToInt64(urun_barkod1.Text);
          Product product = Product.getProductbyBarcode(8697524862546);

          if (product == null)
          {
            MessageBox.Show("Bu Barkoda Ait Ürün Bulunmamaktadır", "ERROR");
          }
          else
          {
            /*if (Product.getProductbyBarcode(barcode).product_no == null)
            {
                table.Rows.Add(Product.getProductbyBarcode(barcode).product_no);
                dataGridView1.DataSource = table;
            }




          }


        }


        catch (Exception EX)
        {
          MessageBox.Show(EX.Message, "FRMARKETOTOMASYONU");

        }

      }*/

    }
  }
}