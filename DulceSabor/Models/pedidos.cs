using System.ComponentModel.DataAnnotations;

namespace DulceSabor.Models
{
    public class pedidos
    {
        [Key]
        public int id_pedido { get; set; }
        public int id_mesa { get; set; }
        public int id_plato { get; set; }
        public string? estado { get; set; }
        public string? comentario { get; set; }
    }
}
