using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1
{
    public partial class Gestion_Activo_Fijo : Form
    {
        public Gestion_Activo_Fijo()
        {
            InitializeComponent();
        }

        private void Nuevo(object sender, EventArgs e)
        {
            FmdActivoFijo fmd = new FmdActivoFijo();
            fmd.Show();
        }

        private void Gestion_Activo_Fijo_Load(object sender, EventArgs e)
        {

        }

        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
