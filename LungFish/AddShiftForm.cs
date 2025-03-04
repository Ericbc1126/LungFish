using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LungFish
{
    public partial class AddShiftForm : Form
    {
        public AddShiftForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMorningShiftTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConfirmAddShift_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMorningShiftTime.Text) ||
        string.IsNullOrEmpty(txtEveningShiftTime.Text) ||
        string.IsNullOrEmpty(txtNormalShiftTime.Text))
            {
                MessageBox.Show("请输入完整的班次时间信息！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
