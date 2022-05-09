using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    public class Aluno
    {
        public string nome { get; set; }
        public string endereco { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }
        public string cpf { get; set; }
        public int ra { get; set; }


        public Aluno(string nome, string endereco, string email, string telefone, string cpf, int ra)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.email = email;
            this.telefone = telefone;
            this.cpf = cpf;
            this.ra = ra;
        }
    }
}
