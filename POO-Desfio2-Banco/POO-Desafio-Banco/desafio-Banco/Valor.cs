using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public class Valor
    {
        private string texto, nombre;
        private decimal cotizacion;

        public string Texto
        {
            get { return texto; }
            set { texto = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Cotizacion
        {
            get { return cotizacion; }
            set { cotizacion = value; }
        }

        public Valor(string texto, string nombre, decimal cotizacion)
        {
            this.texto = texto;
            this.nombre = nombre;
            this.cotizacion = cotizacion;
        }
    }
}
