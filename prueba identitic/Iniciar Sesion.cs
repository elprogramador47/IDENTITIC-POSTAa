using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba_identitic
{
    public partial class Iniciar_Sesion : Form
    {
        public Iniciar_Sesion()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registrarse registrarse = new Registrarse();
            registrarse.Show();
            this.Hide();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "Mail" || bunifuMaterialTextbox2.Text == "Contraseña")
            {
                MessageBox.Show("¡Complete todos los campos!");
            }

        }
    }
}
