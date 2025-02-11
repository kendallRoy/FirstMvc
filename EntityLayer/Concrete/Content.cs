﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Content
    { 
        public int ContentID { get; set }
        public string ContentValue { get; set; }
        public DateTime MyProperty { get; set; }

        public int HeadingID { get; set; }
        public virtual Heading Heading { get; set; }

        public int WriterID { get; set; }
        public virtual Writer Writer { get; set; }

    }
}
