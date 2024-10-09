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
    public partial class frmEditarProduto : Form
    {
        private List<Produto> listaProdutos;
        public frmEditarProduto()
        {
            InitializeComponent();
        }
        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            SalvarProduto();
        }
        private void SalvarProduto()
        {
            if (txtNomeProduto.Text.Length == 0)
            {
                MessageBox.Show("Escreva um nome para o produto!");
                return;
            }
            
            if (nmrValorDoProduto.Value == 0)
            {
                MessageBox.Show("Valor não pode ser zero!");
                return;
        }

            Produto produto = new Produto(txtNomeProduto.Text, rbtDescriçãoEditar.Text, nmrValorDoProduto.Value);
            listaProdutos.Add(produto);

            MessageBox.Show("Produto salvo com sucesso!");

            ArquivosJson.ExportarProdutosJson(listaProdutos);

            DialogResult resultado = MessageBox.Show(
                "Deseja cadastrar outro produto?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
        {
                txtNomeProduto.Clear();
                rbtDescriçãoEditar.Clear();
                nmrValorDoProduto.Value = 0;

                txtNomeProduto.Focus();
        }
            else
        {
                this.Close();
            }
        }

        private void FrmEditarProduto_Load(object sender, EventArgs e)
        {
            listaProdutos = ArquivosJson.ImportarProdutosJson();
        }
    }
}
