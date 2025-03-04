using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LungFish
{
    public class ShiftScheduler
    {
        public List<ShiftAssignment> ScheduleShifts(List<Employee> employees, List<Department> departments, List<Shift> shifts)
        {
            List<ShiftAssignment> assignments = new List<ShiftAssignment>();

            // 遍历每个部门
            foreach (var department in departments)
            {
                // 获取该部门的员工
                var departmentEmployees = employees.Where(e => e.Department == department.Name).ToList();

                // 遍历每个班次
                foreach (var shift in shifts)
                {
                    int morningShiftCount = int.Parse(department.MorningShiftCount);
                    int eveningShiftCount = int.Parse(department.EveningShiftCount);
                    int normalShiftCount = int.Parse(department.NormalShiftCount);

                    int totalShiftCount = morningShiftCount + eveningShiftCount + normalShiftCount;

                    if (departmentEmployees.Count > totalShiftCount)
                    {
                        // 员工人数超过班次总人数，随机安排一名员工休息
                        Random random = new Random();
                        int indexToRest = random.Next(0, departmentEmployees.Count);
                        var employeeToRest = departmentEmployees[indexToRest];
                        departmentEmployees.RemoveAt(indexToRest);
                    }

                    // 分配早班
                    for (int i = 0; i < morningShiftCount && i < departmentEmployees.Count; i++)
                    {
                        assignments.Add(new ShiftAssignment
                        {
                            Employee = departmentEmployees[i],
                            Shift = shift,
                            ShiftType = ShiftType.Morning
                        });
                    }

                    // 分配晚班
                    for (int i = morningShiftCount; i < morningShiftCount + eveningShiftCount && i < departmentEmployees.Count; i++)
                    {
                        assignments.Add(new ShiftAssignment
                        {
                            Employee = departmentEmployees[i],
                            Shift = shift,
                            ShiftType = ShiftType.Evening
                        });
                    }

                    // 分配正常班
                    for (int i = morningShiftCount + eveningShiftCount; i < totalShiftCount && i < departmentEmployees.Count; i++)
                    {
                        assignments.Add(new ShiftAssignment
                        {
                            Employee = departmentEmployees[i],
                            Shift = shift,
                            ShiftType = ShiftType.Normal
                        });
                    }
                }
            }

            // 确保每个员工月休息天数为 6 天（这里只是简单示例，实际可能需要更复杂的逻辑）
            foreach (var employee in employees)
            {
                int restDays = 6;
                var employeeAssignments = assignments.Where(a => a.Employee == employee).ToList();
                while (restDays > 0 && employeeAssignments.Count > 0)
                {
                    Random random = new Random();
                    int indexToRemove = random.Next(0, employeeAssignments.Count);
                    assignments.Remove(employeeAssignments[indexToRemove]);
                    employeeAssignments.RemoveAt(indexToRemove);
                    restDays--;
                }
            }

            return assignments;
        }
    }

    public class Employee
    {
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public class Department
    {
        public string Name { get; set; }
        public string MorningShiftCount { get; set; }
        public string EveningShiftCount { get; set; }
        public string NormalShiftCount { get; set; }
    }

    public class Shift
    {
        public string MorningShiftTime { get; set; }
        public string EveningShiftTime { get; set; }
        public string NormalShiftTime { get; set; }
    }

    public class ShiftAssignment
    {
        public Employee Employee { get; set; }
        public Shift Shift { get; set; }
        public ShiftType ShiftType { get; set; }
    }

    public enum ShiftType
    {
        Morning,
        Evening,
        Normal
    }
}
