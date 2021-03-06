using SafeKey.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SafeKey
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
            txtContraseña.UseSystemPasswordChar = true;
        }

        private void btGenerarPass_Click(object sender, EventArgs e)
        {
            txtContraseña.Text = generarContraseñaSegura();
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ckMostrar_CheckedChanged(object sender, EventArgs e)
        {
            if (ckMostrar.Checked)
                txtContraseña.UseSystemPasswordChar = false;
            else
               txtContraseña.UseSystemPasswordChar = true;
        }

        private void btVerContraseñas_Click(object sender, EventArgs e)
        {
            if(pnMisContraseñas.Visible)
                 pnMisContraseñas.Visible = false;
            else
                pnMisContraseñas.Visible = true;
        }

        private void btNuevaContraseña_Click(object sender, EventArgs e)
        {
            if (pnContraseñaNueva.Visible)
                pnContraseñaNueva.Visible = false;
            else
                pnContraseñaNueva.Visible = true;
        }

        private void btGenerarContraseñaApp_Click(object sender, EventArgs e)
        {
            txtGenerarContraseñaAPP.Text = generarContraseñaSegura();
        }

        public string generarContraseñaSegura()
        {
            ManagerContraseñas contraseñas = new ManagerContraseñas();
            string contraseña = contraseñas.GenerarContrasña();
            return contraseña;
            
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
