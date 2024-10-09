using PolarMarrom.Classes;
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
        private Pedido pedidoAtual;
        private List<Produto> listaProdutos;
        List<Produto> produtosListados;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void editarProdutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEditarProduto frmeditarProduto = new frmEditarProduto();
            frmeditarProduto.Show();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            listaProdutos = ArquivosJson.ImportarProdutosJson();
            pedidoAtual = new Pedido();
        }
        private void btnAdicionarItem_Click(object sender, EventArgs e)
        {

        }

        private void CriarItemPedido(Produto produtoSelected)
        {
            Item item = new Item(produtoSelected);
            item.Quantidade = (int)nmrQuantidadeItem.Value;
            item.Valor = produtoSelected.Valor;
        }

        private void Atualizarlista()
        {
            lsbListaPedidos.Items.Clear();
            lsbListaPedidos.Items.AddRange(pedidoAtual.Items.ToArray());
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
