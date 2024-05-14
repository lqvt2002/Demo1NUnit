using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo1NUnit
{
    public partial class Form1 : Form
    {
        xuLyTinhToan xulytinhtoan;
        public Form1()
        {
            InitializeComponent();
            xulytinhtoan = new xuLyTinhToan();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string inputA = txtbA.Text; // Lấy dữ liệu từ TextBox A
            string inputB = txtbB.Text; // Lấy dữ liệu từ TextBox B

            if (xulytinhtoan.isNumber(inputA) && xulytinhtoan.isNumber(inputB))
            {
                int a = Int32.Parse(inputA); // Ép kiểu dữ liệu từ TextBox A thành kiểu số nguyên
                int b = Int32.Parse(inputB); // Ép kiểu dữ liệu từ TextBox B thành kiểu số nguyên
                ketqua.Text = xulytinhtoan.TinhTongHaiSo(a, b).ToString();
            }
            else
            {
                ketqua.Text = "Không hợp lệ";
            }

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
