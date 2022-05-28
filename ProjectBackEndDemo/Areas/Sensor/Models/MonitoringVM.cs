using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.Models
{
    public class MonitoringVM
    {
        public string UserId  { get; set; }
        public int AnimalId { get; set; }
        public string AnimalType { get; set; }
        public string AnimalGenderType { get; set; }
        public int CurrentTempreture { get; set; }
        public int StartTempreture { get; set; }
        public int EndTempreture { get; set; }


        public int CurrentClucose { get; set; }
        public int StartClucose { get; set; }
        public int EndClucose { get; set; }

        public int CurrentPulse { get; set; }
        public int StartPulse { get; set; }
        public int EndPulse { get; set; }

     //   public int AnimalPulse { get; set; }

        public string AnimalNickName { get; set; }
        public string AnimalAge { get; set; }
        public string AnimalPicSource { get; set; }

        public SensorDataVM LastTempretureSend { get; set; }
        public SensorDataVM LastGlucoseSend { get; set; }
        public SensorDataVM LastPulseSend { get; set; }




    }
}
