using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lógica_C_.Models
{
    public class Pessoa
    {   private string curso;

        public string Curso { get; set; }
        public int idade { get; set; }
        public string name { get; set; }

        public void Apresentacao(){
            Console.WriteLine($"Ola meu nome é {name} e eu tenho {idade} anos");
        }
    }
}
