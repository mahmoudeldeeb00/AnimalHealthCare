﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectBackEndDemo.Areas.Identity.Models
{
    public class ForgetPasswordVM
    {
        [Required(ErrorMessage = "Required")]
     
        public string UserName { get; set; }
    }
}
