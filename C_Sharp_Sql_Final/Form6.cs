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
    public partial class Profesores_add : Form
    {
        public Profesores_add()
        {
            InitializeComponent();
        }
        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");

        private void Profesores_add_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Agrega Registro");
            toolTip1.SetToolTip(button2, "Elimina Registro");
            toolTip1.SetToolTip(button3, "Editar Registro");
            toolTip1.SetToolTip(button4, "Imprimir");
            toolTip1.SetToolTip(button4, "Salir");
            Muestra_Profesores();
        }
        void Muestra_Profesores()
        {
            SqlCommand comando = new SqlCommand("select * from Profesores", miconexion);
            miconexion.Open();

            SqlDataReader leer = comando.ExecuteReader();
            dataGridView1.Rows.Clear();
            int renglon = 0;
            while (leer.Read())
            {
                renglon = dataGridView1.Rows.Add();
                dataGridView1.Rows[renglon].Cells["CodProfesor"].Value = leer.GetString(0);
                dataGridView1.Rows[renglon].Cells["Nombres"].Value = leer.GetString(1);
                dataGridView1.Rows[renglon].Cells["Apellidos"].Value = leer.GetString(2);
                dataGridView1.Rows[renglon].Cells["Direccion"].Value = leer.GetString(3);
                dataGridView1.Rows[renglon].Cells["Telefono"].Value = leer.GetString(4);
                dataGridView1.Rows[renglon].Cells["EMail"].Value = leer.GetString(5);
                dataGridView1.Rows[renglon].Cells["CodCurso"].Value = leer.GetString(6);
            }
            miconexion.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Altas_Profesores Form7 = new Altas_Profesores();
            Form7.MdiParent = this.MdiParent;
            Form7.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Estas Seguro de Eliminar el Registro Seleccionado?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.No)
            {
                return;
            }

            SqlCommand comando = new SqlCommand("delete from Profesores where CodProfesor=@CodProfesor", miconexion);
            comando.Parameters.AddWithValue("CodProfesor", dataGridView1.CurrentRow.Cells["CodProfesor"].Value);
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();
            MessageBox.Show("Registro Eliminado Satisfactoriamente", "Sistema");

            Muestra_Profesores();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Modificar_Profesor ob = new Modificar_Profesor();
            string seleccionado = (string)dataGridView1.CurrentRow.Cells["CodProfesor"].Value;
            ob.nc_profesor_seleccionado = seleccionado;
            this.Hide();
            ob.MdiParent = this.MdiParent;
            ob.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(bm, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}