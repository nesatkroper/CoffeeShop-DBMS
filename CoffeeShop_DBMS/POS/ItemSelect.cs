using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_DBMS.POS
{
    public partial class ItemSelect : UserControl
    {
        public ItemSelect()
        {
            InitializeComponent();
        }

        private string _name;
        private string _price;
        private string _qty;

        int qty = 1;
        double unitPrice = 9.9;

        #region MyRegion
        [Category("Custom Props")]
        public string Title
        {
            get { return _name; }
            set
            {
                _name = value;
                lbName.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set
            {
                _price = value;
                lbPrice.Text = value;
            }
        }

        [Category("Custom Props")]
        public string Qty
        {
            get { return _qty; }
            set
            {
                _qty = value;
                lbQty.Text = value;
            }
        }
        #endregion

        private void ItemSelect_Load(object sender, EventArgs e)
        {
            lbPrice.Text = qty.ToString();
            lbQty.Text = qty.ToString();
            lbAmount.Text = (unitPrice * qty).ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            qty--;
            lbQty.Text = qty.ToString();
            lbAmount.Text = (unitPrice * qty).ToString();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            qty++;
            lbQty.Text = qty.ToString();
            lbAmount.Text = (unitPrice * qty).ToString();
        }
    }
}
