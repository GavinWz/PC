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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selected = "";
            var d = new DataClasses1DataContext();
            if (radioButton1.Checked)
                selected = "用户";
            else if (radioButton2.Checked)
                selected = "员工";
            var id = textBox1.Text.ToString();
            var passwd = textBox2.Text.ToString();
            if (id.Length == 0 || passwd.Length == 0)
            {
                MessageBox.Show("用户名和密码不能为空！");
                return;
            }
            int? status = 2;
            if (selected == "用户")
            {
                d.user_login(id, passwd, ref status);
                if (status == 0)
                {
                    UserParent userParent = new UserParent(id);
                    this.Hide();
                    userParent.ShowDialog();
                    this.Dispose();
                }
                else if (status == 1)
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
            else if (selected == "员工")
            {
                d.staff_login(id, passwd, ref status);
                if (status == 0)
                {
                    StaffParent staffParent = new StaffParent(id);
                    this.Hide();
                    staffParent.ShowDialog();
                    this.Dispose();
                }
                else if (status == 1)
                {
                    MessageBox.Show("用户名或密码错误！");
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            foreach (var btn in groupBox1.Controls.Cast<RadioButton>().ToList<RadioButton>())
            {
                if (btn.Name != (sender as Control).Name)
                {
                    btn.Checked = false;
                }
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
