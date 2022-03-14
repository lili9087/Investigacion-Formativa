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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Comprobar())
                {
                    if (txtUsuario.Text == "pam" && txtContrasenia.Text == "admin")
                    {
                        Inicio ini = new Inicio();
                        this.Hide();
                        ini.Show();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o contraseña incorrecta");
                    }
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

        public bool Comprobar()
        {
            bool aux = false;
            if (txtUsuario.Text != "" && txtContrasenia.Text != "")
            {
                aux = true;
            }
            return aux;
        }
    }
}
