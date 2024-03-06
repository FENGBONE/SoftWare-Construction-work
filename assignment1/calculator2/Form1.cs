using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator2
{
    public partial class Form1 : Form
    {
        int a;
        int b;
        int num;  //局部变量就近定义
        public Form1()
        {
            InitializeComponent();
        }

        //减法按钮点击事件
        private void button5_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            num = a - b;
           // label1.Text = num.ToString();
        }


        //Button改为radioButton

        //加法按钮点击事件       
        private void button1_Click(object sender, EventArgs e)
        {
            a=int.Parse(textBox1.Text);
            b=int.Parse(textBox2.Text);
            num = a + b;
           // label1.Text = num.ToString();
        }

        //乘法按钮点击事件
        private void button2_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);//异常处理
            num = a * b;
           // label1.Text = num.ToString();
        }
        //除法按钮点击事件
        private void button3_Click(object sender, EventArgs e)
        {
            a = int.Parse(textBox1.Text);
            b = int.Parse(textBox2.Text);
            if (b != 0)
            {
                num = a / b;
            }
            
            //label1.Text = num.ToString();
        }

        //等号按钮点击事件
        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = num.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
