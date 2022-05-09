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
using ConexionSQLSERVER;
namespace ConexionSQLSERVER
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Conexion.Conexionsql();
            MessageBox.Show("Conexion exitosa");

            dataGridView1.DataSource = Consulta();
        }
        public DataTable Consulta()
        {
            Conexion.Conexionsql();
            DataTable datos = new DataTable();
            string consultar = "SELECT * FROM Alumnos";
            SqlCommand cmd = new SqlCommand(consultar, Conexion.Conexionsql());
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(datos);
            return datos;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Conexion.Conexionsql();
            string insertar = "INSERT INTO Alumnos (textBoxId, textBoxNombre, textBoxApellido) VALUES (@id_alumno, @Nombre_alumno, @Apellido_alumno)";
            SqlCommand insert = new SqlCommand(insertar, Conexion.Conexionsql());
            insert.Parameters.AddWithValue("@id_alumno", textBoxId);
            insert.Parameters.AddWithValue("@Nombre_alumno", textBoxNombre);
            insert.Parameters.AddWithValue("@Apellido_alumno", textBoxApellido);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
