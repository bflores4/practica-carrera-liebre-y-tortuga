using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_carrera_liebre_y_tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Tortuga tortuga;
        Liebre liebre;

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            tortuga = new Tortuga();
            liebre = new Liebre();

            txtlaCarrera.Text = "";
            while (tortuga.pasosAvanzados <= 80 && liebre.pasosAvanzados <= 80)
            {
                txtlaCarrera.Text += tortuga.avanzar();
                txtlaCarrera.Text += liebre.avanzar();
            }

            if (tortuga.pasosAvanzados < liebre.pasosAvanzados)
                txtlaCarrera.Text += "¡ GANO LA LIEBRE !";
            else
                txtlaCarrera.Text += "¡ GANO LA TORTUGA !";
        }
    }
}
