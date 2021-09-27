namespace C_Sharp_Sql_Final
{
    partial class Buscarprofes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Buscarprofes));
            this.label1 = new System.Windows.Forms.Label();
            this.datosClientes = new System.Windows.Forms.DataGridView();
            this.listaApellidos = new System.Windows.Forms.ListBox();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datosClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese Apellidos del Profesor";
            // 
            // datosClientes
            // 
            this.datosClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datosClientes.Location = new System.Drawing.Point(254, 112);
            this.datosClientes.Name = "datosClientes";
            this.datosClientes.Size = new System.Drawing.Size(21, 26);
            this.datosClientes.TabIndex = 6;
            this.datosClientes.Visible = false;
            // 
            // listaApellidos
            // 
            this.listaApellidos.FormattingEnabled = true;
            this.listaApellidos.Location = new System.Drawing.Point(38, 67);
            this.listaApellidos.Name = "listaApellidos";
            this.listaApellidos.Size = new System.Drawing.Size(210, 160);
            this.listaApellidos.TabIndex = 5;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Location = new System.Drawing.Point(58, 31);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(170, 20);
            this.txtApellidos.TabIndex = 4;
            this.txtApellidos.TextChanged += new System.EventHandler(this.txtApellidos_TextChanged);
            // 
            // Buscarprofes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 243);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.datosClientes);
            this.Controls.Add(this.listaApellidos);
            this.Controls.Add(this.txtApellidos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 281);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(300, 281);
            this.Name = "Buscarprofes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Profesor";
            this.Load += new System.EventHandler(this.Buscarprofes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datosClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView datosClientes;
        private System.Windows.Forms.ListBox listaApellidos;
        private System.Windows.Forms.TextBox txtApellidos;
    }
}