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
    public partial class UserParent : Form
    {
        private int childFormNumber = 0;
        private string uid;

        public UserParent()
        {
            InitializeComponent();
        }
        public UserParent(string uid)
        {
            this.uid = uid;
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "窗口 " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "文本文件(*.txt)|*.txt|所有文件(*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }


        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void close_childs()
        {
            var childs = this.MdiChildren;
            foreach (var child in childs)
                if (child != null)
                    child.Close();

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            close_childs();
            Wonder wonder = new Wonder(uid);
            wonder.WindowState = FormWindowState.Maximized;
            wonder.MdiParent = this;
            wonder.Show();
        }


        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            close_childs();
            UserOrder userOrder = new UserOrder(uid);
            userOrder.WindowState = FormWindowState.Maximized;
            userOrder.MdiParent = this;
            userOrder.Show();
        }
        private void UserParent_Load(object sender, EventArgs e)
        {
            if (this.uid == null || this.uid.Length == 0)
            {
                MessageBox.Show("请登录");
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Dispose();
            }
            else
            {
                label1.Text = "欢迎您：" + uid;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.uid != null)
            {
                this.uid = null;
                MessageBox.Show("注销成功");
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("未登录");
            }
        }

    }
}
