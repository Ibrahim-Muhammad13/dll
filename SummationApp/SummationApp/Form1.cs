using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummationApp
{
    public partial class Form1 : Form
    {
        [DllImport("C:\\Users\\DELL\\source\\repos\\MathLibrary\\x64\\Debug\\MathLibrary.dll")]
        public static extern int result(int a, int b);
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int FirstNumber = Convert.ToInt32(textBox1.Text);
            int SecondNumber = Convert.ToInt32(textBox2.Text);
   
            int ans = result(FirstNumber, SecondNumber);
            button1.Text = ans.ToString();    
        }
    }
}
