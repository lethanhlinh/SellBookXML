
namespace WebBanSach
{
    partial class Sach
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
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TableSach = new System.Windows.Forms.DataGridView();
            this.Sua = new System.Windows.Forms.Button();
            this.Thoat = new System.Windows.Forms.Button();
            this.Xoa = new System.Windows.Forms.Button();
            this.Them = new System.Windows.Forms.Button();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.NamXuatBan = new System.Windows.Forms.TextBox();
            this.NhaXuatBan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GiaBan = new System.Windows.Forms.TextBox();
            this.TacGia = new System.Windows.Forms.TextBox();
            this.MaSach = new System.Windows.Forms.TextBox();
            this.TenSach = new System.Windows.Forms.TextBox();
            this.MaNhomSach = new System.Windows.Forms.ComboBox();
            this.Label11 = new System.Windows.Forms.Label();
            this.Label13 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSach)).BeginInit();
            this.GroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu2});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(1223, 38);
            this.MenuStrip1.TabIndex = 74;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // menu2
            // 
            this.menu2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menu2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(175, 34);
            this.menu2.Text = "Thông tin sách";
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // TableSach
            // 
            this.TableSach.AllowUserToAddRows = false;
            this.TableSach.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TableSach.BackgroundColor = System.Drawing.Color.LightCyan;
            this.TableSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableSach.Location = new System.Drawing.Point(69, 538);
            this.TableSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TableSach.Name = "TableSach";
            this.TableSach.RowHeadersWidth = 51;
            this.TableSach.RowTemplate.Height = 24;
            this.TableSach.Size = new System.Drawing.Size(1087, 202);
            this.TableSach.TabIndex = 73;
            // 
            // Sua
            // 
            this.Sua.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sua.ForeColor = System.Drawing.Color.Snow;
            this.Sua.Location = new System.Drawing.Point(636, 451);
            this.Sua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Sua.Name = "Sua";
            this.Sua.Size = new System.Drawing.Size(146, 42);
            this.Sua.TabIndex = 72;
            this.Sua.Text = "Sửa";
            this.Sua.UseVisualStyleBackColor = false;
            this.Sua.Click += new System.EventHandler(this.Sua_Click);
            // 
            // Thoat
            // 
            this.Thoat.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Thoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Thoat.ForeColor = System.Drawing.Color.Snow;
            this.Thoat.Location = new System.Drawing.Point(855, 451);
            this.Thoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Thoat.Name = "Thoat";
            this.Thoat.Size = new System.Drawing.Size(142, 42);
            this.Thoat.TabIndex = 69;
            this.Thoat.Text = "Thoát";
            this.Thoat.UseVisualStyleBackColor = false;
            this.Thoat.Click += new System.EventHandler(this.Thoat_Click);
            // 
            // Xoa
            // 
            this.Xoa.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xoa.ForeColor = System.Drawing.Color.Snow;
            this.Xoa.Location = new System.Drawing.Point(411, 451);
            this.Xoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Xoa.Name = "Xoa";
            this.Xoa.Size = new System.Drawing.Size(146, 42);
            this.Xoa.TabIndex = 70;
            this.Xoa.Text = "Xoá";
            this.Xoa.UseVisualStyleBackColor = false;
            this.Xoa.Click += new System.EventHandler(this.Xoa_Click);
            // 
            // Them
            // 
            this.Them.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Them.ForeColor = System.Drawing.Color.Snow;
            this.Them.Location = new System.Drawing.Point(205, 451);
            this.Them.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Them.Name = "Them";
            this.Them.Size = new System.Drawing.Size(134, 42);
            this.Them.TabIndex = 71;
            this.Them.Text = "Thêm";
            this.Them.UseVisualStyleBackColor = false;
            this.Them.Click += new System.EventHandler(this.Them_Click);
            // 
            // GroupBox1
            // 
            this.GroupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.GroupBox1.Controls.Add(this.NamXuatBan);
            this.GroupBox1.Controls.Add(this.NhaXuatBan);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.GiaBan);
            this.GroupBox1.Controls.Add(this.TacGia);
            this.GroupBox1.Controls.Add(this.MaSach);
            this.GroupBox1.Controls.Add(this.TenSach);
            this.GroupBox1.Controls.Add(this.MaNhomSach);
            this.GroupBox1.Controls.Add(this.Label11);
            this.GroupBox1.Controls.Add(this.Label13);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.Label4);
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.GroupBox1.Location = new System.Drawing.Point(92, 162);
            this.GroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.GroupBox1.Size = new System.Drawing.Size(1038, 222);
            this.GroupBox1.TabIndex = 68;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Thông tin sách";
            // 
            // NamXuatBan
            // 
            this.NamXuatBan.Location = new System.Drawing.Point(467, 54);
            this.NamXuatBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NamXuatBan.Name = "NamXuatBan";
            this.NamXuatBan.Size = new System.Drawing.Size(159, 25);
            this.NamXuatBan.TabIndex = 9;
            // 
            // NhaXuatBan
            // 
            this.NhaXuatBan.Location = new System.Drawing.Point(467, 109);
            this.NhaXuatBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NhaXuatBan.Name = "NhaXuatBan";
            this.NhaXuatBan.Size = new System.Drawing.Size(159, 25);
            this.NhaXuatBan.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(339, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 36);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nhà xuất bản";
            // 
            // GiaBan
            // 
            this.GiaBan.Location = new System.Drawing.Point(785, 54);
            this.GiaBan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.Size = new System.Drawing.Size(165, 25);
            this.GiaBan.TabIndex = 4;
            // 
            // TacGia
            // 
            this.TacGia.Location = new System.Drawing.Point(144, 170);
            this.TacGia.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TacGia.Name = "TacGia";
            this.TacGia.Size = new System.Drawing.Size(159, 25);
            this.TacGia.TabIndex = 4;
            // 
            // MaSach
            // 
            this.MaSach.Location = new System.Drawing.Point(144, 54);
            this.MaSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaSach.Name = "MaSach";
            this.MaSach.Size = new System.Drawing.Size(159, 25);
            this.MaSach.TabIndex = 4;
            // 
            // TenSach
            // 
            this.TenSach.Location = new System.Drawing.Point(144, 109);
            this.TenSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TenSach.Name = "TenSach";
            this.TenSach.Size = new System.Drawing.Size(159, 25);
            this.TenSach.TabIndex = 4;
            // 
            // MaNhomSach
            // 
            this.MaNhomSach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaNhomSach.FormattingEnabled = true;
            this.MaNhomSach.ItemHeight = 22;
            this.MaNhomSach.Location = new System.Drawing.Point(467, 164);
            this.MaNhomSach.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaNhomSach.Name = "MaNhomSach";
            this.MaNhomSach.Size = new System.Drawing.Size(165, 30);
            this.MaNhomSach.TabIndex = 3;
            // 
            // Label11
            // 
            this.Label11.Location = new System.Drawing.Point(692, 58);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(141, 36);
            this.Label11.TabIndex = 2;
            this.Label11.Text = "Giá bán";
            // 
            // Label13
            // 
            this.Label13.Location = new System.Drawing.Point(339, 170);
            this.Label13.Name = "Label13";
            this.Label13.Size = new System.Drawing.Size(122, 36);
            this.Label13.TabIndex = 2;
            this.Label13.Text = "Mã nhóm sách";
            // 
            // Label6
            // 
            this.Label6.Location = new System.Drawing.Point(21, 170);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(141, 36);
            this.Label6.TabIndex = 2;
            this.Label6.Text = "Tác giả";
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(341, 58);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(141, 36);
            this.Label5.TabIndex = 2;
            this.Label5.Text = "Năm xuất bản";
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(24, 58);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(141, 36);
            this.Label4.TabIndex = 2;
            this.Label4.Text = "Mã sách";
            // 
            // Label3
            // 
            this.Label3.Location = new System.Drawing.Point(24, 112);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(141, 36);
            this.Label3.TabIndex = 2;
            this.Label3.Text = "Tên sách";
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.Label1.Location = new System.Drawing.Point(404, 106);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(418, 36);
            this.Label1.TabIndex = 67;
            this.Label1.Text = "NHẬP THÔNG TIN SÁCH";
            // 
            // Sach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1223, 749);
            this.Controls.Add(this.MenuStrip1);
            this.Controls.Add(this.TableSach);
            this.Controls.Add(this.Sua);
            this.Controls.Add(this.Thoat);
            this.Controls.Add(this.Xoa);
            this.Controls.Add(this.Them);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.Label1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Sach";
            this.Text = "SACH";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TableSach)).EndInit();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem menu2;
        internal System.Windows.Forms.DataGridView TableSach;
        internal System.Windows.Forms.Button Sua;
        internal System.Windows.Forms.Button Thoat;
        internal System.Windows.Forms.Button Xoa;
        internal System.Windows.Forms.Button Them;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.TextBox GiaBan;
        internal System.Windows.Forms.TextBox TacGia;
        internal System.Windows.Forms.TextBox MaSach;
        internal System.Windows.Forms.TextBox TenSach;
        internal System.Windows.Forms.ComboBox MaNhomSach;
        internal System.Windows.Forms.Label Label11;
        internal System.Windows.Forms.Label Label13;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.TextBox NhaXuatBan;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.TextBox NamXuatBan;
    }
}