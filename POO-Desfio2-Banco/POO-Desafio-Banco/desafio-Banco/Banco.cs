using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public class Banco
    {
        private string nombre;
        private int codigo;


        //Get & Set
        public string Nombre { get => nombre; set => nombre = value; }
        public int Codigo { get => codigo; set => codigo = value; }

        //Constructor

        public Banco(string nombre, int codigo)
        {
            this.Nombre = nombre;
            this.Codigo = codigo;
        }

        
    }
}
