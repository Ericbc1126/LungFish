namespace LungFish
{
    partial class AddDepartmentForm
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
            this.txtDepartmentName = new System.Windows.Forms.TextBox();
            this.txtMorningShiftCount = new System.Windows.Forms.TextBox();
            this.txtNormalShiftCount = new System.Windows.Forms.TextBox();
            this.txtEveningShiftCount = new System.Windows.Forms.TextBox();
            this.btnConfirmAddDepartment = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDepartmentName
            // 
            this.txtDepartmentName.Location = new System.Drawing.Point(12, 12);
            this.txtDepartmentName.Name = "txtDepartmentName";
            this.txtDepartmentName.Size = new System.Drawing.Size(100, 28);
            this.txtDepartmentName.TabIndex = 0;
            this.txtDepartmentName.Text = "部门名";
            this.txtDepartmentName.TextChanged += new System.EventHandler(this.txtDepartmentName_TextChanged);
            // 
            // txtMorningShiftCount
            // 
            this.txtMorningShiftCount.Location = new System.Drawing.Point(118, 12);
            this.txtMorningShiftCount.Name = "txtMorningShiftCount";
            this.txtMorningShiftCount.Size = new System.Drawing.Size(100, 28);
            this.txtMorningShiftCount.TabIndex = 1;
            this.txtMorningShiftCount.Text = "早班人数";
            this.txtMorningShiftCount.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNormalShiftCount
            // 
            this.txtNormalShiftCount.Location = new System.Drawing.Point(330, 12);
            this.txtNormalShiftCount.Name = "txtNormalShiftCount";
            this.txtNormalShiftCount.Size = new System.Drawing.Size(100, 28);
            this.txtNormalShiftCount.TabIndex = 3;
            this.txtNormalShiftCount.Text = "正常班人数";
            // 
            // txtEveningShiftCount
            // 
            this.txtEveningShiftCount.Location = new System.Drawing.Point(224, 12);
            this.txtEveningShiftCount.Name = "txtEveningShiftCount";
            this.txtEveningShiftCount.Size = new System.Drawing.Size(100, 28);
            this.txtEveningShiftCount.TabIndex = 2;
            this.txtEveningShiftCount.Text = "晚班人数";
            // 
            // btnConfirmAddDepartment
            // 
            this.btnConfirmAddDepartment.Location = new System.Drawing.Point(661, 341);
            this.btnConfirmAddDepartment.Name = "btnConfirmAddDepartment";
            this.btnConfirmAddDepartment.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddDepartment.TabIndex = 4;
            this.btnConfirmAddDepartment.Text = "确认";
            this.btnConfirmAddDepartment.UseVisualStyleBackColor = true;
            this.btnConfirmAddDepartment.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddDepartmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmAddDepartment);
            this.Controls.Add(this.txtNormalShiftCount);
            this.Controls.Add(this.txtEveningShiftCount);
            this.Controls.Add(this.txtMorningShiftCount);
            this.Controls.Add(this.txtDepartmentName);
            this.Name = "AddDepartmentForm";
            this.Text = "AddDepartmentForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDepartmentName;
        private System.Windows.Forms.TextBox txtMorningShiftCount;
        private System.Windows.Forms.TextBox txtNormalShiftCount;
        private System.Windows.Forms.TextBox txtEveningShiftCount;
        private System.Windows.Forms.Button btnConfirmAddDepartment;
    }
}