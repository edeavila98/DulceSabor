﻿using System.ComponentModel.DataAnnotations;

namespace DulceSabor.Models
{
    public class mesas
    {
        [Key]
        public int id_mesa { get; set; }
        public int? cantidad_personas { get; set; }
        public string? estado { get; set; }
        public string? nombre_mesa { get; set; }
    }
}
