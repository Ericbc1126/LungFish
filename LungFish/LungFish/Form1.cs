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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    dataGridView1.Rows.RemoveAt(i);
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            bool hasSelected = false;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    hasSelected = true;
                    break;
                }
            }
            if (hasSelected)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.ShowDialog();
                this.Show();
            }
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
        
            AddEmployeeForm addForm = new AddEmployeeForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                int newRowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[newRowIndex].Cells[1].Value = addForm.txtEmployeeName.Text;
                dataGridView1.Rows[newRowIndex].Cells[2].Value = addForm.txtDepartment.Text;
                dataGridView1.Rows[newRowIndex].Cells[0].Value = false;
            }
        
        }
    }
}
