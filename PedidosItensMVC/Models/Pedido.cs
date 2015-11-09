using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PedidosItensMVC.Models
{
    public class Pedido
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "O campo Data não pode ficar vaziu.")]
        public DateTime Data { get; set; }
        [Required(ErrorMessage = "O campo Cliente não pode ficar vaziu.")]
        public string Cliente { get; set; }
        [Required(ErrorMessage = "O campo Valor não pode ficar vaziu.")]
        public decimal Valor { get; set; }
    }
}