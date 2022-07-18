using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entities
{
    public class KardexEntity
    {
        [Key]
        public int Id { get; set; }
        public string? fecha { get; set; }
        public string? hora { get; set; }
        public int userId { get; set; }
        public string card { get; set; }
        public string transaccion { get; set; }
        public string transaccion2 { get; set; }
        public string transaccion3 { get; set; }
        public bool Active { get; set; }
    }
}
