using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public class TarjetaDeCredito
    {
        private string fechaVencimiento, numero, tipo, titular;

        public string FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }

        public TarjetaDeCredito(string fechaVencimiento, string numero, string tipo, string titular)
        {
            this.fechaVencimiento = fechaVencimiento;
            this.numero = numero;
            this.tipo = tipo;
            this.titular = titular;
        }
    }
}
