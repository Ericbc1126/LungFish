using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LungFish;

namespace LungFish
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        private void btnConfirm3_Click(object sender, EventArgs e)
        {
            // 检查是否有选中的行
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
                // 显示等待界面
                WaitForm waitForm = new WaitForm();
                waitForm.Show();

                this.Enabled = false;

                // 设置超时定时器
                timeoutTimer = new System.Timers.Timer(60000); // 超时时间为 60 秒
                timeoutTimer.Elapsed += TimeoutTimer_Elapsed;
                timeoutTimer.Start();

                try
                {
                    // 获取用户选择的员工、部门和班次信息
                    List<Employee> selectedEmployees = GetSelectedEmployees();
                    List<Department> selectedDepartments = GetSelectedDepartments();
                    List<Shift> selectedShifts = GetSelectedShifts();

                    // 调用排班方法
                    ShiftScheduler scheduler = new ShiftScheduler();
                    List<ShiftAssignment> assignments = scheduler.ScheduleShifts(selectedEmployees, selectedDepartments, selectedShifts);
                }
                catch (Exception ex)
                {
                    // 处理异常，比如显示错误信息
                    MessageBox.Show($"排班过程中出现错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    timeoutTimer.Stop();
                    timeoutTimer.Dispose();
                    // 关闭等待界面
                    waitForm.Close();

                    this.Enabled = true;
                }
                // 保存排班结果（这里可以根据需要将结果保存到文件或数据库）

                // 跳转到第四界面
                Form4 form4 = new Form4();
                this.Hide();
                form4.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("请至少选择一行数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void TimeoutTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            // 超时处理
            timeoutTimer.Stop();
            timeoutTimer.Dispose();

            this.Invoke((MethodInvoker)delegate
            {
                waitForm.Close();
                this.Enabled = true;
                MessageBox.Show("排班操作超时，请稍后重试。", "超时提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            });
        }

        private List<Employee> GetSelectedEmployees()
        {
            List<Employee> employees = new List<Employee>();
            // 假设 Form1 中存储了员工信息，这里需要根据实际情况获取
            // 可以通过静态变量、全局对象或者方法传递等方式获取
            // 以下是简单示例，需要根据实际代码调整
            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (form1 != null)
            {
                for (int i = 0; i < form1.dataGridView1.Rows.Count; i++)
                {
                    if (Convert.ToBoolean(form1.dataGridView1.Rows[i].Cells[0].Value))
                    {
                        employees.Add(new Employee
                        {
                            Name = form1.dataGridView1.Rows[i].Cells[1].Value.ToString(),
                            Department = form1.dataGridView1.Rows[i].Cells[2].Value.ToString()
                        });
                    }
                }
            }
            return employees;
        }

        private List<Department> GetSelectedDepartments()
        {
            List<Department> departments = new List<Department>();
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    departments.Add(new Department
                    {
                        Name = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        MorningShiftCount = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        EveningShiftCount = dataGridView1.Rows[i].Cells[3].Value.ToString(),
                        NormalShiftCount = dataGridView1.Rows[i].Cells[4].Value.ToString()
                    });
                }
            }
            return departments;
        }

        private List<Shift> GetSelectedShifts()
        {
            List<Shift> shifts = new List<Shift>();
            // 假设这里获取班次信息的方式与部门信息类似，根据实际情况调整
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[0].Value))
                {
                    shifts.Add(new Shift
                    {
                        MorningShiftTime = dataGridView1.Rows[i].Cells[1].Value.ToString(),
                        EveningShiftTime = dataGridView1.Rows[i].Cells[2].Value.ToString(),
                        NormalShiftTime = dataGridView1.Rows[i].Cells[3].Value.ToString()
                    });
                }
            }
            return shifts;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddShiftForm addShiftForm = new AddShiftForm();
            if (addShiftForm.ShowDialog() == DialogResult.OK)
            {
                int newRowIndex = dataGridView1.Rows.Add();
                dataGridView1.Rows[newRowIndex].Cells[1].Value = addShiftForm.txtMorningShiftTime.Text;
                dataGridView1.Rows[newRowIndex].Cells[2].Value = addShiftForm.txtEveningShiftTime.Text;
                dataGridView1.Rows[newRowIndex].Cells[3].Value = addShiftForm.txtNormalShiftTime.Text;
                dataGridView1.Rows[newRowIndex].Cells[0].Value = false;
            }
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteShift_Click(object sender, EventArgs e)
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
