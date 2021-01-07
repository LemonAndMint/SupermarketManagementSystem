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
            string[] lines = File.ReadAllLines(@"C:\Users\User\Desktop\products.txt");
            string[] values;

            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split('/');
                string[] row = new string[values.Length];

                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();
                }

                table.Rows.Add(row);


            }
        }
    }
}