using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class UsersEntity
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "* Obligatorio")]
        public string? Namesshort { get; set; }
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Password { get; set; }
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "* Obligatorio")]
        public string? Email { get; set; }
        public int DepartamentId { get; set; }
        public int CompanyId { get; set; }
        public bool? Active { get; set; }

        public virtual CompanysEntity Company { get; set; } = null!;
        public virtual DepartamentsEntity Departament { get; set; } = null!;
    }
}
