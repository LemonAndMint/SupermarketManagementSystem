using SupermarketManagementSystem.database;
using SupermarketManagementSystem.database.sale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class SubFormStok : Form
    {
        public SubFormStok()
        {
            InitializeComponent();
           

        }

    DataTable table = new DataTable();
    private void SubFormStok_Load(object sender, EventArgs e)
    {
      
    }

    private void Product_Import(object sender, EventArgs e)
    {

    }

    public  void loadDatabaseProduct()
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

    private void button1_Click(object sender, EventArgs e)
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

      String strAppPath = Path.GetDirectoryName(System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName);
      String strFilePath = Path.Combine(strAppPath, "Resources");
      String strFullFilename = Path.Combine(strFilePath, "products.txt");
      string[] lines = File.ReadAllLines(strFullFilename);
      string[] values;

      for (int i = 0; i < lines.Length; i++)
      {
        values = lines[i].ToString().Split('/');
        string[] row = new string[values.Length];

        for (int j = 0; j < values.Length; j++)
        {
          row[j] = values[j].Trim();
        }
        Product.setProduct(int.Parse(row[5]), int.Parse(row[1]), 3, 
                           int.Parse(row[0]), float.Parse(row[4], CultureInfo.InvariantCulture.NumberFormat), int.Parse(row[3]), 
                           float.Parse(row[6], CultureInfo.InvariantCulture.NumberFormat), DateTime.Now, row[2]);
        
      }
      loadDatabaseProduct();
    }

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

        private void SubFormStok_Load_1(object sender, EventArgs e)
        {

        }
    }
}
