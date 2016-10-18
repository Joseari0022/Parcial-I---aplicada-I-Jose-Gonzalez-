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
namespace Parcial_I___aplicada_I__Jose_Gonzalez_.Consultas
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        public List<Clientes> lista = new List<Clientes>();
        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(FiltrotextBox.Text))
            {
                lista = ClientesBll.GetLista(Utilidades.ToInt(FiltrotextBox.Text));
            }
            else
            {
                lista = ClientesBll.GetLista;
            }
            DatosdataGridView.DataSource = lista;
        }
    }
}
