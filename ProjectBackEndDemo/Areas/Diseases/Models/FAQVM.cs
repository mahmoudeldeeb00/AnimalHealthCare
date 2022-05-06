using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Diseases.Models
{
    public class FAQVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Required")]

        public string Question { get; set; }
        [Required(ErrorMessage = "Required")]

        public string Answer { get; set; }
    }
}
