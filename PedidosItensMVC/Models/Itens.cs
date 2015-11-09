using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PedidosItensMVC.Models
{
    public class Itens
    {
        public int ID { get; set; }
        public Pedido Pedido { get; set; }
        public int Quantidade { get; set; }
        public string Produto { get; set; }
        public Decimal ValorUnitario { get; set; }
    }
}