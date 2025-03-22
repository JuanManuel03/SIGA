using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SIGA
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        public class Rol
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
        }

        private void Form1_Load(object sender, EventArgs e)//Lista de los roles
        {
            
            List<Rol> roles = new List<Rol>()
        {
            new Rol() { Id = 1, Nombre = "Administrador" },
            new Rol() { Id = 2, Nombre = "Profesor" },
            new Rol() { Id = 3, Nombre = "Estudiante" }
        };
                comrol.DataSource = roles;
                comrol.ValueMember = "Id";
                comrol.DisplayMember = "Nombre";
        }

        private void guardarbd_Click(object sender, EventArgs e)//Guardamos en la base de datos
        {
            SqlConnection conexion = new SqlConnection("server=DIOUSEK\\DIOUSEKSQL;database=siga;Integrated Security=true;");
            conexion.Open();
            int id = Convert.ToInt32(txtID.Text);
            int idrool = Convert.ToInt32(idrol.Text);
            string Nombrol = comrol.Text;
            string Nombusu = txtNombusu.Text;
            string Nombusu2 = txtNombusu2.Text;
            string Apellusu = txtApellusu.Text;
            string Apellusu2 = txtApellusu2.Text;
            int Edad = Convert.ToInt32(txtEdad.Text);
            string Correo = txtCorreo.Text;
            string Contra = txtContra.Text;
            string cadena = "insert into usuarios(Id_usuario,Id_rol,Nomb_Rol,Nomb_usu, Nomb2_usu, Apell_usu, Apell2_usu, Edad, Correo, Contrasena) values(" + id + ",'" + idrool + "','" + Nombrol + "','" + Nombusu + "','" + Nombusu2 + "','" + Apellusu + "','" + Apellusu2 + "','" + Edad + "','" + Correo + "','" + Contra + "')";
            SqlCommand com = new SqlCommand(cadena, conexion);
            com.ExecuteNonQuery();

            MessageBox.Show("Se ha registrado correctamente el usuario con el rol " + Nombrol);

            conexion.Close();

            Form InicioS = new InicioSesion();
            InicioS.Show();
            this.Hide();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void txtContra_TextChanged(object sender, EventArgs e)//Codigo para el hide del campo contrasena
        {
            if (ojoocultar.Visible)
            {
                txtContra.PasswordChar = '*';
            }
        }

        private void ojover_Click(object sender, EventArgs e)
        {
            ojoocultar.BringToFront();
            txtContra.PasswordChar = '\0';
        }

        private void ojoocultar_Click(object sender, EventArgs e)
        {
            ojover.BringToFront();
            txtContra.PasswordChar = '*';

        }

        private void btnInicioSesion_Click(object sender, EventArgs e)
        {
            Form InicioS = new InicioSesion();
            InicioS.Show();
        }

        private void comrol_SelectedIndexChanged(object sender, EventArgs e)//Establecemos los roles
        {
            if (comrol.SelectedIndex == 0)
            {
                // Administrador
                idrol.Text = "1";
            }
            else if (comrol.SelectedIndex == 1)
            {
                // Profesor
                idrol.Text = "2";
            }
            else if (comrol.SelectedIndex == 2)
            {
                // Estudiante
                idrol.Text = "3";
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void idrol_Click(object sender, EventArgs e)
        {

        }
    }
}
