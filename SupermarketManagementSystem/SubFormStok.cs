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

    private void SubFormStok_Load_1(object sender, EventArgs e)
    {
            table.Columns.Add("product_no", typeof(int));
            table.Columns.Add("barcode", typeof(long));
            table.Columns.Add("product_name", typeof(string));
            table.Columns.Add("amount", typeof(int));
            table.Columns.Add("unit_input_price", typeof(float));
            table.Columns.Add("supplier_no", typeof(int));
            table.Columns.Add("prize", typeof(float));

            dataGridView1.DataSource = table;
            //Product_Import(sender, e);

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
                                      (p.price).ToString()};
          table.Rows.Add(row);
        }
      }
    }
    int i = 0;
    private void button1_Click(object sender, EventArgs e)
	{
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int secilisatir = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(secilisatir);
                Product.delProductByBarcode(Convert.ToInt32(dataGridView1.Rows[secilisatir].Cells["barcode"].Value));

            }
            else
            {
                MessageBox.Show("Lüffen silinecek satırı seçin.");
            }



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

      

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
            table.Rows.Add(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, textBox7.Text);

            //Product.setProduct(i, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox7.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox3.Text), Convert.ToSingle(textBox6.Text), DateTime.Now, textBox2.Text);
            Product.setProduct(i, Convert.ToInt32(textBox2.Text), Convert.ToInt32(textBox6.Text), Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox5.Text), Convert.ToInt32(textBox4.Text), Convert.ToInt32(textBox7.Text), DateTime.Now, (textBox3.Text));
            dataGridView1.DataSource = table;
            MessageBox.Show("PRODUCT ADDED ");
            textBox7.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            i++;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
