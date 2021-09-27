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
    public partial class Modificar_Profesor : Form
    {
        public Modificar_Profesor()
        {
            InitializeComponent();
        }
        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");
        public string nc_profesor_seleccionado;

        private void Modificar_Profesor_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button1, "Modifica Registro");
            toolTip1.SetToolTip(button2, "Salir");
            carga_registros_profesor();
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
        void carga_registros_profesor()
        {
            SqlCommand comando = new SqlCommand("select * from Profesores where CodProfesor = '" + nc_profesor_seleccionado + "'", miconexion);
            miconexion.Open();
            SqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                textBox1.Text = leer.GetString(0);
                textBox2.Text = leer.GetString(1);
                textBox3.Text = leer.GetString(2);
                textBox4.Text = leer.GetString(3);
                textBox5.Text = leer.GetString(4);
                textBox6.Text = leer.GetString(5);
                textBox7.Text = leer.GetString(6);
            }
            miconexion.Close();

        }

      

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlCommand comando = new SqlCommand("update Profesores set Nombres=@Nombres,Apellidos=@Apellidos,Direccion=@Direccion,Telefono=@Telefono,EMail=@EMail,CodCurso=@CodCurso where CodProfesor=@CodProfesor", miconexion);
            comando.Parameters.AddWithValue("CodProfesor", nc_profesor_seleccionado);
            comando.Parameters.AddWithValue("Nombres", textBox2.Text);
            comando.Parameters.AddWithValue("Apellidos", textBox3.Text);
            comando.Parameters.AddWithValue("Direccion", textBox4.Text);
            comando.Parameters.AddWithValue("Telefono", textBox5.Text);
            comando.Parameters.AddWithValue("EMail", textBox6.Text);
            comando.Parameters.AddWithValue("CodCurso", textBox7.Text);
            miconexion.Open();
            comando.ExecuteNonQuery();
            miconexion.Close();

            MessageBox.Show("Registro Modificado Satisfactoriamente", "Sistema");

            this.Hide();
            Profesores_add Form7 = new Profesores_add();
            Form7.MdiParent = this.MdiParent;
            Form7.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
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

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.White;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.BackColor = Color.Yellow;
        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.Yellow;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.BackColor = Color.White;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.White;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.BackColor = Color.Yellow;
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
    }
}