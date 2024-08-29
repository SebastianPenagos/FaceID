using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FaceId
{
    public partial class Registrar : Form
    {

        public Registrar()
        {
            InitializeComponent();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {
            string cedula = txtCedula.Text;
            string nombres = txtNombres.Text;
            string apellidos = txtApellidos.Text;
            int edad = int.Parse(txtEdad.Text);
            string nacionalidad = txtNacionalidad.Text;
            string nombreUsuario = txtNombreUsuario.Text;
            string correoElectronico = txtCorreoElectronico.Text;
            string contraseña = txtContraseña.Text;



            Usuario usuario = new Usuario
            {
                Cedula = cedula,
            };


            DatosMostrados.Show();

            MessageBox.Show("¡Registro exitoso!", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
