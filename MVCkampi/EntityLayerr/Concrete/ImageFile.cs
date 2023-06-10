﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concrete
{
    public class ImageFile
    {
        [Key]
        public int ImageiD { get; set; }

        [StringLength(100)]
        public string ImageName { get; set; }

        [StringLength(250)]
        public string ImagePath { get; set; }
        
    }
}
