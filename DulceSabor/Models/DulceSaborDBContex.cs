using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace DulceSabor.Models
{
    public class DulceSaborDBContex : DbContext
    {
        public DulceSaborDBContex(DbContextOptions options) : base(options) 
        {
        
        }
        public DbSet<DulceSabor.Models.platos> platos { get; set; } = default;
        public DbSet<comentarios> comentarios{ get; set; }
        
        public DbSet<Detalle_Pedido> Detalle_Pedidos { get; set; }
        public DbSet<pedidos> pedidos { get; set; }

        public DbSet<mesas> mesas { get; set; }
        


    }
}
