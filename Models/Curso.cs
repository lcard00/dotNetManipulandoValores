using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetManipulandoValores.Models
{
    public class Curso
    {
        public string Nome { get; set; }    
        public List<Pessoa> Alunos { get; set; }    

        public void AdicionarAluno(Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados()
        {
            return Alunos.Count;
        }

        public void RemoverAluno(Pessoa aluno)
        {
            Alunos.Remove(aluno);
        }

        public void ListarAlunos()
        {
            int count = 0;
            
            Console.WriteLine($"Curso: {Nome}");
            foreach (Pessoa aluno in Alunos)
            {
                Console.WriteLine($"Nº {count + 1} - {aluno.NomeCompleto}");

                count++;
            }
        }
    }
}