﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class DiseasMedicine
    {
        public int DiseaseId { get; set; }
        public Disease Disease { get; set; }

        public int MedicineId { get; set; }
        public Medicine Medicine { get; set; }



    }
}
