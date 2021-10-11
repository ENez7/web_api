using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Pruebitas.Models
{
    public class Musica
    {
        
        public string nombreCancion { get; set; }
        [Key]
        public string autor { get; set; }
        public string letra { get; set; }
        public string link { get; set; }
        public int mancos { get; set; }
    }
}
