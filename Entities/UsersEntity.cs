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


        [Required(ErrorMessage = "* Name short Required")]
        [MinLength(2)]
        public string? Namesshort { get; set; }

        
        [Required(ErrorMessage = "* Password Required")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        [Required(ErrorMessage = "* Name Required")]
        public string? Name { get; set; }

        [EmailAddress]
        [Required(ErrorMessage = "El campo correo Electronico es Obligatorio")]
        [StringLength(100, ErrorMessage = "El correo electronico no es una direccion de Correo Electronico Valida")]
        public string? Email { get; set; }
        public string? Field1 { get; set; }
        public string? Field2 { get; set; }

        public int DepartamentId { get; set; }
        public int CompanyId { get; set; }
        public bool? Active { get; set; }

        public virtual CompanysEntity Company { get; set; } = null!;
        public virtual DepartamentsEntity Departament { get; set; } = null!;
    }
}
