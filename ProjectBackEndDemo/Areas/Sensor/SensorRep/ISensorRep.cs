using ProjectBackEndDemo.Areas.Sensor.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.SensorRep
{
   public  interface ISensorRep
    {

        public void AddSensorData(SensorDataVM model);
        public SensorDataVM GetSensorData(int Id);


    }
}
