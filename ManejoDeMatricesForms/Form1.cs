using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejoDeMatricesForms
{
    public partial class panelAyuda : Form
    {
        public panelAyuda()
        {
            InitializeComponent();
        }

        private void Regresar_Click(object sender, EventArgs e)
        {
            formEjercicio ejercicio = new formEjercicio(); // Crea una instancia del formulario "EJERCICIO"
            ejercicio.Show(); // Muestra el formulario "menu"
            this.Hide(); // Opcional: oculta el formulario actual
        }
    }
}
