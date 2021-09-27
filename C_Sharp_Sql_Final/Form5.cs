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
    public partial class Modificar_Alumno : Form
    {
        public Modificar_Alumno()
        {
            InitializeComponent();
        }
        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");
        public string nc_alumno_seleccionado;

        private void Form5_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Cambiar Curso");
            toolTip1.SetToolTip(button2, "Salir");
            carga_registros();
            miconexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select Nombre from cursos";
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
        void carga_registros()
       {
        SqlCommand comando = new SqlCommand("select * from Alumnos where CodAlumno ='" + nc_alumno_seleccionado + "'", miconexion);
        miconexion.Open();
        SqlDataReader leer = comando.ExecuteReader();
        if (leer.Read())
        {
            textBox1.Text = leer.GetString(0);
            textBox2.Text = leer.GetString(1);
            textBox3.Text = leer.GetString(2);
            textBox4.Text = leer.GetString(3);
       
        }
        miconexion.Close();

       }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlCommand comando = new SqlCommand("update Alumnos set CodAlumno=@CodAlumno,Nombres=@Nombres,Apellidos=@Apellidos,CodCurso=CodCurso where CodAlumno=@CodAlumno", miconexion);
           
                SqlCommand comando = new SqlCommand("update Alumnos SET Nombres=@Nombres,Apellidos=@Apellidos, CodCurso=@CodCurso FROM Cursos WHERE CodAlumno=@CodAlumno ", miconexion);
                comando.Parameters.AddWithValue("CodAlumno", nc_alumno_seleccionado);
                comando.Parameters.AddWithValue("Nombres", textBox2.Text);
                comando.Parameters.AddWithValue("Apellidos", textBox3.Text);
                comando.Parameters.AddWithValue("CodCurso", textBox4.Text);
                miconexion.Open();
                comando.ExecuteNonQuery();
                miconexion.Close();

                MessageBox.Show("Registro Modificado Satisfactoriamente", "Sistema");
       

            this.Hide();
            Alumnos_add Form4 = new Alumnos_add();
            Form4.MdiParent = this.MdiParent;
            Form4.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alumnos_add Form4 = new Alumnos_add();
            Form4.MdiParent = this.MdiParent;
            Form4.Show();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Yellow;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
           
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            miconexion.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select CodCurso from cursos where nombre= '" + comboBox1.Text + "'";
            cmd.Connection = miconexion;
            SqlDataReader leer;
            leer = cmd.ExecuteReader();
            while (leer.Read())
            {

                textBox4.Text = leer[0].ToString();

            }
            miconexion.Close();

            leer.Close();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
