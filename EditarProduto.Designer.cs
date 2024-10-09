namespace PolarMarrom
{
    partial class frmEditarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nmrValorDoProduto = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelarProduto = new System.Windows.Forms.Button();
            this.btnSalvarProduto = new System.Windows.Forms.Button();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.rbtDescriçãoEditar = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.nmrValorDoProduto)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Cyan;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(74, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valor:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Descrição";
            // 
            // nmrValorDoProduto
            // 
            this.nmrValorDoProduto.DecimalPlaces = 2;
            this.nmrValorDoProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmrValorDoProduto.Location = new System.Drawing.Point(116, 79);
            this.nmrValorDoProduto.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nmrValorDoProduto.Name = "nmrValorDoProduto";
            this.nmrValorDoProduto.Size = new System.Drawing.Size(302, 30);
            this.nmrValorDoProduto.TabIndex = 1;
            this.nmrValorDoProduto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nmrValorDoProduto.Enter += new System.EventHandler(this.nmrValorDoProduto_Enter);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.btnCancelarProduto);
            this.panel1.Controls.Add(this.btnSalvarProduto);
            this.panel1.Controls.Add(this.txtNomeProduto);
            this.panel1.Controls.Add(this.rbtDescriçãoEditar);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.nmrValorDoProduto);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(-36, 218);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(703, 486);
            this.panel1.TabIndex = 7;
            // 
            // btnCancelarProduto
            // 
            this.btnCancelarProduto.BackColor = System.Drawing.Color.Red;
            this.btnCancelarProduto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelarProduto.Location = new System.Drawing.Point(52, 282);
            this.btnCancelarProduto.Name = "btnCancelarProduto";
            this.btnCancelarProduto.Size = new System.Drawing.Size(119, 55);
            this.btnCancelarProduto.TabIndex = 4;
            this.btnCancelarProduto.Text = "Cancelar";
            this.btnCancelarProduto.UseVisualStyleBackColor = false;
            this.btnCancelarProduto.Click += new System.EventHandler(this.btnCancelarProduto_Click);
            // 
            // btnSalvarProduto
            // 
            this.btnSalvarProduto.BackColor = System.Drawing.Color.Lime;
            this.btnSalvarProduto.Location = new System.Drawing.Point(292, 282);
            this.btnSalvarProduto.Name = "btnSalvarProduto";
            this.btnSalvarProduto.Size = new System.Drawing.Size(126, 55);
            this.btnSalvarProduto.TabIndex = 3;
            this.btnSalvarProduto.Text = "Salvar";
            this.btnSalvarProduto.UseVisualStyleBackColor = false;
            this.btnSalvarProduto.Click += new System.EventHandler(this.btnSalvarProduto_Click);
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(116, 35);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(302, 26);
            this.txtNomeProduto.TabIndex = 0;
            // 
            // rbtDescriçãoEditar
            // 
            this.rbtDescriçãoEditar.Location = new System.Drawing.Point(48, 155);
            this.rbtDescriçãoEditar.Name = "rbtDescriçãoEditar";
            this.rbtDescriçãoEditar.Size = new System.Drawing.Size(370, 96);
            this.rbtDescriçãoEditar.TabIndex = 6;
            this.rbtDescriçãoEditar.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(89, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(217, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // frmEditarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(394, 573);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmEditarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadastrarProduto";
            this.Load += new System.EventHandler(this.FrmEditarProduto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrValorDoProduto)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nmrValorDoProduto;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rbtDescriçãoEditar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.Button btnCancelarProduto;
        private System.Windows.Forms.Button btnSalvarProduto;
    }
}