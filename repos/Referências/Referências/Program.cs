using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Referências
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CLASSE É UM CONJUNTO DE REGRAS
            //OBJETO É A INSTÂNCIA DE UMA CLASSE, uma variável do tipo da classe

            Aluno pedro = new Aluno("pedrinho", 1111111, "acordapedrinho@gmail.com"); //"pedro" é a referência(ponteiro) para o objeto aluno que criamos
            //quando fazemos o NEW, nós criamos o objeto
            pedro.Mostrar();
            //se eu faço
            Aluno APONTAR_PRO_PEDRO = pedro;
            //temos um ponteiro. se eu alter o valor nele:
            APONTAR_PRO_PEDRO.matricula = 42;
            //o valor no meu objeto muda
            pedro.Mostrar();
        }
    }
    class Aluno{ //TIPO, CONJUNTO DE REGRAS
        public int matricula;
        public string nome;
        public string email;

        public Aluno(string nome, int matricula, string email)
        {
            this.nome = nome; this.email = email; this.matricula = matricula;
        }

        public void Mostrar()
        {
            Console.WriteLine("Aluno: {0}(mat.:{1}) -- email: {2}", this.nome, this.matricula, this.email);
        }
    }
}
