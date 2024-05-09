namespace Quan_li_SV
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            dateTimePicker1 = new DateTimePicker();
            txt_Hoten = new TextBox();
            txt_maSV = new TextBox();
            lb_ngaysinh = new Label();
            lb_ten = new Label();
            lb_MaSV = new Label();
            panel2 = new Panel();
            rdo_bt_nu = new RadioButton();
            rdo_bt_nam = new RadioButton();
            txt_noisinh = new TextBox();
            bt_loc = new Button();
            bt_xoa = new Button();
            bt_sua = new Button();
            bt_them = new Button();
            lb_gioitinh = new Label();
            lb_noisinh = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 0);
            tableLayoutPanel1.Location = new Point(3, 1);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(877, 213);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(txt_Hoten);
            panel1.Controls.Add(txt_maSV);
            panel1.Controls.Add(lb_ngaysinh);
            panel1.Controls.Add(lb_ten);
            panel1.Controls.Add(lb_MaSV);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(432, 207);
            panel1.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
            dateTimePicker1.Location = new Point(117, 154);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 3;
            dateTimePicker1.Value = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // txt_Hoten
            // 
            txt_Hoten.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_Hoten.Location = new Point(117, 90);
            txt_Hoten.Name = "txt_Hoten";
            txt_Hoten.Size = new Size(240, 27);
            txt_Hoten.TabIndex = 2;
            // 
            // txt_maSV
            // 
            txt_maSV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_maSV.Location = new Point(117, 17);
            txt_maSV.Name = "txt_maSV";
            txt_maSV.Size = new Size(240, 27);
            txt_maSV.TabIndex = 1;
            // 
            // lb_ngaysinh
            // 
            lb_ngaysinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_ngaysinh.AutoSize = true;
            lb_ngaysinh.Location = new Point(37, 159);
            lb_ngaysinh.Name = "lb_ngaysinh";
            lb_ngaysinh.Size = new Size(74, 20);
            lb_ngaysinh.TabIndex = 2;
            lb_ngaysinh.Text = "Ngay sinh";
            // 
            // lb_ten
            // 
            lb_ten.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_ten.AutoSize = true;
            lb_ten.Location = new Point(37, 93);
            lb_ten.Name = "lb_ten";
            lb_ten.Size = new Size(56, 20);
            lb_ten.TabIndex = 1;
            lb_ten.Text = "Ho Ten";
            // 
            // lb_MaSV
            // 
            lb_MaSV.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_MaSV.AutoSize = true;
            lb_MaSV.Location = new Point(37, 24);
            lb_MaSV.Name = "lb_MaSV";
            lb_MaSV.Size = new Size(51, 20);
            lb_MaSV.TabIndex = 0;
            lb_MaSV.Text = "Ma SV";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(rdo_bt_nu);
            panel2.Controls.Add(rdo_bt_nam);
            panel2.Controls.Add(txt_noisinh);
            panel2.Controls.Add(bt_loc);
            panel2.Controls.Add(bt_xoa);
            panel2.Controls.Add(bt_sua);
            panel2.Controls.Add(bt_them);
            panel2.Controls.Add(lb_gioitinh);
            panel2.Controls.Add(lb_noisinh);
            panel2.Location = new Point(441, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(433, 207);
            panel2.TabIndex = 1;
            // 
            // rdo_bt_nu
            // 
            rdo_bt_nu.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdo_bt_nu.AutoSize = true;
            rdo_bt_nu.Location = new Point(244, 89);
            rdo_bt_nu.Name = "rdo_bt_nu";
            rdo_bt_nu.Size = new Size(49, 24);
            rdo_bt_nu.TabIndex = 6;
            rdo_bt_nu.TabStop = true;
            rdo_bt_nu.Text = "Nu";
            rdo_bt_nu.UseVisualStyleBackColor = true;
            // 
            // rdo_bt_nam
            // 
            rdo_bt_nam.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            rdo_bt_nam.AutoSize = true;
            rdo_bt_nam.Location = new Point(122, 89);
            rdo_bt_nam.Name = "rdo_bt_nam";
            rdo_bt_nam.Size = new Size(62, 24);
            rdo_bt_nam.TabIndex = 5;
            rdo_bt_nam.TabStop = true;
            rdo_bt_nam.Text = "Nam";
            rdo_bt_nam.UseVisualStyleBackColor = true;
            // 
            // txt_noisinh
            // 
            txt_noisinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txt_noisinh.Location = new Point(122, 21);
            txt_noisinh.Name = "txt_noisinh";
            txt_noisinh.Size = new Size(240, 27);
            txt_noisinh.TabIndex = 4;
            // 
            // bt_loc
            // 
            bt_loc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bt_loc.Location = new Point(322, 150);
            bt_loc.Name = "bt_loc";
            bt_loc.Size = new Size(94, 29);
            bt_loc.TabIndex = 10;
            bt_loc.Text = "Loc";
            bt_loc.UseVisualStyleBackColor = true;
            // 
            // bt_xoa
            // 
            bt_xoa.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bt_xoa.Location = new Point(222, 150);
            bt_xoa.Name = "bt_xoa";
            bt_xoa.Size = new Size(94, 29);
            bt_xoa.TabIndex = 9;
            bt_xoa.Text = "Xoa";
            bt_xoa.UseVisualStyleBackColor = true;
            // 
            // bt_sua
            // 
            bt_sua.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bt_sua.Location = new Point(122, 150);
            bt_sua.Name = "bt_sua";
            bt_sua.Size = new Size(94, 29);
            bt_sua.TabIndex = 8;
            bt_sua.Text = "Sua";
            bt_sua.UseVisualStyleBackColor = true;
            // 
            // bt_them
            // 
            bt_them.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            bt_them.Location = new Point(22, 150);
            bt_them.Name = "bt_them";
            bt_them.Size = new Size(94, 29);
            bt_them.TabIndex = 7;
            bt_them.Text = "Them";
            bt_them.UseVisualStyleBackColor = true;
            // 
            // lb_gioitinh
            // 
            lb_gioitinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_gioitinh.AutoSize = true;
            lb_gioitinh.Location = new Point(31, 93);
            lb_gioitinh.Name = "lb_gioitinh";
            lb_gioitinh.Size = new Size(65, 20);
            lb_gioitinh.TabIndex = 3;
            lb_gioitinh.Text = "Gioi tinh";
            // 
            // lb_noisinh
            // 
            lb_noisinh.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lb_noisinh.AutoSize = true;
            lb_noisinh.Location = new Point(31, 24);
            lb_noisinh.Name = "lb_noisinh";
            lb_noisinh.Size = new Size(65, 20);
            lb_noisinh.TabIndex = 2;
            lb_noisinh.Text = "Noi Sinh";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 238);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(877, 313);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(883, 507);
            Controls.Add(dataGridView1);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quan li sinh vien ( Le Tien Dat - 2051060429)";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label lb_ten;
        private Label lb_MaSV;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private TextBox txt_Hoten;
        private TextBox txt_maSV;
        private Label lb_ngaysinh;
        private TextBox txt_noisinh;
        private Button bt_loc;
        private Button bt_xoa;
        private Button bt_sua;
        private Button bt_them;
        private Label lb_gioitinh;
        private Label lb_noisinh;
        private RadioButton rdo_bt_nu;
        private RadioButton rdo_bt_nam;
        private DataGridView dataGridView1;
    }
}