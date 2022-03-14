using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploExcepciones
{
    public partial class Perfil : Form
    {
        public Perfil()
        {
            InitializeComponent();
        }

        private void Perfil_Load(object sender, EventArgs e)
        {
            lblCodigod.Text = "46168";
            lblCodigod.Text = "46168";
            lblNombred.Text = "Pamela Alexandra";
            lblCedulad.Text = "Buñay Guisñan";
            lblEmaild.Text = "pbunay@unach.edu.ec";
            lblCatedrasd.Text = "Fundamentos de programación \nProgramacion \nEstructura de Datos \nBase de Datos";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void lblNombred_Click(object sender, EventArgs e)
        {
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            this.Hide();
            ini.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
