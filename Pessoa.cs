using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lógica_C_
{
    public class Pessoa
    {
        public int idade { get; set; }
        public string name { get; set; }

        void Apresentacao(){
            Console.WriteLine($"Ola meu nome é {name} e eu tenho {idade} anos");
        }
    }
}