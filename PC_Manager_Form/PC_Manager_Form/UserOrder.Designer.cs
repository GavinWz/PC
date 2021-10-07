
namespace PC_Manager_Form
{
    partial class UserOrder
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pC_ManagerDataSet = new PC_Manager_Form.PC_ManagerDataSet();
            this.orderTableAdapter = new PC_Manager_Form.PC_ManagerDataSetTableAdapters.orderTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.主板DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPUDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.内存DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.散热DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.显卡DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.硬盘DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.机箱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.显示器DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.键盘DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.鼠标DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.电源DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.总计DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.getproposalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pC_ManagerDataSet1 = new PC_Manager_Form.PC_ManagerDataSet1();
            this.label2 = new System.Windows.Forms.Label();
            this.get_proposalTableAdapter = new PC_Manager_Form.PC_ManagerDataSet1TableAdapters.get_proposalTableAdapter();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pC_ManagerDataSet16 = new PC_Manager_Form.PC_ManagerDataSet16();
            this.userorderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_orderTableAdapter = new PC_Manager_Form.PC_ManagerDataSet16TableAdapters.user_orderTableAdapter();
            this.订单号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.备注DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.配置方案号DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.员工DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.成交价DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.状态DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.getproposalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userorderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.订单号DataGridViewTextBoxColumn,
            this.备注DataGridViewTextBoxColumn,
            this.配置方案号DataGridViewTextBoxColumn,
            this.员工DataGridViewTextBoxColumn,
            this.成交价DataGridViewTextBoxColumn,
            this.日期DataGridViewTextBoxColumn,
            this.状态DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.userorderBindingSource;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1005, 150);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "order";
            this.orderBindingSource.DataSource = this.pC_ManagerDataSet;
            // 
            // pC_ManagerDataSet
            // 
            this.pC_ManagerDataSet.DataSetName = "PC_ManagerDataSet";
            this.pC_ManagerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.主板DataGridViewTextBoxColumn,
            this.cPUDataGridViewTextBoxColumn,
            this.内存DataGridViewTextBoxColumn,
            this.散热DataGridViewTextBoxColumn,
            this.显卡DataGridViewTextBoxColumn,
            this.硬盘DataGridViewTextBoxColumn,
            this.机箱DataGridViewTextBoxColumn,
            this.显示器DataGridViewTextBoxColumn,
            this.键盘DataGridViewTextBoxColumn,
            this.鼠标DataGridViewTextBoxColumn,
            this.电源DataGridViewTextBoxColumn,
            this.总计DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.getproposalBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView2.Location = new System.Drawing.Point(0, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowTemplate.Height = 130;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1005, 150);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.FillWeight = 50F;
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 主板DataGridViewTextBoxColumn
            // 
            this.主板DataGridViewTextBoxColumn.DataPropertyName = "主板";
            this.主板DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.主板DataGridViewTextBoxColumn.HeaderText = "主板";
            this.主板DataGridViewTextBoxColumn.Name = "主板DataGridViewTextBoxColumn";
            this.主板DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPUDataGridViewTextBoxColumn
            // 
            this.cPUDataGridViewTextBoxColumn.DataPropertyName = "CPU";
            this.cPUDataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.cPUDataGridViewTextBoxColumn.HeaderText = "CPU";
            this.cPUDataGridViewTextBoxColumn.Name = "cPUDataGridViewTextBoxColumn";
            this.cPUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 内存DataGridViewTextBoxColumn
            // 
            this.内存DataGridViewTextBoxColumn.DataPropertyName = "内存";
            this.内存DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.内存DataGridViewTextBoxColumn.HeaderText = "内存";
            this.内存DataGridViewTextBoxColumn.Name = "内存DataGridViewTextBoxColumn";
            this.内存DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 散热DataGridViewTextBoxColumn
            // 
            this.散热DataGridViewTextBoxColumn.DataPropertyName = "散热";
            this.散热DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.散热DataGridViewTextBoxColumn.HeaderText = "散热";
            this.散热DataGridViewTextBoxColumn.Name = "散热DataGridViewTextBoxColumn";
            this.散热DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 显卡DataGridViewTextBoxColumn
            // 
            this.显卡DataGridViewTextBoxColumn.DataPropertyName = "显卡";
            this.显卡DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.显卡DataGridViewTextBoxColumn.HeaderText = "显卡";
            this.显卡DataGridViewTextBoxColumn.Name = "显卡DataGridViewTextBoxColumn";
            this.显卡DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 硬盘DataGridViewTextBoxColumn
            // 
            this.硬盘DataGridViewTextBoxColumn.DataPropertyName = "硬盘";
            this.硬盘DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.硬盘DataGridViewTextBoxColumn.HeaderText = "硬盘";
            this.硬盘DataGridViewTextBoxColumn.Name = "硬盘DataGridViewTextBoxColumn";
            this.硬盘DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 机箱DataGridViewTextBoxColumn
            // 
            this.机箱DataGridViewTextBoxColumn.DataPropertyName = "机箱";
            this.机箱DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.机箱DataGridViewTextBoxColumn.HeaderText = "机箱";
            this.机箱DataGridViewTextBoxColumn.Name = "机箱DataGridViewTextBoxColumn";
            this.机箱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 显示器DataGridViewTextBoxColumn
            // 
            this.显示器DataGridViewTextBoxColumn.DataPropertyName = "显示器";
            this.显示器DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.显示器DataGridViewTextBoxColumn.HeaderText = "显示器";
            this.显示器DataGridViewTextBoxColumn.Name = "显示器DataGridViewTextBoxColumn";
            this.显示器DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 键盘DataGridViewTextBoxColumn
            // 
            this.键盘DataGridViewTextBoxColumn.DataPropertyName = "键盘";
            this.键盘DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.键盘DataGridViewTextBoxColumn.HeaderText = "键盘";
            this.键盘DataGridViewTextBoxColumn.Name = "键盘DataGridViewTextBoxColumn";
            this.键盘DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 鼠标DataGridViewTextBoxColumn
            // 
            this.鼠标DataGridViewTextBoxColumn.DataPropertyName = "鼠标";
            this.鼠标DataGridViewTextBoxColumn.FillWeight = 97.33502F;
            this.鼠标DataGridViewTextBoxColumn.HeaderText = "鼠标";
            this.鼠标DataGridViewTextBoxColumn.Name = "鼠标DataGridViewTextBoxColumn";
            this.鼠标DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 电源DataGridViewTextBoxColumn
            // 
            this.电源DataGridViewTextBoxColumn.DataPropertyName = "电源";
            this.电源DataGridViewTextBoxColumn.FillWeight = 97F;
            this.电源DataGridViewTextBoxColumn.HeaderText = "电源";
            this.电源DataGridViewTextBoxColumn.Name = "电源DataGridViewTextBoxColumn";
            this.电源DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 总计DataGridViewTextBoxColumn
            // 
            this.总计DataGridViewTextBoxColumn.DataPropertyName = "总计";
            this.总计DataGridViewTextBoxColumn.FillWeight = 50F;
            this.总计DataGridViewTextBoxColumn.HeaderText = "总计";
            this.总计DataGridViewTextBoxColumn.Name = "总计DataGridViewTextBoxColumn";
            this.总计DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // getproposalBindingSource
            // 
            this.getproposalBindingSource.DataMember = "get_proposal";
            this.getproposalBindingSource.DataSource = this.pC_ManagerDataSet1;
            // 
            // pC_ManagerDataSet1
            // 
            this.pC_ManagerDataSet1.DataSetName = "PC_ManagerDataSet1";
            this.pC_ManagerDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Location = new System.Drawing.Point(0, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1005, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "label2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // get_proposalTableAdapter
            // 
            this.get_proposalTableAdapter.ClearBeforeFill = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = global::PC_Manager_Form.Properties.Resources.AMDRyzen32200GE;
            this.pictureBox1.Location = new System.Drawing.Point(2, 156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(169, 138);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // pC_ManagerDataSet16
            // 
            this.pC_ManagerDataSet16.DataSetName = "PC_ManagerDataSet16";
            this.pC_ManagerDataSet16.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userorderBindingSource
            // 
            this.userorderBindingSource.DataMember = "user_order";
            this.userorderBindingSource.DataSource = this.pC_ManagerDataSet16;
            // 
            // user_orderTableAdapter
            // 
            this.user_orderTableAdapter.ClearBeforeFill = true;
            // 
            // 订单号DataGridViewTextBoxColumn
            // 
            this.订单号DataGridViewTextBoxColumn.DataPropertyName = "订单号";
            this.订单号DataGridViewTextBoxColumn.HeaderText = "订单号";
            this.订单号DataGridViewTextBoxColumn.Name = "订单号DataGridViewTextBoxColumn";
            this.订单号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 备注DataGridViewTextBoxColumn
            // 
            this.备注DataGridViewTextBoxColumn.DataPropertyName = "备注";
            this.备注DataGridViewTextBoxColumn.HeaderText = "备注";
            this.备注DataGridViewTextBoxColumn.Name = "备注DataGridViewTextBoxColumn";
            this.备注DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 配置方案号DataGridViewTextBoxColumn
            // 
            this.配置方案号DataGridViewTextBoxColumn.DataPropertyName = "配置方案号";
            this.配置方案号DataGridViewTextBoxColumn.HeaderText = "配置方案号";
            this.配置方案号DataGridViewTextBoxColumn.Name = "配置方案号DataGridViewTextBoxColumn";
            this.配置方案号DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 员工DataGridViewTextBoxColumn
            // 
            this.员工DataGridViewTextBoxColumn.DataPropertyName = "员工";
            this.员工DataGridViewTextBoxColumn.HeaderText = "员工";
            this.员工DataGridViewTextBoxColumn.Name = "员工DataGridViewTextBoxColumn";
            this.员工DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 成交价DataGridViewTextBoxColumn
            // 
            this.成交价DataGridViewTextBoxColumn.DataPropertyName = "成交价";
            this.成交价DataGridViewTextBoxColumn.HeaderText = "成交价";
            this.成交价DataGridViewTextBoxColumn.Name = "成交价DataGridViewTextBoxColumn";
            this.成交价DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 日期DataGridViewTextBoxColumn
            // 
            this.日期DataGridViewTextBoxColumn.DataPropertyName = "日期";
            this.日期DataGridViewTextBoxColumn.HeaderText = "日期";
            this.日期DataGridViewTextBoxColumn.Name = "日期DataGridViewTextBoxColumn";
            this.日期DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 状态DataGridViewTextBoxColumn
            // 
            this.状态DataGridViewTextBoxColumn.DataPropertyName = "状态";
            this.状态DataGridViewTextBoxColumn.HeaderText = "状态";
            this.状态DataGridViewTextBoxColumn.Name = "状态DataGridViewTextBoxColumn";
            this.状态DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // UserOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserOrder";
            this.Text = "User Order";
            this.Load += new System.EventHandler(this.user_order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.getproposalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userorderBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private PC_ManagerDataSet pC_ManagerDataSet;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private PC_ManagerDataSetTableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource getproposalBindingSource;
        private PC_ManagerDataSet1 pC_ManagerDataSet1;
        private PC_ManagerDataSet1TableAdapters.get_proposalTableAdapter get_proposalTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 主板DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPUDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 内存DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 散热DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 显卡DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 硬盘DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 机箱DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 显示器DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 键盘DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 鼠标DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 电源DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 总计DataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 订单号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 备注DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 配置方案号DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 员工DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 成交价DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 状态DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userorderBindingSource;
        private PC_ManagerDataSet16 pC_ManagerDataSet16;
        private PC_ManagerDataSet16TableAdapters.user_orderTableAdapter user_orderTableAdapter;
    }
}

