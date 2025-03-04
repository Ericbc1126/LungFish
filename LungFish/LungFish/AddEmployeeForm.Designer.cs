namespace LungFish
{
    partial class AddEmployeeForm
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
            this.txtEmployeeName = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.btnConfirmAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEmployeeName
            // 
            this.txtEmployeeName.Location = new System.Drawing.Point(12, 12);
            this.txtEmployeeName.Name = "txtEmployeeName";
            this.txtEmployeeName.Size = new System.Drawing.Size(100, 28);
            this.txtEmployeeName.TabIndex = 0;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(137, 12);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.Size = new System.Drawing.Size(100, 28);
            this.txtDepartment.TabIndex = 1;
            // 
            // btnConfirmAdd
            // 
            this.btnConfirmAdd.Location = new System.Drawing.Point(36, 286);
            this.btnConfirmAdd.Name = "btnConfirmAdd";
            this.btnConfirmAdd.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAdd.TabIndex = 2;
            this.btnConfirmAdd.Text = "确认";
            this.btnConfirmAdd.UseVisualStyleBackColor = true;
            this.btnConfirmAdd.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmAdd);
            this.Controls.Add(this.txtDepartment);
            this.Controls.Add(this.txtEmployeeName);
            this.Name = "AddEmployeeForm";
            this.Text = "AddEmployeeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmployeeName;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.Button btnConfirmAdd;
    }
}