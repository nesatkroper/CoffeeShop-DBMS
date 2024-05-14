using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoffeeShop_DBMS.Items
{
    public partial class ItemsForm : Form
    {
        public ItemsForm()
        {
            InitializeComponent();
        }

        Consts consts = new Consts();
        SqlConnection conn;

        bool succes = false;
        string id_;
        string imgLocation = null;
        string curentImageName = null;
        string curentImagePath = null;
        string currentImgUrl = null;
        string ImgPath_ = null;
        string imgDesPath = null;
        string[] category = new string[] { "Hot Drink", "Cool Drink", "Frape" };

        void AddItem()
        {
            foreach (var item in category) cbCate.Items.Add(item);
            cbCate.Text = category[0];
        }

        // THIS IS USE FOR BROWSE IMAGE
        void BrowseImage_()
        {
            try
            {
                OpenFileDialog dailog = new OpenFileDialog();
                dailog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                dailog.FilterIndex = 1;
                pcbItem.ImageLocation = null;
                if (dailog.ShowDialog() == DialogResult.OK)
                {
                    imgLocation = null;
                    imgLocation = dailog.FileName.ToString();
                    pcbItem.ImageLocation = imgLocation;
                    curentImageName = Path.GetFileName(imgLocation);
                    succes = true;
                }
                else return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // THIS IS USE FOR COPY IMAGE AND STORE IN APPLICATION
        void CopyImage_()
        {
            if (!string.IsNullOrEmpty(imgLocation))
            {
                imgDesPath = Path.Combine(Application.StartupPath, "Items", curentImageName);
                try
                {
                    File.Copy(imgLocation, imgDesPath);
                    curentImagePath = imgDesPath;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else return;
        }

        void LoadData_()
        {
            try
            {
                conn.Open();
                string sql = "select * from Item_TB";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                dgvData.Refresh();
                dgvData.Rows.Clear();
                while (reader.Read())
                {
                    FileStream stream = new FileStream(reader[4].ToString(), FileMode.Open);
                    MemoryStream photoStream = new MemoryStream();
                    stream.CopyTo(photoStream);
                    stream.Close();
                    dgvData.Rows.Add(reader[0], reader[1], reader[3], reader[2], Image.FromStream(photoStream));
                }
                reader.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // ADD RECORD
        void InsertDatabase_()
        {
            try
            {
                conn.Open();
                string sql = "insert into Item_TB (ite_name, ite_price, ite_cate, ite_pic) values (@name, @price, @cate, @pic);";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@price", txtPrice.Text);
                command.Parameters.AddWithValue("@cate", cbCate.Text);
                command.Parameters.AddWithValue("@pic", curentImagePath);
                command.ExecuteNonQuery();
                conn.Close();
                LoadData_();
                succes = true;
                ClearInput_();
            }
            catch (SqlException ex)
            {
                ClearInput_();
                succes = false;
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        void UpdateDatabase_()
        {
            bool success = false;
            try
            {
                conn.Open();
                string sql = "update Item_TB set ite_name = @name, ite_price = @price, ite_cate = @cate, ite_pic = @pic where ite_id = @id";
                string sql_ = "update Item_TB set ite_name = @name, ite_price = @price, ite_cate = @cate where ite_id = @id";
                SqlCommand command = new SqlCommand(sql_, conn);
                command.Parameters.AddWithValue("@name", txtName.Text);
                command.Parameters.AddWithValue("@price", txtPrice.Text);
                command.Parameters.AddWithValue("@cate", cbCate.Text);
                command.Parameters.AddWithValue("@id", id_);
                if (succes)
                {
                    command.Parameters.AddWithValue("@pic", curentImagePath);
                    File.Delete(currentImgUrl);
                    succes = false;
                    command.CommandText = sql;
                }
                else command.CommandText = sql_;
                command.ExecuteNonQuery();
                MessageBox.Show("Employee Information Updated.", "Success...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                conn.Close();
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        // DELETE RECORD
        void DeleteRecord_()
        {
            try
            {
                conn.Open();
                string sql = "delete from Item_TB where ite_id = @id";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@id", id_);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
        }

        void DeleteImg_()
        {
            try
            {
                conn.Open();
                string query_ = "select ite_pic from Item_TB WHERE ite_id = @id";
                SqlCommand cmd = new SqlCommand(query_, conn);
                cmd.Parameters.AddWithValue("@id", id_);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ImgPath_ = dr[0].ToString();
                }
                dr.Close();
                conn.Close();
            }
            catch (SqlException ex)
            {
                conn.Close();
                MessageBox.Show(ex.Message);
            }
            File.Delete(ImgPath_);
        }

        void ClearInput_()
        {
            txtName.Clear();
            txtPrice.Clear();
        }

        private void ItemsForm_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(consts.connString);
            AddItem();
            LoadData_();

            txtName.Text = "Example Name";
            txtName.ForeColor = Color.Gray;
            txtName.Text = "Example Name";
            txtName.ForeColor = Color.Gray;
        }

        private void pcbItem_Click(object sender, EventArgs e)
        {
            BrowseImage_();
            CopyImage_();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            InsertDatabase_();
            if (!succes) File.Delete(imgDesPath);
            LoadData_();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            UpdateDatabase_();
            LoadData_();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Wanna Delete This Record?", "Question...", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                DeleteImg_();
                DeleteRecord_();
                LoadData_();
            }
            else return;
        }

        private void dgvData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvData.SelectedRows.Count > 0)
            {
                id_ = dgvData.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dgvData.SelectedRows[0].Cells[1].Value.ToString();
                cbCate.Text = dgvData.SelectedRows[0].Cells[2].Value.ToString();
                txtPrice.Text = ("$ ") + (dgvData.SelectedRows[0].Cells[3].Value.ToString());
                conn.Open();
                SqlCommand cmd = new SqlCommand($"select ite_pic from Item_TB where ite_id = '{id_}'", conn);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read()) currentImgUrl = dr[0].ToString();
                conn.Close();
                pcbItem.ImageLocation = currentImgUrl;
            }
        }

        private void txtName_Click(object sender, EventArgs e)
        {

        }

        private void txtPrice_Click(object sender, EventArgs e)
        {

        }
    }
}
