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
    public partial class Listar : Form
    {
        public Listar()
        {
            InitializeComponent();
        }

        private void Listar_Load(object sender, EventArgs e)
        {
            // Coneccion
            string connstring = @"server = localhost; database = AdventureWorks2014;
                                Integrated Security = true;";

            //
            string sql = @"Select * from HumanResources.Department";

            SqlConnection conn = new SqlConnection(connstring);

            try
            {
                SqlDataAdapter da = new SqlDataAdapter();

                da.SelectCommand = new SqlCommand(sql, conn);

                DataSet ds = new DataSet();

                da.Fill(ds, "HumanResources.Department");

                DataTable dt = ds.Tables[ "HumanResources.Department"];

                DataView vista1 = new DataView(dt);

                DV.DataSource = vista1;


            }
            catch (SqlException ex )
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
