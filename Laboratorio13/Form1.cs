using System.Data.SqlClient;
using System.Data;
using Microsoft.Data.SqlClient;
using System;

namespace Laboratorio13
{
    public partial class Form1 : Form
    {

        private string connectionString = "Server=.\sqlexpress;Database=Northwind;TrustServerCertificate=true;Integrated Security=SSPI;";

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conexion = new SqlConnection(connectionString);
                conexion.Open();

                MessageBox.Show("Se abri� la conexi�n con el servidor SQL Server y se seleccion� la base de datos");

                SqlCommand cmd = new SqlCommand("select ProductName from Products ", conexion);

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    lista.Items.Add(reader.GetString(0));
                }
                
                conexion.Close();
                MessageBox.Show("Se cerr� la conexi�n.");



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
