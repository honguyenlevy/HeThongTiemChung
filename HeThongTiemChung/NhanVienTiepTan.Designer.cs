﻿
namespace HeThongTiemChung
{
    partial class NhanVienTiepTan
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
            this.panelTopNhanVienTiepTan = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelDatMua = new System.Windows.Forms.Label();
            this.labelDangKyTiem = new System.Windows.Forms.Label();
            this.panelNhanVienTiepTan = new System.Windows.Forms.Panel();
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
            this.tableLayoutPanel1.Controls.Add(this.panelTopNhanVienTiepTan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDatMua, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelDangKyTiem, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 62);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.label1.Size = new System.Drawing.Size(339, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhân viên tiếp tân";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDatMua
            // 
            this.labelDatMua.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDatMua.AutoSize = true;
            this.labelDatMua.Location = new System.Drawing.Point(1023, 0);
            this.labelDatMua.Name = "labelDatMua";
            this.labelDatMua.Size = new System.Drawing.Size(157, 62);
            this.labelDatMua.TabIndex = 2;
            this.labelDatMua.Text = "Đặt mua vaccine";
            this.labelDatMua.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDatMua.Click += new System.EventHandler(this.labelDatMua_Click);
            // 
            // labelDangKyTiem
            // 
            this.labelDangKyTiem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.labelDangKyTiem.AutoSize = true;
            this.labelDangKyTiem.Location = new System.Drawing.Point(843, 0);
            this.labelDangKyTiem.Name = "labelDangKyTiem";
            this.labelDangKyTiem.Size = new System.Drawing.Size(160, 62);
            this.labelDangKyTiem.TabIndex = 1;
            this.labelDangKyTiem.Text = "Đăng ký tiêm phiếu tiêm chủng";
            this.labelDangKyTiem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelDangKyTiem.Click += new System.EventHandler(this.labelDangKyTiem_Click);
            // 
            // panelNhanVienTiepTan
            // 
            this.panelNhanVienTiepTan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNhanVienTiepTan.Location = new System.Drawing.Point(0, 62);
            this.panelNhanVienTiepTan.Name = "panelNhanVienTiepTan";
            this.panelNhanVienTiepTan.Size = new System.Drawing.Size(1200, 641);
            this.panelNhanVienTiepTan.TabIndex = 2;
            // 
            // NhanVienTiepTan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.panelNhanVienTiepTan);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "NhanVienTiepTan";
            this.Text = "NhanVienTiepTan";
            this.Load += new System.EventHandler(this.NhanVienTiepTan_Load);
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
        private System.Windows.Forms.Label labelDatMua;
        private System.Windows.Forms.Label labelDangKyTiem;
        private System.Windows.Forms.Panel panelNhanVienTiepTan;
    }
}