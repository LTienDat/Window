namespace DESO2
{
    public partial class Form1 : Form
    {
        int stt = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int thanhtien = Convert.ToInt32(numericUpDown1.Value) * Convert.ToInt32(textBox2.Text);

            dataGridView1.Rows.Add(stt++, comboBox1.Text, numericUpDown1.Text, textBox2.Text, thanhtien);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                textBox2.Text = "100000";
            }
            if (comboBox1.SelectedIndex == 1)
            {
                textBox2.Text = "200000";
            }
            if (comboBox1.SelectedIndex == 2)
            {
                textBox2.Text = "300000";
            }
            if (comboBox1.SelectedIndex == 3)
            {
                textBox2.Text = "400000";
            }
            if (comboBox1.SelectedIndex == 4)
            {
                textBox2.Text = "500000";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int tong = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                int tt = Convert.ToInt32(row.Cells[4].Value.ToString());
                tong = tong + tt;
            }
            textBox3.Text = tong.ToString();
        }

        private void đổiMàuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog d = new ColorDialog();
            DialogResult rs = d.ShowDialog();
            if (rs == DialogResult.OK)
            {
                ToolStripMenuItem toolstrip = (ToolStripMenuItem)sender;
                ContextMenuStrip contextMenu = (ContextMenuStrip)toolstrip.Owner;
                Control c = contextMenu.SourceControl;
                //= sender.Ow



                Control f = ((ContextMenuStrip)((ToolStripMenuItem)sender).Owner).SourceControl;

                c.BackColor = d.Color;
            }
        }
    }
}