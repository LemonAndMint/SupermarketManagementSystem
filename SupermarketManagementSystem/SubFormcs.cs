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
        }

        private void Product_Import(object sender, EventArgs e)
        {
            
        }

		private void button1_Click(object sender, EventArgs e)
		{
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

        Product.setProduct(1, (int)long.Parse(row[1]), 3, int.Parse(row[0]), int.Parse(row[3]), 1, float.Parse(row[4]), DateTime.Now);
        table.Rows.Add(row);
      }
    }
	}
}