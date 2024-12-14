
namespace WebBanSach
{
    partial class BanGiao
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
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu4 = new System.Windows.Forms.ToolStripMenuItem();
            this.TableBGT = new System.Windows.Forms.DataGridView();
            this.Sua = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.MaThuoc = new System.Windows.Forms.ComboBox();
            this.MaNV = new System.Windows.Forms.ComboBox();
            this.NgayBanGiao = new System.Windows.Forms.DateTimePicker();
            this.Phong = new System.Windows.Forms.TextBox();
            this.MaBG = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableBGT)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu4});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1104, 38);
            this.MenuStrip1.TabIndex = 69;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // menu4
            // 
            this.menu4.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menu4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu4.Name = "menu4";
            this.menu4.Size = new System.Drawing.Size(164, 34);
            this.menu4.Text = "Bàn giao sách";
            this.menu4.Click += new System.EventHandler(this.menu4_Click);
            // 
            // TableBGT
            // 
            this.TableBGT.AllowUserToAddRows = false;
            this.TableBGT.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableBGT.BackgroundColor = System.Drawing.Color.LightCyan;
            this.TableBGT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableBGT.Location = new System.Drawing.Point(161, 519);
            this.TableBGT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableBGT.Name = "TableBGT";
            this.TableBGT.RowHeadersWidth = 51;
            this.TableBGT.RowTemplate.Height = 24;
            this.TableBGT.Size = new System.Drawing.Size(786, 198);
            this.TableBGT.TabIndex = 68;
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.ForeColor = System.Drawing.Color.Snow;
            this.Sua.Location = new System.Drawing.Point(560, 431);
            this.Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(133, 52);
            this.Sua.TabIndex = 67;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.Snow;
            this.Button5.Location = new System.Drawing.Point(767, 431);
            this.Button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(128, 52);
            this.Button5.TabIndex = 64;
            this.Button5.Text = "Thoát";
            this.Button5.UseVisualStyleBackColor = false;
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.Color.Snow;
            this.Xoa.Location = new System.Drawing.Point(370, 431);
            this.Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(133, 52);
            this.Xoa.TabIndex = 65;
            this.Xoa.Text = "Xoá";
            this.Xoa.UseVisualStyleBackColor = false;
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.ForeColor = System.Drawing.Color.Snow;
            this.Them.Location = new System.Drawing.Point(202, 431);
            this.Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(120, 52);
            this.Them.TabIndex = 66;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = false;
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.GroupBox1.Controls.Add(this.MaThuoc);
            this.GroupBox1.Controls.Add(this.MaNV);
            this.GroupBox1.Controls.Add(this.NgayBanGiao);
            this.GroupBox1.Controls.Add(this.Phong);
            this.GroupBox1.Controls.Add(this.MaBG);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupBox1.Location = new System.Drawing.Point(161, 158);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.GroupBox1.Size = new System.Drawing.Size(786, 222);
            this.GroupBox1.TabIndex = 63;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin sách";
            // 
            // MaThuoc
            // 
            this.MaThuoc.FormattingEnabled = true;
            this.MaThuoc.Location = new System.Drawing.Point(144, 170);
            this.MaThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaThuoc.Name = "MaThuoc";
            this.MaThuoc.Size = new System.Drawing.Size(159, 28);
            this.MaThuoc.TabIndex = 55;
            // 
            // MaNV
            // 
            this.MaNV.FormattingEnabled = true;
            this.MaNV.Location = new System.Drawing.Point(144, 109);
            this.MaNV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(159, 28);
            this.MaNV.TabIndex = 54;
            // 
            // NgayBanGiao
            // 
            this.NgayBanGiao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.NgayBanGiao.Location = new System.Drawing.Point(467, 109);
            this.NgayBanGiao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NgayBanGiao.Name = "NgayBanGiao";
            this.NgayBanGiao.Size = new System.Drawing.Size(165, 25);
            this.NgayBanGiao.TabIndex = 7;
            // 
            // Phong
            // 
            this.Phong.Location = new System.Drawing.Point(467, 58);
            this.Phong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Phong.Name = "Phong";
            this.Phong.Size = new System.Drawing.Size(165, 25);
            this.Phong.TabIndex = 4;
            // 
            // MaBG
            // 
            this.MaBG.Location = new System.Drawing.Point(144, 54);
            this.MaBG.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaBG.Name = "MaBG";
            this.MaBG.Size = new System.Drawing.Size(159, 25);
            this.MaBG.TabIndex = 4;
            // 
            // Label7
            // 
            this.Label7.Location = new System.Drawing.Point(341, 112);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(125, 36);
            this.Label7.TabIndex = 2;
            this.Label7.Text = "Ngày bàn giao";
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(341, 54);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(105, 36);
            this.Label11.TabIndex = 2;
            this.Label11.Text = "Kho";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(24, 170);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(141, 36);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Mã sách";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(24, 58);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(141, 36);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Mã bàn giao";
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(24, 112);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(141, 36);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Mã nhân viên";
            // 
            // Label3
            // 
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.RoyalBlue;
            this.Label3.Location = new System.Drawing.Point(317, 84);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(520, 42);
            this.Label3.TabIndex = 62;
            this.Label3.Text = "BÀN GIAO SÁCH CHO CÁC KHO";
            this.Label3.Click += new System.EventHandler(this.Label3_Click);
            // 
            // BanGiao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 765);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.TableBGT);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label3);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BanGiao";
            this.Text = "Form1";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableBGT)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem menu4;
        internal System.Windows.Forms.DataGridView TableBGT;
        internal System.Windows.Forms.Button Sua;
        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.Button Xoa;
        internal System.Windows.Forms.Button Them;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.ComboBox MaThuoc;
        internal System.Windows.Forms.ComboBox MaNV;
        internal System.Windows.Forms.DateTimePicker NgayBanGiao;
        internal System.Windows.Forms.TextBox Phong;
        internal System.Windows.Forms.TextBox MaBG;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Label Label3;
    }
}

