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
    public partial class Form1 : System.Windows.Forms.Form
    {
        


        public Form1()
        {
            // Usar el tipo de letra Segoe UI en Vista & 7
            Font = SystemFonts.MessageBoxFont;

            InitializeComponent();
            
        }

    
        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent1()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxText = new System.Windows.Forms.TextBox();
            this.numericUpDownHeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxTitle = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Test";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(16, 14);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(232, 20);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.Text = "Title Text";
            // 
            // textBoxText
            // 
            this.textBoxText.Location = new System.Drawing.Point(16, 64);
            this.textBoxText.Name = "textBoxText";
            this.textBoxText.Size = new System.Drawing.Size(232, 20);
            this.textBoxText.TabIndex = 2;
            this.textBoxText.Text = "This is the body of text to be displayed";
            // 
            // numericUpDownHeight
            // 
            this.numericUpDownHeight.Location = new System.Drawing.Point(160, 96);
            this.numericUpDownHeight.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownHeight.Name = "numericUpDownHeight";
            this.numericUpDownHeight.Size = new System.Drawing.Size(40, 20);
            this.numericUpDownHeight.TabIndex = 4;
            this.numericUpDownHeight.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // numericUpDownWidth
            // 
            this.numericUpDownWidth.Location = new System.Drawing.Point(56, 96);
            this.numericUpDownWidth.Maximum = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            this.numericUpDownWidth.Name = "numericUpDownWidth";
            this.numericUpDownWidth.Size = new System.Drawing.Size(48, 20);
            this.numericUpDownWidth.TabIndex = 3;
            this.numericUpDownWidth.Value = new decimal(new int[] {
            130,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Width";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(120, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Height";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // checkBoxTitle
            // 
            this.checkBoxTitle.Checked = true;
            this.checkBoxTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTitle.Location = new System.Drawing.Point(144, 40);
            this.checkBoxTitle.Name = "checkBoxTitle";
            this.checkBoxTitle.Size = new System.Drawing.Size(104, 16);
            this.checkBoxTitle.TabIndex = 7;
            this.checkBoxTitle.Text = "Use Title Text";
            // 
            // Form1
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(264, 166);
            this.Controls.Add(this.checkBoxTitle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownWidth);
            this.Controls.Add(this.numericUpDownHeight);
            this.Controls.Add(this.textBoxText);
            this.Controls.Add(this.textBoxTitle);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "NotifyWindow Tester";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownHeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWidth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
        }
        //SqlConnection miconexion = new SqlConnection(" Data source=.\\sqlexpress;DataBase=Final_Algoritmos;Integrated Security=SSPI");
        //SqlConnection miconexion = new SqlConnection("Data Source=localhost;Initial Catalog=Final_Algoritmos;Integrated Security=True");
        //SqlConnection mi conexion=new SqlConnection("Data Source=oeacosta\sql2005;Initial Catalog=DatosPeliculas;Persist Security Info=True;User ID=admUsuarios;Password= ")
        SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");
        protected override void WndProc(ref Message m)
        {
            const int WM_NCHITTEST = 0x0084;    // Mouse Capture Test
            const int HTCAPTION = 0x002;        // Application Title Bar

            if (m.Msg == WM_NCHITTEST)
            {
                m.Result = new IntPtr(HTCAPTION);
                return;
            }

            base.WndProc(ref m);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Acceso();
            
         }

         protected void titleClick(object sender, System.EventArgs e)
         {
             //MessageBox.Show("Ud esta conectado a la Base de Datos");
         }

         protected void textClick(object sender, System.EventArgs e)
         {
             //MessageBox.Show("Todo en Orden");
         }

        public void Acceso()
        {
             miconexion.Open();
            SqlCommand consulta=new SqlCommand("select * from Usuarios where Usuario='" + txtnombre.Text + "'and Pass='" + txtpass.Text + "'", miconexion);
            SqlDataReader ejecuta = consulta.ExecuteReader();
            if (ejecuta.Read() == true)
            {
                if (txtnombre.Text == "Administrador")
                {
                    MessageBox.Show("Bienvenido: " + txtnombre.Text, "Sistema");

                    NotifyWindow nw;
                    if (checkBoxTitle.Checked)
                    {
                        nw = new NotifyWindow(textBoxTitle.Text, textBoxText.Text);
                        nw.TitleClicked += new System.EventHandler(titleClick);
                    }
                    else
                        nw = new NotifyWindow(textBoxText.Text);
                    nw.TextClicked += new System.EventHandler(textClick);
                    nw.SetDimensions((int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
                    nw.Notify();

                    this.Hide();
                    Sistema abrir = new Sistema();
                    abrir.Show();
                }
                else
                {
                    MessageBox.Show("Bienvenido: " + txtnombre.Text, "Sistema");
                    NotifyWindow nw;
                    if (checkBoxTitle.Checked)
                    {
                        nw = new NotifyWindow(textBoxTitle.Text, textBoxText.Text);
                        nw.TitleClicked += new System.EventHandler(titleClick);
                    }
                    else
                        nw = new NotifyWindow(textBoxText.Text);
                    nw.TextClicked += new System.EventHandler(textClick);
                    nw.SetDimensions((int)numericUpDownWidth.Value, (int)numericUpDownHeight.Value);
                    nw.Notify();
                    this.Hide();
                    Sistema abrir = new Sistema();
                    abrir.cursosToolStripMenuItem.Enabled = false;
                    abrir.Show();
                }
            }
            else if (txtnombre.Text == "")
            {
                MessageBox.Show("No deje Campos Vacios", "Acceso Denegado");
                txtnombre.Clear();
                txtpass.Clear();
                txtnombre.Focus();
                miconexion.Close();
            }
            else if (txtpass.Text == "")
            {
                MessageBox.Show("No deje Campos Vacios", "Acceso Denegado");
                txtnombre.Clear();
                txtpass.Clear();
                txtnombre.Focus();
                miconexion.Close();
            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta - Ingrese Datos Otra vez", "Acceso Denegado");
                txtnombre.Clear();
                txtpass.Clear();
                txtnombre.Focus();
                miconexion.Close();
            }
           
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Cerrar el formulario cuando se presiona la tecla Escape
            if (keyData == Keys.Escape)
                this.Close();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void txtpass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Acceso();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtnombre.Focus();
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtnombre_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtnombre_Enter(object sender, EventArgs e)
        {
            txtnombre.BackColor = Color.Yellow;
        }

        private void txtnombre_Leave(object sender, EventArgs e)
        {
            txtnombre.BackColor = Color.White;
        }

        private void txtpass_Enter(object sender, EventArgs e)
        {
            txtpass.BackColor = Color.Yellow;
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            txtpass.BackColor = Color.White;
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }
     
        
    }
}