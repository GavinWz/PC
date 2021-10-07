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
    public partial class Proposal : Form
    {
        string sid;
        public Proposal()
        {
            InitializeComponent();
        }
        public Proposal(string sid)
        {
            this.sid = sid;
            InitializeComponent();
        }

        private void Proposal_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet15.order_list”中。您可以根据需要移动或删除它。
            this.order_listTableAdapter.Fill(this.pC_ManagerDataSet15.order_list);
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet12.order”中。您可以根据需要移动或删除它。
            this.orderTableAdapter.Fill(this.pC_ManagerDataSet12.order);
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet11.proposal”中。您可以根据需要移动或删除它。
            this.proposalTableAdapter1.Fill(this.pC_ManagerDataSet11.proposal);
            // TODO: 这行代码将数据加载到表“pC_ManagerDataSet10.proposal”中。您可以根据需要移动或删除它。
            this.proposalTableAdapter.Fill(this.pC_ManagerDataSet10.proposal);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var oid = comboBox1.SelectedValue.ToString();

            var d = new DataClasses1DataContext();
            var selected = dataGridView2.CurrentRow;
            var pid = selected.Cells[0].Value.ToString();
            double final_price = double.Parse(selected.Cells[13].Value.ToString());
            var remark = selected.Cells[1].Value.ToString();
            var date = DateTime.Now.ToString();
            int? status = 2;
            if (oid == "1")
            {
                d.order_add(remark, Int32.Parse(pid), null, sid, final_price, date, ref status);
            }

            else
            {
                d.order_add_to_id(remark, Int32.Parse(oid), Int32.Parse(pid),  null,sid, final_price, date, ref status);
            }
            if (status == 0)
            {
                MessageBox.Show("添加成功！");
            }
            else if (status == 1)
            {
                MessageBox.Show("数据库添加失败！");
            }
            else
            {
                MessageBox.Show("发生未知错误！");
            }
        }
        
       }
}
