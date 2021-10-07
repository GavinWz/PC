
namespace PC_Manager_Form
{
    partial class Proposal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pC_ManagerDataSet10 = new PC_Manager_Form.PC_ManagerDataSet10();
            this.proposalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.proposalTableAdapter = new PC_Manager_Form.PC_ManagerDataSet10TableAdapters.proposalTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proposalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pC_ManagerDataSet11 = new PC_Manager_Form.PC_ManagerDataSet11();
            this.proposalTableAdapter1 = new PC_Manager_Form.PC_ManagerDataSet11TableAdapters.proposalTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pC_ManagerDataSet12 = new PC_Manager_Form.PC_ManagerDataSet12();
            this.orderTableAdapter = new PC_Manager_Form.PC_ManagerDataSet12TableAdapters.orderTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.pC_ManagerDataSet15 = new PC_Manager_Form.PC_ManagerDataSet15();
            this.orderlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.order_listTableAdapter = new PC_Manager_Form.PC_ManagerDataSet15TableAdapters.order_listTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proposalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proposalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pC_ManagerDataSet10
            // 
            this.pC_ManagerDataSet10.DataSetName = "PC_ManagerDataSet10";
            this.pC_ManagerDataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proposalBindingSource
            // 
            this.proposalBindingSource.DataMember = "proposal";
            this.proposalBindingSource.DataSource = this.pC_ManagerDataSet10;
            // 
            // proposalTableAdapter
            // 
            this.proposalTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("黑体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pidDataGridViewTextBoxColumn,
            this.remarkDataGridViewTextBoxColumn,
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
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.proposalBindingSource1;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.RowTemplate.Height = 100;
            this.dataGridView2.Size = new System.Drawing.Size(1024, 412);
            this.dataGridView2.TabIndex = 3;
            // 
            // pidDataGridViewTextBoxColumn
            // 
            this.pidDataGridViewTextBoxColumn.DataPropertyName = "pid";
            this.pidDataGridViewTextBoxColumn.HeaderText = "方案号";
            this.pidDataGridViewTextBoxColumn.Name = "pidDataGridViewTextBoxColumn";
            this.pidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            this.remarkDataGridViewTextBoxColumn.DataPropertyName = "remark";
            this.remarkDataGridViewTextBoxColumn.HeaderText = "备注";
            this.remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            this.remarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 主板DataGridViewTextBoxColumn
            // 
            this.主板DataGridViewTextBoxColumn.DataPropertyName = "主板";
            this.主板DataGridViewTextBoxColumn.HeaderText = "主板";
            this.主板DataGridViewTextBoxColumn.Name = "主板DataGridViewTextBoxColumn";
            this.主板DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cPUDataGridViewTextBoxColumn
            // 
            this.cPUDataGridViewTextBoxColumn.DataPropertyName = "CPU";
            this.cPUDataGridViewTextBoxColumn.HeaderText = "CPU";
            this.cPUDataGridViewTextBoxColumn.Name = "cPUDataGridViewTextBoxColumn";
            this.cPUDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 内存DataGridViewTextBoxColumn
            // 
            this.内存DataGridViewTextBoxColumn.DataPropertyName = "内存";
            this.内存DataGridViewTextBoxColumn.HeaderText = "内存";
            this.内存DataGridViewTextBoxColumn.Name = "内存DataGridViewTextBoxColumn";
            this.内存DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 散热DataGridViewTextBoxColumn
            // 
            this.散热DataGridViewTextBoxColumn.DataPropertyName = "散热";
            this.散热DataGridViewTextBoxColumn.HeaderText = "散热";
            this.散热DataGridViewTextBoxColumn.Name = "散热DataGridViewTextBoxColumn";
            this.散热DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 显卡DataGridViewTextBoxColumn
            // 
            this.显卡DataGridViewTextBoxColumn.DataPropertyName = "显卡";
            this.显卡DataGridViewTextBoxColumn.HeaderText = "显卡";
            this.显卡DataGridViewTextBoxColumn.Name = "显卡DataGridViewTextBoxColumn";
            this.显卡DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 硬盘DataGridViewTextBoxColumn
            // 
            this.硬盘DataGridViewTextBoxColumn.DataPropertyName = "硬盘";
            this.硬盘DataGridViewTextBoxColumn.HeaderText = "硬盘";
            this.硬盘DataGridViewTextBoxColumn.Name = "硬盘DataGridViewTextBoxColumn";
            this.硬盘DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 机箱DataGridViewTextBoxColumn
            // 
            this.机箱DataGridViewTextBoxColumn.DataPropertyName = "机箱";
            this.机箱DataGridViewTextBoxColumn.HeaderText = "机箱";
            this.机箱DataGridViewTextBoxColumn.Name = "机箱DataGridViewTextBoxColumn";
            this.机箱DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 显示器DataGridViewTextBoxColumn
            // 
            this.显示器DataGridViewTextBoxColumn.DataPropertyName = "显示器";
            this.显示器DataGridViewTextBoxColumn.HeaderText = "显示器";
            this.显示器DataGridViewTextBoxColumn.Name = "显示器DataGridViewTextBoxColumn";
            this.显示器DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 键盘DataGridViewTextBoxColumn
            // 
            this.键盘DataGridViewTextBoxColumn.DataPropertyName = "键盘";
            this.键盘DataGridViewTextBoxColumn.HeaderText = "键盘";
            this.键盘DataGridViewTextBoxColumn.Name = "键盘DataGridViewTextBoxColumn";
            this.键盘DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 鼠标DataGridViewTextBoxColumn
            // 
            this.鼠标DataGridViewTextBoxColumn.DataPropertyName = "鼠标";
            this.鼠标DataGridViewTextBoxColumn.HeaderText = "鼠标";
            this.鼠标DataGridViewTextBoxColumn.Name = "鼠标DataGridViewTextBoxColumn";
            this.鼠标DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 电源DataGridViewTextBoxColumn
            // 
            this.电源DataGridViewTextBoxColumn.DataPropertyName = "电源";
            this.电源DataGridViewTextBoxColumn.HeaderText = "电源";
            this.电源DataGridViewTextBoxColumn.Name = "电源DataGridViewTextBoxColumn";
            this.电源DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "总计";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // proposalBindingSource1
            // 
            this.proposalBindingSource1.DataMember = "proposal";
            this.proposalBindingSource1.DataSource = this.pC_ManagerDataSet11;
            // 
            // pC_ManagerDataSet11
            // 
            this.pC_ManagerDataSet11.DataSetName = "PC_ManagerDataSet11";
            this.pC_ManagerDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proposalTableAdapter1
            // 
            this.proposalTableAdapter1.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.comboBox1.DataSource = this.orderlistBindingSource;
            this.comboBox1.DisplayMember = "remark";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(301, 418);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(252, 20);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "oid";
            // 
            // pC_ManagerDataSet12
            // 
            this.pC_ManagerDataSet12.DataSetName = "PC_ManagerDataSet12";
            this.pC_ManagerDataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderTableAdapter
            // 
            this.orderTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(559, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "生成订单";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pC_ManagerDataSet15
            // 
            this.pC_ManagerDataSet15.DataSetName = "PC_ManagerDataSet15";
            this.pC_ManagerDataSet15.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderlistBindingSource
            // 
            this.orderlistBindingSource.DataMember = "order_list";
            this.orderlistBindingSource.DataSource = this.pC_ManagerDataSet15;
            // 
            // order_listTableAdapter
            // 
            this.order_listTableAdapter.ClearBeforeFill = true;
            // 
            // Proposal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Proposal";
            this.Text = "Proposal";
            this.Load += new System.EventHandler(this.Proposal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proposalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proposalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pC_ManagerDataSet15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderlistBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PC_ManagerDataSet10 pC_ManagerDataSet10;
        private System.Windows.Forms.BindingSource proposalBindingSource;
        private PC_ManagerDataSet10TableAdapters.proposalTableAdapter proposalTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private PC_ManagerDataSet11 pC_ManagerDataSet11;
        private System.Windows.Forms.BindingSource proposalBindingSource1;
        private PC_ManagerDataSet11TableAdapters.proposalTableAdapter proposalTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private PC_ManagerDataSet12 pC_ManagerDataSet12;
        private PC_ManagerDataSet12TableAdapters.orderTableAdapter orderTableAdapter;
        private System.Windows.Forms.Button button1;
        private PC_ManagerDataSet15 pC_ManagerDataSet15;
        private System.Windows.Forms.BindingSource orderlistBindingSource;
        private PC_ManagerDataSet15TableAdapters.order_listTableAdapter order_listTableAdapter;
    }
}