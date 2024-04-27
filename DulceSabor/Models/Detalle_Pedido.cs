using System.ComponentModel.DataAnnotations;

namespace DulceSabor.Models
{
    public class Detalle_Pedido
    {
        [Key]
        public int Id_DetalleCuenta { get; set; }
        public int id_pedido { get; set; }
        public int Id_plato { get; set; }
        public int cantidad { get; set; }

    }
}
