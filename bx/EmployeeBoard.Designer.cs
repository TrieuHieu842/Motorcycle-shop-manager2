﻿namespace bx
{
    partial class EmployeeBoard
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

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeBoard));
            this.label8 = new System.Windows.Forms.Label();
            this.lbExit = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.uC_Sale1 = new bx.ALL_UserControl.UC_Sale();
            this.uC_Product1 = new bx.ALL_UserControl.UC_Product();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnProduct = new Guna.UI2.WinForms.Guna2Button();
            this.btnCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnSuppiler = new Guna.UI2.WinForms.Guna2Button();
            this.btnBill = new Guna.UI2.WinForms.Guna2Button();
            this.btnRevenue = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.PanelMoving = new Guna.UI2.WinForms.Guna2Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnlog_out = new Guna.UI2.WinForms.Guna2Button();
            this.btnSale = new Guna.UI2.WinForms.Guna2Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.AliceBlue;
            this.label8.Font = new System.Drawing.Font("Lucida Bright", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOrange;
            this.label8.Location = new System.Drawing.Point(20, 8);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 46);
            this.label8.TabIndex = 62;
            this.label8.Text = "-";
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.BackColor = System.Drawing.Color.AliceBlue;
            this.lbExit.Font = new System.Drawing.Font("Segoe UI", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.DarkOrange;
            this.lbExit.Location = new System.Drawing.Point(13, -3);
            this.lbExit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(48, 57);
            this.lbExit.TabIndex = 60;
            this.lbExit.Text = "x";
            this.lbExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbExit);
            this.panel2.Location = new System.Drawing.Point(1857, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(65, 61);
            this.panel2.TabIndex = 61;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(1784, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(65, 60);
            this.panel3.TabIndex = 63;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.uC_Sale1);
            this.panel1.Controls.Add(this.uC_Product1);
            this.panel1.Location = new System.Drawing.Point(419, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1503, 1157);
            this.panel1.TabIndex = 68;
            // 
            // uC_Sale1
            // 
            this.uC_Sale1.BackColor = System.Drawing.Color.DarkOrange;
            this.uC_Sale1.Location = new System.Drawing.Point(12, 12);
            this.uC_Sale1.Name = "uC_Sale1";
            this.uC_Sale1.Size = new System.Drawing.Size(1450, 1100);
            this.uC_Sale1.TabIndex = 1;
            // 
            // uC_Product1
            // 
            this.uC_Product1.BackColor = System.Drawing.Color.DodgerBlue;
            this.uC_Product1.Location = new System.Drawing.Point(12, 12);
            this.uC_Product1.Name = "uC_Product1";
            this.uC_Product1.Size = new System.Drawing.Size(1450, 1100);
            this.uC_Product1.TabIndex = 0;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.TargetControl = this;
            // 
            // btnAccount
            // 
            this.btnAccount.BorderRadius = 15;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnAccount.ForeColor = System.Drawing.Color.DimGray;
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnAccount.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAccount.Location = new System.Drawing.Point(30, 232);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(382, 80);
            this.btnAccount.TabIndex = 70;
            this.btnAccount.Text = "Tài Khoản";
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BorderRadius = 15;
            this.btnProduct.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnProduct.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnProduct.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnProduct.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnProduct.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnProduct.ForeColor = System.Drawing.Color.DimGray;
            this.btnProduct.Image = ((System.Drawing.Image)(resources.GetObject("btnProduct.Image")));
            this.btnProduct.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnProduct.ImageSize = new System.Drawing.Size(50, 50);
            this.btnProduct.Location = new System.Drawing.Point(30, 318);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(382, 80);
            this.btnProduct.TabIndex = 71;
            this.btnProduct.Text = "Sản Phẩm";
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.BorderRadius = 15;
            this.btnCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCustomer.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnCustomer.ForeColor = System.Drawing.Color.DimGray;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCustomer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCustomer.Location = new System.Drawing.Point(30, 490);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(382, 80);
            this.btnCustomer.TabIndex = 73;
            this.btnCustomer.Text = "    Khách Hàng";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSuppiler
            // 
            this.btnSuppiler.BorderRadius = 15;
            this.btnSuppiler.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSuppiler.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSuppiler.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSuppiler.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSuppiler.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSuppiler.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnSuppiler.ForeColor = System.Drawing.Color.DimGray;
            this.btnSuppiler.Image = ((System.Drawing.Image)(resources.GetObject("btnSuppiler.Image")));
            this.btnSuppiler.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuppiler.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSuppiler.Location = new System.Drawing.Point(30, 404);
            this.btnSuppiler.Name = "btnSuppiler";
            this.btnSuppiler.Size = new System.Drawing.Size(382, 80);
            this.btnSuppiler.TabIndex = 72;
            this.btnSuppiler.Text = "Đối Tác";
            this.btnSuppiler.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSuppiler.Click += new System.EventHandler(this.btnSuppiler_Click);
            // 
            // btnBill
            // 
            this.btnBill.BorderRadius = 15;
            this.btnBill.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnBill.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnBill.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnBill.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnBill.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnBill.ForeColor = System.Drawing.Color.DimGray;
            this.btnBill.Image = ((System.Drawing.Image)(resources.GetObject("btnBill.Image")));
            this.btnBill.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnBill.ImageSize = new System.Drawing.Size(50, 50);
            this.btnBill.Location = new System.Drawing.Point(31, 662);
            this.btnBill.Name = "btnBill";
            this.btnBill.Size = new System.Drawing.Size(382, 80);
            this.btnBill.TabIndex = 75;
            this.btnBill.Text = "Hóa Đơn";
            this.btnBill.Click += new System.EventHandler(this.btnBill_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.BorderRadius = 15;
            this.btnRevenue.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRevenue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRevenue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRevenue.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnRevenue.ForeColor = System.Drawing.Color.DimGray;
            this.btnRevenue.Image = ((System.Drawing.Image)(resources.GetObject("btnRevenue.Image")));
            this.btnRevenue.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRevenue.ImageSize = new System.Drawing.Size(50, 50);
            this.btnRevenue.Location = new System.Drawing.Point(30, 748);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(382, 80);
            this.btnRevenue.TabIndex = 74;
            this.btnRevenue.Text = "    Doanh Thu";
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.AliceBlue;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.AliceBlue;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnLogout.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogout.HoverState.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnLogout.HoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnLogout.ImageSize = new System.Drawing.Size(50, 50);
            this.btnLogout.Location = new System.Drawing.Point(31, 1119);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(141, 95);
            this.btnLogout.TabIndex = 76;
            // 
            // PanelMoving
            // 
            this.PanelMoving.BackColor = System.Drawing.Color.OrangeRed;
            this.PanelMoving.Location = new System.Drawing.Point(21, 321);
            this.PanelMoving.Name = "PanelMoving";
            this.PanelMoving.Size = new System.Drawing.Size(12, 77);
            this.PanelMoving.TabIndex = 78;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(52, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // btnlog_out
            // 
            this.btnlog_out.BackColor = System.Drawing.Color.AliceBlue;
            this.btnlog_out.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnlog_out.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnlog_out.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnlog_out.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnlog_out.FillColor = System.Drawing.Color.AliceBlue;
            this.btnlog_out.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnlog_out.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnlog_out.HoverState.BorderColor = System.Drawing.Color.AliceBlue;
            this.btnlog_out.HoverState.FillColor = System.Drawing.Color.AliceBlue;
            this.btnlog_out.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.btnlog_out.Image = ((System.Drawing.Image)(resources.GetObject("btnlog_out.Image")));
            this.btnlog_out.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnlog_out.ImageSize = new System.Drawing.Size(50, 50);
            this.btnlog_out.Location = new System.Drawing.Point(31, 1096);
            this.btnlog_out.Name = "btnlog_out";
            this.btnlog_out.Size = new System.Drawing.Size(141, 95);
            this.btnlog_out.TabIndex = 81;
            this.btnlog_out.Click += new System.EventHandler(this.btnlog_out_Click);
            this.btnlog_out.MouseEnter += new System.EventHandler(this.btnlog_out_MouseEnter);
            this.btnlog_out.MouseLeave += new System.EventHandler(this.btnlog_out_MouseLeave);
            // 
            // btnSale
            // 
            this.btnSale.BorderRadius = 15;
            this.btnSale.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSale.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSale.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSale.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSale.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnSale.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.btnSale.ForeColor = System.Drawing.Color.DimGray;
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSale.ImageSize = new System.Drawing.Size(50, 50);
            this.btnSale.Location = new System.Drawing.Point(31, 576);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(382, 80);
            this.btnSale.TabIndex = 80;
            this.btnSale.Text = "Bán Hàng";
            this.btnSale.Click += new System.EventHandler(this.btnSale_Click);
            // 
            // EmployeeBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1946, 1226);
            this.Controls.Add(this.btnlog_out);
            this.Controls.Add(this.btnSale);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PanelMoving);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnBill);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSuppiler);
            this.Controls.Add(this.btnAccount);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EmployeeBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.EmployeeBoard_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnBill;
        private Guna.UI2.WinForms.Guna2Button btnRevenue;
        private Guna.UI2.WinForms.Guna2Button btnCustomer;
        private Guna.UI2.WinForms.Guna2Button btnProduct;
        private Guna.UI2.WinForms.Guna2Button btnSuppiler;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Panel PanelMoving;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnlog_out;
        private Guna.UI2.WinForms.Guna2Button btnSale;
        private ALL_UserControl.UC_Sale uC_Sale1;
        private ALL_UserControl.UC_Product uC_Product1;
    }
}