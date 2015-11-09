using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PedidosItensMVC.Context;
using System.Threading.Tasks;

namespace PedidosItensMVC.Controllers
{
    public class ItensController : Controller
    {
        private readonly DBContext _dbContext = new DBContext();

        // GET: Itens/ListarItens

        public async Task<ActionResult> ListarItens(int id)
        {
            var lista = _dbContext.Itens.Where(itens => itens.Pedido.ID == id).ToList();
            ViewBag.Pedido = id;
            return PartialView(lista);
        }

        [HttpGet]
        public ActionResult SalvarItens(int quantidade, string produto, decimal valorunitario, int idPedido)
        {
            var item = new Models.Itens()
            {
                Quantidade = quantidade,
                Produto = produto,
                ValorUnitario = valorunitario,
                Pedido = _dbContext.Pedidos.Find(idPedido)
            };

            _dbContext.Itens.Add(item);
            _dbContext.SaveChanges();

            return Json(new {Resultado = item.ID}, JsonRequestBehavior.AllowGet);
        }
    }
}