﻿
namespace WebBanSach
{
    partial class DangNhap
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
            this.PictureBox1 = new System.Windows.Forms.PictureBox();
            this.RichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Button1 = new System.Windows.Forms.Button();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBox1
            // 
            this.PictureBox1.Location = new System.Drawing.Point(483, 135);
            this.PictureBox1.Name = "PictureBox1";
            this.PictureBox1.Size = new System.Drawing.Size(253, 292);
            this.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox1.TabIndex = 36;
            this.PictureBox1.TabStop = false;
            // 
            // RichTextBox1
            // 
            this.RichTextBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.RichTextBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.RichTextBox1.Location = new System.Drawing.Point(64, 355);
            this.RichTextBox1.Name = "RichTextBox1";
            this.RichTextBox1.ReadOnly = true;
            this.RichTextBox1.Size = new System.Drawing.Size(341, 96);
            this.RichTextBox1.TabIndex = 35;
            this.RichTextBox1.Text = "Muốn xem thông tin bệnh viện hãy vào link sau:\nhttps://khamdinhkydanang.com/benh-" +
    "vien-da-khoa-da-nang/";
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Button1.Location = new System.Drawing.Point(188, 259);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(132, 37);
            this.Button1.TabIndex = 34;
            this.Button1.Text = "Đăng Nhập";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // TextBox2
            // 
            this.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox2.Location = new System.Drawing.Point(194, 211);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(173, 22);
            this.TextBox2.TabIndex = 32;
            // 
            // TextBox1
            // 
            this.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox1.Location = new System.Drawing.Point(194, 167);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(173, 22);
            this.TextBox1.TabIndex = 33;
            // 
            // Label2
            // 
            this.Label2.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label2.Location = new System.Drawing.Point(65, 213);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(100, 23);
            this.Label2.TabIndex = 29;
            this.Label2.Text = "Mật Khẩu";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label3.Location = new System.Drawing.Point(93, 68);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(491, 40);
            this.Label3.TabIndex = 30;
            this.Label3.Text = "ĐĂNG NHẬP QUẢN LÍ NHÀ THUỐC";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.White;
            this.Label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.Label1.Location = new System.Drawing.Point(65, 166);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(123, 23);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "Tên Đăng Nhập";
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.PictureBox1);
            this.Controls.Add(this.RichTextBox1);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.PictureBox PictureBox1;
        internal System.Windows.Forms.RichTextBox RichTextBox1;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.TextBox TextBox2;
        internal System.Windows.Forms.TextBox TextBox1;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
    }
}