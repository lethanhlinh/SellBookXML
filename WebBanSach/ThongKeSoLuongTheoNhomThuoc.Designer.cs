
namespace WebBanSach
{
    partial class ThongKeSoLuongTheoNhomThuoc
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
            this.Button5 = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button5
            // 
            this.Button5.BackColor = System.Drawing.Color.Azure;
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Button5.Location = new System.Drawing.Point(354, 599);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(126, 34);
            this.Button5.TabIndex = 55;
            this.Button5.Text = "Thoát";
            this.Button5.UseVisualStyleBackColor = false;
            // 
            // DataGridView1
            // 
            this.DataGridView1.AllowUserToAddRows = false;
            this.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView1.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(77, 413);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 51;
            this.DataGridView1.RowTemplate.Height = 24;
            this.DataGridView1.Size = new System.Drawing.Size(647, 150);
            this.DataGridView1.TabIndex = 54;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Navy;
            this.Label1.Location = new System.Drawing.Point(156, 40);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(499, 49);
            this.Label1.TabIndex = 53;
            this.Label1.Text = "THỐNG KÊ SỐ LƯỢNG THEO NHÓM THUỐC";
            this.Label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // ThongKeSoLuongTheoNhomThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 652);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label1);
            this.Name = "ThongKeSoLuongTheoNhomThuoc";
            this.Text = "ThongKeSoLuongTheoNhomThuoc";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.Button Button5;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label1;
    }
}