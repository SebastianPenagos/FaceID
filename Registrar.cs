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
            CenterToScreen();
        }

        private void Registrar_Load(object sender, EventArgs e)
        {

            DatosMostrados fMostrados = new DatosMostrados(txtCedula.Text);

            fMostrados.label8.Text = txtCedula.Text;
            fMostrados.label7.Text = txtNombres.Text;
            fMostrados.label6.Text = txtApellidos.Text;
            fMostrados.label5 = Convert.ToInt32(txtEdad.Text);
            fMostrados.label4.Text = txtNacionalidad.Text;
            fMostrados.label3.Text = txtNombreUsuario.Text;
            fMostrados.label2.Text = txtCorreoElectronico.Text;
            fMostrados.label1.Text = txtContraseña.Text;

           
            fMostrados.Show(this);


        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 iniForm1 = new Form1();
            iniForm1.ShowDialog();
        }
    }
}
