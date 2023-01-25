using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public class Sucursal
    {
        private string id_sucursal, direccion;

        public string IdSucursal
        {
            get { return id_sucursal; }
            set { id_sucursal = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public Sucursal(string id_sucursal, string direccion)
        {
            this.id_sucursal = id_sucursal;
            this.direccion = direccion;
        }

        public void agregarCliente()
        {
            Console.WriteLine("Agregar Cliente");
        }
        public void bajaCliente()
        {
            Console.WriteLine("Baja Cliente");
        }
        public void modificarCliente()
        {
            Console.WriteLine("Modificar Cliente");
        }
        public void consultarCliente()
        {
            Console.WriteLine("consultar Cliente");
        }
    }
}
