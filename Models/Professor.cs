using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lógica_C_.Models
{
    public class Professor:Pessoa
    {
        public void Apresentação(){
            Console.WriteLine($"Sou o professor(a) {name} e tenho {idade} anos");
        }
    }
}