﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concrete
{
    public class About
    {
        [Key]
        public int AboutiD { get; set; }

        [StringLength(500)]
        public string AboutDetails1 { get; set; }


        [StringLength(500)]
        public string AboutDetails2 { get; set; }


        [StringLength(100)]
        public string AboutImage1 { get; set; }


        [StringLength(100)]
        public string AboutImage2 { get;set; }

    }
}
