using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Diseases.Models
{
    public class SymptomVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<int> DieasesIds { get; set; }
        public List<string> DieasesNames { get; set; }
        public string KeyWords { get; set; }


    }
}
