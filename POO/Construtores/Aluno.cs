using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Construtores
{
    public class Aluno
    {
        public string Nome;
        public int Nota;
        public int Idade;


        public Aluno()
        {
            Console.WriteLine("Objeto Aluno Criado!");
        }
        public Aluno(string n, int i, int no)
        {
            Nome = n;
            Idade = i;
            Nota = no;
            Console.WriteLine("Objeto Aluno Criado com parâmetros!");
        }
        public void ExibirDados()
        {
            Console.WriteLine($"Nome: {Nome}, Idade: {Idade}, Nota: {Nota}");
        }


    }
}
    