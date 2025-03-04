namespace LungFish
{
    partial class AddShiftForm
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
            this.txtMorningShiftTime = new System.Windows.Forms.TextBox();
            this.txtEveningShiftTime = new System.Windows.Forms.TextBox();
            this.txtNormalShiftTime = new System.Windows.Forms.TextBox();
            this.btnConfirmAddShift = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMorningShiftTime
            // 
            this.txtMorningShiftTime.Location = new System.Drawing.Point(12, 12);
            this.txtMorningShiftTime.Name = "txtMorningShiftTime";
            this.txtMorningShiftTime.Size = new System.Drawing.Size(100, 28);
            this.txtMorningShiftTime.TabIndex = 0;
            this.txtMorningShiftTime.Text = "早班时间";
            this.txtMorningShiftTime.TextChanged += new System.EventHandler(this.txtMorningShiftTime_TextChanged);
            // 
            // txtEveningShiftTime
            // 
            this.txtEveningShiftTime.Location = new System.Drawing.Point(118, 12);
            this.txtEveningShiftTime.Name = "txtEveningShiftTime";
            this.txtEveningShiftTime.Size = new System.Drawing.Size(100, 28);
            this.txtEveningShiftTime.TabIndex = 1;
            this.txtEveningShiftTime.Text = "晚班时间";
            this.txtEveningShiftTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtNormalShiftTime
            // 
            this.txtNormalShiftTime.Location = new System.Drawing.Point(225, 11);
            this.txtNormalShiftTime.Name = "txtNormalShiftTime";
            this.txtNormalShiftTime.Size = new System.Drawing.Size(100, 28);
            this.txtNormalShiftTime.TabIndex = 2;
            this.txtNormalShiftTime.Text = "正常班时间";
            this.txtNormalShiftTime.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btnConfirmAddShift
            // 
            this.btnConfirmAddShift.Location = new System.Drawing.Point(713, 321);
            this.btnConfirmAddShift.Name = "btnConfirmAddShift";
            this.btnConfirmAddShift.Size = new System.Drawing.Size(75, 23);
            this.btnConfirmAddShift.TabIndex = 3;
            this.btnConfirmAddShift.Text = "确认";
            this.btnConfirmAddShift.UseVisualStyleBackColor = true;
            this.btnConfirmAddShift.Click += new System.EventHandler(this.btnConfirmAddShift_Click);
            // 
            // AddShiftForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmAddShift);
            this.Controls.Add(this.txtNormalShiftTime);
            this.Controls.Add(this.txtEveningShiftTime);
            this.Controls.Add(this.txtMorningShiftTime);
            this.Name = "AddShiftForm";
            this.Text = "AddShiftForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMorningShiftTime;
        private System.Windows.Forms.TextBox txtEveningShiftTime;
        private System.Windows.Forms.TextBox txtNormalShiftTime;
        private System.Windows.Forms.Button btnConfirmAddShift;
    }
}