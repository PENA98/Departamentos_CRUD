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
    public partial class Eliminar : Form
    {
        public Eliminar()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Server=localhost; Database=AdventureWorks2014; User Id=MDPC; Password=12345");

            string elim = "exec sp_eliminar_departamento @name";

            SqlCommand cmd = new SqlCommand(elim, conn);

            try
            {
                conn.Open();

                using (cmd)
                {
                    cmd.Parameters.Add("@name", SqlDbType.VarChar).Value = textBox1.Text;

                    cmd.ExecuteNonQuery();

                    lblConf.Text = "Exito!";
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "Detalles de la excepcion!");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
