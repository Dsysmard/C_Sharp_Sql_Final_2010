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
    public partial class Form12 : Form
    {
        private DataGridView masterDataGridView = new DataGridView();
        private BindingSource masterBindingSource = new BindingSource();
        private DataGridView detailsDataGridView = new DataGridView();
        private BindingSource detailsBindingSource = new BindingSource();

        [STAThreadAttribute()]
        public static void Main()
        {
            Application.Run(new Form12());
        }

        public Form12()
        {
            InitializeComponent();
            //masterDataGridView.Dock = DockStyle.Fill;
            //detailsDataGridView.Dock = DockStyle.Fill;

            //SplitContainer splitContainer1 = new SplitContainer();
            //splitContainer1.Dock = DockStyle.Fill;
            //splitContainer1.Orientation = Orientation.Horizontal;
            //splitContainer1.Panel1.Controls.Add(masterDataGridView);
            //splitContainer1.Panel2.Controls.Add(detailsDataGridView);

            //this.Controls.Add(splitContainer1);
            //this.Load += new System.EventHandler(Form12_Load);
            //this.Text = "Cursos x Alumnos";
        }

        private void GetData()
        {
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                String connectionString =
                    "Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI";
                SqlConnection connection = new SqlConnection(connectionString);

                // Create a DataSet.
                DataSet data = new DataSet();
                data.Locale = System.Globalization.CultureInfo.InvariantCulture;

                // Add data from the Customers table to the DataSet.
                SqlDataAdapter masterDataAdapter = new
                    SqlDataAdapter("select Nombre, CodCurso from Cursos", connection);
                masterDataAdapter.Fill(data, "Cursos");

                // Add data from the Orders table to the DataSet.
                SqlDataAdapter detailsDataAdapter = new
                    SqlDataAdapter("select CodCurso, Apellidos, CodAlumno from Alumnos", connection);
                detailsDataAdapter.Fill(data, "Alumnos");

                // Establish a relationship between the two tables.
                DataRelation relation = new DataRelation("CursosAlumnos",
                    data.Tables["Cursos"].Columns["CodCurso"],
                    data.Tables["Alumnos"].Columns["CodCurso"]);
                data.Relations.Add(relation);

                // Bind the master data connector to the Customers table.
                masterBindingSource.DataSource = data;
                masterBindingSource.DataMember = "Cursos";

                // Bind the details data connector to the master data connector,
                // using the DataRelation name to filter the information in the 
                // details table based on the current row in the master table. 
                detailsBindingSource.DataSource = masterBindingSource;
                detailsBindingSource.DataMember = "CursosAlumnos";
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {

            //SqlConnection miconexion = new SqlConnection("Data source=(local);DataBase=Final_Algoritmos;Integrated Security=SSPI");
            // Bind the DataGridView controls to the BindingSource
            // components and load the data from the database.
            masterDataGridView.DataSource = masterBindingSource;
            detailsDataGridView.DataSource = detailsBindingSource;
            GetData();

            // Resize the master DataGridView columns to fit the newly loaded data.
            masterDataGridView.AutoResizeColumns();

            // Configure the details DataGridView so that its columns automatically
            // adjust their widths when the data changes.
            detailsDataGridView.AutoSizeColumnsMode =
                DataGridViewAutoSizeColumnsMode.AllCells;

        }
    }
}