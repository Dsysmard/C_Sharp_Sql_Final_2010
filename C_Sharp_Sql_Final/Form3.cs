using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace C_Sharp_Sql_Final
{
    public partial class Alumnos_add : Form
    {
        public Alumnos_add()
        {
            InitializeComponent();
        }
        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Altas_Alumnos Form4 = new Altas_Alumnos();
            Form4.MdiParent = this.MdiParent;
            Form4.Show();
        }

        private void Alumnos_add_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Agrega Registro");
            toolTip1.SetToolTip(button2, "Elimina Registro");
            toolTip1.SetToolTip(button3, "Cambio de Curso");
            toolTip1.SetToolTip(button4, "Imprimir");
            Muestra_Alumnos();
        }
        void Muestra_Alumnos()
        {
            SqlCommand comando = new SqlCommand("select * from Alumnos", miconexion);
            miconexion.Open();

            SqlDataReader leer = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            int renglon = 0;
            while (leer.Read())
            {
                renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["CodAlumno"].Value = leer.GetString(0);
                dataGridView1.Rows[renglon].Cells["Nombres"].Value = leer.GetString(1);
                dataGridView1.Rows[renglon].Cells["Apellidos"].Value = leer.GetString(2);
                dataGridView1.Rows[renglon].Cells["CodCurso"].Value = leer.GetString(3);
            }
            miconexion.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modificar_Alumno ob = new Modificar_Alumno();
            string seleccionado = (string)dataGridView1.CurrentRow.Cells["CodAlumno"].Value;
            ob.nc_alumno_seleccionado = seleccionado;
            this.Hide();
            ob.MdiParent = this.MdiParent;
            ob.Show();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            //Sistema Form4 = new Sistema();
            ////Form.MdiParent = this.MdiParent;
            //Sistema.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas Seguro de Eliminar el Registro Seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            SqlCommand comando = new SqlCommand("delete from Alumnos where CodAlumno=@CodAlumno", miconexion);
            comando.Parameters.AddWithValue("CodAlumno", dataGridView1.CurrentRow.Cells["CodAlumno"].Value);
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Registro Eliminado Satisfactoriamente", "Sistema");

            Muestra_Alumnos();
        }


        //MANDAR A EXCELL

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
        

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}