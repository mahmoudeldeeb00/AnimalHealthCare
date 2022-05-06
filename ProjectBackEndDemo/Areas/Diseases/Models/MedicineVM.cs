using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Diseases.Models
{
    public class MedicineVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Temperature { get; set; }
        public bool HasSideEffect { get; set; }
        public string Expirty { get; set; }
        public string KeyWords { get; set; }

        public List<int> DieasesIds { get; set; }
        public List<string> DieasesNames { get; set; }




    }
}
