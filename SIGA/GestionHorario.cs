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
using SpreadsheetLight;

namespace SIGA
{
    public partial class GestionHorario : Form
    {
        public GestionHorario()
        {
            InitializeComponent();
        }

        private void ListadoHorarioP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscarP_Click(object sender, EventArgs e)
        {

            try
            {
                //Establecemos la conexión con la base de datos
                using (SqlConnection conexion = new SqlConnection("server=JUANMATADORPC;database=siga;Integrated Security=true"))
                {
                    conexion.Open();

                    int idConsulta = Convert.ToInt32(txtDocente.Text);
                    string consulta = "select * from GestionHorario where Documento =" + idConsulta;
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta,conexion);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    ListadoHorarioP.DataSource = dt;
                    SqlCommand comando = new SqlCommand(consulta, conexion);
                    SqlDataReader lector = comando.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnexportar_Click(object sender, EventArgs e)
        {
            SLDocument sl = new SLDocument();

            int NF = 1; 

            foreach (DataGridViewRow row in ListadoHorarioP.Rows)
            {
                if (row != null) 
                {
                    for (int i = 0; i < 6; i++)
                    {
                        object cellValue = row.Cells[i].Value;
                        if (cellValue != null) 
                        {
                            sl.SetCellValue(NF, i, cellValue.ToString());
                        }
                        else
                        {
                            sl.SetCellValue(NF, i, "");
                        }
                    }
                    NF++;
                }
            }

            sl.SaveAs(@"C:\Users\juanj\source\repos\SIGA\SIGA\HorarioGenerado.xlsx");
            MessageBox.Show("Se ha exportado el archivo en excel correctamente");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form Profe = new InicioSesion();
            Profe.Show();
            this.Hide();
        }
    }
}
