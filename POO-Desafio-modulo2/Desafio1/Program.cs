using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Elemento e1= new Elemento("botella", "Coca-Cola", 10,5.2);

            Cliente c1 = new Cliente();
            c1.ingresaElemento();

            Maquina m1= new Maquina();
            m1.recibirElemento();
            m1.procesarElemento();
            m1.imprimirRecibo();
            Console.WriteLine(e1.Tipo);
            Console.WriteLine(e1.Marca);
            Console.WriteLine($"{e1.Largo} cm");
            Console.WriteLine($"{e1.Peso} grs");



            Console.ReadKey();
        }
    }

    public class Elemento
    {
        private string tipo,marca;
        private int largo;
        private double peso; 

        public string Tipo
        {
            get { return tipo; }
            set { this.tipo = value; }
        }
        public string Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public int Largo
        {
            get { return largo; }
            set { this.largo = value; }
        }
        public double Peso
        {
            get { return peso; }
            set { this.peso = value; }
        }

        public Elemento(string tipo, string marca, int largo, double peso)
        {
            Tipo = tipo;
            Marca = marca;
            Largo = largo;
            Peso = peso;
            
        }
    }

    public class Cliente
    {
        public void ingresaElemento()
        {
            Console.WriteLine("Ingresando Elemento");
        }
    }

    public class Maquina
    {
        public void recibirElemento()
        {
            Console.WriteLine("Recibiendo Elemento");
        }
        public void procesarElemento()
        {
            Console.WriteLine("Procesando Elemento");
        }
        public void imprimirRecibo()
        {
            Console.WriteLine("Imprimiendo Recibo");
        }
    }


}
