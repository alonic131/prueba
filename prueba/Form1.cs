using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba
{
    public partial class Form1 : Form
    {
        int[] nums = { };
        string resultado = "";
        int num1;
        int num2;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtGuardar_Click(object sender, EventArgs e)
        {
            string Num1 = textBox2.Text;
            nums = nums.Append(Int32.Parse(Num1)).ToArray();
            Array.Sort(nums);
            listBox1.Items.Clear();
            for (int i = 0; i < nums.Length; i++)
            {
                listBox1.Items.Add(  $"{i+1}                    {nums[i]}");
            }
            num2 = nums[0];
            num1 = nums[nums.Length-1];
            label4.Text = num1.ToString();
            label5.Text = num2.ToString();

            textBox2.Text = "";
        }

        private void Resultado_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
