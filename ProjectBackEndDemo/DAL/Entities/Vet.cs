using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class Vet
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int age { get; set; }
        public string Address { get; set; }
        public string Telephone { get; set; }
        public string PictureUrl { get; set; }




        //ForeignKey
        public int CityId { get; set; }

        [ForeignKey("CityId")]
        public City City { get; set; }



    }
}
