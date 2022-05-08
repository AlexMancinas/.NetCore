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

    }
}
