using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parcial_I___aplicada_I__Jose_Gonzalez_
{
    public class Utilidades
    {
        public static int ToInt(string Numero)
        {
            int retorno = 0;

            int.TryParse(Numero, out retorno);

            return retorno;
        }
    }
}
