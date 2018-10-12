using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.OleDb;
namespace prueba_identitic
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }
		OleDbCommand comando;

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void Registrarse_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
			OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Base de datos general de identitic.accdb");

			string sql = "INSERT INTO Registro (email, nombre, apellido, contrasena, Funcion) VALUES ('" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox1.Text + "', '" + bunifuMaterialTextbox1.Text + "','" + bunifuMaterialTextbox4.Text + "', '" + comboBox1.Text + "')";
			comando = new OleDbCommand(sql, con);
		    con.Open();
		    comando.ExecuteNonQuery();
			con.Close();
			
			

			if (bunifuMaterialTextbox1.Text == "nombre completo" || bunifuMaterialTextbox2.Text == "Mail"
               || comboBox1.SelectedText == "Funcion" || bunifuMaterialTextbox4.Text == "Contraseña")
            {
                MessageBox.Show("Faltan completar campos");
            }
            else
            {
                MessageBox.Show("Usuario Registrado. ¡Ahora inicia sesion!");
                Iniciar_Sesion iniciar_Sesion = new Iniciar_Sesion();
                iniciar_Sesion.Show();
                this.Hide();
            }
            

        }

        private void bunifuMaterialTextbox1_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox1.Text == "Nombre completo")
            {
                bunifuMaterialTextbox1.Text = "";
               
            }
                
        }

        private void bunifuMaterialTextbox1_Leave(object sender, EventArgs e)
        {
            if( bunifuMaterialTextbox1.Text =="")
            {
                bunifuMaterialTextbox1.Text = "Nombre completo";
            }
        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "Mail")
            {
                bunifuMaterialTextbox2.Text = "";
               
            }

        }

        private void bunifuMaterialTextbox2_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox2.Text == "")
            {
                bunifuMaterialTextbox1.Text = "Mail";
            }

        }

        private void bunifuMaterialTextbox4_Enter(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "Contraseña")
            {
                bunifuMaterialTextbox4.Text = "";
               
            }

        }

        private void bunifuMaterialTextbox4_Leave(object sender, EventArgs e)
        {
            if (bunifuMaterialTextbox4.Text == "")
            {
                bunifuMaterialTextbox4.Text = "Contraseña";
            }

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Iniciar_Sesion iniciar_Sesion = new Iniciar_Sesion();
            iniciar_Sesion.Show();
            this.Hide();

        }
    }
}
