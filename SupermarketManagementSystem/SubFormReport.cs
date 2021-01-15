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
    public partial class SubFormReport : Form
    {
        public SubFormReport()
        {
            
            InitializeComponent();
        }




        private void SubFormReport_Load(object sender, EventArgs e)
        {

            DataTable table = new DataTable();
            table.Columns.Add("Customer No", typeof(int));
            table.Columns.Add("Product No", typeof(string));
            table.Columns.Add("Total Amount", typeof(int));
            table.Columns.Add("Total Sale", typeof(float));

            dataGridView2.DataSource = table;

            List<DebitSale> prdts = DebitSale.getallDSale();

            if (prdts != null)
            {
                foreach (DebitSale p in prdts)
                {
                    object[] row = { p.customer_no, p.product_no, 1, p.price };
                    table.Rows.Add(row);
                }
            }
        }
    }
}
