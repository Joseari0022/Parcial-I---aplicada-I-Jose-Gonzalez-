using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using BLL;

namespace Parcial_I___aplicada_I__Jose_Gonzalez_
{
    public partial class RegistroCliente : Form
    {
        public RegistroCliente()
        {
            InitializeComponent();
        }

        public void LlenarClase(Clientes c)
        {
            c.Nombres = NombretextBox.Text;
            c.FehcaNacimiento = FechaNacimientodateTimePicker.MaxDate;
            c.LimiteCredito = LimiteCreditotextBox.Text;
        }

        private void Idbutton_Click(object sender, EventArgs e)
        {
            LlenarCliente(ClientesBll.Buscar(String(IdtextBox.Text)));
        }

        public void LlenarCliente(Clientes cliente)
        {
            IdtextBox.Text = cliente.ClienteId.ToString();
            NombretextBox.Text = cliente.Nombres.ToString();
            FechaNacimientodateTimePicker.MaxDate = cliente.FehcaNacimiento;
            LimiteCreditotextBox.Text = cliente.LimiteCredito.ToString();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Clientes cliente = new Clientes();
            LlenarClase(cliente);
            if (validarTex() && validarExistente(NombretextBox.Text))
            {
                ClientesBll.Guardar(cliente);
                MessageBox.Show("Guardado con exito");
            }
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ClientesBll.Eliminar(String(IdtextBox.Text));
            MessageBox.Show("Usuario Eliminado");
        }

        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        public bool validarTex()
        {
            if (string.IsNullOrEmpty(NombretextBox.Text) && string.IsNullOrEmpty(LimiteCreditotextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                FechaNacimientoerrorProvider.SetError(FechaNacimientodateTimePicker, "Ingrese la fecha de nacimiento");
                LimiteCreditoerrorProvider.SetError(LimiteCreditotextBox, "Ingrese el limite de credito");
                MessageBox.Show("Llenar los campos");
            }
            if (string.IsNullOrEmpty(NombretextBox.Text))
            {
                NombreerrorProvider.SetError(NombretextBox, "Ingrese el nombre");
                return false;
            }
            if (string.IsNullOrEmpty(LimiteCreditotextBox.Text))
            {
                NombreerrorProvider.Clear();                
                LimiteCreditoerrorProvider.SetError(LimiteCreditotextBox, "Ingrese el telefono");
                return false;
            }
            return true;
        }

        public bool validarExistente(string aux)
        {
            if(ClientesBll.GetListaNombreCliente(aux).Count() > 0)
            {
                MessageBox.Show("Este usuario existe");
                return false;
            }
            return true;
        }
    }
}
