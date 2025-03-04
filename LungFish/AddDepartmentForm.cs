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
    public partial class AddDepartmentForm : Form
    {
        public AddDepartmentForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDepartmentName_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("确定要删除选中的行吗？", "确认删除", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                {
                    if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                    {
                        dataGridView1.Rows.RemoveAt(i);
                    }
                }
            }
        }
    }
}
