using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class Clientes
    {
        public int ClienteId { get; set; }
        public string Nombres { get; set; }
        public DateTime FehcaNacimiento { get; set; }
        public  string  LimiteCredito { get; set; }
    }
}
