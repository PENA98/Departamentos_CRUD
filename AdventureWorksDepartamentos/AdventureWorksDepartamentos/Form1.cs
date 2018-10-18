using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureWorksDepartamentos
{
    public partial class Departamentos : Form
    {
        public Departamentos()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Listar vista = new Listar();
            vista.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Insertar vista = new Insertar();
            vista.Show();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Actualizar vista = new Actualizar();
            vista.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Eliminar vista = new Eliminar();
            vista.Show();
        }
    }
}
