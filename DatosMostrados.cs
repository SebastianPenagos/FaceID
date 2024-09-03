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
    public partial class DatosMostrados : Form
    {
        private string _cedula;
        public DatosMostrados(string cedula)
        {
            InitializeComponent();
            _cedula = cedula;
        }

        private void DatosMostrados_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
            DatosPersonales subirDatosPersonales = new DatosPersonales();
            subirDatosPersonales.ShowDialog(this);
        }
    }
}
