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
    public partial class Altas_Alumnos : Form
    {
        public Altas_Alumnos()
        {
            InitializeComponent();
        }
        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "")
            {
                MessageBox.Show("Ingrese Nombres", "Advertencia");
                textBox2.Focus();

            }
            else if (textBox4.Text=="")
            {
                    MessageBox.Show("Seleccione Curso", "Advertencia");
                    comboBox1.Focus();

            }
            else
            {
                SqlCommand comando = new SqlCommand("insert into Alumnos(CodAlumno, Nombres, Apellidos,CodCurso)values(@CodAlumno,@Nombres,@Apellidos,@CodCurso)", miconexion);
                comando.Parameters.AddWithValue("CodAlumno", textBox1.Text);
                comando.Parameters.AddWithValue("Nombres", textBox2.Text);
                comando.Parameters.AddWithValue("Apellidos", textBox3.Text);
                comando.Parameters.AddWithValue("CodCurso", textBox4.Text);
                miconexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado Satisfactoriamente", "Sistema");
               
                this.Hide();
                Alumnos_add Form4 = new Alumnos_add();
                Form4.MdiParent = this.MdiParent;
                Form4.Show();
                }
        }

        private void Altas_Alumnos_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Agrega Registro");
            toolTip1.SetToolTip(button2, "Salir");

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Alumnos_add Form4 = new Alumnos_add();
            Form4.MdiParent = this.MdiParent;
            Form4.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Ingrese Apellidos", "Advertencia");
                textBox3.Focus();
            }
            else
            {
                textBox3.BackColor = Color.White;
                String p, t, u, l, n, c;
                n = (textBox3.Text);
                p = n.Substring(0, 1);
                t = n.Substring(2, 1);
                u = n.Substring(n.Length - 1);
                l = (n.Trim().Length).ToString();
                c = (p + t + u + l).ToUpper();
                textBox1.Text = "013" + c.ToString();
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox3_MouseLeave(object sender, EventArgs e)
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}