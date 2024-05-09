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

namespace de8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string key = "Data Source=DESKTOP-NCPS3NI\\TIENDAT;Initial Catalog=De_8;Integrated Security=True;";
            SqlConnection connection = new SqlConnection(key);

            connection.Open();
            SqlDataAdapter sqlData = new SqlDataAdapter("select * from DatHang", connection);
            DataTable data = new DataTable();
            sqlData.Fill(data);


            dataGridView1.DataSource = data;

            cbbDoUong.DisplayMember = "DoUong";
            cbbDoUong.ValueMember = "DoUong";

            cbbDoUong.DataSource = data;

            connection.Close();
        }

        private void btTK_Click(object sender, EventArgs e)
        {
            int tong ;
            //MessageBox.Show(dataGridView1.CurrentRow.Cells[3].Value.ToString());
            if (cbDoUong.Checked == true && cbNgayThang.Checked != true)
            {
                tong = 0;
                string key = "Data Source=DESKTOP-NCPS3NI\\TIENDAT;Initial Catalog=De_8;Integrated Security=True;";
                SqlConnection connection = new SqlConnection(key);

                connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("select * from DatHang where DoUong like N'" + cbbDoUong.Text + "'", connection);
                DataTable data = new DataTable();
                sqlData.Fill(data);


                dataGridView1.DataSource = data;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    
                    tong += int.Parse(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[4].Value.ToString());
                    
                }

                txtDoanhThu.Text = tong.ToString();

                connection.Close();
            }

            if (cbDoUong.Checked != true && cbNgayThang.Checked == true)
            {
                tong = 0;
                string key = "Data Source=DESKTOP-NCPS3NI\\TIENDAT;Initial Catalog=De_8;Integrated Security=True;";
                SqlConnection connection = new SqlConnection(key);

                connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("select * from DatHang where Ngay between '" + dtpngay1.Value + "' and '" + dtpngay2.Value + "'", connection);
                DataTable data = new DataTable();
                sqlData.Fill(data);


                dataGridView1.DataSource = data;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {

                    tong += int.Parse(row.Cells[3].Value.ToString()) * int.Parse(row.Cells[4].Value.ToString());
                }

                txtDoanhThu.Text = tong.ToString();

                connection.Close();
            }


            if (cbDoUong.Checked == true && cbNgayThang.Checked == true)
            {
                tong = 0;
                string key = "Data Source = DESKTOP - NCPS3NI\\TIENDAT; Initial Catalog = De_8; Integrated Security = True; ";
                SqlConnection connection = new SqlConnection(key);

                connection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("select * from Dathang where ngay between '" + dtpngay1.Value + "' and '" + dtpngay2.Value + "'and DoUong like N'" + cbbDoUong.Text + "'", connection);
                DataTable data = new DataTable();
                sqlData.Fill(data);


                dataGridView1.DataSource = data;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    int value3, value4;
                    if (row.Cells[3].Value != null && row.Cells[4].Value != null)
                    {
                        if ((int.TryParse(row.Cells[3].Value.ToString(), out value3)) && int.TryParse(row.Cells[4].Value.ToString(), out value4))
                        {
                            tong += value3 * value4;
                        }
                    }
                }

                txtDoanhThu.Text = tong.ToString();
                connection.Close();
            }

           


        }

        private void dtpngay1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
