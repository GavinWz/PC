using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Manager_Form
{
    public partial class Wonder : Form
    {
        string uid;

        public Wonder()
        {
            InitializeComponent();
        }

        public Wonder(string uid)
        {
            this.uid = uid;
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            String remark = "[" + richTextBox1.Text + "] " + textBox1.Text;
            int? status = 2;
            d.order_add(remark, null, uid, null, null, DateTime.Now.ToString(), ref status);
            if (status == 0)
            {
                MessageBox.Show("添加成功！");
            }
            else if (status == 1)
            {
                MessageBox.Show("添加失败！");
            }
            else
            {
                MessageBox.Show("发生未知错误！");
            }

        }
    }
}
