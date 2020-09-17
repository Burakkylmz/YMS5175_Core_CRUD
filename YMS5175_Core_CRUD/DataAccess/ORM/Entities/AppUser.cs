using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace YMS5175_Core_CRUD.DataAccess.ORM.Entities
{
    [Table("AppUsers")]
    public class AppUser:BaseEntity
    {
        [Required]
        [MinLength(3, ErrorMessage ="Minimum lenght is 3")]
        public string FirstName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string LastName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string UserName { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string Password { get; set; }
        [Required]
        [MinLength(3, ErrorMessage = "Minimum lenght is 3")]
        public string Email { get; set; }
    }
}
