using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using SupermarketManagementSystem.database;
using SupermarketManagementSystem.database.sale;

namespace SupermarketManagementSystem
{
    public partial class SubFormcs : Form
    {
    string barcode;
        public SubFormcs()
        {
            InitializeComponent();
            
        }
        DataTable table = new DataTable();
        private void SubFormcs_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Product Id", typeof(int));
            table.Columns.Add("Barcode", typeof(long));
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Quantify(package/kg)", typeof(int));
            table.Columns.Add("Unit Price(TL)", typeof(float));
            table.Columns.Add("Delivery No", typeof(int));
            table.Columns.Add("Sale Price(TL)", typeof(float));

            dataGridView1.DataSource = table;
            Product_Import(sender, e);
            loadDatabaseProduct();

        //CashSale.setCSale(1,11,DateTime.Now,"nakit","aa",1);
        //CashSale.setCSale(1,11,DateTime.Now, "nakit", "aa", 1);
        //CashSale.getallCSale();

        //DebitSale.setDSale(1, 1 ,11, DateTime.Now, "nakit", "aa", 1, 1);
        //DebitSale.setDSale(2, 2, 12, DateTime.Now, "nakit", "aa", 2, 1);
        //DebitSale.setDSale(2, 3, 12, DateTime.Now, "nakit", "aa", 2, 1);
        //DebitSale.getallDSale();

    }

        private void Product_Import(object sender, EventArgs e)
        {
            
        }

    private void loadDatabaseProduct()
		{
    List<Product> prdts = Product.getAllProduct();

      if (prdts != null)
      {
        foreach (Product p in prdts)
        {
          string[] row = {(p.product_no).ToString(), (p.barcode).ToString(),
                                      p.product_name, (p.amount).ToString(),
                                      (p.unit_input_price).ToString(), (p.waybill_no).ToString(),
                                      (p.prize).ToString()};
          table.Rows.Add(row);
        }
      }
		}

    private void removeDatabase()
		{
      table.Rows.Clear();
    }

		private void button2_Click(object sender, EventArgs e)
		{
             Product.delProductByBarcode(int.Parse(barcode));
             removeDatabase();
             loadDatabaseProduct();
        }

		private void button3_Click(object sender, EventArgs e)
		{

		}

		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
      barcode = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
      MessageBox.Show(barcode);
		}
	}
}