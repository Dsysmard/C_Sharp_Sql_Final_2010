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
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");
       
      
        private void Form9_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button2, "Salir");
            toolTip1.SetToolTip(button4, "Imprimir");
            miconexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select nombre from cursos";
            cmd.Connection = miconexion;
            SqlDataReader leer;
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {
                comboBox1.Items.Add(leer[0]);

            }
            miconexion.Close();

            leer.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            SqlCommand cmd = new SqlCommand("select Alumnos.CodAlumno, Alumnos.Apellidos From Alumnos inner join Cursos on Alumnos.CodCurso = Cursos.CodCurso where Cursos.Nombre like '" + comboBox1.Text + "'", miconexion);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            DataSet ds = new DataSet();
            da.Fill(ds, "Apellidos");
            dataGridView1.DataSource = ds.Tables["Apellidos"];




           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }
    }
}