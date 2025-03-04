using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;
using OfficeOpenXml;

namespace LungFish
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            DataTable shiftTable = GetShiftTable();

            // 生成临时文件路径，用于保存班表图片
            string imagePath = Path.Combine(Path.GetTempPath(), "shift_schedule.png");

            // 调用 GenerateShiftScheduleImage 方法生成班表图片
            GenerateShiftScheduleImage(shiftTable, imagePath);

            // 创建预览窗体实例，并传递图片路径
            PreviewForm previewForm = new PreviewForm(imagePath);
            previewForm.ShowDialog(); // 以模态对话框的形式显示预览窗体
        }

        private DataTable GetShiftTable()
        {
            // 这里需要实现获取排好的班表数据的逻辑
            // 可以从前面的排班结果中获取数据并返回一个 DataTable 对象
            // 例如，假设前面的排班结果存储在某个类的静态属性中
            return SomeClass.ShiftScheduleTable;
        }

        private void GenerateShiftScheduleImage(DataTable shiftTable, string imagePath)
        {
            // 确定图片的宽度和高度
            int width = 800;
            int height = shiftTable.Rows.Count * 30 + 50; // 根据班表行数计算高度

            // 创建一个 Bitmap 对象，它代表了一个位图图像
            Bitmap bitmap = new Bitmap(width, height);

            // 创建一个 Graphics 对象，用于在 Bitmap 上进行绘制操作
            using (Graphics g = Graphics.FromImage(bitmap))
            {
                // 设置背景颜色为白色
                g.Clear(Color.White);

                // 定义表头的字体和画刷
                Font headerFont = new Font("Arial", 12, FontStyle.Bold);
                Brush headerBrush = Brushes.Black;

                // 绘制表头
                for (int i = 0; i < shiftTable.Columns.Count; i++)
                {
                    g.DrawString(shiftTable.Columns[i].ColumnName, headerFont, headerBrush, new PointF(10 + i * 150, 10));
                }

                // 定义表格内容的字体
                Font cellFont = new Font("Arial", 10);

                // 绘制表格内容
                for (int row = 0; row < shiftTable.Rows.Count; row++)
                {
                    for (int col = 0; col < shiftTable.Columns.Count; col++)
                    {
                        g.DrawString(shiftTable.Rows[row][col].ToString(), cellFont, headerBrush, new PointF(10 + col * 150, 40 + row * 30));
                    }
                }
            }

            // 保存生成的图片
            bitmap.Save(imagePath, ImageFormat.Png);
            bitmap.Dispose(); // 释放 Bitmap 对象占用的资源
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel 文件|*.xlsx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                DataTable shiftTable = GetShiftTable();
                if (shiftTable.Rows.Count == 0)
                {
                    MessageBox.Show("没有可导出的班表数据，请先进行排班。", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                try
                {
                    using (ExcelPackage package = new ExcelPackage())
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("班表");

                        // 写入表头
                        for (int col = 0; col < shiftTable.Columns.Count; col++)
                        {
                            worksheet.Cells[1, col + 1].Value = shiftTable.Columns[col].ColumnName;
                        }

                        // 写入表格内容
                        for (int row = 0; row < shiftTable.Rows.Count; row++)
                        {
                            for (int col = 0; col < shiftTable.Columns.Count; col++)
                            {
                                worksheet.Cells[row + 2, col + 1].Value = shiftTable.Rows[row][col].ToString();
                            }
                        }

                        // 日期列格式处理
                        // 假设日期列的索引为 2
                        for (int row = 0; row < shiftTable.Rows.Count; row++)
                        {
                            if (shiftTable.Rows[row][2] != DBNull.Value)
                            {
                                DateTime date = Convert.ToDateTime(shiftTable.Rows[row][2]);
                                worksheet.Cells[row + 2, 3].Value = date;
                                worksheet.Cells[row + 2, 3].Style.Numberformat.Format = "yyyy-MM-dd";
                            }
                        }

                        FileInfo file = new FileInfo(saveFileDialog.FileName);
                        package.SaveAs(file);
                    }

                    MessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (IOException)
                {
                    MessageBox.Show("无法保存文件，请确保文件未被占用或有足够的权限。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"导出过程中出现未知错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

