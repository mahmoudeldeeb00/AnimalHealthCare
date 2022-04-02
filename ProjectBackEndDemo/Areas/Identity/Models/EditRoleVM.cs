using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class EditRoleVM
    {

        public string Id { get; set; }

        [Required(ErrorMessage ="enter a valid Role Name")]
        [MinLength(3,ErrorMessage ="min length to role name is 3")]
        public string Name { get; set; }

    }
}
