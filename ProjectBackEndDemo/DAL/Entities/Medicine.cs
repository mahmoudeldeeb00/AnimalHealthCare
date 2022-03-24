using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.DAL.Entities
{
    public class Medicine
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Temperature { get; set; }
        public bool HasSideEffect { get; set; }
        public string Expirty { get; set; }


        public virtual ICollection<Disease> Disease { get; set; }

    }
}
