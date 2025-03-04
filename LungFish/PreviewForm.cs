using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace LungFish
{
    public partial class PreviewForm : Form
    {
        public PreviewForm(string imagePath)
        {
            InitializeComponent();
            try
            {
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = Image.FromFile(imagePath);
                }
                else
                {
                    MessageBox.Show("图片文件不存在，请检查！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
            catch (OutOfMemoryException)
            {
                MessageBox.Show("无法加载图片，可能是文件损坏或内存不足。", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"加载图片时出现未知错误：{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); // 关闭预览窗体
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PreviewForm_Load(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                pictureBox1.Image.Dispose();
                pictureBox1.Image = null;
            }
        }
    }
}
