namespace C_Sharp_Sql_Final
{
    partial class Sistema
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sistema));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAlumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoDeProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarProfesoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alumnosXCursoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cursosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cambiarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minimizarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarAplicacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.fotosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.YellowGreen;
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.profesoresToolStripMenuItem,
            this.cursosToolStripMenuItem,
            this.sistemaToolStripMenuItem,
            this.minimizarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeAlumnosToolStripMenuItem,
            this.buscarAlumnosToolStripMenuItem,
            this.fotosToolStripMenuItem});
            this.alumnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosToolStripMenuItem.Image")));
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            this.alumnosToolStripMenuItem.Click += new System.EventHandler(this.alumnosToolStripMenuItem_Click);
            // 
            // mantenimientoDeAlumnosToolStripMenuItem
            // 
            this.mantenimientoDeAlumnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoDeAlumnosToolStripMenuItem.Image")));
            this.mantenimientoDeAlumnosToolStripMenuItem.Name = "mantenimientoDeAlumnosToolStripMenuItem";
            this.mantenimientoDeAlumnosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.mantenimientoDeAlumnosToolStripMenuItem.Text = "Mantenimiento de Alumnos";
            this.mantenimientoDeAlumnosToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeAlumnosToolStripMenuItem_Click);
            // 
            // buscarAlumnosToolStripMenuItem
            // 
            this.buscarAlumnosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarAlumnosToolStripMenuItem.Image")));
            this.buscarAlumnosToolStripMenuItem.Name = "buscarAlumnosToolStripMenuItem";
            this.buscarAlumnosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.buscarAlumnosToolStripMenuItem.Text = "Buscar Alumnos";
            this.buscarAlumnosToolStripMenuItem.Click += new System.EventHandler(this.buscarAlumnosToolStripMenuItem_Click);
            // 
            // profesoresToolStripMenuItem
            // 
            this.profesoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoDeProfesoresToolStripMenuItem,
            this.buscarProfesoresToolStripMenuItem});
            this.profesoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("profesoresToolStripMenuItem.Image")));
            this.profesoresToolStripMenuItem.Name = "profesoresToolStripMenuItem";
            this.profesoresToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.profesoresToolStripMenuItem.Text = "Profesores";
            this.profesoresToolStripMenuItem.Click += new System.EventHandler(this.profesoresToolStripMenuItem_Click);
            // 
            // mantenimientoDeProfesoresToolStripMenuItem
            // 
            this.mantenimientoDeProfesoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mantenimientoDeProfesoresToolStripMenuItem.Image")));
            this.mantenimientoDeProfesoresToolStripMenuItem.Name = "mantenimientoDeProfesoresToolStripMenuItem";
            this.mantenimientoDeProfesoresToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.mantenimientoDeProfesoresToolStripMenuItem.Text = "Mantenimiento de Profesores";
            this.mantenimientoDeProfesoresToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoDeProfesoresToolStripMenuItem_Click);
            // 
            // buscarProfesoresToolStripMenuItem
            // 
            this.buscarProfesoresToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("buscarProfesoresToolStripMenuItem.Image")));
            this.buscarProfesoresToolStripMenuItem.Name = "buscarProfesoresToolStripMenuItem";
            this.buscarProfesoresToolStripMenuItem.Size = new System.Drawing.Size(230, 22);
            this.buscarProfesoresToolStripMenuItem.Text = "Buscar Profesores";
            this.buscarProfesoresToolStripMenuItem.Click += new System.EventHandler(this.buscarProfesoresToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem
            // 
            this.cursosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosXCursoToolStripMenuItem,
            this.cursosToolStripMenuItem1});
            this.cursosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cursosToolStripMenuItem.Image")));
            this.cursosToolStripMenuItem.Name = "cursosToolStripMenuItem";
            this.cursosToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.cursosToolStripMenuItem.Text = "Cursos";
            this.cursosToolStripMenuItem.Click += new System.EventHandler(this.cursosToolStripMenuItem_Click);
            // 
            // alumnosXCursoToolStripMenuItem
            // 
            this.alumnosXCursoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("alumnosXCursoToolStripMenuItem.Image")));
            this.alumnosXCursoToolStripMenuItem.Name = "alumnosXCursoToolStripMenuItem";
            this.alumnosXCursoToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.alumnosXCursoToolStripMenuItem.Text = "Alumnos x Curso";
            this.alumnosXCursoToolStripMenuItem.Click += new System.EventHandler(this.alumnosXCursoToolStripMenuItem_Click);
            // 
            // cursosToolStripMenuItem1
            // 
            this.cursosToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("cursosToolStripMenuItem1.Image")));
            this.cursosToolStripMenuItem1.Name = "cursosToolStripMenuItem1";
            this.cursosToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.cursosToolStripMenuItem1.Text = "Cursos";
            this.cursosToolStripMenuItem1.Click += new System.EventHandler(this.cursosToolStripMenuItem1_Click);
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cambiarUsuarioToolStripMenuItem,
            this.salirToolStripMenuItem1});
            this.sistemaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sistemaToolStripMenuItem.Image")));
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // cambiarUsuarioToolStripMenuItem
            // 
            this.cambiarUsuarioToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cambiarUsuarioToolStripMenuItem.Image")));
            this.cambiarUsuarioToolStripMenuItem.Name = "cambiarUsuarioToolStripMenuItem";
            this.cambiarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.cambiarUsuarioToolStripMenuItem.Text = "Cambiar Usuario";
            this.cambiarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.cambiarUsuarioToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem1
            // 
            this.salirToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem1.Image")));
            this.salirToolStripMenuItem1.Name = "salirToolStripMenuItem1";
            this.salirToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.salirToolStripMenuItem1.Text = "Salir";
            this.salirToolStripMenuItem1.Click += new System.EventHandler(this.salirToolStripMenuItem1_Click);
            // 
            // minimizarToolStripMenuItem
            // 
            this.minimizarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("minimizarToolStripMenuItem.Image")));
            this.minimizarToolStripMenuItem.Name = "minimizarToolStripMenuItem";
            this.minimizarToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.minimizarToolStripMenuItem.Text = "Minimizar";
            this.minimizarToolStripMenuItem.Click += new System.EventHandler(this.minimizarToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarAplicacionToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // mostrarAplicacionToolStripMenuItem
            // 
            this.mostrarAplicacionToolStripMenuItem.Name = "mostrarAplicacionToolStripMenuItem";
            this.mostrarAplicacionToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mostrarAplicacionToolStripMenuItem.Text = "Mostrar Aplicacion";
            this.mostrarAplicacionToolStripMenuItem.Click += new System.EventHandler(this.mostrarAplicacionToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Michell School";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.Click += new System.EventHandler(this.notifyIcon1_Click);
            // 
            // fotosToolStripMenuItem
            // 
            this.fotosToolStripMenuItem.Name = "fotosToolStripMenuItem";
            this.fotosToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.fotosToolStripMenuItem.Text = "Fotos";
            this.fotosToolStripMenuItem.Click += new System.EventHandler(this.fotosToolStripMenuItem_Click);
            // 
            // Sistema
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(884, 609);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sistema";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Michell School [Sistema Académico Ver. 2.00.19]";
            this.Load += new System.EventHandler(this.Sistema_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profesoresToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarAlumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoDeProfesoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarProfesoresToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ToolStripMenuItem mostrarAplicacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minimizarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alumnosXCursoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cursosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fotosToolStripMenuItem;
    }
}