
namespace HeThongTiemChung
{
    partial class NhanVien
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelDangKyLichRanh = new System.Windows.Forms.Label();
            this.panelTopNhanVienTiepTan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelXemLichLamViec = new System.Windows.Forms.Label();
            this.panelNhanVien = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelTopNhanVienTiepTan.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 180F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelDangKyLichRanh, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panelTopNhanVienTiepTan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelXemLichLamViec, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 62);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // labelDangKyLichRanh
            // 
            this.labelDangKyLichRanh.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDangKyLichRanh.AutoSize = true;
            this.labelDangKyLichRanh.Location = new System.Drawing.Point(843, 0);
            this.labelDangKyLichRanh.Name = "labelDangKyLichRanh";
            this.labelDangKyLichRanh.Size = new System.Drawing.Size(162, 62);
            this.labelDangKyLichRanh.TabIndex = 1;
            this.labelDangKyLichRanh.Text = "Đăng ký lịch rảnh";
            this.labelDangKyLichRanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDangKyLichRanh.Click += new System.EventHandler(this.labelDangKyLichRanh_Click);
            // 
            // panelTopNhanVienTiepTan
            // 
            this.panelTopNhanVienTiepTan.Controls.Add(this.label1);
            this.panelTopNhanVienTiepTan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTopNhanVienTiepTan.Location = new System.Drawing.Point(3, 3);
            this.panelTopNhanVienTiepTan.Name = "panelTopNhanVienTiepTan";
            this.panelTopNhanVienTiepTan.Size = new System.Drawing.Size(834, 56);
            this.panelTopNhanVienTiepTan.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelXemLichLamViec
            // 
            this.labelXemLichLamViec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelXemLichLamViec.AutoSize = true;
            this.labelXemLichLamViec.Location = new System.Drawing.Point(1023, 0);
            this.labelXemLichLamViec.Name = "labelXemLichLamViec";
            this.labelXemLichLamViec.Size = new System.Drawing.Size(163, 62);
            this.labelXemLichLamViec.TabIndex = 2;
            this.labelXemLichLamViec.Text = "Xem lịch làm việc";
            this.labelXemLichLamViec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelXemLichLamViec.Click += new System.EventHandler(this.labelXemLichLamViec_Click);
            // 
            // panelNhanVien
            // 
            this.panelNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhanVien.Location = new System.Drawing.Point(0, 62);
            this.panelNhanVien.Name = "panelNhanVien";
            this.panelNhanVien.Size = new System.Drawing.Size(1200, 641);
            this.panelNhanVien.TabIndex = 3;
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panelNhanVien);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.Load += new System.EventHandler(this.NhanVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelTopNhanVienTiepTan.ResumeLayout(false);
            this.panelTopNhanVienTiepTan.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panelTopNhanVienTiepTan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelXemLichLamViec;
        private System.Windows.Forms.Label labelDangKyLichRanh;
        private System.Windows.Forms.Panel panelNhanVien;
    }
}