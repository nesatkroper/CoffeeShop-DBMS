using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop_DBMS.POS
{
    public partial class Item : UserControl
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(int left, int top, int right, int bottom, int width, int height);

        public Item()
        {
            InitializeComponent();
        }

        private Image _img;
        private string _name;
        private string _price;
        private string _cate;

        #region MyRegion
        [Category("Custom Props")]
        public Image Img
        {
            get { return _img; }
            set
            {
                _img = value;
                pbItem.Image = value;
            }
        }

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
        public string Cate
        {
            get { return _cate; }
            set
            {
                _cate = value;
                lbCate.Text = value;
            }
        }
        #endregion


        private void Item_Load(object sender, EventArgs e)
        {

        }
    }
}
