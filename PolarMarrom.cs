using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolarMarrom
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarProduto EditarProduto = new frmEditarProduto();
            DialogResult resposta = EditarProduto.ShowDialog();
        }
    }
}
