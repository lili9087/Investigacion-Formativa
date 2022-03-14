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
    public partial class Suspenso : Form
    {
        public Estudiantes personas3 = new Estudiantes();
        public Suspenso()
        {
            InitializeComponent();
        }

        private void Suspenso_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvListaSuspenso.DataSource = personas3.ListarSuspenso();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Registro rg = new Registro();
            rg.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
