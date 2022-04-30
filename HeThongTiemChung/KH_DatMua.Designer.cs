
namespace HeThongTiemChung
{
    partial class KH_DatMua
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
            this.textBoxTen = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonChonGoiVaccine = new System.Windows.Forms.RadioButton();
            this.radioButtonChonVaccine = new System.Windows.Forms.RadioButton();
            this.buttonSubmit = new System.Windows.Forms.Button();
            this.textBoxSoLuong = new System.Windows.Forms.TextBox();
            this.labelSL = new System.Windows.Forms.Label();
            this.dataGridViewVaccine = new System.Windows.Forms.DataGridView();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccine)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.textBoxTen, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.buttonSubmit, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxSoLuong, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.labelSL, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(63, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1074, 169);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // textBoxTen
            // 
            this.textBoxTen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTen.ForeColor = System.Drawing.Color.Black;
            this.textBoxTen.Location = new System.Drawing.Point(360, 69);
            this.textBoxTen.Name = "textBoxTen";
            this.textBoxTen.Size = new System.Drawing.Size(352, 30);
            this.textBoxTen.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên gói vaccine / vaccine";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // radioButtonChonGoiVaccine
            // 
            this.radioButtonChonGoiVaccine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radioButtonChonGoiVaccine.AutoSize = true;
            this.radioButtonChonGoiVaccine.Location = new System.Drawing.Point(3, 3);
            this.radioButtonChonGoiVaccine.Name = "radioButtonChonGoiVaccine";
            this.radioButtonChonGoiVaccine.Size = new System.Drawing.Size(170, 44);
            this.radioButtonChonGoiVaccine.TabIndex = 6;
            this.radioButtonChonGoiVaccine.TabStop = true;
            this.radioButtonChonGoiVaccine.Text = "Chọn gói vaccine";
            this.radioButtonChonGoiVaccine.UseVisualStyleBackColor = true;
            this.radioButtonChonGoiVaccine.CheckedChanged += new System.EventHandler(this.radioButtonChonGoiVaccine_CheckedChanged);
            // 
            // radioButtonChonVaccine
            // 
            this.radioButtonChonVaccine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.radioButtonChonVaccine.AutoSize = true;
            this.radioButtonChonVaccine.Location = new System.Drawing.Point(179, 3);
            this.radioButtonChonVaccine.Name = "radioButtonChonVaccine";
            this.radioButtonChonVaccine.Size = new System.Drawing.Size(153, 44);
            this.radioButtonChonVaccine.TabIndex = 7;
            this.radioButtonChonVaccine.TabStop = true;
            this.radioButtonChonVaccine.Text = "Chọn vaccine";
            this.radioButtonChonVaccine.UseVisualStyleBackColor = true;
            this.radioButtonChonVaccine.CheckedChanged += new System.EventHandler(this.radioButtonChonVaccine_CheckedChanged);
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(213)))), ((int)(((byte)(79)))));
            this.buttonSubmit.Location = new System.Drawing.Point(718, 115);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(184, 51);
            this.buttonSubmit.TabIndex = 1;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = false;
            this.buttonSubmit.Click += new System.EventHandler(this.buttonSubmit_Click);
            // 
            // textBoxSoLuong
            // 
            this.textBoxSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxSoLuong.Location = new System.Drawing.Point(360, 125);
            this.textBoxSoLuong.Name = "textBoxSoLuong";
            this.textBoxSoLuong.Size = new System.Drawing.Size(352, 30);
            this.textBoxSoLuong.TabIndex = 8;
            // 
            // labelSL
            // 
            this.labelSL.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelSL.AutoSize = true;
            this.labelSL.Location = new System.Drawing.Point(257, 128);
            this.labelSL.Name = "labelSL";
            this.labelSL.Size = new System.Drawing.Size(97, 25);
            this.labelSL.TabIndex = 9;
            this.labelSL.Text = "Số Lượng";
            this.labelSL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataGridViewVaccine
            // 
            this.dataGridViewVaccine.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.dataGridViewVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccine.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewVaccine.Location = new System.Drawing.Point(63, 178);
            this.dataGridViewVaccine.Name = "dataGridViewVaccine";
            this.dataGridViewVaccine.RowHeadersWidth = 51;
            this.dataGridViewVaccine.RowTemplate.Height = 24;
            this.dataGridViewVaccine.Size = new System.Drawing.Size(1074, 486);
            this.dataGridViewVaccine.TabIndex = 0;
            this.dataGridViewVaccine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVaccine_CellContentClick);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Controls.Add(this.dataGridViewVaccine, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.tableLayoutPanel1, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1200, 703);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.radioButtonChonGoiVaccine, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.radioButtonChonVaccine, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(360, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(352, 50);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // KH_DatMua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(179)))));
            this.ClientSize = new System.Drawing.Size(1200, 703);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KH_DatMua";
            this.Text = "KH_DatMua";
            this.Load += new System.EventHandler(this.KH_DatMua_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccine)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTen;
        private System.Windows.Forms.DataGridView dataGridViewVaccine;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.RadioButton radioButtonChonGoiVaccine;
        private System.Windows.Forms.RadioButton radioButtonChonVaccine;
        private System.Windows.Forms.TextBox textBoxSoLuong;
        private System.Windows.Forms.Label labelSL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}