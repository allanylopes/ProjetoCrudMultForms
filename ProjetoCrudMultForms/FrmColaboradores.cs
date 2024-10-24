using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCrudMultForms
{
    public partial class FrmColaboradores : Form
    {
        public FrmColaboradores()
        {
            InitializeComponent();
        }
        Colaboradores cola = new Colaboradores();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                cola.Cpf = txt_Cpf.Text;
                cola.Nome = txt_Nome.Text;
                cola.Sobrenome = txt_Sobrenome.Text;
                cola.inserir();
                dgv_Colaboradores.DataSource = cola.Consultar();
            }
            finally
            {

                MessageBox.Show("Informações Gravadas com Sucesso!");
            }
        }

        private void dgv_Colaboradores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Alterar_Click(object sender, EventArgs e)
        {
            try
            {
                cola.Cpf = txt_Cpf.Text;
                cola.Nome = txt_Nome.Text;
                cola.Sobrenome = txt_Sobrenome.Text;
                cola.alterar();
                dgv_Colaboradores.DataSource = cola.Consultar();
            }
            finally
            {
                MessageBox.Show("Dados Alterados com Sucesso");
            }
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            try
            {
                cola.Cpf = txt_Cpf.Text;
                cola.excluir();
                dgv_Colaboradores.DataSource = cola.Consultar();
            }
            finally
            {

                MessageBox.Show("Informações Excluidas com Sucesso");
            }
        }

        private void btn_Consultar_Click(object sender, EventArgs e)
        {
            dgv_Colaboradores.DataSource = cola.Consultar();
            dgv_Colaboradores.Columns["nome_colaborador"].HeaderText = "Nome";
            dgv_Colaboradores.Columns["id"].HeaderText = "Código";
            dgv_Colaboradores.Columns["sobrenome_colaborador"].HeaderText = "Sobrenome";
            dgv_Colaboradores.Columns["cpf_colaborador"].HeaderText = "CPF";

        }

        private void dgv_Colaboradores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Nome.Text = dgv_Colaboradores.CurrentRow.Cells["nome_colaborador"].Value.ToString();
            txt_Sobrenome.Text = dgv_Colaboradores.CurrentRow.Cells["sobrenome_colaborador"].Value.ToString();
            txt_Cpf.Text = dgv_Colaboradores.CurrentRow.Cells["cpf_colaborador"].Value.ToString();
        }

        private void btn_Limpar_Click(object sender, EventArgs e)
        {
            txt_Cpf.Clear();
            txt_Nome.Clear();
            txt_Sobrenome.Clear();
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
