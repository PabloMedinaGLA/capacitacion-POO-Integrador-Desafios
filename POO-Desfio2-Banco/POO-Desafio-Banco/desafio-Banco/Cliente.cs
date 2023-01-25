using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public class Cliente : Persona
    {
        private string dni, direccion, telefono;

        public string Dni { get => dni; set => dni = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        public Cliente(string nombre, string dni, string direccion, string telefono) : base(nombre)
        {
            this.dni = dni;
            this.direccion= direccion;
            this.telefono = telefono;
        }

        public void extraer()
        {
            Console.WriteLine("Extraer");
        }

        public void depositar()
        {
            Console.WriteLine("Depositar");
        }
        public void transferir()
        {
            Console.WriteLine("Transferencia");
        }

        public override string Saludar()
        {
            return "Hola clase Cliente te saluda";
        }

        public override string Saludar(string mensaje)
        {
            return $"Soy pedriño este es mi Instragram {mensaje}";
        }
    }
}
