using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class DepartamentsEntity
    {
        public DepartamentsEntity()
        {
            Users = new HashSet<UsersEntity>();
        }
        [Key]
        public int DepartamentId { get; set; }
        public string Name { get; set; } = null!;
        public string Leadership { get; set; } = null!;
        public string? Add1 { get; set; }
        public string? Add2 { get; set; }
        public bool Active { get; set; }

        public virtual ICollection<UsersEntity> Users { get; set; }
    }
}
