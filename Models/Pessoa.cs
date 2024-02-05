using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotNetManipulandoValores.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }    
        public int Idade { get; set; }

        public string NomeCompleto
        {
            get => ($"{Nome.ToUpper()} {Sobrenome.ToUpper()}");
        }

        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}.");
        }
    }
}