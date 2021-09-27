using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

using System.Windows.Forms;

namespace C_Sharp_Sql_Final
{
    public partial class Sistema : Form
    {
        public Sistema()
        {
            InitializeComponent();
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void Sistema_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void profesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void matriculadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void mantenimientoDeAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alumnos_add form3 = new Alumnos_add();
            form3.MdiParent = this;
            form3.Show();
        }

        private void buscarAlumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Matriculados form10 = new Matriculados();
            form10.MdiParent = this;
            form10.Show();
        }

        private void mantenimientoDeProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Profesores_add form6 = new Profesores_add();
            form6.MdiParent = this;
            form6.Show();
        }

        private void buscarProfesoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscarprofes form11 = new Buscarprofes();
            form11.MdiParent = this;
            form11.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
            
           

        }

      

      

      

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void mostrarAplicacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Visible = !this.Visible;
            //notifyIcon1.Visible = !this.Visible;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Dispose();
        }

        private void notifyIcon1_Click(object sender, EventArgs e)
        {
            this.Visible = !this.Visible;
            notifyIcon1.Visible = !this.Visible;
        }

        private void cambiarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 form1 = new Form1();
            //form1.MdiParent = this;
            form1.Show();
        }

        private void salirToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            notifyIcon1.Visible = true;
            notifyIcon1.BalloonTipText = "Ejecutando Sistema\n" + "Alexander.michell@live.com";
            notifyIcon1.BalloonTipTitle = "Michell School";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon1.ShowBalloonTip(5000);
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Cursos form9 = new Cursos();
            form9.MdiParent = this;
            form9.Show();
        }

        private void alumnosXCursoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form12 form12 = new Form12();
            form12.MdiParent = this;
            form12.Show();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Cerrar el formulario cuando se presiona la tecla Escape
            if (keyData == Keys.Escape)
                this.Close();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void fotosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form14 form14 = new Form14();
            form14.MdiParent = this;
            form14.Show();
        }

        
        }
    }

