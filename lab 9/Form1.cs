using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab_9
{
    public partial class Form1 : Form
    {
        int index, index1;
        ComplexNumber n1, n2, res;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            createNumber();
            calculate();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            index = comboBox1.SelectedIndex;                      
        }

        //Equals
        private void button4_Click(object sender, EventArgs e)
        {
            createNumber();
            result.Text = $"{n1.Equals(n2)}";
        }

        //GetHashCode
        private void button3_Click(object sender, EventArgs e)
        {
            createNumber();
            result.Text = $"{n1.GetHashCode()}\n{n2.GetHashCode()}";
        }

        //Convert
        private void button2_Click(object sender, EventArgs e)
        {
            
            switch (index1)
            {
                case 0:
                    createNumber();
                    result.Text = $"{Convert.ToInt32(n1)}\n{Convert.ToInt32(n2)}";
                    break;

                case 1:
                    n1 = new ComplexNumber(Double.Parse(textBox1.Text), 0);
                    n2 = new ComplexNumber(Double.Parse(textBox3.Text), 0);
                    result.Text = $"{n1.getNumber()} + {n1.getComplexNumber()}i\n" +
                        $"{n2.getNumber()} + {n2.getComplexNumber()}i";                   
                    textBox2.Enabled = true;                    
                    textBox4.Enabled = true;
                    break;
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            index1 = comboBox2.SelectedIndex;
            if(index1 == 1)
            {
                textBox2.Enabled = false;               
                textBox4.Enabled = false;
            }
        }

        public void createNumber()
        {
            n1 = new ComplexNumber(Double.Parse(textBox1.Text), Double.Parse(textBox2.Text));
            n2 = new ComplexNumber(Double.Parse(textBox3.Text), Double.Parse(textBox4.Text));
        }

        public void calculate()
        {
            switch (index)
            {
                case 0:
                    res = n1 + n2;
                    if(res.getComplexNumber() > 0)
                        result.Text = $"{res.getNumber()} + {res.getComplexNumber()}i";
                    else
                        result.Text = $"{res.getNumber()} {res.getComplexNumber()}i";
                    break;

                case 1:
                    res = n1 - n2;
                    if (res.getComplexNumber() > 0)
                        result.Text = $"{res.getNumber()} + {res.getComplexNumber()}i";
                    else
                        result.Text = $"{res.getNumber()} {res.getComplexNumber()}i";
                    break;

                case 2:
                    res = n1 * n2;
                    if (res.getComplexNumber() > 0)
                        result.Text = $"{res.getNumber()} + {res.getComplexNumber()}i";
                    else
                        result.Text = $"{res.getNumber()} {res.getComplexNumber()}i";
                    break;

                case 3:
                    res = n1 / n2;
                    if (res.getComplexNumber() > 0)
                        result.Text = $"{res.getNumber()} + {res.getComplexNumber()}i";
                    else
                        result.Text = $"{res.getNumber()} {res.getComplexNumber()}i";
                    break;

                case 4:
                    result.Text = $"{n1 == n2}";
                    break;

                case 5:
                    result.Text = $"{n1 != n2}";
                    break;

                case 6:
                    result.Text = $"{n1 > n2}";
                    break;

                case 7:
                    result.Text = $"{n1 < n2}";
                    break;
            }

            
        }
    }
}
/*
indekser (element nr 0 to część rzeczywista, a element nr 1 to część urojona)
indekser (element nr 'r' to część rzeczywista, a element nr 'i' to część urojona)
 */