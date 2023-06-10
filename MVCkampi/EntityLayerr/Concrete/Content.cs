using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayerr.Concrete
{
    public class Content
    {

        [Key]
        public int ContentiD { get; set; }


        [StringLength(500)]
        public string ContentValue { get; set; }

        public DateTime ContentDate { get; set; }


        public bool ContentStatus { get; set; }

        public int HeadingiD { get; set; }
        public virtual Heading Heading { get; set; }



        public int? WriteriD { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
