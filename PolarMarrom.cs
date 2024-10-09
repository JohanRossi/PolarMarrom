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
        private List<Produto> produtosListados;

        public frmMenu()
        {
            InitializeComponent();
            produtosListados = new List<Produto>(); // Inicialização
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
            if (lsbListaPedidos.SelectedItems.Count > 0)
            {
                Produto produtoSelecionado = (Produto) lsbListaPedidos.SelectedItem;
                CriarItemPedido(produtoSelecionado);
            }
        }

        private void CriarItemPedido(Produto produtoSelecionado)
        {
            Item item = new Item(produtoSelecionado)
            {
                Quantidade = (int)nmrQuantidadeItem.Value,
                Valor = produtoSelecionado.Valor
            };

            pedidoAtual.Items.Add(item);
            AtualizarLista();
        }

        private void AtualizarLista()
        {
            lsbListaPedidos.Items.Clear();
            lsbListaPedidos.Items.AddRange(pedidoAtual.Items.Select(i => new ListViewItem(new[] { i.Produto.Nome, i.Valor.ToString("C") })).ToArray());
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void cmbProdutoProcurar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbProdutoProcurar.Text.Length < 2) return;

            produtosListados = listaProdutos
                .Where(p => p.Nome.Contains(cmbProdutoProcurar.Text))
                .ToList();

            CarregarListProdutos(produtosListados);
        }

        private void CarregarListProdutos(List<Produto> listaProdutos)
        {
            lsbListaPedidos.Items.Clear();

            foreach (var produto in listaProdutos)
            {
                ListViewItem item = new ListViewItem(produto.Nome);
                item.SubItems.Add(produto.Valor.ToString("C"));
                lsbListaPedidos.Items.Add(item);
            }
        }
    }
}
