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

            dataGridView1.DataSource = table;
            Product_Import(sender, e);
            loadDatabaseProduct();
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
                                      p.product_name, (p.unit_input_price).ToString(),
                                      (p.prize).ToString(), (p.waybill_no).ToString()};
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