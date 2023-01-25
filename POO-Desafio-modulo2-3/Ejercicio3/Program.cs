using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioBanco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            list<Banco> listaBanco = new list<Banco>();

            Banco b1 = new Banco("HSBC",101);
            listaBanco.Add(b1);

            Console.WriteLine(listaBanco);
        }
    }

    public class Banco
    {
        private string nombre;
        private int codigo;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public Banco(string nombre, int codigo)
        {
            this.nombre = nombre;
            this.codigo = codigo;
        }
    }
    public class Cuenta
    {
        private string fechaApertura;
        private string numero;
        private decimal saldo;
        private int meses;
        private decimal interes;


        public string FechaApertura
        {
            get { return fechaApertura; }
            set { fechaApertura = value;}
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
        public int Meses {
            get { return meses; }
            set { meses = value; }
        }
        public decimal Interes
        {
            get { return interes; }
            set { interes = value;}
        }

        public Cuenta(string fechaApertura, string numero, decimal saldo, int meses, decimal interes)
        {
            this.fechaApertura = fechaApertura;
            this.numero = numero;
            this.saldo = saldo;
            this.meses = meses;
            this.interes = interes;
        }
    }

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
            this.cotizacion= cotizacion;
        }
    }

    public class Sucursal
    {
        private string id_sucursal, direccion;

        public string IdSucursal
        {
            get { return id_sucursal; }
            set { id_sucursal = value; }
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
            this.fechaApertura=fechaApertura;
            this.fechaVencimiento=fechaVencimiento;
            this.nombre=nombre;
            this.importe=importe;
            this.rentabilidad=rentabilidad;
        }
    }

    public class CarteraDeValores   //  <-----------------------------------------Verificar esto
    {
        private Valor valores;


        public CarteraDeValores(Valor valores)
        {
            this.valores = valores;
        }
    }
    public class Cliente
    {
        private string dni, nombre, direccion, telefono;

        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        { 
            get { return nombre; }
            set { nombre = value; }
        }

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        public Cliente(string dni, string nombre, string direccion, string telefono)
        {
            this.dni = dni;
            this.nombre = nombre;
            this.direccion = direccion;
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
    }

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
            this.fechaVencimiento= fechaVencimiento;
            this.numero= numero;
            this.tipo= tipo;
            this.titular= titular;
        }
    }
}
