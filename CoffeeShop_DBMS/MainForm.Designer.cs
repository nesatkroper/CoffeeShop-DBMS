namespace CoffeeShop_DBMS
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.pnSidebar = new System.Windows.Forms.Panel();
            this.tmSidebar = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbId = new System.Windows.Forms.Label();
            this.lbPos = new System.Windows.Forms.Label();
            this.pnProfile = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pbProfile = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnItem = new System.Windows.Forms.Button();
            this.btnPos = new System.Windows.Forms.Button();
            this.btnSumary = new System.Windows.Forms.Button();
            this.btnToggle = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.ttShow = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.tmTime = new System.Windows.Forms.Timer(this.components);
            this.pnSidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnProfile.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnSidebar
            // 
            this.pnSidebar.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnSidebar.Controls.Add(this.pnProfile);
            this.pnSidebar.Controls.Add(this.btnLogout);
            this.pnSidebar.Controls.Add(this.lbVersion);
            this.pnSidebar.Controls.Add(this.button4);
            this.pnSidebar.Controls.Add(this.btnItem);
            this.pnSidebar.Controls.Add(this.btnPos);
            this.pnSidebar.Controls.Add(this.btnSumary);
            this.pnSidebar.Controls.Add(this.panel1);
            this.pnSidebar.Controls.Add(this.btnToggle);
            this.pnSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnSidebar.Location = new System.Drawing.Point(0, 40);
            this.pnSidebar.Name = "pnSidebar";
            this.pnSidebar.Size = new System.Drawing.Size(50, 831);
            this.pnSidebar.TabIndex = 0;
            // 
            // tmSidebar
            // 
            this.tmSidebar.Tick += new System.EventHandler(this.tmSidebar_Tick);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(50, 50);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnMinimize);
            this.panel2.Controls.Add(this.btnMaximize);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1584, 40);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Kode Mono", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1584, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "COFFEE SHOP ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVersion
            // 
            this.lbVersion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbVersion.Font = new System.Drawing.Font("Kode Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.ForeColor = System.Drawing.Color.White;
            this.lbVersion.Location = new System.Drawing.Point(0, 813);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(50, 18);
            this.lbVersion.TabIndex = 7;
            this.lbVersion.Text = "v 1.0.0";
            this.lbVersion.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lbVersion.Visible = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Kode Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.ForeColor = System.Drawing.Color.White;
            this.lbName.Location = new System.Drawing.Point(9, 138);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(15, 18);
            this.lbName.TabIndex = 7;
            this.lbName.Text = "?";
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Font = new System.Drawing.Font("Kode Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbId.ForeColor = System.Drawing.Color.White;
            this.lbId.Location = new System.Drawing.Point(9, 156);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(15, 18);
            this.lbId.TabIndex = 7;
            this.lbId.Text = "?";
            // 
            // lbPos
            // 
            this.lbPos.AutoSize = true;
            this.lbPos.Font = new System.Drawing.Font("Kode Mono", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPos.ForeColor = System.Drawing.Color.White;
            this.lbPos.Location = new System.Drawing.Point(9, 174);
            this.lbPos.Name = "lbPos";
            this.lbPos.Size = new System.Drawing.Size(15, 18);
            this.lbPos.TabIndex = 7;
            this.lbPos.Text = "?";
            // 
            // pnProfile
            // 
            this.pnProfile.Controls.Add(this.pbProfile);
            this.pnProfile.Controls.Add(this.lbPos);
            this.pnProfile.Controls.Add(this.lbId);
            this.pnProfile.Controls.Add(this.lbName);
            this.pnProfile.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnProfile.Location = new System.Drawing.Point(0, 574);
            this.pnProfile.Name = "pnProfile";
            this.pnProfile.Size = new System.Drawing.Size(50, 199);
            this.pnProfile.TabIndex = 8;
            this.pnProfile.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Controls.Add(this.label2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 871);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1584, 40);
            this.panel5.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Kode Mono", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1584, 40);
            this.label2.TabIndex = 1;
            this.label2.Text = "Copyright @2024 || Developer SUON PHANUN. All right reserved.";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMain.Location = new System.Drawing.Point(50, 40);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1534, 831);
            this.pnMain.TabIndex = 6;
            // 
            // pbProfile
            // 
            this.pbProfile.Location = new System.Drawing.Point(12, 15);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(120, 120);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbProfile.TabIndex = 8;
            this.pbProfile.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Kode Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Image = global::CoffeeShop_DBMS.Properties.Resources.log_out_regular_24__2_;
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(0, 773);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnLogout.Size = new System.Drawing.Size(50, 40);
            this.btnLogout.TabIndex = 6;
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Kode Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::CoffeeShop_DBMS.Properties.Resources.list_ul_regular_24__1_;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(0, 210);
            this.button4.Name = "button4";
            this.button4.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.button4.Size = new System.Drawing.Size(50, 40);
            this.button4.TabIndex = 5;
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnItem
            // 
            this.btnItem.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnItem.FlatAppearance.BorderSize = 0;
            this.btnItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItem.Font = new System.Drawing.Font("Kode Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnItem.ForeColor = System.Drawing.Color.White;
            this.btnItem.Image = global::CoffeeShop_DBMS.Properties.Resources.coffee_regular_24;
            this.btnItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnItem.Location = new System.Drawing.Point(0, 170);
            this.btnItem.Name = "btnItem";
            this.btnItem.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnItem.Size = new System.Drawing.Size(50, 40);
            this.btnItem.TabIndex = 4;
            this.btnItem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnItem.UseVisualStyleBackColor = true;
            this.btnItem.Click += new System.EventHandler(this.btnItem_Click);
            this.btnItem.MouseHover += new System.EventHandler(this.btnItem_MouseHover);
            // 
            // btnPos
            // 
            this.btnPos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPos.FlatAppearance.BorderSize = 0;
            this.btnPos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPos.Font = new System.Drawing.Font("Kode Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPos.ForeColor = System.Drawing.Color.White;
            this.btnPos.Image = global::CoffeeShop_DBMS.Properties.Resources.badge_dollar_solid_24__1_;
            this.btnPos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPos.Location = new System.Drawing.Point(0, 130);
            this.btnPos.Name = "btnPos";
            this.btnPos.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnPos.Size = new System.Drawing.Size(50, 40);
            this.btnPos.TabIndex = 3;
            this.btnPos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPos.UseVisualStyleBackColor = true;
            this.btnPos.Click += new System.EventHandler(this.btnPos_Click);
            this.btnPos.MouseHover += new System.EventHandler(this.btnPos_MouseHover);
            // 
            // btnSumary
            // 
            this.btnSumary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSumary.FlatAppearance.BorderSize = 0;
            this.btnSumary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSumary.Font = new System.Drawing.Font("Kode Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSumary.ForeColor = System.Drawing.Color.White;
            this.btnSumary.Image = global::CoffeeShop_DBMS.Properties.Resources.bar_chart_alt_2_solid_24__2_;
            this.btnSumary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSumary.Location = new System.Drawing.Point(0, 90);
            this.btnSumary.Name = "btnSumary";
            this.btnSumary.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnSumary.Size = new System.Drawing.Size(50, 40);
            this.btnSumary.TabIndex = 2;
            this.btnSumary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSumary.UseVisualStyleBackColor = true;
            this.btnSumary.Click += new System.EventHandler(this.btnSumary_Click);
            this.btnSumary.MouseHover += new System.EventHandler(this.btnSumary_MouseHover);
            // 
            // btnToggle
            // 
            this.btnToggle.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnToggle.FlatAppearance.BorderSize = 0;
            this.btnToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToggle.Font = new System.Drawing.Font("Kode Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggle.ForeColor = System.Drawing.Color.White;
            this.btnToggle.Image = global::CoffeeShop_DBMS.Properties.Resources.list_ul_regular_24__1_;
            this.btnToggle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggle.Location = new System.Drawing.Point(0, 0);
            this.btnToggle.Name = "btnToggle";
            this.btnToggle.Padding = new System.Windows.Forms.Padding(8, 0, 10, 0);
            this.btnToggle.Size = new System.Drawing.Size(50, 40);
            this.btnToggle.TabIndex = 0;
            this.btnToggle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToggle.UseVisualStyleBackColor = true;
            this.btnToggle.Click += new System.EventHandler(this.btnToggle_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = global::CoffeeShop_DBMS.Properties.Resources.minus_square_solid_24;
            this.btnMinimize.Location = new System.Drawing.Point(1479, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(35, 40);
            this.btnMinimize.TabIndex = 3;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Image = global::CoffeeShop_DBMS.Properties.Resources.plus_square_solid_24;
            this.btnMaximize.Location = new System.Drawing.Point(1514, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(35, 40);
            this.btnMaximize.TabIndex = 2;
            this.btnMaximize.UseVisualStyleBackColor = true;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = global::CoffeeShop_DBMS.Properties.Resources.x_square_solid_24;
            this.btnClose.Location = new System.Drawing.Point(1549, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ttShow
            // 
            this.ttShow.AutoPopDelay = 50000;
            this.ttShow.InitialDelay = 500;
            this.ttShow.ReshowDelay = 100;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lbTime);
            this.panel3.Controls.Add(this.lbDate);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(318, 40);
            this.panel3.TabIndex = 0;
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Kode Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.ForeColor = System.Drawing.Color.White;
            this.lbDate.Location = new System.Drawing.Point(47, 3);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(15, 17);
            this.lbDate.TabIndex = 0;
            this.lbDate.Text = "?";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Kode Mono SemiBold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.Color.White;
            this.lbTime.Location = new System.Drawing.Point(47, 20);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(15, 17);
            this.lbTime.TabIndex = 0;
            this.lbTime.Text = "?";
            // 
            // tmTime
            // 
            this.tmTime.Enabled = true;
            this.tmTime.Interval = 1000;
            this.tmTime.Tick += new System.EventHandler(this.tmTime_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 911);
            this.Controls.Add(this.pnMain);
            this.Controls.Add(this.pnSidebar);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnSidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnProfile.ResumeLayout(false);
            this.pnProfile.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnSidebar;
        private System.Windows.Forms.Timer tmSidebar;
        private System.Windows.Forms.Button btnToggle;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnItem;
        private System.Windows.Forms.Button btnPos;
        private System.Windows.Forms.Button btnSumary;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbProfile;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbPos;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Panel pnProfile;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnMaximize;
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.ToolTip ttShow;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer tmTime;
    }
}