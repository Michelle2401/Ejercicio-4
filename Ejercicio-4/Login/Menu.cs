using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VistaLog
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Userforms userforms = new Userforms();
            userforms.Show();

        }
    }
}
