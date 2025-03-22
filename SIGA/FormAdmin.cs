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
    public partial class FormAdmin : Form
    {
        public FormAdmin(int idUsuario)
        {
            InitializeComponent();

            //Conexion a la base de datos
            string connectionString = "server=DIOUSEK\\DIOUSEKSQL;database=siga;Integrated Security=true;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Obtenemos por medio de una busqueda el nombre apellido del usuario
                string query = "SELECT Nomb_usu, Apell_usu FROM Usuarios WHERE Id_usuario = @Id_usuario";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Id_usuario", idUsuario);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            //Mostramos el nombre y apellido en el txtnomadmin
                            txtnomadmin.Text = reader["Nomb_usu"].ToString() + " " + reader["Apell_usu"].ToString();
                        }
                    }
                }
            }
        }

        private void FormProfe_Load(object sender, EventArgs e)
        {
            
        }

        private void txtnomadmin_Click(object sender, EventArgs e)
        {
        
        }

        private void txtbuscardocente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

            try
            {
                //Establecemos la conexión con la base de datos
                using (SqlConnection conexion = new SqlConnection("server=DIOUSEK\\DIOUSEKSQL;database=siga;Integrated Security=true;"))
                {
                    conexion.Open();

                    //Realizamos la consulta
                    string consulta = "select u.Id_usuario as Cédula, concat (u.Apell_usu,' ', u.Apell2_usu) as Apellidos,concat(u.Nomb_usu,' ', u.Nomb2_usu) as Nombres, s.Nomb_cur as Materia, s.Id_curso as Aula from usuarios as u join cursos as s on s.Id_usuario = u.Id_usuario WHERE u.Id_usuario >= 7628912 and u.Id_usuario <= 1030615244 order by Apellidos asc";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    ListadoProfes.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector = comando.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {

        }

        private void btnCrearH_Click(object sender, EventArgs e)
        {

            try
            {
                //Hacemos la conexion
                using (SqlConnection conexion = new SqlConnection("server=DIOUSEK\\DIOUSEKSQL;database=siga;Integrated Security=true;"))
                {
                    conexion.Open();

                    //Consulta
                    string consulta = "WITH UniqueHours AS (SELECT DISTINCT h.Dia, h.Hora,v.Id_curso, p.Descrip FROM horarios h, cursos c, profes p, asignatura v) SELECT TOP 15 u.Id_usuario AS Documento, CONCAT(u.Apell_usu, ' ', u.Apell2_usu, ' ', u.Nomb_usu, ' ', u.Nomb2_usu) AS Docente, p.Descrip AS Materia, h.Dia AS Dia, h.Hora AS Franja, c.Id_curso FROM UniqueHours INNER JOIN horarios h ON UniqueHours.Dia = h.Dia AND UniqueHours.Hora = h.Hora INNER JOIN profes p ON p.Id_pro = p.Id_pro INNER JOIN cursos c ON c.Id_usuario = p.Id_usuario INNER JOIN usuarios AS u ON u.Id_usuario = p.Id_usuario WHERE u.Id_usuario >= 7628912 and u.Id_usuario <= 1030615244 ORDER BY NEWID(), Documento desc, Docente desc; ";
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    GuardarProfes.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector = comando.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnGuardarp_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DIOUSEK\\DIOUSEKSQL;database=siga;Integrated Security=true;");
            conexion.Open();

            SqlCommand agregar = new SqlCommand("insert into GestionHorario values(@Documento, @Docente, @Materia, @Dia, @Franja, @Id_curso)", conexion);

            try
            {
                foreach (DataGridViewRow fila in GuardarProfes.Rows)
                {
                    agregar.Parameters.Clear();
                    agregar.Parameters.AddWithValue("@Documento", Convert.ToString(fila.Cells["Documento"].Value));
                    agregar.Parameters.AddWithValue("@Docente", Convert.ToString(fila.Cells["Docente"].Value));
                    agregar.Parameters.AddWithValue("@Materia", Convert.ToString(fila.Cells["Materia"].Value));
                    agregar.Parameters.AddWithValue("@Dia", Convert.ToString(fila.Cells["Dia"].Value));
                    agregar.Parameters.AddWithValue("@Franja", Convert.ToString(fila.Cells["Franja"].Value));
                    agregar.Parameters.AddWithValue("@Id_curso", Convert.ToString(fila.Cells["Id_curso"].Value));

                    agregar.ExecuteNonQuery();
                }
                MessageBox.Show("Datos guardados"); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); 
            }
            finally
            {
                conexion.Close();
            }
        }

        private void GuardarProfes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ListadoProfes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Form Admin = new InicioSesion();
            Admin.Show();
            this.Hide();
        }
    }
}
