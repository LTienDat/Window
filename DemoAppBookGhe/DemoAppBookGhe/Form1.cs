using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoAppBookGhe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            int i = 1, j = 70;//j  = 70 là mã ASC II của F
            foreach(Button c in tableLayoutPanel1.Controls)
            {
                if(i % 7 != 0)
                {
                    c.Text = (char)j + (7-i).ToString();
                    i++;
                    if(i == 7 )
                    {
                        j--;
                        i = 1;
                    }    
                }    
            }    
        }

        private void cbPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbThanhTien.Text = "0 đ";
            int i = 0;
            if(dicGhe.Count > 0 && dicGhe.ContainsKey(cbPhim.Text))//khi chọn lại phim mà đã mua ghế thì sẽ fill lại màu đỏ cho ghế đã bán
            {
                foreach (Button b in tableLayoutPanel1.Controls)
                {
                    b.Enabled = true;
                    if (b.Text.Contains("A"))
                    {
                        b.BackColor = Color.FromArgb(128, 255, 255);

                    }
                    else if (b.Text.Contains("B"))
                    {
                        b.BackColor = Color.FromArgb(192, 255, 192);
                    }
                    else if (b.Text.Contains("C"))
                    {
                        b.BackColor = Color.FromArgb(255, 255, 192);
                    }
                    else if (b.Text.Contains("D"))
                    {
                        b.BackColor = Color.FromArgb(255, 192, 255);
                    }
                    else if (b.Text.Contains("E"))
                    {
                        b.BackColor = Color.FromArgb(255, 192, 192);
                    }
                    else
                    {
                        b.BackColor = Color.FromArgb(255, 192, 128);
                    }
                    lbThanhTien.Text = thanhtien.ToString();
                }

                foreach (Button c in tableLayoutPanel1.Controls)
                {
                    
                    int[] ghe = dicGhe[cbPhim.Text];
                    if (ghe[i] == 1)
                    {
                        c.BackColor = Color.Red;
                    }
                    i++;
                }
                lbTenPhim.Text = cbPhim.Text.Trim();
                MessageBox.Show(cbPhim.Text + "đã bán đc " + dicPhim[cbPhim.Text] + "ghế và còn " + (36 - dicPhim[cbPhim.Text]) + "ghế trống");
            }
            else
            {
                foreach (Button b in tableLayoutPanel1.Controls)
                {
                    b.Enabled = true;
                    if (b.Text.Contains("A"))
                    {
                        b.BackColor = Color.FromArgb(128, 255, 255);
                        
                    }
                    else if (b.Text.Contains("B"))
                    {
                        b.BackColor = Color.FromArgb(192, 255, 192);
                    }
                    else if (b.Text.Contains("C"))
                    {
                        b.BackColor = Color.FromArgb(255, 255, 192);
                    }
                    else if (b.Text.Contains("D"))
                    {
                        b.BackColor = Color.FromArgb(255, 192, 255);
                    }
                    else if (b.Text.Contains("E"))
                    {
                        b.BackColor = Color.FromArgb(255, 192, 192);
                    }
                    else
                    {
                        b.BackColor = Color.FromArgb(255, 192, 128);
                    }
                    lbThanhTien.Text = thanhtien.ToString();
                }
            }
           
        }
        long thanhtien = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            

            //kích lại ghế lần 2
            if (b.BackColor == Color.Green)
            {
                if (b.Text.Contains("A"))
                {
                    thanhtien -= 25000; 
                    b.BackColor = Color.FromArgb(128,255,255);
                }
                else if (b.Text.Contains("B"))
                {
                    thanhtien -= 30000;
                    b.BackColor = Color.FromArgb(192, 255, 192);
                }
                else if (b.Text.Contains("C"))
                {
                    b.BackColor = Color.FromArgb(255, 255, 192);
                    thanhtien -= 35000;
                }
                else if (b.Text.Contains("D"))
                {
                    b.BackColor = Color.FromArgb(255, 192, 255);
                    thanhtien -= 40000;
                }
                else if (b.Text.Contains("E"))
                {
                    thanhtien -= 50000;
                    b.BackColor = Color.FromArgb(255, 192, 192);
                }
                else
                {
                    thanhtien -= 45000;
                    b.BackColor = Color.FromArgb(255, 192, 128);
                }
                lbThanhTien.Text = thanhtien.ToString();
            }
            else// kích lần đầu
            {
                b.BackColor = Color.Green;
                if (b.Text.Contains("A"))
                {
                    thanhtien += 25000;
                }
                else if (b.Text.Contains("B"))
                {
                    thanhtien += 30000;
                }
                else if (b.Text.Contains("C"))
                {
                    thanhtien += 35000;
                }
                else if (b.Text.Contains("D"))
                {
                    thanhtien += 40000;
                }
                else if (b.Text.Contains("E"))
                {
                    thanhtien += 50000;
                }
                else
                {
                    thanhtien += 45000;
                }
                lbThanhTien.Text = thanhtien.ToString();
            }
        }
        
        Dictionary<string,int> dicPhim = new Dictionary<string, int>();
        Dictionary<string, int[]> dicGhe = new Dictionary<string, int[]>();
        private void btThanhToan_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn mua ghế đã chọn hay không?", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
            if(rs == DialogResult.Yes)
            {
                lbThanhTien.Text = "0 đ";
                int[] listGhe = new int[36];//[0,0,1,...0]
                int index = 0;
                int dem = 0;
                foreach (Button c in tableLayoutPanel1.Controls)
                {
                    if (c.BackColor == Color.Green)
                    {
                        dem++;
                        c.BackColor = Color.Red;
                        c.Enabled = false;
                        listGhe[index] = 1;
                        
                    }
                    index++;
                }
                if(!dicPhim.ContainsKey(cbPhim.Text))
                {
                    dicPhim.Add(cbPhim.Text, dem);
                }
                if (!dicGhe.ContainsKey(cbPhim.Text))
                {
                    dicGhe.Add(cbPhim.Text,listGhe);
                }
            }   
            else
            {
                 
            }    
        
        }
    }
}
