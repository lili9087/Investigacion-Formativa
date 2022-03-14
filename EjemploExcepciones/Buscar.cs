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
    public partial class Buscar : Form
    {
        public Estudiantes personas2 = new Estudiantes();

        public Buscar()
        {
            InitializeComponent();
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
            Registro bu = Owner as Registro;
            string cd = bu.Txtcadena.Text;
            dgvListadoEstudiantes.DataSource = null;
            dgvListadoEstudiantes.DataSource = personas2.ListarCadena(cd);
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Registro rg = new Registro();
            this.Hide();
            rg.Show();
        }

        private void Buscar_Load(object sender, EventArgs e)
        {

        }
    }
}
