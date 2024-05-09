using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace quanLySV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string key = "Data Source=DESKTOP-NCPS3NI\\TIENDAT;Initial Catalog=Quan_li_SV;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(key);
            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("\r\nSELECT  [MaSV] as 'Mã sinh viên',[HoTen] as 'Họ tên',[NgaySinh] as ' Ngày sinh',[NoiSinh] as 'Nơi sinh',[GioiTinh] as 'Giới tính'FROM [Quan_li_SV].[dbo].[SinhVien]", connection);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gt;
            string key = "Data Source=DESKTOP-NCPS3NI\\TIENDAT;Initial Catalog=Quan_li_SV;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(key);
            connection.Open();
            if (raNam.Checked == true) gt = "Nam";
            else gt = "Nữ";
            SqlCommand command = new SqlCommand("insert into thongTinSV values ('"+txtMa.Text+"',N'"+txtTen.Text+"', '"+dtNS.Text+"',N'"+txtNoiSinh.Text+"', N'"+gt+"')", connection);
            int sl = command.ExecuteNonQuery();
            if (sl > 0)
            {
                MessageBox.Show("Thêm thành công");
            }
            else
                MessageBox.Show("không thành công");                
            
         

            
            SqlDataAdapter sqlData = new SqlDataAdapter("\r\nSELECT  [MaSV] as 'Mã sinh viên',[HoTen] as 'Họ tên',[NgaySinh] as ' Ngày sinh',[NoiSinh] as 'Nơi sinh',[GioiTinh] as 'Giới tính'FROM [Quan_li_SV].[dbo].[SinhVien]", connection);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
                

            //string gt;


            ////MessageBox.Show(txtMa.Text);
            ////MessageBox.Show(txtTen.Text);// lấy nội dung
            //////MessageBox.Show(txtMa.Text);
            ////MessageBox.Show(dtNS.Text);
            ////MessageBox.Show(txtNoiSinh.Text);
            //if (raNam.Checked == true) gt = "Nam";else gt = "Nữ";
            ////MessageBox.Show(gt);
            ////MessageBox.Show(txtMa.Text + "  " + txtTen.Text + "  " + dtNS.Text + "  " + txtNoiSinh.Text + "  " + gt);
            //dataGridView1.Rows.Add(txtMa.Text, txtTen.Text, dtNS.Text, gt,txtNoiSinh.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMa.Text=dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtNoiSinh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            dtNS.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Nam") raNam.Checked=true;
            else raNu.Checked = true;
            //txtMa.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string gt;
            string key = "Data Source=DESKTOP-NCPS3NI\\TIENDAT;Initial Catalog=Quan_li_SV;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(key);
            connection.Open();
            if (raNam.Checked == true) gt = "Nam";
            else gt = "Nữ";
            SqlCommand command = new SqlCommand("update SinhVien  set HoTen = N'"+txtTen.Text+"',NgaySinh = '"+ dtNS.Text+"',noiSinh = N'"+txtNoiSinh.Text+"', GioiTinh= N'"+gt+"' where maSV = '"+txtMa.Text+"'\r\n", connection);
            int sl = command.ExecuteNonQuery();
            if (sl > 0)
            {
                MessageBox.Show("thành công");
            }
            else
                MessageBox.Show("không thành công");

            SqlDataAdapter sqlData = new SqlDataAdapter("\r\nSELECT  [MaSV] as 'Mã sinh viên',[HoTen] as 'Họ tên',[NgaySinh] as ' Ngày sinh',[NoiSinh] as 'Nơi sinh',[GioiTinh] as 'Giới tính'FROM [Quan_li_SV].[dbo].[SinhVien]", connection);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string gt;
            string key = "Data Source=DESKTOP-NCPS3NI\\TIENDAT;Initial Catalog=Quan_li_SV;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(key);
            connection.Open();
            if (raNam.Checked == true) gt = "Nam";
            else gt = "Nữ";
            SqlCommand command = new SqlCommand("delete from  SinhVien  where MaSV = '" + txtMa.Text + "'\r\n", connection);
            int sl = command.ExecuteNonQuery();
            if (sl > 0)
            {
                MessageBox.Show("thành công");
            }
            else
                MessageBox.Show("không thành công");

            SqlDataAdapter sqlData = new SqlDataAdapter("\r\nSELECT  [MaSV] as 'Mã sinh viên',[HoTen] as 'Họ tên',[NgaySinh] as ' Ngày sinh',[NoiSinh] as 'Nơi sinh',[GioiTinh] as 'Giới tính'FROM [Quan_li_SV].[dbo].[SinhVien]", connection);
            DataTable table = new DataTable();
            sqlData.Fill(table);
            dataGridView1.DataSource = table;
            connection.Close();
        }

        private void dtNS_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
