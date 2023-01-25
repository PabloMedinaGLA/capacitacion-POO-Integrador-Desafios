using desafio_Banco;
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
            
            Banco b1 = new Banco("HSBC", 101);
            Console.WriteLine(b1.Nombre);
            Console.WriteLine(b1.Codigo);


            Cuenta c1 = new Cuenta ("01/01/2020","1121542",5000,12,50);
            Console.WriteLine(c1.FechaApertura);
            Console.WriteLine(c1.Numero);
            Console.WriteLine(c1.Saldo);
            Console.WriteLine(c1.Meses);
            Console.WriteLine(c1.Interes);


            Valor v1 = new Valor("USD","Dolar",128);
            Console.WriteLine(v1.Texto);
            Console.WriteLine(v1.Nombre);
            Console.WriteLine(v1.Cotizacion);


            Sucursal s1 = new Sucursal("1","calle falsa 123");
            Console.WriteLine(s1.IdSucursal);
            Console.WriteLine(s1.Direccion);


            FondoDeInversion fi1 = new FondoDeInversion("01/02/2020", "12/12/2020","Galicia",20,30);
            Console.WriteLine(fi1.FechaApertura);
            Console.WriteLine(fi1.FechaVencimiento);
            Console.WriteLine(fi1.Nombre);
            Console.WriteLine(fi1.Importe);
            Console.WriteLine(fi1.Rentabilidad);


            CarteraDeValores cv1 = new CarteraDeValores(v1);  //  <-----------------------------------------Verificar esto
            Console.WriteLine(cv1.Valores.Texto);



            Cliente varCliente = new Cliente("12212121","pablo","calle 123","1133554466");
            Console.WriteLine(varCliente.Dni);
            Console.WriteLine(varCliente.Nombre);
            Console.WriteLine(varCliente.Direccion);
            Console.WriteLine(varCliente.Telefono);


            TarjetaDeCredito t1 = new TarjetaDeCredito("20/12/2019", "1231213213212121", "VISA", "Pablo");
            Console.WriteLine(t1.FechaVencimiento);
            Console.WriteLine(t1.Numero);
            Console.WriteLine(t1.Tipo);
            Console.WriteLine(t1.Titular);

            Console.ReadKey();
        }
    } 
}
