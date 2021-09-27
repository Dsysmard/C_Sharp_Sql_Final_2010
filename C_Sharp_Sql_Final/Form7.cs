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
    public partial class Altas_Profesores : Form
    {
        public Altas_Profesores()
        {
            InitializeComponent();
        }
        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");

        private void Form7_Load(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "")
            {
                MessageBox.Show("No Deje Campos Vacios", "Advertencia");
                textBox2.Focus();

            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Seleccione Curso", "Advertencia");
                comboBox1.Focus();

            }
            else
            {
                SqlCommand comando = new SqlCommand("insert into Profesores(CodProfesor, Nombres, Apellidos, Direccion, Telefono, EMail, CodCurso)values(@CodProfesor,@Nombres,@Apellidos,@Direccion,@Telefono,@EMail,@CodCurso)", miconexion);
                comando.Parameters.AddWithValue("CodProfesor", textBox1.Text);
                comando.Parameters.AddWithValue("Nombres", textBox2.Text);
                comando.Parameters.AddWithValue("Apellidos", textBox3.Text);
                comando.Parameters.AddWithValue("Direccion", textBox4.Text);
                comando.Parameters.AddWithValue("Telefono", textBox5.Text);
                comando.Parameters.AddWithValue("EMail", textBox6.Text);
                comando.Parameters.AddWithValue("CodCurso", textBox7.Text);
                miconexion.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Registro Agregado Satisfactoriamente", "Sistema");

                this.Hide();
                Profesores_add Form7 = new Profesores_add();
                Form7.MdiParent = this.MdiParent;
                Form7.Show();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Profesores_add Form7 = new Profesores_add();
            Form7.MdiParent = this.MdiParent;
            Form7.Show();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar))
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

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

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
                textBox1.Text = "PRO" + c.ToString();
            }
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

                textBox7.Text = leer[0].ToString();

            }
            miconexion.Close();

            leer.Close();
        }

        private void textBox2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.BackColor = Color.Yellow;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Yellow;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Yellow;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.BackColor = Color.Yellow;
        }
    }
}