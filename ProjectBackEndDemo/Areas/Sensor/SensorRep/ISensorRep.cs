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

        public void AddSensorMeter(string Name);

        public MonitoringVM ViewMonitoring(string UserId);

        public UserAnimalVM GetUserAnimalByUserId(string UserId);


        public EditAnimalPictureVM GetUserAnimalPictureToEdit(string UserId);
        public void EditPetProfile(UserAnimalVM model);
        public void EditPetProfilePicture(EditAnimalPictureVM model);
        public MonitoringVM ChangeScaleValues(string Id);
    }
}
