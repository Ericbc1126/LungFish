namespace LungFish
{
    partial class Form2
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.编号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部门名 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.早班人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.晚班人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.正常班人数 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddDepartment = new System.Windows.Forms.Button();
            this.btnDeleteDepartment = new System.Windows.Forms.Button();
            this.btnConfirm2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.部门名,
            this.早班人数,
            this.晚班人数,
            this.正常班人数});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // 编号
            // 
            this.编号.HeaderText = "编号";
            this.编号.MinimumWidth = 8;
            this.编号.Name = "编号";
            this.编号.Width = 150;
            // 
            // 部门名
            // 
            this.部门名.HeaderText = "部门名";
            this.部门名.MinimumWidth = 8;
            this.部门名.Name = "部门名";
            this.部门名.Width = 150;
            // 
            // 早班人数
            // 
            this.早班人数.HeaderText = "早班人数";
            this.早班人数.MinimumWidth = 8;
            this.早班人数.Name = "早班人数";
            this.早班人数.Width = 150;
            // 
            // 晚班人数
            // 
            this.晚班人数.HeaderText = "晚班人数";
            this.晚班人数.MinimumWidth = 8;
            this.晚班人数.Name = "晚班人数";
            this.晚班人数.Width = 150;
            // 
            // 正常班人数
            // 
            this.正常班人数.HeaderText = "正常班人数";
            this.正常班人数.MinimumWidth = 8;
            this.正常班人数.Name = "正常班人数";
            this.正常班人数.Width = 150;
            // 
            // btnAddDepartment
            // 
            this.btnAddDepartment.Location = new System.Drawing.Point(12, 305);
            this.btnAddDepartment.Name = "btnAddDepartment";
            this.btnAddDepartment.Size = new System.Drawing.Size(98, 23);
            this.btnAddDepartment.TabIndex = 1;
            this.btnAddDepartment.Text = "添加部门";
            this.btnAddDepartment.UseVisualStyleBackColor = true;
            this.btnAddDepartment.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDeleteDepartment
            // 
            this.btnDeleteDepartment.Location = new System.Drawing.Point(116, 305);
            this.btnDeleteDepartment.Name = "btnDeleteDepartment";
            this.btnDeleteDepartment.Size = new System.Drawing.Size(98, 23);
            this.btnDeleteDepartment.TabIndex = 2;
            this.btnDeleteDepartment.Text = "删除部门";
            this.btnDeleteDepartment.UseVisualStyleBackColor = true;
            this.btnDeleteDepartment.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnConfirm2
            // 
            this.btnConfirm2.Location = new System.Drawing.Point(663, 305);
            this.btnConfirm2.Name = "btnConfirm2";
            this.btnConfirm2.Size = new System.Drawing.Size(75, 23);
            this.btnConfirm2.TabIndex = 3;
            this.btnConfirm2.Text = "确认";
            this.btnConfirm2.UseVisualStyleBackColor = true;
            this.btnConfirm2.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm2);
            this.Controls.Add(this.btnDeleteDepartment);
            this.Controls.Add(this.btnAddDepartment);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部门名;
        private System.Windows.Forms.DataGridViewTextBoxColumn 早班人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 晚班人数;
        private System.Windows.Forms.DataGridViewTextBoxColumn 正常班人数;
        private System.Windows.Forms.Button btnAddDepartment;
        private System.Windows.Forms.Button btnDeleteDepartment;
        private System.Windows.Forms.Button btnConfirm2;
    }
}