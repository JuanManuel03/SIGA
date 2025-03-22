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
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {

        }

        public class Usuario
        {
            public string Correo { get; set; }
            public string Contrasena { get; set; }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            try
            {
                //Obtenemos el correo y la contraseña de los txt
                string correo = txtcorreoinicio.Text;
                string contrasena = txtcontrainicio.Text;

                //Conexion a la base de datos
                string connectionString = "server=DIOUSEK\\DIOUSEKSQL;database=siga;Integrated Security=true;"; 

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    string query = "SELECT * FROM Usuarios WHERE Correo = @correo AND Contrasena = @contrasena";//Comparamos los campos de los txt con los de la base de datos

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@correo", correo);
                        command.Parameters.AddWithValue("@contrasena", contrasena);

                        connection.Open();

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                MessageBox.Show("Inicio de sesión exitoso");

                                //Obtenemos el Id_rol y Id_usuario del usuario
                                int idRol = -1;
                                int idUsuario = -1;
                                while (reader.Read())
                                {
                                    idRol = int.Parse(reader["Id_rol"].ToString());
                                    idUsuario = int.Parse(reader["Id_usuario"].ToString());
                                }

                                //Establecemos que formulario debe arir segun rol y pasamos el Id_usuario
                                switch (idRol)
                                {
                                    case 1:
                                        Form Admin = new FormAdmin(idUsuario);
                                        Admin.Show();
                                        break;
                                    case 2:
                                        Form Profe = new GestionHorario();
                                        Profe.Show();
                                        break;
                                    case 3:
                                        Form Estudiante = new GestionHorario();
                                        Estudiante.Show();
                                        break;
                                    default:
                                        MessageBox.Show("Rol no encontrado");
                                        break;
                                }
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Datos incorrectos");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Manejar cualquier error relacionado con la base de datos
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnregistro_Click(object sender, EventArgs e)
        {
            Form Registro = new FormRegistro();
            Registro.Show();
            this.Hide();
        }

        private void txtcontrainicio_TextChanged(object sender, EventArgs e)//Codigo para establecer el hide en la contrasena
        {
            if (ojoocultar.Visible)
            {
                txtcontrainicio.PasswordChar = '*';
            }
        }

        private void ojover_Click(object sender, EventArgs e)
        {
            ojoocultar.BringToFront();
            txtcontrainicio.PasswordChar = '\0';
        }

        private void ojoocultar_Click(object sender, EventArgs e)
        {
            ojover.BringToFront();
            txtcontrainicio.PasswordChar = '*';
        }
    }
}
