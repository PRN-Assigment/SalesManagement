﻿namespace SalesWinApp
{
    partial class frmLogin
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
            this.dangNhap = new System.Windows.Forms.Label();
            this.lbtenDangNhap = new System.Windows.Forms.Label();
            this.lbMatKhau = new System.Windows.Forms.Label();
            this.tbtenDangNhap = new System.Windows.Forms.TextBox();
            this.tbMatKhau = new System.Windows.Forms.TextBox();
            this.btdangNhap = new System.Windows.Forms.Button();
            this.btReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dangNhap
            // 
            this.dangNhap.AutoSize = true;
            this.dangNhap.Font = new System.Drawing.Font("Roboto Slab", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dangNhap.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.dangNhap.Location = new System.Drawing.Point(352, 87);
            this.dangNhap.Name = "dangNhap";
            this.dangNhap.Size = new System.Drawing.Size(137, 46);
            this.dangNhap.TabIndex = 0;
            this.dangNhap.Text = " LOGIN ";
            // 
            // lbtenDangNhap
            // 
            this.lbtenDangNhap.AutoSize = true;
            this.lbtenDangNhap.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbtenDangNhap.Location = new System.Drawing.Point(249, 201);
            this.lbtenDangNhap.Name = "lbtenDangNhap";
            this.lbtenDangNhap.Size = new System.Drawing.Size(72, 27);
            this.lbtenDangNhap.TabIndex = 1;
            this.lbtenDangNhap.Text = "Email ";
            // 
            // lbMatKhau
            // 
            this.lbMatKhau.AutoSize = true;
            this.lbMatKhau.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbMatKhau.Location = new System.Drawing.Point(219, 321);
            this.lbMatKhau.Name = "lbMatKhau";
            this.lbMatKhau.Size = new System.Drawing.Size(105, 27);
            this.lbMatKhau.TabIndex = 2;
            this.lbMatKhau.Text = "Password";
            // 
            // tbtenDangNhap
            // 
            this.tbtenDangNhap.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbtenDangNhap.Location = new System.Drawing.Point(352, 197);
            this.tbtenDangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbtenDangNhap.Name = "tbtenDangNhap";
            this.tbtenDangNhap.Size = new System.Drawing.Size(287, 34);
            this.tbtenDangNhap.TabIndex = 3;
            // 
            // tbMatKhau
            // 
            this.tbMatKhau.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbMatKhau.Location = new System.Drawing.Point(352, 317);
            this.tbMatKhau.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbMatKhau.Name = "tbMatKhau";
            this.tbMatKhau.PasswordChar = '*';
            this.tbMatKhau.Size = new System.Drawing.Size(287, 34);
            this.tbMatKhau.TabIndex = 4;
            // 
            // btdangNhap
            // 
            this.btdangNhap.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btdangNhap.Location = new System.Drawing.Point(253, 383);
            this.btdangNhap.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btdangNhap.Name = "btdangNhap";
            this.btdangNhap.Size = new System.Drawing.Size(141, 48);
            this.btdangNhap.TabIndex = 5;
            this.btdangNhap.Text = "Đăng Nhập ";
            this.btdangNhap.UseVisualStyleBackColor = true;
            this.btdangNhap.Click += new System.EventHandler(this.btDangNhap_Click);
            // 
            // btReset
            // 
            this.btReset.Font = new System.Drawing.Font("Roboto Slab", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btReset.Location = new System.Drawing.Point(459, 383);
            this.btReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btReset.Name = "btReset";
            this.btReset.Size = new System.Drawing.Size(141, 48);
            this.btReset.TabIndex = 6;
            this.btReset.Text = "Reset";
            this.btReset.UseVisualStyleBackColor = true;
            this.btReset.Click += new System.EventHandler(this.btReset_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btReset);
            this.Controls.Add(this.btdangNhap);
            this.Controls.Add(this.tbMatKhau);
            this.Controls.Add(this.tbtenDangNhap);
            this.Controls.Add(this.lbMatKhau);
            this.Controls.Add(this.lbtenDangNhap);
            this.Controls.Add(this.dangNhap);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label dangNhap;
        private Label lbtenDangNhap;
        private Label lbMatKhau;
        private TextBox tbtenDangNhap;
        private TextBox tbMatKhau;
        private Button btdangNhap;
        private Button btReset;
    }
}