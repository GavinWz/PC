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
    public partial class Store : Form
    {
        public Store()
        {
            InitializeComponent();
        }

        private void Store_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet9.proposal_remark”中。您可以根据需要移动或删除它。
            this.proposal_remarkTableAdapter.Fill(this.pC_ManagerDataSet9.proposal_remark);
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet8.proposal”中。您可以根据需要移动或删除它。
            this.proposalTableAdapter.Fill(this.pC_ManagerDataSet8.proposal);
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet7.type”中。您可以根据需要移动或删除它。
            this.typeTableAdapter3.Fill(this.pC_ManagerDataSet7.type);
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet6.type”中。您可以根据需要移动或删除它。
            this.typeTableAdapter2.Fill(this.pC_ManagerDataSet6.type);
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet5.type”中。您可以根据需要移动或删除它。
            this.typeTableAdapter1.Fill(this.pC_ManagerDataSet5.type);
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet4.type”中。您可以根据需要移动或删除它。
            this.typeTableAdapter.Fill(this.pC_ManagerDataSet4.type);
            var d = new DataClasses1DataContext();
            dataGridView1.DataSource = d.selectAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            var name = textBox1.Text;
            string type = comboBox1.SelectedValue.ToString();
            int? status = 2;
            if(name == "" && type == "所有配件")
            {
                dataGridView1.DataSource = d.selectAll();
                status = 0;
            }

            else if(type == "" || type == "所有配件")
            {
                var new_data = d.search_in_all(name, ref status);
                if (status == 0)
                    dataGridView1.DataSource = new_data;
            }
            else
            {
                var new_data = d.search_in_type(name, type, ref status);
                if (status == 0)
                    dataGridView1.DataSource = new_data;
            }

            if (status == 1)
            {
                MessageBox.Show("查询失败");
            }
            else if(status == 2)
            {
                MessageBox.Show("发生未知错误");
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            var selected = "";
            var selected_value = comboBox1.SelectedValue;
            if (selected_value != null)
                selected = selected_value.ToString();

            int? status = 2;

            if (selected == "所有配件" || selected == "")
            {
                dataGridView1.DataSource = d.selectAll();
            }
            else
            {
                label1.Text = selected;

                dataGridView1.DataSource = d.selectType(selected, ref status);
            }
            textBox1.Text = "";
        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.typeTableAdapter2.FillBy1(this.pC_ManagerDataSet6.type);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.typeTableAdapter2.FillBy2(this.pC_ManagerDataSet6.type);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            var item = dataGridView1.CurrentRow;

            label3.Text = item.Cells[0].Value.ToString();
            textBox2.Text = item.Cells[1].Value.ToString();
            textBox3.Text = item.Cells[2].Value.ToString();
            textBox4.Text = item.Cells[3].Value.ToString();
            textBox5.Text = item.Cells[4].Value.ToString();
            string img_name = textBox3.Text.Replace(" ", "").Replace("\\", "\\\\");
            string img_type = textBox2.Text.Replace(" ", "");
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

        private void button3_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            var pid = comboBox2.SelectedValue.ToString();
            //var name = DropDownList2.SelectedItem.Text;

            var type = textBox2.Text;
            var name = textBox3.Text;
            if (name == "" || name == "")
            {
                MessageBox.Show("请填入配件信息!");
                return;
            }
            int? status = 2;
            d.proposal_attach(Int32.Parse(pid), type, name, ref status);
            //double? total = 0;
            //d.get_total(ref total);
            if (status == 0)
            {
                MessageBox.Show("添加成功！");
            }
            else if (status == 1)
            {
                MessageBox.Show("该方案不存在！");
            }
            else
            {
                MessageBox.Show("发生未知错误！");
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();
            var remark = textBox6.Text;
            int? status = 2;
            if (remark.Length > 0)
            {
                d.proposalAdd(remark, ref status);
            }
            else
                status = 1;
            if (status == 1)
            {
                MessageBox.Show("请输入方案描述！");
            }
            else if (status == 0)
            {
                MessageBox.Show("添加成功！");
                //bind(DropDownList1.SelectedValue);
                comboBox2.DataSource = d.proposal_remark();
            }
            else
            {
                MessageBox.Show("发生未知错误！");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var d = new DataClasses1DataContext();

            int? status = 1;
            d.modify(Int32.Parse(label3.Text), textBox2.Text, textBox3.Text, textBox4.Text, float.Parse(textBox5.Text), ref status);
            if (status == 0)
            {
                MessageBox.Show("修改成功！");
                button1_Click(sender, e);
            }
            else
            {
                MessageBox.Show("发生未知错误！");
            }
        }
    }
}
