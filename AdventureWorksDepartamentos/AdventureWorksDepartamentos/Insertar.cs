using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace AdventureWorksDepartamentos
{
    public partial class Insertar : Form
    {
        public Insertar()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=localhost; Database=AdventureWorks2014; User Id=MDPC;
                                    Password=12345;");

            string ins = @"exec sp_insertar_departamento @name , @descripcion";

            SqlCommand cmd = new SqlCommand(ins, conn);

            try
            {
                conn.Open();
                using (cmd)
                {
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = txtNombre.Text;
                    cmd.Parameters.Add("@descripcion", SqlDbType.VarChar).Value = txtDescripcion.Text;

                    cmd.ExecuteNonQuery();

                    lblConfirmacion.Text = "Exito!";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepcion");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
