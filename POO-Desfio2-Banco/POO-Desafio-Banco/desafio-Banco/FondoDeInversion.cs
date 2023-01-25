using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public class FondoDeInversion
    {
        private string fechaApertura, fechaVencimiento, nombre;
        private decimal importe, rentabilidad;

        public string FechaApertura
        {
            get { return fechaApertura; }
            set { fechaApertura = value; }
        }
        public string FechaVencimiento
        {
            get { return fechaVencimiento; }
            set { fechaVencimiento = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public decimal Importe
        {
            get { return importe; }
            set { importe = value; }
        }
        public decimal Rentabilidad
        {
            get { return rentabilidad; }
            set { rentabilidad = value; }
        }

        public FondoDeInversion(string fechaApertura, string fechaVencimiento, string nombre, decimal importe, decimal rentabilidad)
        {
            this.fechaApertura = fechaApertura;
            this.fechaVencimiento = fechaVencimiento;
            this.nombre = nombre;
            this.importe = importe;
            this.rentabilidad = rentabilidad;
        }
    }
}
