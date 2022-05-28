using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Sensor.Models
{
    public class EditAnimalPictureVM
    {

        public string ApplicationUserId { get; set; }
        public string pictureSrc { get; set; }
        
        public IFormFile AnimalPicture { get; set; }

    }
}
