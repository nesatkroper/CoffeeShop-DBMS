namespace CoffeeShop_DBMS.POS
{
    partial class POSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.flpData = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbCate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flpOrder = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.item1 = new CoffeeShop_DBMS.POS.Item();
            this.item2 = new CoffeeShop_DBMS.POS.Item();
            this.item3 = new CoffeeShop_DBMS.POS.Item();
            this.item4 = new CoffeeShop_DBMS.POS.Item();
            this.item5 = new CoffeeShop_DBMS.POS.Item();
            this.item6 = new CoffeeShop_DBMS.POS.Item();
            this.itemSelect1 = new CoffeeShop_DBMS.POS.ItemSelect();
            this.itemSelect2 = new CoffeeShop_DBMS.POS.ItemSelect();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.flpData.SuspendLayout();
            this.flpOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1174, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(350, 813);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClear);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(10, 10);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10, 15, 10, 15);
            this.panel2.Size = new System.Drawing.Size(330, 74);
            this.panel2.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(10, 715);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(10, 10, 10, 0);
            this.panel3.Size = new System.Drawing.Size(330, 88);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.flpOrder);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 631);
            this.panel4.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Kode Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selected Items";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel5.Location = new System.Drawing.Point(1169, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 813);
            this.panel5.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel6.Controls.Add(this.flpData);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.panel7);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(5, 5);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(5);
            this.panel6.Size = new System.Drawing.Size(1164, 813);
            this.panel6.TabIndex = 2;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.Control;
            this.panel7.Controls.Add(this.comboBox2);
            this.panel7.Controls.Add(this.label4);
            this.panel7.Controls.Add(this.cbCate);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(5, 5);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1154, 79);
            this.panel7.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(5, 84);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1154, 8);
            this.panel8.TabIndex = 1;
            // 
            // flpData
            // 
            this.flpData.AutoScroll = true;
            this.flpData.BackColor = System.Drawing.SystemColors.Control;
            this.flpData.Controls.Add(this.item1);
            this.flpData.Controls.Add(this.item2);
            this.flpData.Controls.Add(this.item3);
            this.flpData.Controls.Add(this.item4);
            this.flpData.Controls.Add(this.item5);
            this.flpData.Controls.Add(this.item6);
            this.flpData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpData.Location = new System.Drawing.Point(5, 92);
            this.flpData.Name = "flpData";
            this.flpData.Padding = new System.Windows.Forms.Padding(10);
            this.flpData.Size = new System.Drawing.Size(1154, 716);
            this.flpData.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Kode Mono", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1154, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Selected Items";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbCate
            // 
            this.cbCate.Font = new System.Drawing.Font("Kode Mono", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbCate.FormattingEnabled = true;
            this.cbCate.Location = new System.Drawing.Point(32, 40);
            this.cbCate.Name = "cbCate";
            this.cbCate.Size = new System.Drawing.Size(200, 31);
            this.cbCate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Kode Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(28, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "Category";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Kode Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(234, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Category";
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Kode Mono", 11.25F, System.Drawing.FontStyle.Bold);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(238, 40);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 31);
            this.comboBox2.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Kode Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(216, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 29);
            this.label6.TabIndex = 0;
            this.label6.Text = "$";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Kode Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(241, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "200.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Kode Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 29);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Pay:";
            // 
            // flpOrder
            // 
            this.flpOrder.AutoScroll = true;
            this.flpOrder.BackColor = System.Drawing.Color.White;
            this.flpOrder.Controls.Add(this.itemSelect1);
            this.flpOrder.Controls.Add(this.itemSelect2);
            this.flpOrder.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpOrder.Location = new System.Drawing.Point(0, 0);
            this.flpOrder.Name = "flpOrder";
            this.flpOrder.Padding = new System.Windows.Forms.Padding(5);
            this.flpOrder.Size = new System.Drawing.Size(330, 631);
            this.flpOrder.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Kode Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = global::CoffeeShop_DBMS.Properties.Resources.badge_dollar_solid_24__1_1;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(10, 50);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.button1.Size = new System.Drawing.Size(310, 38);
            this.button1.TabIndex = 1;
            this.button1.Text = "Pay";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Kode Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Image = global::CoffeeShop_DBMS.Properties.Resources.trash_regular_24__1_;
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClear.Location = new System.Drawing.Point(221, 15);
            this.btnClear.Name = "btnClear";
            this.btnClear.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnClear.Size = new System.Drawing.Size(99, 44);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // item1
            // 
            this.item1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item1.Location = new System.Drawing.Point(13, 13);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(350, 111);
            this.item1.TabIndex = 0;
            // 
            // item2
            // 
            this.item2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item2.Location = new System.Drawing.Point(369, 13);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(350, 111);
            this.item2.TabIndex = 1;
            // 
            // item3
            // 
            this.item3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item3.Location = new System.Drawing.Point(725, 13);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(350, 111);
            this.item3.TabIndex = 2;
            // 
            // item4
            // 
            this.item4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item4.Location = new System.Drawing.Point(13, 130);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(350, 111);
            this.item4.TabIndex = 3;
            // 
            // item5
            // 
            this.item5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item5.Location = new System.Drawing.Point(369, 130);
            this.item5.Name = "item5";
            this.item5.Size = new System.Drawing.Size(350, 111);
            this.item5.TabIndex = 4;
            // 
            // item6
            // 
            this.item6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.item6.Location = new System.Drawing.Point(725, 130);
            this.item6.Name = "item6";
            this.item6.Size = new System.Drawing.Size(350, 111);
            this.item6.TabIndex = 5;
            // 
            // itemSelect1
            // 
            this.itemSelect1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.itemSelect1.Location = new System.Drawing.Point(8, 8);
            this.itemSelect1.Name = "itemSelect1";
            this.itemSelect1.Size = new System.Drawing.Size(290, 55);
            this.itemSelect1.TabIndex = 0;
            // 
            // itemSelect2
            // 
            this.itemSelect2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.itemSelect2.Location = new System.Drawing.Point(8, 69);
            this.itemSelect2.Name = "itemSelect2";
            this.itemSelect2.Size = new System.Drawing.Size(290, 55);
            this.itemSelect2.TabIndex = 1;
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1529, 823);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "POSForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "POSForm";
            this.Load += new System.EventHandler(this.POSForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.flpData.ResumeLayout(false);
            this.flpOrder.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.FlowLayoutPanel flpData;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flpOrder;
        private Item item1;
        private Item item2;
        private Item item3;
        private Item item4;
        private Item item5;
        private Item item6;
        private ItemSelect itemSelect1;
        private ItemSelect itemSelect2;
    }
}