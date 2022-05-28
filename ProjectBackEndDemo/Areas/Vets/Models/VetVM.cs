using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Vets.Models
{
    public class VetVM
    {
        public int Id { get; set; }
        [Required(ErrorMessage= " NameRequired")]
        public string Name { get; set; }
        public int age { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        [Required(ErrorMessage = "CityId Required")]
        public int CityId { get; set; }
        public string PictureUrl { get; set; }

        [Required(ErrorMessage = "Picture Required")]
        public IFormFile Picture { get; set; }
        public string CityName { get; set; }
  
        [Required(ErrorMessage = "Speciality Required")]
        public string Speciality { get; set; }
        
    }
}
