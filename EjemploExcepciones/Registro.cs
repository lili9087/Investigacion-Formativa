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
    public partial class Registro : Form
    {
        Estudiantes personas = new Estudiantes();

        public Registro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Comprobar())
                {
                    Estudiante persona = new Estudiante();

                    persona.Asignatura = cmbAsignatura.SelectedItem.ToString();
                    persona.Codigo = txtCodigo.Text;
                    persona.Nombres = mtxtNombres.Text;
                    persona.Apellidos = mtxtApellidos.Text;
                    persona.Semestre = cmbSemestre.SelectedItem.ToString();
                    persona.Paralelo = cmbParalelo.SelectedItem.ToString();
                    persona.Email = txtEmail.Text;
                    persona.Nota = Convert.ToInt32(mtxtNota.Text);
                    personas.AgregarPersona(persona);
                    
                    MessageBox.Show("Datos almacenados correctamente");
                    dgvPersonas.DataSource = null;
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Ingrese toda la información");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mtxtNombres_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = personas.ListPersonas;
        }

        private void dgvPersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            txtCodigo.Text = "";
            cmbAsignatura.SelectedIndex = -1;
            mtxtNombres.Text = "";
            mtxtApellidos.Text = "";
            cmbSemestre.SelectedIndex = -1;
            cmbParalelo.SelectedIndex = -1;
            txtEmail.Text = "";
            mtxtNota.Text = "";
        }

        public bool Comprobar()
        {
            bool aux = false;
            if (txtCodigo.Text != "" && cmbAsignatura.SelectedIndex >= 0 && mtxtNombres.Text != "" && mtxtApellidos.Text != "" && mtxtNota.Text != ""
            && txtEmail.Text != "" && cmbSemestre.SelectedIndex >= 0 && cmbParalelo.SelectedIndex >= 0)
            {
                aux = true;
            }
            return aux;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            this.Hide();
            ini.Show();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            obcadena();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar bu = new Buscar();
            AddOwnedForm(bu);
            bu.Show();
            bu.personas2 = personas;

        }

        private TextBox _txtcadena;

        public TextBox Txtcadena { get => _txtcadena; set => _txtcadena = value; }

        private void obcadena()
        {
            _txtcadena = txtCadena;
        }

        private void btnSuspensos_Click(object sender, EventArgs e)
        {
            Suspenso su = new Suspenso();
            su.Show();
            su.personas3 = personas;
        }
    }
}
