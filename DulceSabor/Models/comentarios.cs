using System.ComponentModel.DataAnnotations;

namespace DulceSabor.Models
{
    public class comentarios
    {
        [Key]
        public int id_comentarios { get; set; }
        public int id_pedido { get; set; }
        public String? Comentario { get; set; }
   
    }
}
