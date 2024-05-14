using CoffeeShop_DBMS.Items;
using CoffeeShop_DBMS.POS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_DBMS
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        POSForm pOSForm = new POSForm();
        ItemsForm ItemsForm = new ItemsForm();

        bool isToggle = true;
        bool isMaximize = false;

        private void MainForm_Load(object sender, EventArgs e)
        {
            tmSidebar.Interval = 1;
            tmSidebar.Stop();
            tmTime.Start();
        }

        private void tmSidebar_Tick(object sender, EventArgs e)
        {
            if (!isToggle)
            {
                pnSidebar.Width -= 17;
                if (pnSidebar.Width <= 140)
                {
                    btnToggle.Text = string.Empty;
                    btnSumary.Text = string.Empty;
                    btnItem.Text = string.Empty;
                    btnPos.Text = string.Empty;
                    btnLogout.Text = string.Empty;

                    lbVersion.Visible = false;
                    pnProfile.Visible = false;
                }
                if (pnSidebar.Width <= 45)
                {
                    tmSidebar.Stop();
                    isToggle = true;

                }
            }
            if (isToggle)
            {
                pnSidebar.Width += 17;
                if (pnSidebar.Width >= 150)
                {
                    tmSidebar.Stop();
                    isToggle = false;

                    btnToggle.Text = "Menu";
                    btnPos.Text = "POS";
                    btnSumary.Text = "Sumary";
                    btnItem.Text = "Items";
                    btnLogout.Text = "Log Out";

                    lbVersion.Visible = true;
                    pnProfile.Visible = true;
                }
            }
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
            tmSidebar.Start();
            pOSForm.Dock = DockStyle.Fill;
        }

        private void btnSumary_Click(object sender, EventArgs e)
        {
            btnSumary.BackColor = Color.Black;
            btnItem.BackColor = Color.FromArgb(105, 105, 105);
            btnPos.BackColor = Color.FromArgb(105, 105, 105);
        }

        private void btnPos_Click(object sender, EventArgs e)
        {
            pOSForm.TopLevel = false;
            pOSForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(pOSForm);
            pOSForm.Show();
            pOSForm.BringToFront();

            btnPos.BackColor = Color.Black;
            btnItem.BackColor = Color.FromArgb(105, 105, 105);
            btnSumary.BackColor = Color.FromArgb(105, 105, 105);
        }

        private void btnItem_Click(object sender, EventArgs e)
        {
            ItemsForm.TopLevel = false;
            ItemsForm.Dock = DockStyle.Fill;
            pnMain.Controls.Add(ItemsForm);
            ItemsForm.Show();
            ItemsForm.BringToFront();

            btnItem.BackColor = Color.Black;
            btnPos.BackColor = Color.FromArgb(105, 105, 105);
            btnSumary.BackColor = Color.FromArgb(105, 105, 105);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnSumary_MouseHover(object sender, EventArgs e)
        {
            ttShow.SetToolTip(btnSumary, "Summary");
        }

        private void btnPos_MouseHover(object sender, EventArgs e)
        {
            ttShow.SetToolTip(btnPos, "POS");
        }

        private void btnItem_MouseHover(object sender, EventArgs e)
        {
            ttShow.SetToolTip(btnItem, "Coffee Item");
        }

        private void tmTime_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToString("D");
            lbTime.Text = DateTime.Now.ToString("T");
        }
    }
}
