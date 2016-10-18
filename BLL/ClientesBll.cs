using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using DAL;

namespace BLL
{
    public class ClientesBll
    {
        Clientes cliente = new Clientes();
        public static void Guardar (Clientes c)
        {
            try
            {
                SistemaRegistroDb db = new SistemaRegistroDb();
                {
                    db.Clientes.Add(c);
                    db.SaveChanges();
                }
            }catch(Exception e)
            {
                throw e;
            }
        }
        
        public static void Eliminar(Clientes c)
        {
            SistemaRegistroDb db = new SistemaRegistroDb();
            Clientes us = db.Clientes.Find(c);
            db.Clientes.Remove(c);
            db.SaveChanges();
        }

        public static Clientes Buscar(int Id)
        {
            SistemaRegistroDb db = new SistemaRegistroDb();
            return db.Clientes.Find(Id);
        }

        public static List<Clientes> GetListaNombreCliente(string aux)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaRegistroDb db = new SistemaRegistroDb();
            lista = db.Clientes.Where(p => p.Nombres == aux).ToList();
            return lista;
        }

        public static List<Clientes> GetLista(int clienteId)
        {
            List<Clientes> lista = new List<Clientes>();
            SistemaRegistroDb db = new SistemaRegistroDb();
            lista = db.Clientes.Where(d => d.ClienteId == clienteId).ToList();
            return lista;
        }

        public static void Eliminar(int v)
        {
            SistemaRegistroDb db = new SistemaRegistroDb();
            Clientes ct = db.Clientes.Find(v);
            try
            {
                db.Clientes.Remove(ct);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
