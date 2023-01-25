using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public abstract class Persona
    {
        private string nombre;

        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }

        public abstract string Saludar();
        public virtual string Saludar(string mensaje)
        {
            return $"Soy la clase persona {mensaje}";
        }

        
    }

}
