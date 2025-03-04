namespace LungFish
{
    partial class Form3
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
            this.早班时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.晚班时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.正常班时间 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnDeleteShift = new System.Windows.Forms.Button();
            this.btnConfirm3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.编号,
            this.早班时间,
            this.晚班时间,
            this.正常班时间});
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
            // 早班时间
            // 
            this.早班时间.HeaderText = "早班时间";
            this.早班时间.MinimumWidth = 8;
            this.早班时间.Name = "早班时间";
            this.早班时间.Width = 150;
            // 
            // 晚班时间
            // 
            this.晚班时间.HeaderText = "晚班时间";
            this.晚班时间.MinimumWidth = 8;
            this.晚班时间.Name = "晚班时间";
            this.晚班时间.Width = 150;
            // 
            // 正常班时间
            // 
            this.正常班时间.HeaderText = "正常班时间";
            this.正常班时间.MinimumWidth = 8;
            this.正常班时间.Name = "正常班时间";
            this.正常班时间.Width = 150;
            // 
            // btnAddShift
            // 
            this.btnAddShift.Location = new System.Drawing.Point(12, 311);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(93, 23);
            this.btnAddShift.TabIndex = 1;
            this.btnAddShift.Text = "添加班次";
            this.btnAddShift.UseVisualStyleBackColor = true;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnDeleteShift
            // 
            this.btnDeleteShift.Location = new System.Drawing.Point(111, 311);
            this.btnDeleteShift.Name = "btnDeleteShift";
            this.btnDeleteShift.Size = new System.Drawing.Size(93, 23);
            this.btnDeleteShift.TabIndex = 2;
            this.btnDeleteShift.Text = "删除班次";
            this.btnDeleteShift.UseVisualStyleBackColor = true;
            this.btnDeleteShift.Click += new System.EventHandler(this.btnDeleteShift_Click);
            // 
            // btnConfirm3
            // 
            this.btnConfirm3.Location = new System.Drawing.Point(695, 311);
            this.btnConfirm3.Name = "btnConfirm3";
            this.btnConfirm3.Size = new System.Drawing.Size(93, 23);
            this.btnConfirm3.TabIndex = 3;
            this.btnConfirm3.Text = "确认";
            this.btnConfirm3.UseVisualStyleBackColor = true;
            this.btnConfirm3.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirm3);
            this.Controls.Add(this.btnDeleteShift);
            this.Controls.Add(this.btnAddShift);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 编号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 早班时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 晚班时间;
        private System.Windows.Forms.DataGridViewTextBoxColumn 正常班时间;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnDeleteShift;
        private System.Windows.Forms.Button btnConfirm3;
    }
}