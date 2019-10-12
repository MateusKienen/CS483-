using System;
using System.Collections.Generic;
using System.Windows.Forms;
using ClassLibrary.Entidades;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        int id = 0;
        PessoaJuridica pj;
        PessoaFisica pf;
        List<PessoaJuridica> ListaPj = new List<PessoaJuridica>();
        List<PessoaFisica> ListaPf = new List<PessoaFisica>();
        List<object> Lista = new List<object>();

        public Form1()
        {
            InitializeComponent();
            txtFantasia.Visible = false;
            lbNomeFantasia.Visible = false;
        }

        private void CbTipoPessoa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbTipoPessoa.SelectedItem.ToString().Equals("F"))
            {
                txtCpfCnpj.Mask = "000.000.000-00";
                txtFantasia.Visible = false;
                lbNomeFantasia.Visible = false;

            }
            else
            {
                txtCpfCnpj.Mask = "00.000.000/0000-00";
                txtFantasia.Visible = true;
                lbNomeFantasia.Visible = true;

            }

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void LbEmail_Click(object sender, EventArgs e)
        {

        }

        private void BtInserir_Click(object sender, EventArgs e)
        {
            if (cbTipoPessoa.SelectedItem.ToString().Equals("F"))
            {
                pf = new PessoaFisica();
                pf.CPF = txtCpfCnpj.Text;
                pf.Nome = txtNome.Text;
                pf.Email = txtEmail.Text;
                pf.Id = id++;
                Lista.Add(pf);
            }
            else
            {
                pj = new PessoaJuridica();
                pj.CNPJ = txtCpfCnpj.Text;
                pj.Nome = txtNome.Text;
                pj.NomeFantasia = txtFantasia.Text;
                pj.Email = txtEmail.Text;
                pj.Id = id++;
                Lista.Add(pj);
            }
        }



        private void BtListar_Click(object sender, EventArgs e)
        {
            gdListas.Rows.Clear();
            if (cbTipoPessoa.SelectedIndex == -1)
            {
                MessageBox.Show("O tipo de pessoa deve ser selecionado");
            }
            else if (cbTipoPessoa.SelectedItem.ToString().Equals("F"))
            {
                gdListas.ColumnCount = 4;
                gdListas.Columns[0].Name = " ID ";
                gdListas.Columns[1].Name = " CPF ";
                gdListas.Columns[2].Name = " Nome ";
                gdListas.Columns[3].Name = " E-mail ";
                foreach (var item in Lista)
                {
                    PessoaFisica pf = item as PessoaFisica;
                    if (pf != null)
                    {
                        string[] row = new string[] { pf.Id.ToString(), pf.CPF, pf.Nome, pf.Email };
                        gdListas.Rows.Add(row);

                    }
                }
            }
            else
            {
                gdListas.ColumnCount = 5;
                gdListas.Columns[0].Name = " ID ";
                gdListas.Columns[1].Name = " CNPJ ";
                gdListas.Columns[2].Name = " Nome ";
                gdListas.Columns[3].Name = " Nome Fantasia ";
                gdListas.Columns[4].Name = " E-mail ";
                foreach (var item in Lista)
                {
                    PessoaJuridica pj = item as PessoaJuridica;
                    if (pj != null)
                    {
                        string[] row = new string[] { pj.Id.ToString(), pj.CNPJ, pj.Nome, pj.NomeFantasia, pf.Email };
                        gdListas.Rows.Add(row);

                    }
                }
            }
        }

        private void BtCancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void LimparCampos()
        {
            txtCpfCnpj.Clear();
            txtEmail.Clear();
            txtFantasia.Clear();
            txtNome.Clear();
            cbTipoPessoa.SelectedIndex = 0;
            gdListas.Rows.Clear();
        }

    }
}
