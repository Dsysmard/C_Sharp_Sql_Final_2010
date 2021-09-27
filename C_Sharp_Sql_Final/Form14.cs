using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;

namespace C_Sharp_Sql_Final
{
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }

        byte[] fnLeerArchivo(string sDireccion)
        {
            FileStream fStream = new FileStream(sDireccion, FileMode.Open, FileAccess.Read);
            byte[] imgData = new byte[fStream.Length];

            // Lee la información del archivo
            fStream.Read(imgData, 0, (int)fStream.Length);
            fStream.Close();

            return imgData;
        }

        

       


        private void Form14_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Image newImage = null;

            // Configurar el ConnectionString
            string cs = @"Data Source=|DataDirectory|\dbImagenes.sdf";
            SqlCeConnection CN = new SqlCeConnection(cs);

            try
            {
                string qry = "select Nombre, Imagen from tblImagenes where Id = @InfoId";
                SqlCeCommand SqlCom = new SqlCeCommand(qry, CN);

                SqlCom.Parameters.Add(new SqlCeParameter("@InfoId", nudId.Value));

                CN.Open();

                SqlCeDataReader rdr = SqlCom.ExecuteReader();
                if (rdr.Read())
                {
                    txtNombre.Text = (string)rdr.GetValue(0);
                    byte[] imgData = (byte[])rdr.GetValue(1);

                    // Leer la imagen en memoria
                    using (MemoryStream ms = new MemoryStream(imgData, 0, imgData.Length))
                    {
                        ms.Write(imgData, 0, imgData.Length);

                        // Graba la imagen
                        newImage = Image.FromStream(ms, true);
                    }

                    // Establece la imagen
                    picImagen2.Image = newImage;
                }
                else
                {
                    MessageBox.Show("No existen registros con ese número de Identidad");
                }

                newImage = null;
                CN.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Imágenes|*.jpg;*.bmp;*.gif;*.png;*.jpeg";
            DialogResult dlgRes = dlg.ShowDialog();

            if (dlgRes != DialogResult.Cancel)
            {
                // Mostrar la imagen y la dirección
                txtDireccion.Text = dlg.FileName;
                picImagen1.ImageLocation = dlg.FileName;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Preparar la información para almacenarla
                string strName = Path.GetFileNameWithoutExtension(txtDireccion.Text);
                byte[] imageData = fnLeerArchivo(txtDireccion.Text);

                // Configurar el ConnectionString
                string cs = @"Data Source=|DataDirectory|\dbImagenes.sdf";
                SqlCeConnection CN = new SqlCeConnection(cs);

                // Configurar el query
                string qry = "insert into tblImagenes (Nombre, Imagen) values (@InfoNombre, @InfoImagen)";
                SqlCeCommand SqlCom = new SqlCeCommand(qry, CN);

                // Configurar los parametros
                SqlCom.Parameters.Add(new SqlCeParameter("@InfoNombre", strName));
                SqlCom.Parameters.Add(new SqlCeParameter("@InfoImagen", (object)imageData));

                // Abre la conexión y ejecuta el query
                CN.Open();
                SqlCom.ExecuteNonQuery();
                CN.Close();

                imageData = null;

                MessageBox.Show("Imagen almacenada correctamente!");
            }
            catch (Exception ex)
            {
                // Muestra un dialogo del error producido
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
