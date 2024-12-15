
namespace WebBanSach
{
    partial class Home
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
            this.menu1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3 = new System.Windows.Forms.ToolStripMenuItem();
            this.TìmKiếmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TìmKiếmNhânViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ĐăngNhậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tìmKiếmSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1,
            this.menu2,
            this.menu3,
            this.TìmKiếmToolStripMenuItem,
            this.ĐăngNhậpToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MenuStrip1.Size = new System.Drawing.Size(929, 31);
            this.MenuStrip1.TabIndex = 20;
            this.MenuStrip1.Text = "MenuStrip1";
            // 
            // menu1
            // 
            this.menu1.BackColor = System.Drawing.SystemColors.Control;
            this.menu1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu1.Name = "menu1";
            this.menu1.Size = new System.Drawing.Size(184, 27);
            this.menu1.Text = "Thông tin nhân viên";
            this.menu1.Click += new System.EventHandler(this.menu1_Click);
            // 
            // menu2
            // 
            this.menu2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu2.Name = "menu2";
            this.menu2.Size = new System.Drawing.Size(141, 27);
            this.menu2.Text = "Thông tin sách";
            this.menu2.Click += new System.EventHandler(this.menu2_Click);
            // 
            // menu3
            // 
            this.menu3.BackColor = System.Drawing.SystemColors.Control;
            this.menu3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menu3.Name = "menu3";
            this.menu3.Size = new System.Drawing.Size(212, 27);
            this.menu3.Text = "Điền thông tin hóa đơn";
            this.menu3.Click += new System.EventHandler(this.menu3_Click);
            // 
            // TìmKiếmToolStripMenuItem
            // 
            this.TìmKiếmToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TìmKiếmNhânViênToolStripMenuItem,
            this.tìmKiếmSáchToolStripMenuItem});
            this.TìmKiếmToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TìmKiếmToolStripMenuItem.Name = "TìmKiếmToolStripMenuItem";
            this.TìmKiếmToolStripMenuItem.Size = new System.Drawing.Size(100, 27);
            this.TìmKiếmToolStripMenuItem.Text = "Tìm kiếm";
            // 
            // TìmKiếmNhânViênToolStripMenuItem
            // 
            this.TìmKiếmNhânViênToolStripMenuItem.Name = "TìmKiếmNhânViênToolStripMenuItem";
            this.TìmKiếmNhânViênToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.TìmKiếmNhânViênToolStripMenuItem.Text = "Tìm kiếm nhân viên";
            this.TìmKiếmNhânViênToolStripMenuItem.Click += new System.EventHandler(this.TìmKiếmNhânViênToolStripMenuItem_Click);
            // 
            // ĐăngNhậpToolStripMenuItem
            // 
            this.ĐăngNhậpToolStripMenuItem.Name = "ĐăngNhậpToolStripMenuItem";
            this.ĐăngNhậpToolStripMenuItem.Size = new System.Drawing.Size(107, 27);
            this.ĐăngNhậpToolStripMenuItem.Text = "Đăng xuất";
            this.ĐăngNhậpToolStripMenuItem.Click += new System.EventHandler(this.ĐăngNhậpToolStripMenuItem_Click);
            // 
            // tìmKiếmSáchToolStripMenuItem
            // 
            this.tìmKiếmSáchToolStripMenuItem.Name = "tìmKiếmSáchToolStripMenuItem";
            this.tìmKiếmSáchToolStripMenuItem.Size = new System.Drawing.Size(252, 28);
            this.tìmKiếmSáchToolStripMenuItem.Text = "Tìm kiếm sách";
            this.tìmKiếmSáchToolStripMenuItem.Click += new System.EventHandler(this.tìmKiếmSáchToolStripMenuItem_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 557);
            this.Controls.Add(this.MenuStrip1);
            this.Name = "Home";
            this.Text = "Home";
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip MenuStrip1;
        internal System.Windows.Forms.ToolStripMenuItem menu1;
        internal System.Windows.Forms.ToolStripMenuItem menu2;
        internal System.Windows.Forms.ToolStripMenuItem menu3;
        internal System.Windows.Forms.ToolStripMenuItem TìmKiếmToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem TìmKiếmNhânViênToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem ĐăngNhậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmSáchToolStripMenuItem;
    }
}