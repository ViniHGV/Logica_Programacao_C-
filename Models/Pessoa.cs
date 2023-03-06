using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lógica_C_.Models
{
    public class Pessoa
    {   
        private string curso;

        public string Curso {
             get{ return curso ;} 
             set{ curso = value; } 
        }
        public int idade { get; set; }
        public string name { get; set; }

        public void Apresentacao(string Cursos){
            curso = Cursos;
            Console.WriteLine($"Ola meu nome é {name} e eu tenho {idade} anos \nCursando: {curso}");
        }
    }
}
