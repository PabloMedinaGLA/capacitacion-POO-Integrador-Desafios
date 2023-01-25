using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public class Cuenta
    {
        private string fechaApertura;
        private string numero;
        private decimal saldo;
        private int meses;
        private decimal interes;

        //Get & Set
        public string FechaApertura
        {
            get { return fechaApertura; }
            set { fechaApertura = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }
        public decimal Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }
        public int Meses
        {
            get { return meses; }
            set { meses = value; }
        }
        public decimal Interes
        {
            get { return interes; }
            set { interes = value; }
        }

        //Constructor
        public Cuenta(string fechaApertura, string numero, decimal saldo, int meses, decimal interes)
        {
            this.fechaApertura = fechaApertura;
            this.numero = numero;
            this.saldo = saldo;
            this.meses = meses;
            this.interes = interes;
        }
    }
}
