using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Diseases.Models
{
    public class DieseaseVM
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage ="Required")]
        public string Name { get; set; }

        public bool IsInfect { get; set; }
        [Required(ErrorMessage = "Required")]

        public int AnimalId { get; set; }
        public string AnimalName { get; set; }
        public List<int> SymptomIds { get; set; }
        public List <string> SymptomNames { get; set; }

        public string KeyWords { get; set; }
        public List<int> MedicineIds { get; set; }
        public List<string> MedicineNames { get; set; }





    }
}
