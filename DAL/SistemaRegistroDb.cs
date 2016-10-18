using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using Entidades;

namespace DAL
{
    public class SistemaRegistroDb : DbContext
    {
        public SistemaRegistroDb() : base("name = ConStr")
        {
            
        }
        public virtual DbSet<Clientes> Clientes { get; set; }
    }
}
