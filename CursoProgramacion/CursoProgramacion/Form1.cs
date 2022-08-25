using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CursoProgramacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           //En esta parte creamos una variable para obtener la edad 
            string textoEdad = txtEdad.Text;

            //Parseamos el texto a entero 
            int edad = Int32.Parse(textoEdad);
            bool esMayorDeEdad = edad>=18;
           
            
            if (esMayorDeEdad)
            {
                lblResultado.Text = "El usuario es mayor de edad";
            }
            else
            {
                lblResultado.Text = "El usuario no es mayor de edad";
            }
            
        }
    }
}
