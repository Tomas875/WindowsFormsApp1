using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //konstantos
        public int clicks = 0;
        public int[] numArray = new int[10];
        public int sum = 0;
        public Form1()
        {
            InitializeComponent();
        }
        //tikrinimas ar ivesti skaiciai
        bool check(string text)
        {
            return String.IsNullOrWhiteSpace(text);
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            string num = textBox1.Text;
            if(check(num))
            {
                textBox1.Text = "Ivestas ne skaicius";
            }
            else 
            {
                //skaiciuoja kiek kartu paspausta
                int b = Convert.ToInt32(num);
                numArray[clicks] = b;
                clicks++;
                label2.Text = "Iveskite dar " + (10 - clicks) + " skaicius";
                if (clicks == numArray.Length)
                {
                    //raso i masyva
                    for (int i = 0; i < numArray.Length; i++)
                    {
                        sum += numArray[i];
                    }

                    label2.Text = "Jusu atsakymas yra:     Galite per naujo vesti skaicius";
                    textBox1.Text = sum.ToString();
                    sum = 0;
                    clicks = 0;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string layer = textBox2.Text;
            if (check(layer))
            {
                richTextBox1.Text = "Ivestas ne skaicius";
            }
            else
            {
                richTextBox1.Text = "";
                int star = 1;
                int a = Convert.ToInt32(layer);
                int layers = a;
                for(int i = 0; i < a; i++)
                {
                    for (int j = 0; j < layers; j++)
                    {
                        richTextBox1.Text += " ";
                    }
                    for(int j = 0; j < star; j++)
                    {
                        richTextBox1.Text += "* ";
                    }
                    richTextBox1.Text += "\n";
                    star++;
                    layers--;
                }
            }
        }
    }
}
