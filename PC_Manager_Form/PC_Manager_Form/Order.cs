using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PC_Manager_Form
{
    public partial class Order : Form
    {
        public Order()
        {
            InitializeComponent();
        }

        private void Order_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet13.order”中。您可以根据需要移动或删除它。
            this.orderTableAdapter.Fill(this.pC_ManagerDataSet13.order);

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var d = new DataClasses1DataContext();

                //string data1 = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                //string data2 = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                //label1.Text = data1;
                //label2.Text = data2;

                label2.Text = "具体配置方案信息：";

                string id = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                if (id == "&nbsp;")
                {
                    dataGridView2.DataSource = "请等待技术人员提供解决方案";
                    return;
                }
                //else
                //{
                //    dataGridView2.DataSource = "id = " + id;
                //    return;
                //}
                if (id.Length != 0)
                {
                    var data = d.get_proposal(Int32.Parse(id));
                    dataGridView2.DataSource = data;
                }
                else if (dataGridView2.DataSource != null)
                {
                    dataGridView2.Rows.Clear();
                }
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var row = dataGridView2.CurrentCell.Value;
            var column = dataGridView2.CurrentCell.ColumnIndex;
            if (row != null && column != 0 && column != 12)
            {
                string img_name = row.ToString().Replace(" ", "").Replace("\\", "\\\\");
                string img_type = dataGridView2.Columns[dataGridView2.CurrentCell.ColumnIndex].HeaderText.ToString().Replace(" ", "");
                string path = "D:/IMG/" + img_type + "/" + img_name + ".jpg";
                if (File.Exists(path))
                {
                    pictureBox1.Load(path);
                    pictureBox1.Show();
                }
                else
                {
                    pictureBox1.Hide();
                }
            }
            else
                pictureBox1.Hide();
        }
    }
}
