using DulceSabor.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DulceSabor.Controllers
{
    public class DulceSaborController : Controller

    {
        private readonly DulceSaborDBContex _context;

        public DulceSaborController(DulceSaborDBContex context)
        {
            _context = context;
        }

        //get platos
        public async Task<IActionResult> Index()
        {
            var listadoDePlatos = (from c in _context.comentarios
                                   join p in _context.pedidos on c.id_pedido equals p.id_pedido
                                   join pl in _context.platos on p.id_plato equals pl.id_plato
                                     select new
                                     {
                                         idPedido = p.id_pedido,
                                         nombre = pl.nombre_plato,
                                         descripcion = pl.descripcion,
                                         estado = p.estado,
                                         comentario = c.Comentario

                                     }).ToList();
            ViewData["listadoDePlatos"] = listadoDePlatos;

            return View();
        }





        public IActionResult CambiarEstado(int idPedido)
        {
            var pedido = _context.pedidos.Find(idPedido);

            if (pedido == null)
            {
                return NotFound(); // Pedido no encontrado
            }

            // Cambiar el estado del pedido según el estado actual
            switch (pedido.estado)
            {
                case "Solicitado":
                    pedido.estado = "En proceso";
                    break;
                case "En proceso":
                    pedido.estado = "Finalizado";
                    break;
                default:
                    return BadRequest("El pedido no puede cambiar a un estado diferente."); // Estado no válido
            }

            _context.SaveChanges(); // Guardar cambios en la base de datos

            // Devolver una respuesta exitosa (opcional)
            return Ok("Estado cambiado correctamente.");
        }



    }
}
