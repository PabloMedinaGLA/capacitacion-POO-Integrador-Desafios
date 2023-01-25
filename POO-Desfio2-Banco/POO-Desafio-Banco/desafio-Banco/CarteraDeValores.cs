using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio_Banco
{
    public class CarteraDeValores   //  <-----------------------------------------Verificar esto
    {
        private Valor valores;


        public CarteraDeValores(Valor valores)
        {
            this.valores = valores;
        }

        public Valor Valores { get => valores; set => valores = value; }
    }
}
