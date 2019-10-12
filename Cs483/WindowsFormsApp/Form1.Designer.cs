namespace WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.txtCpfCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.txtFantasia = new System.Windows.Forms.TextBox();
            this.lbNomeFantasia = new System.Windows.Forms.Label();
            this.btInserir = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btListar = new System.Windows.Forms.Button();
            this.gdListas = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gdListas)).BeginInit();
            this.SuspendLayout();
            // 
            // cbTipoPessoa
            // 
            this.cbTipoPessoa.BackColor = System.Drawing.SystemColors.Window;
            this.cbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTipoPessoa.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTipoPessoa.FormattingEnabled = true;
            this.cbTipoPessoa.Items.AddRange(new object[] {
            "F",
            "J"});
            this.cbTipoPessoa.Location = new System.Drawing.Point(32, 20);
            this.cbTipoPessoa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbTipoPessoa.Name = "cbTipoPessoa";
            this.cbTipoPessoa.Size = new System.Drawing.Size(40, 27);
            this.cbTipoPessoa.TabIndex = 2;
            this.cbTipoPessoa.SelectedIndexChanged += new System.EventHandler(this.CbTipoPessoa_SelectedIndexChanged);
            // 
            // txtCpfCnpj
            // 
            this.txtCpfCnpj.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCpfCnpj.Location = new System.Drawing.Point(83, 20);
            this.txtCpfCnpj.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCpfCnpj.Mask = "000.000.000-00";
            this.txtCpfCnpj.Name = "txtCpfCnpj";
            this.txtCpfCnpj.Size = new System.Drawing.Size(161, 26);
            this.txtCpfCnpj.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(83, 146);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(337, 26);
            this.txtEmail.TabIndex = 7;
            this.txtEmail.TextChanged += new System.EventHandler(this.TxtEmail_TextChanged);
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(83, 64);
            this.txtNome.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(337, 26);
            this.txtNome.TabIndex = 6;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(25, 149);
            this.lbEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 19);
            this.lbEmail.TabIndex = 5;
            this.lbEmail.Text = "E-mail";
            this.lbEmail.Click += new System.EventHandler(this.LbEmail_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNome.Location = new System.Drawing.Point(25, 64);
            this.lbNome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(46, 19);
            this.lbNome.TabIndex = 4;
            this.lbNome.Text = "Nome";
            // 
            // txtFantasia
            // 
            this.txtFantasia.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFantasia.Location = new System.Drawing.Point(106, 106);
            this.txtFantasia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtFantasia.Name = "txtFantasia";
            this.txtFantasia.Size = new System.Drawing.Size(314, 26);
            this.txtFantasia.TabIndex = 9;
            this.txtFantasia.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // lbNomeFantasia
            // 
            this.lbNomeFantasia.AutoSize = true;
            this.lbNomeFantasia.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeFantasia.Location = new System.Drawing.Point(9, 109);
            this.lbNomeFantasia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNomeFantasia.Name = "lbNomeFantasia";
            this.lbNomeFantasia.Size = new System.Drawing.Size(100, 19);
            this.lbNomeFantasia.TabIndex = 8;
            this.lbNomeFantasia.Text = "Nome Fantasia";
            this.lbNomeFantasia.Click += new System.EventHandler(this.Label1_Click);
            // 
            // btInserir
            // 
            this.btInserir.BackColor = System.Drawing.Color.LimeGreen;
            this.btInserir.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btInserir.Location = new System.Drawing.Point(532, 188);
            this.btInserir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btInserir.Name = "btInserir";
            this.btInserir.Size = new System.Drawing.Size(63, 66);
            this.btInserir.TabIndex = 10;
            this.btInserir.Text = "Inserir";
            this.btInserir.UseVisualStyleBackColor = false;
            this.btInserir.Click += new System.EventHandler(this.BtInserir_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Orange;
            this.btCancelar.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCancelar.Location = new System.Drawing.Point(464, 188);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(63, 66);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // btListar
            // 
            this.btListar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btListar.Font = new System.Drawing.Font("Segoe UI Emoji", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListar.Location = new System.Drawing.Point(397, 188);
            this.btListar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btListar.Name = "btListar";
            this.btListar.Size = new System.Drawing.Size(63, 66);
            this.btListar.TabIndex = 12;
            this.btListar.Text = "Listar";
            this.btListar.UseVisualStyleBackColor = false;
            this.btListar.Click += new System.EventHandler(this.BtListar_Click);
            // 
            // gdListas
            // 
            this.gdListas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gdListas.Location = new System.Drawing.Point(9, 259);
            this.gdListas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gdListas.Name = "gdListas";
            this.gdListas.RowHeadersWidth = 51;
            this.gdListas.RowTemplate.Height = 24;
            this.gdListas.Size = new System.Drawing.Size(586, 236);
            this.gdListas.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 513);
            this.Controls.Add(this.gdListas);
            this.Controls.Add(this.btListar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btInserir);
            this.Controls.Add(this.txtFantasia);
            this.Controls.Add(this.lbNomeFantasia);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbNome);
            this.Controls.Add(this.txtCpfCnpj);
            this.Controls.Add(this.cbTipoPessoa);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gdListas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbTipoPessoa;
        private System.Windows.Forms.MaskedTextBox txtCpfCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbNome;
        private System.Windows.Forms.TextBox txtFantasia;
        private System.Windows.Forms.Label lbNomeFantasia;
        private System.Windows.Forms.Button btInserir;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btListar;
        private System.Windows.Forms.DataGridView gdListas;
    }
}

