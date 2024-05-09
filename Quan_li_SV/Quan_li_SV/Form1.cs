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
namespace Quan_li_SV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_maSV.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_Hoten.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_noisinh.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            if (dataGridView1.CurrentRow.Cells[3].Value.ToString() == "Nam") { rdo_bt_nam.Checked = true; }
            else { rdo_bt_nu.Checked = true; }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string key = "Data Source=DESKTOP-NCPS3NI\\TIENDAT;Initial Catalog=Quan_li_SV;Integrated Security=True";
            sqlcon
           
        }
    }
}