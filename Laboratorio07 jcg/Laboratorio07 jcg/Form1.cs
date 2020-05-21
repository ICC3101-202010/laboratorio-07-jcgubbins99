using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laboratorio07_jcg
{
    public partial class Form1 : Form
    {
        double v1, v2;
        string operacion;
        string resultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnueve_Click(object sender, EventArgs e)
        {
            if(textCalculadora.Text == "")
            {
                textCalculadora.Text = "9";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "9";
            }

        }

        private void btocho_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "8";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "8";
            }
        }

        private void btsiete_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "7";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "7";
            }
        }

        private void btcuatro_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "4";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "4";
            }
        }

        private void btcinco_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "5";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "5";
            }
        }

        private void btseis_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "6";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "6";
            }
        }

        private void btuno_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "1";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "1";
            }
        }

        private void btdos_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "2";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "2";
            }
        }

        private void bttres_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "3";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "3";
            }
        }

        private void btcero_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = "0";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + "0";
            }
        }

        private void btclean_Click(object sender, EventArgs e)
        {
            v1 = 0;
            v2 = 0;
            textCalculadora.Clear();
            textCalculadora.Focus();
        }

        private void btdivision_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = Convert.ToDouble(textCalculadora.Text);
                operacion = "÷";
                textCalculadora.Clear();
                textCalculadora.Focus();
            }
            catch(Exception)
            {
                textCalculadora.Text = "SYNTAX ERROR";
            }
            
        }

        private void btmultiplicacion_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = Convert.ToDouble(textCalculadora.Text);
                operacion = "X";
                textCalculadora.Clear();
                textCalculadora.Focus();
            }
            catch (Exception)
            {
                textCalculadora.Text = "SYNTAX ERROR";
            }
        }

        private void btsuma_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = Convert.ToDouble(textCalculadora.Text);
                operacion = "+";
                textCalculadora.Clear();
                textCalculadora.Focus();
            }
            catch(Exception)
            {
                textCalculadora.Text = "SYNTAX ERROR";
            }
            
        }

        private void btresta_Click(object sender, EventArgs e)
        {
            try
            {
                v1 = Convert.ToDouble(textCalculadora.Text);
                operacion = "-";
                textCalculadora.Clear();
                textCalculadora.Focus();
            }
            catch (Exception)
            {
                textCalculadora.Text = "SYNTAX ERROR";
            }
        }

        private void btigual_Click(object sender, EventArgs e)
        {

            try
            {
                v2 = Convert.ToDouble(textCalculadora.Text);
                switch (operacion)
                {
                    case "÷":
                        try
                        {
                            textCalculadora.Text = Convert.ToString(v1 / v2);

                            if (textCalculadora.Text == "∞")
                            {
                                textCalculadora.Text = "MATH ERROR";
                            }
                            else
                            {
                                resultado = textCalculadora.Text;
                            }
                        }
                        catch (Exception)
                        {
                            textCalculadora.Text = "SYNTAX ERROR";
                        }

                        break;
                    case "X":
                        textCalculadora.Text = Convert.ToString(v1 * v2);
                        resultado = textCalculadora.Text;
                        break;
                    case "+":
                        textCalculadora.Text = Convert.ToString(v1 + v2);
                        resultado = textCalculadora.Text;
                        break;
                    case "-":
                        textCalculadora.Text = Convert.ToString(v1 - v2);
                        resultado = textCalculadora.Text;
                        break;




                }


            }
            catch (Exception)
            {
                textCalculadora.Text = "SYNTAX ERROR";
            }
                
            



            

        }

        private void btdelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (textCalculadora.Text.Length == 1)
                    textCalculadora.Text = "";
                else
                    textCalculadora.Text = textCalculadora.Text.Substring(0, textCalculadora.Text.Length - 1);
            }
            catch(Exception)
            {
                textCalculadora.Text = "SYNTAX ERROR";
            }
            
        }

        private void btans_Click(object sender, EventArgs e)
        {
            textCalculadora.Text = resultado;
        }

        private void btpunto_Click(object sender, EventArgs e)
        {
            if (textCalculadora.Text == "")
            {
                textCalculadora.Text = ",";
            }
            else
            {
                textCalculadora.Text = textCalculadora.Text + ",";
            }
        }
    }
}
