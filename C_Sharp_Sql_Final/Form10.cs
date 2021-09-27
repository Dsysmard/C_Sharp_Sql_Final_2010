using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace C_Sharp_Sql_Final
{
    public partial class Matriculados : Form
    {
        public Matriculados()
        {
            InitializeComponent();
        }


        private bool iniciando = true;
        private DataTable dt;
        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");
        private string seleccion = "SELECT CodAlumno, Apellidos, Nombres FROM Alumnos";
        private SqlDataAdapter da;



        private void Form10_Load(object sender, EventArgs e)
        {
            this.txtApellidos.Text = "";
            da = new SqlDataAdapter(seleccion, miconexion);
            dt = new DataTable();
            da.Fill(dt);
            this.datosClientes.DataSource = dt;
            iniciando = false;

        }

        private void txtApellidos_TextChanged(object sender, EventArgs e)
        {
            if (iniciando) return;
            DataRow[] filas;
            filas = dt.Select("Apellidos LIKE '%" + txtApellidos.Text + "%'");
            this.listaApellidos.Items.Clear();
            {
                // Recorrer cada fila y mostrar los apellidos
                foreach (DataRow dr in filas)
                {
                    // También puedes mostrar cualquier otro campo,
                    // pero siempre que esté en la cadena de selección
                    // usada al cargar los datos
                    this.listaApellidos.Items.Add(dr["Apellidos"].ToString()  + ", " +
                    dr["Nombres"].ToString() + ", " + dr["CodAlumno"].ToString());
                }
            }

        }

        private void listaApellidos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}