using SupermarketManagementSystem.database;
using SupermarketManagementSystem.database.sale;
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
    public partial class SubFormCari : Form
    {
        private int rowIndex = 0;
        //public int 
        public SubFormCari()
        {
            InitializeComponent();
        }
        DataTable table = new DataTable();

        private void SubFormCari_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Product No", typeof(int));     
            table.Columns.Add("Barcode No", typeof(int));
            table.Columns.Add("Product Name", typeof(string));
            table.Columns.Add("Amount", typeof(int));
            table.Columns.Add("Unit Input Price", typeof(float));
            table.Columns.Add("Sale Price", typeof(float));
            




            dataGridView1.DataSource = table;
        }
        public void hesapla()
        {
            float toplam = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplam += Convert.ToSingle(dataGridView1.Rows[i].Cells["Sale Price"].Value);
            }
            label5.Text =( toplam.ToString() + "₺" );
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
                        table.Rows.Add(product.product_no, barcode, product.product_name, 1, product.unit_input_price ,product.price);
                        dataGridView1.DataSource = table;
                        urun_barkod1.Text = "";
                        hesapla();
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "ERROR");
                }

            }
        }
     

        public void CustomerShoppingCounter()
        {
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            int DebtSaleNo = 1;

            for(int i = 0; i< dataGridView1.Rows.Count -1; i++)
            {
                DebitSale.setDSale(Convert.ToInt32(addCustomer.Text), i, Convert.ToInt32(dataGridView1.Rows[i].Cells["Product No"].Value), Convert.ToSingle(dataGridView1.Rows[i].Cells["Unit Input Price"].Value), DateTime.Now, "Cari", "aa", Convert.ToInt32(dataGridView1.Rows[i].Cells["Barcode No"].Value), Convert.ToSingle(dataGridView1.Rows[i].Cells["Sale Price"].Value));
                //CustomerDebt.setCDebt(Convert.ToInt32(addCustomer.Text), Convert.ToInt32(dataGridView1.Rows[i].Cells["Unit Input Price"].Value) * Convert.ToInt32(dataGridView1.Rows[i].Cells["Amount"].Value), DateTime.Now, i);
            }
            //CustomerDebt.setCDebt(Convert.ToInt32(addCustomer.Text), Convert.ToInt32(label5.Text), DateTime.Now, DebitSale.getDebitSale(Convert.ToInt32( addCustomer.Text)).sale_no );
            MessageBox.Show("THE SALE WAS MADE ");
            DebtSaleNo++;
            label5.Text = "0 ₺";
            addCustomer.Text = "";
            table.Clear();
           
            
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

        private void deleteProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.dataGridView1.Rows[this.rowIndex].IsNewRow)
            {
                this.dataGridView1.Rows.RemoveAt(this.rowIndex);
            }
            hesapla();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void addCustomer_TextChanged(object sender, EventArgs e)
        {

        }

        private void urun_barkod1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
