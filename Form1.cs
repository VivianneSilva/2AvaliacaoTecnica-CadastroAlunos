using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CadastroAlunos
{
    public partial class CadastroDeAlunos : Form
    {
        Aluno aluno;
        public CadastroDeAlunos()
        {
            InitializeComponent();
        }
        int contagem = 0;
        int ra = 1;
       

        private void btnCadastro_Click(object sender, EventArgs e)
        {
         string nome = txtNome.Text;            
         string endereco = txtEndereco.Text;
         string email = txtEmail.Text;
         string telefone = txtTelefone.Text;
         string cpf = txtCpf.Text;
         ra = int.Parse( txtRa.Text);
            

            if (ListaAlunos.Items.Count < 5)
            {
                aluno = new Aluno(nome, endereco, email, telefone, cpf, ra);
                ListaAlunos.Items.Add(aluno.nome);

                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtEndereco.Clear();
                txtRa.Clear();

                contagem++;
                ra++;
                lblContagem.Text = contagem.ToString();
            }
            else
            {
                MessageBox.Show("Limite de Alunos foi atingido!");

                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtEndereco.Clear();
                txtRa.Clear();
            }

        }

        private void ListaAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGerarRa_Click(object sender, EventArgs e)
        {
            if (txtRa.Text == "5")
            {
                MessageBox.Show("Limite de cadastro atingido");
                btnGerarRa.Enabled = false;
                txtRa.Clear();

            }
            txtRa.Text = ra++.ToString();

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string msg = "Deseja remover o Aluno?";
            string caption = "";
            var result = MessageBox.Show(msg, caption, MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                ListaAlunos.Items.RemoveAt(ListaAlunos.SelectedIndex);


                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();
                txtCpf.Clear();
                txtEndereco.Clear();
                txtRa.Clear();

                contagem--;
                lblContagem.Text = contagem.ToString();
            }
            
           
            
           
        }

       
    }
}
