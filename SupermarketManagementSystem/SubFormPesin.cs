using SupermarketManagementSystem.database;
using SupermarketManagementSystem.database.sale;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SupermarketManagementSystem
{
    public partial class SubFormPesin : Form
    {

        private int rowIndex = 0;
        public SubFormPesin()
        {
            InitializeComponent();
    
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-PCFS9CS\\SQLEXPRESS;Initial Catalog=SchoolDB-ByConnectionString;Integrated Security=true;");
        DataSet daset = new DataSet();
        DataTable table = new DataTable();
        private void SubFormPesin_Load_1(object sender, EventArgs e)
        {
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Barcode No", typeof(int));
            table.Columns.Add("Product No", typeof(int));
            table.Columns.Add("Unit Input Price", typeof(int));
            table.Columns.Add("Amount", typeof(int));


            dataGridView1.DataSource = table;
        }
        public void loadDatabaseSale()
        {
            List<CashSale> sales = CashSale.getallCSale();
            float totalDebt = 0;

            foreach (CashSale s in sales)
            {
                int[] cashSaleProducts = { s.sale_no, s.product_no, Convert.ToInt32(s.sale_date) };
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            //CashSale.setCSale(1, 3, DateTime.Now, "Cash", "aa", 5);
            //for (int i = 0; i < dataGridView1.Rows.Count; i++)
            //CashSale.setCSale(1, 3, DateTime.Now, "Cash", "aa",5)
            //     loadDatabaseSale();


            for(int i = 0; i< dataGridView1.Rows.Count - 1; i++)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("insert into Sales( product_no, sale_date ,payment_method, Discriminator) values ( @product_no, @sale_date ,@payment_method, @Discriminator)", baglanti);

                komut.Parameters.AddWithValue("@product_no", dataGridView1.Rows[i].Cells["Product No"].Value);
                komut.Parameters.AddWithValue("@sale_date", DateTime.Now);
                komut.Parameters.AddWithValue("@payment_method", "Ödeme yapıldı");
                komut.Parameters.AddWithValue("@Discriminator", "??");

                komut.ExecuteNonQuery();
                baglanti.Close();
            }
            MessageBox.Show("Kayıtlar eklendi");
            table.Clear();

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
                        table.Rows.Add(product.product_name, barcode, product.product_no, product.unit_input_price, product.amount);
                        dataGridView1.DataSource = table;
                        urun_barkod1.Text = "";
                        hesapla();
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "FRMARKETOTOMASYONU");
                }

            }
        }

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            }
        }


        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.dataGridView1.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.dataGridView1.CurrentCell = this.dataGridView1.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void urun_barkod1_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}