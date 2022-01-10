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
        int index;
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
konwersja liczby zespolonej na double i z double na liczbę zespoloną
indekser (element nr 0 to część rzeczywista, a element nr 1 to część urojona)
indekser (element nr 'r' to część rzeczywista, a element nr 'i' to część urojona)
Equals( ) i GetHashCode( )
 */