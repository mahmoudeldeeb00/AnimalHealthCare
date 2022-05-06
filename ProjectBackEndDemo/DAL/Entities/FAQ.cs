using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class FAQ
    {
        [Key]
     public int Id { get; set; }
     public string Question { get; set; }

     public string Answer { get; set; }

    }
}
