using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class kalkulator : Form
    {
        int cache = 0, rezCache = 0, napaka = 0;
        double rezultat = 0;
        char opSelect;

        public kalkulator()
        {
            InitializeComponent();
            result.Select();
        }

        public void nums(string num)
        {
            if (rezCache == 1)
            {
                displayBottom.Text = "";
                displayUpper.Text = "";
                rezultat = 0;
                rezCache = 0;
                displayBottom.Text += num;
            }
            else
                displayBottom.Text += num;
        }

        public void operacija(char opCache)
        {
            try
            {
                switch (opCache)
                {
                    case '+':
                        rezultat = rezultat + Convert.ToDouble(displayBottom.Text);
                        break;

                    case '-':
                        rezultat = rezultat - Convert.ToDouble(displayBottom.Text);
                        break;

                    case '✕':
                        rezultat = rezultat * Convert.ToDouble(displayBottom.Text);
                        break;

                    case '÷':
                        if(Convert.ToDouble(displayBottom.Text) == 0)
                        {
                            MessageBox.Show("Napaka.");
                            deleteAll.PerformClick();
                            napaka = 1;
                            break;
                        }
                        rezultat = rezultat / Convert.ToDouble(displayBottom.Text);
                        break;

                    default:
                        break;
                }
            }
            catch(OverflowException)
            {
                MessageBox.Show("Preveliko število.");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Napaka." + ex.Message);
            }
            
        }

        private void deleteChar_Click(object sender, EventArgs e)
        {

            if (displayBottom.Text == "" && displayUpper.Text == "")
            {

            }
            else if (displayBottom.Text == "")
            {
                displayUpper.Text = displayUpper.Text.Substring(0, displayUpper.Text.Length - 1);
            }

            else if (rezCache == 1)
            {

            }

            else
            {
                displayBottom.Text = displayBottom.Text.Substring(0, displayBottom.Text.Length - 1);
            }

        }

        //Vse števile

        private void num0_Click(object sender, EventArgs e)
        {
            nums("0");
        }

        private void num1_Click(object sender, EventArgs e)
        {
            nums("1");
        }

        private void num2_Click(object sender, EventArgs e)
        {
            nums("2");
        }

        private void num3_Click(object sender, EventArgs e)
        {
            nums("3");
        }

        private void num4_Click(object sender, EventArgs e)
        {
            nums("4");
        }

        private void num5_Click(object sender, EventArgs e)
        {
            nums("5");
        }

        private void num6_Click(object sender, EventArgs e)
        {
            nums("6");
        }

        private void num7_Click(object sender, EventArgs e)
        {
            nums("7");
        }

        private void num8_Click(object sender, EventArgs e)
        {
            nums("8");
        }

        private void num9_Click(object sender, EventArgs e)
        {
            nums("9");
        }

        private void deleteLine_Click(object sender, EventArgs e)
        {
            displayBottom.Text = "";
            if(rezCache == 1)
            {
                rezultat = 0;
                displayUpper.Text = "";
                rezCache = 0;
            }
        }

        private void deleteAll_Click(object sender, EventArgs e)
        {
            displayBottom.Text = "";
            displayUpper.Text = "";
            rezultat = 0;
        }

        private void posNeg_Click(object sender, EventArgs e)
        {
            //pozitivno, negativno
            string resString = displayBottom.Text;

            if (resString == "")
            {

            }
            else if (rezCache == 1)
            {

            }
            else
            {
                if (resString.Contains("-"))
                {
                    displayBottom.Text = displayBottom.Text = displayBottom.Text.Remove(0, 1);
                    cache = 0;
                }
                else if (resString.Contains("-") == false)
                {
                    displayBottom.Text = "-" + displayBottom.Text;
                    cache = 1;
                }
            }
        }

        private void displayUpper_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void decimalNum_Click(object sender, EventArgs e)
        {
            //decimalka
            string resString = displayBottom.Text;

            if (resString.Contains(",")) 
            {

            }
            else if (displayBottom.Text == "" && resString.Contains(",") == false)
            {
                displayBottom.Text += "0,";
            }
            else if (resString.Contains(",") == false)
            {
                displayBottom.Text += ",";
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            //seštevanje
            try
            {

                if (rezCache == 1)
                {
                    displayBottom.Text = "";
                    displayUpper.Text = Convert.ToString(rezultat) + "+";
                    opSelect = '+';
                    rezCache = 0;
                }

                if (displayBottom.Text == "")
                {

                }
                else if (displayUpper.Text == "" && displayBottom.Text != "")
                {
                    rezultat = Convert.ToDouble(displayBottom.Text);
                    displayUpper.Text = displayBottom.Text + "+";
                    displayBottom.Text = "";
                    opSelect = '+';
                }
                else if (displayBottom.Text.Contains("-"))
                {
                    operacija(opSelect);
                    if (napaka == 1)
                    {
                        napaka = 0;
                    }
                    else
                    {
                        opSelect = '+';
                        displayUpper.Text = displayUpper.Text + "(" + displayBottom.Text + ")" + '+';
                        displayBottom.Text = "";
                    }
                }
                else
                {
                    operacija(opSelect);
                    if (napaka == 1)
                    {
                        napaka = 0;
                    }
                    else
                    {
                        opSelect = '+';
                        displayUpper.Text = displayUpper.Text + displayBottom.Text + '+';
                        displayBottom.Text = "";
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
        }

        private void subtract_Click(object sender, EventArgs e)
        {
            //odštevanje
            try
            {
                if (rezCache == 1)
                {
                    displayBottom.Text = "";
                    displayUpper.Text = Convert.ToString(rezultat) + "-";
                    opSelect = '-';
                    rezCache = 0;
                }

                if (displayBottom.Text == "")
                {

                }
                else if (displayUpper.Text == "" && displayBottom.Text != "")
                {
                    rezultat = Convert.ToDouble(displayBottom.Text);
                    displayUpper.Text = displayBottom.Text + "-";
                    displayBottom.Text = "";
                    opSelect = '-';
                }
                else if (displayBottom.Text.Contains("-"))
                {
                    operacija(opSelect);
                    if (napaka == 1)
                    {
                        napaka = 0;
                    }
                    else
                    {
                        opSelect = '-';
                        displayUpper.Text = displayUpper.Text + "(" + displayBottom.Text + ")" + '-';
                        displayBottom.Text = "";
                    }
                }
                else
                {
                    operacija(opSelect);
                    if (napaka == 1)
                    {
                        napaka = 0;
                    }
                    else
                    {
                        opSelect = '-';
                        displayUpper.Text = displayUpper.Text + displayBottom.Text + '-';
                        displayBottom.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
        }

        private void division_Click(object sender, EventArgs e)
        {
            //deljenje
            try
            {
                if (rezCache == 1)
                {
                    displayBottom.Text = "";
                    displayUpper.Text = Convert.ToString(rezultat) + "÷";
                    opSelect = '÷';
                    rezCache = 0;
                }

                if (displayBottom.Text == "")
                {

                }
                else if (displayUpper.Text == "" && displayBottom.Text != "")
                {
                    rezultat = Convert.ToDouble(displayBottom.Text);
                    displayUpper.Text = displayBottom.Text + "÷";
                    displayBottom.Text = "";
                    opSelect = '÷';
                }
                else if (displayBottom.Text.Contains("-"))
                {
                    operacija(opSelect);
                    if (napaka == 1)
                    {
                        napaka = 0;
                    }
                    else
                    {
                        opSelect = '÷';
                        displayUpper.Text = displayUpper.Text + "(" + displayBottom.Text + ")" + '÷';
                        displayBottom.Text = "";
                    }
                }
                else
                {
                    operacija(opSelect);
                    if (napaka == 1)
                    {
                        napaka = 0;
                    }
                    else
                    {
                        opSelect = '÷';
                        displayUpper.Text = displayUpper.Text + displayBottom.Text + '÷';
                        displayBottom.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
        }

        private void multiply_Click(object sender, EventArgs e)
        {
            //množenje
            try
            {
                if (rezCache == 1)
                {
                    displayBottom.Text = "";
                    displayUpper.Text = Convert.ToString(rezultat) + "✕";
                    opSelect = '✕';
                    rezCache = 0;
                }

                if (displayBottom.Text == "")
                {

                }
                else if (displayUpper.Text == "" && displayBottom.Text != "")
                {
                    rezultat = Convert.ToDouble(displayBottom.Text);
                    displayUpper.Text = displayBottom.Text + "✕";
                    displayBottom.Text = "";
                    opSelect = '✕';
                }
                else if (displayBottom.Text.Contains("-"))
                {
                    operacija(opSelect);
                    if (napaka == 1)
                    {
                        napaka = 0;
                    }
                    else
                    {
                        opSelect = '✕';
                        displayUpper.Text = displayUpper.Text + "(" + displayBottom.Text + ")" + '✕';
                        displayBottom.Text = "";
                    }
                }
                else
                {
                    operacija(opSelect);
                    if (napaka == 1)
                    {
                        napaka = 0;
                    }
                    else
                    {
                        opSelect = '✕';
                        displayUpper.Text = displayUpper.Text + displayBottom.Text + '✕';
                        displayBottom.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
        }

        private void result_Click(object sender, EventArgs e)
        {
            //je enako
            try
            {
                if (displayBottom.Text == "")
                {
                    displayBottom.Text = "0";
                }
                else
                {
                    if (displayBottom.Text.Contains("-"))
                    {
                        operacija(opSelect);
                        if (napaka == 1)
                        {
                            napaka = 0;
                        }
                        else
                        {
                            displayUpper.Text = displayUpper.Text + "(" + displayBottom.Text + ")" + "=";
                            displayBottom.Text = "";
                        }

                    }

                    else
                    {
                        operacija(opSelect);
                        if (napaka == 1)
                        {
                            napaka = 0;
                        }
                        else
                        {
                            displayUpper.Text = displayUpper.Text + displayBottom.Text + "=";
                            displayBottom.Text = "";
                        }
                    }

                    displayBottom.Text = Convert.ToString(rezultat);
                    rezCache = 1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Napaka: " + ex.Message);
            }
        }

        /*private void timer1_Tick(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(rezultat);
        }*/

        public void kalkulator_KeyPress(object sender, KeyPressEventArgs key)
        {
            //MessageBox.Show("pritsnjeno:" + key.ToString());
            switch (key.KeyChar)
            {
                case '0':
                    num0.PerformClick();
                    break;
                case '1':
                    num1.PerformClick();
                    break;
                case '2':
                    num2.PerformClick();
                    break;
                case '3':
                    num3.PerformClick();
                    break;
                case '4':
                    num4.PerformClick();
                    break;
                case '5':
                    num5.PerformClick();
                    break;
                case '6':
                    num6.PerformClick();
                    break;
                case '7':
                    num7.PerformClick();
                    break;
                case '8':
                    num8.PerformClick();
                    break;
                case '9':
                    num9.PerformClick();
                    break;
                case '-':
                    subtract.PerformClick();
                    break;
                case '+':
                    add.PerformClick();
                    break;
                case '*':
                    multiply.PerformClick();
                    break;
                case '/':
                    division.PerformClick();
                    break;
                case '=':
                    result.PerformClick();
                    break;
                case ',':
                    decimalNum.PerformClick();
                    break;
                case 'c':
                    deleteAll.PerformClick();
                    break;
                default:
                    break;

            }
        }
    }
}

