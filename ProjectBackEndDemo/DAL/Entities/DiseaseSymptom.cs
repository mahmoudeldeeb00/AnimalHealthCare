using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class DiseaseSymptom
    {
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; }


        public int symptomId { get; set; }
        public Symptom Symptom { get; set; }
    }
}
