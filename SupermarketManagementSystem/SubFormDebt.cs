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
using SupermarketManagementSystem.database;
using System.Data.OleDb;

namespace SupermarketManagementSystem
{
    public partial class SubFormDebt : Form
    {
        public SubFormDebt()
        {
            InitializeComponent();
   
        }
        DataTable table = new DataTable();

        private void SubFormDebt_Load(object sender, EventArgs e)
        {
            table.Columns.Add("Customer No", typeof(int));
            table.Columns.Add("Product No", typeof(int));
            //table.Columns.Add("Debt Amount", typeof(int));
            table.Columns.Add("Sale Price", typeof(float));
            table.Columns.Add("Debt Date", typeof(DateTime));
            //table.Columns.Add("Sale No", typeof(int));
            //table.Columns.Add("Payment_method", typeof(string));
            dataGridView1.DataSource = table;

            List<DebitSale> debtSoldProducts = DebitSale.getallDSale();

            if (debtSoldProducts != null)
            {
                foreach (DebitSale p in debtSoldProducts)
                {
                    object[] row = { (p.customer_no), (p.product_no), p.prize, (p.sale_date).ToString()};
                    // s.customer_no, s.product_no, s.CustomerDebt.debt_amount , s.sale_date, s.sale_no, s.payment_method
                    table.Rows.Add(row);
                }
            }

        }
        public void loadDatabaseCustomerDebts()
        {
            

        }
        private void searchCustomer_TextChanged_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    int customer = Convert.ToInt32(searchCustomer.Text);
                    CustomerDebt customerDebt = CustomerDebt.getCDebt(customer);
                    DebitSale debitSale = DebitSale.getDebitSale(customer);


                    if (customer == null)
                    {
                        MessageBox.Show("The debt information of the customer entered was not found!", "ERROR");
                    }
                    else
                    {
                        List<DebitSale> debtSoldProducts = DebitSale.getallDSale();

                        if (debtSoldProducts != null)
                        {
                            foreach (DebitSale s in debtSoldProducts)
                            {
                                Object[] SoldProducts_debt = { s.customer_no, s.product_no, s.CustomerDebt.debt_amount, s.sale_date, s.sale_no, s.payment_method, };
                                table.Rows.Add(SoldProducts_debt);
                            }
                        }
                    }
                }
                catch (Exception EX)
                {
                    MessageBox.Show(EX.Message, "ERROR");
                }

            }



        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchCustomer_TextChanged(object sender, EventArgs e)
        {
            string aranan = searchCustomer.Text.Trim().ToUpper();
            for (int i = 0; i <= dataGridView1.Rows.Count - 1; i++)
            {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in dataGridView1.Rows[i].Cells)
                    {
                        if (cell.Value != null)
                        {
                            if (cell.Value.ToString().ToUpper() == aranan)
                            {
                                cell.Style.BackColor = Color.FromArgb(180, 205, 147);
                                if(cell.Style.BackColor == Color.White)
                                {
                                    dataGridView1.Rows[i].Visible = false;
                                }
                                break;
                            }
                            cell.Style.BackColor = Color.White;
                            dataGridView1.Rows[i].Visible = true;
                        }
                    }
                }
            }
        }
    }
}
