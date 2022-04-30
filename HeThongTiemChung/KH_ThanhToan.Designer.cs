
namespace HeThongTiemChung
{
    partial class KH_ThanhToan
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
            this.radioButtonThanhToanMotLan = new System.Windows.Forms.RadioButton();
            this.radioButtonThanhToanDot = new System.Windows.Forms.RadioButton();
            this.panelThanhToan = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.radioButtonThanhToanMotLan, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.radioButtonThanhToanDot, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 64);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // radioButtonThanhToanMotLan
            // 
            this.radioButtonThanhToanMotLan.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonThanhToanMotLan.AutoSize = true;
            this.radioButtonThanhToanMotLan.Location = new System.Drawing.Point(383, 3);
            this.radioButtonThanhToanMotLan.Name = "radioButtonThanhToanMotLan";
            this.radioButtonThanhToanMotLan.Size = new System.Drawing.Size(201, 58);
            this.radioButtonThanhToanMotLan.TabIndex = 0;
            this.radioButtonThanhToanMotLan.TabStop = true;
            this.radioButtonThanhToanMotLan.Text = "Thanh toán một lần";
            this.radioButtonThanhToanMotLan.UseVisualStyleBackColor = true;
            this.radioButtonThanhToanMotLan.CheckedChanged += new System.EventHandler(this.radioButtonThanhToanMotLan_CheckedChanged);
            // 
            // radioButtonThanhToanDot
            // 
            this.radioButtonThanhToanDot.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonThanhToanDot.AutoSize = true;
            this.radioButtonThanhToanDot.Location = new System.Drawing.Point(610, 3);
            this.radioButtonThanhToanDot.Name = "radioButtonThanhToanDot";
            this.radioButtonThanhToanDot.Size = new System.Drawing.Size(165, 58);
            this.radioButtonThanhToanDot.TabIndex = 1;
            this.radioButtonThanhToanDot.TabStop = true;
            this.radioButtonThanhToanDot.Text = "Thanh toán đợt";
            this.radioButtonThanhToanDot.UseVisualStyleBackColor = true;
            this.radioButtonThanhToanDot.CheckedChanged += new System.EventHandler(this.radioButtonThanhToanDot_CheckedChanged);
            // 
            // panelThanhToan
            // 
            this.panelThanhToan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelThanhToan.Location = new System.Drawing.Point(3, 73);
            this.panelThanhToan.Name = "panelThanhToan";
            this.panelThanhToan.Size = new System.Drawing.Size(1194, 627);
            this.panelThanhToan.TabIndex = 1;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.panelThanhToan, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1200, 703);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // KH_ThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KH_ThanhToan";
            this.Text = "KH_ThanhToan";
            this.Load += new System.EventHandler(this.KH_ThanhToan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonThanhToanMotLan;
        private System.Windows.Forms.RadioButton radioButtonThanhToanDot;
        private System.Windows.Forms.Panel panelThanhToan;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}