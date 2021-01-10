using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace SupermarketManagementSystem
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            Submenu();
        }

        private void Submenu()
        {
            panelSubMenuSatis.Visible = false;
            panelSubMenuRapor.Visible = false;

        }

        private void HideSubmenu()
        {
            if (panelSubMenuSatis.Visible == true )
            {
                panelSubMenuSatis.Visible = false;
            }
            if (panelSubMenuRapor.Visible == true)
            {
                panelSubMenuRapor.Visible = false;
            }
        }

        private void ShowSubmenu( Panel submenu) 
        {
            if (submenu.Visible == false)
            {
                HideSubmenu();
                submenu.Visible = true;
            }
            else
            {
                submenu.Visible = false;
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormDebt());
            //sonra yazcağım kodlar...

            HideSubmenu();
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelSubMenuSatis);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormCari());
            //sonra yazcağım kodlar...

        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormPesin());
            //sonra yazcağım kodlar...

        }

        private void btnRapor_Click(object sender, EventArgs e)
        {
            ShowSubmenu(panelSubMenuRapor);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormDebtReport());
            //sonra yazcağım kodlar...

            HideSubmenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormKarZarar());
            //sonra yazcağım kodlar...

            HideSubmenu();
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormReport());
            //sonra yazcağım kodlar...

            HideSubmenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //sonra yazcağım kodlar...

            HideSubmenu();
        }

        private void btnUrunler_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormcs());

            HideSubmenu();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormStok());
            //sonra yazcağım kodlar...

            HideSubmenu();
        }

        private Form activeForm = null;
        private void OpenSubForm(Form subForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = subForm;
            subForm.TopLevel = false;
            subForm.FormBorderStyle = FormBorderStyle.None;
            subForm.Dock = DockStyle.Fill;
            panelSubForm.Controls.Add(subForm);
            panelSubForm.BringToFront();
            subForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            button2.Visible = false;
            button6.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            button6.Visible = false;
            button2.Visible = true;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenSubForm(new SubFormCharts());
        }
    }


}
