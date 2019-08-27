using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_en_C_sharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool secuencia = true, punto = true;
        string operacion, borrado;
        double num1, num2, resultado;

        //Numeros a mostrar en la pantalla de la calculadora

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        //boton de borrar pantalla

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            num1 = 0;
            num2 = 0;
            secuencia = true;
        }

        //profesor algunos botones están en desorden porque los programé por partes

        private void Button12_Click(object sender, EventArgs e)
        {
            operacion = "+";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;

        }

        private void Button11_Click(object sender, EventArgs e)
        {
            operacion = "%";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            operacion = "*";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;
        }


        //inciamos con la programacion de los botones con numeros 
        private void Button1_Click(object sender, EventArgs e)
        {
            if (secuencia==true)
            {
                textBox1.Text = "";
                textBox1.Text = "1";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "2";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "3";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "4";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "5";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "6";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "7";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "8";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (secuencia == true)
            {
                textBox1.Text = "";
                textBox1.Text = "9";
                secuencia = false;
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }


        //boton de borrar pantalla

        private void Button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                return;
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void ButtonPunto_Click(object sender, EventArgs e)
        {

            if (punto == true)
            {
                textBox1.Text = textBox1.Text + ".";
                punto = false;
            }
            else
            {
                return;
            }
        }

        //Fin de programado de los botones a mostrar en la pantalla}


        //Iniciamos con la programacion de los botones de las operaciones

        private void Button13_Click(object sender, EventArgs e)
        {
            operacion = "/";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            operacion = "-";
            num1 = double.Parse(textBox1.Text);
            secuencia = true;
        }

        //Botón de igual 

        private void Button10_Click(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox1.Text);
            if (operacion == "+")
            {
                resultado = num1 + num2;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "-")
            {
                resultado = num1 - num2;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "*")
            {
                resultado = num1 * num2;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "/")
            {
                resultado = num1 / num2;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
            if (operacion == "%")
            {
                resultado = (num1 * num2) / 100;
                textBox1.Text = resultado.ToString();
                secuencia = true;
            }
        }

        //boton de borrar la última entrada
        private void Button14_Click(object sender, EventArgs e)
        {
            int x = 0;
            borrado = textBox1.Text;
            x = borrado.Length - 1;
            borrado = borrado.Substring(0, x);
            textBox1.Text = borrado;

            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                secuencia = true;
            }
            if (textBox1.Text == "-")
            {
                textBox1.Text = "0";
                secuencia = true;
            }
        }
    }
}
