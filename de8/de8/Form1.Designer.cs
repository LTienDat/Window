namespace de8
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpHeThong = new System.Windows.Forms.TabPage();
            this.tpDoUong = new System.Windows.Forms.TabPage();
            this.tpBan = new System.Windows.Forms.TabPage();
            this.tpTt = new System.Windows.Forms.TabPage();
            this.tpThongke = new System.Windows.Forms.TabPage();
            this.txtDoanhThu = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btTK = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpngay2 = new System.Windows.Forms.DateTimePicker();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtpngay1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbDoUong = new System.Windows.Forms.ComboBox();
            this.cbNgayThang = new System.Windows.Forms.CheckBox();
            this.cbDoUong = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tpThongke.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpHeThong);
            this.tabControl1.Controls.Add(this.tpDoUong);
            this.tabControl1.Controls.Add(this.tpBan);
            this.tabControl1.Controls.Add(this.tpTt);
            this.tabControl1.Controls.Add(this.tpThongke);
            this.tabControl1.Location = new System.Drawing.Point(3, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(707, 349);
            this.tabControl1.TabIndex = 0;
            // 
            // tpHeThong
            // 
            this.tpHeThong.Location = new System.Drawing.Point(4, 25);
            this.tpHeThong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpHeThong.Name = "tpHeThong";
            this.tpHeThong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpHeThong.Size = new System.Drawing.Size(699, 320);
            this.tpHeThong.TabIndex = 0;
            this.tpHeThong.Text = "Hệ thống";
            this.tpHeThong.UseVisualStyleBackColor = true;
            // 
            // tpDoUong
            // 
            this.tpDoUong.Location = new System.Drawing.Point(4, 25);
            this.tpDoUong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDoUong.Name = "tpDoUong";
            this.tpDoUong.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpDoUong.Size = new System.Drawing.Size(699, 320);
            this.tpDoUong.TabIndex = 1;
            this.tpDoUong.Text = "Đồ uống";
            this.tpDoUong.UseVisualStyleBackColor = true;
            // 
            // tpBan
            // 
            this.tpBan.Location = new System.Drawing.Point(4, 25);
            this.tpBan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpBan.Name = "tpBan";
            this.tpBan.Size = new System.Drawing.Size(699, 320);
            this.tpBan.TabIndex = 2;
            this.tpBan.Text = "Bàn";
            this.tpBan.UseVisualStyleBackColor = true;
            // 
            // tpTt
            // 
            this.tpTt.Location = new System.Drawing.Point(4, 25);
            this.tpTt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpTt.Name = "tpTt";
            this.tpTt.Size = new System.Drawing.Size(699, 320);
            this.tpTt.TabIndex = 3;
            this.tpTt.Text = "Thanh Toán";
            this.tpTt.UseVisualStyleBackColor = true;
            // 
            // tpThongke
            // 
            this.tpThongke.Controls.Add(this.txtDoanhThu);
            this.tpThongke.Controls.Add(this.label4);
            this.tpThongke.Controls.Add(this.label3);
            this.tpThongke.Controls.Add(this.dataGridView1);
            this.tpThongke.Controls.Add(this.groupBox1);
            this.tpThongke.Location = new System.Drawing.Point(4, 25);
            this.tpThongke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tpThongke.Name = "tpThongke";
            this.tpThongke.Size = new System.Drawing.Size(699, 320);
            this.tpThongke.TabIndex = 4;
            this.tpThongke.Text = "Thống kê";
            this.tpThongke.UseVisualStyleBackColor = true;
            // 
            // txtDoanhThu
            // 
            this.txtDoanhThu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDoanhThu.Enabled = false;
            this.txtDoanhThu.Location = new System.Drawing.Point(492, 286);
            this.txtDoanhThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDoanhThu.Name = "txtDoanhThu";
            this.txtDoanhThu.Size = new System.Drawing.Size(144, 22);
            this.txtDoanhThu.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(645, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "(VNĐ)";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Doanh thu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(5, 170);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(680, 110);
            this.dataGridView1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btTK);
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Controls.Add(this.cbbDoUong);
            this.groupBox1.Controls.Add(this.cbNgayThang);
            this.groupBox1.Controls.Add(this.cbDoUong);
            this.groupBox1.Location = new System.Drawing.Point(4, 2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(681, 162);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Lọc thông tin";
            // 
            // btTK
            // 
            this.btTK.Location = new System.Drawing.Point(314, 126);
            this.btTK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTK.Name = "btTK";
            this.btTK.Size = new System.Drawing.Size(90, 24);
            this.btTK.TabIndex = 7;
            this.btTK.Text = "Thống kê";
            this.btTK.UseVisualStyleBackColor = true;
            this.btTK.Click += new System.EventHandler(this.btTK_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(137, 60);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(539, 60);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpngay2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(272, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 56);
            this.panel3.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Đến ngày";
            // 
            // dtpngay2
            // 
            this.dtpngay2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpngay2.CustomFormat = "dd/MM/yyyy";
            this.dtpngay2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngay2.Location = new System.Drawing.Point(3, 26);
            this.dtpngay2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngay2.Name = "dtpngay2";
            this.dtpngay2.Size = new System.Drawing.Size(256, 22);
            this.dtpngay2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 56);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtpngay1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(263, 56);
            this.panel2.TabIndex = 1;
            // 
            // dtpngay1
            // 
            this.dtpngay1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpngay1.CustomFormat = "dd/MM/yyyy";
            this.dtpngay1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpngay1.Location = new System.Drawing.Point(0, 26);
            this.dtpngay1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpngay1.Name = "dtpngay1";
            this.dtpngay1.Size = new System.Drawing.Size(258, 22);
            this.dtpngay1.TabIndex = 3;
            this.dtpngay1.ValueChanged += new System.EventHandler(this.dtpngay1_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ ngày";
            // 
            // cbbDoUong
            // 
            this.cbbDoUong.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbbDoUong.FormattingEnabled = true;
            this.cbbDoUong.Location = new System.Drawing.Point(186, 18);
            this.cbbDoUong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbDoUong.Name = "cbbDoUong";
            this.cbbDoUong.Size = new System.Drawing.Size(232, 24);
            this.cbbDoUong.TabIndex = 2;
            // 
            // cbNgayThang
            // 
            this.cbNgayThang.AutoSize = true;
            this.cbNgayThang.Location = new System.Drawing.Point(28, 89);
            this.cbNgayThang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbNgayThang.Name = "cbNgayThang";
            this.cbNgayThang.Size = new System.Drawing.Size(98, 20);
            this.cbNgayThang.TabIndex = 1;
            this.cbNgayThang.Text = "Ngày tháng";
            this.cbNgayThang.UseVisualStyleBackColor = true;
            // 
            // cbDoUong
            // 
            this.cbDoUong.AutoSize = true;
            this.cbDoUong.Location = new System.Drawing.Point(28, 21);
            this.cbDoUong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbDoUong.Name = "cbDoUong";
            this.cbDoUong.Size = new System.Drawing.Size(79, 20);
            this.cbDoUong.TabIndex = 0;
            this.cbDoUong.Text = "Đồ uống";
            this.cbDoUong.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý cafe (Đặng Thị Thanh Nhung - ct51060107 - 61th1)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpThongke.ResumeLayout(false);
            this.tpThongke.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpHeThong;
        private System.Windows.Forms.TabPage tpDoUong;
        private System.Windows.Forms.TabPage tpBan;
        private System.Windows.Forms.TabPage tpTt;
        private System.Windows.Forms.TabPage tpThongke;
        private System.Windows.Forms.TextBox txtDoanhThu;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpngay2;
        private System.Windows.Forms.DateTimePicker dtpngay1;
        private System.Windows.Forms.ComboBox cbbDoUong;
        private System.Windows.Forms.CheckBox cbNgayThang;
        private System.Windows.Forms.CheckBox cbDoUong;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btTK;
    }
}

