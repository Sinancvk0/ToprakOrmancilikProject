﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Blog:BaseModel
    {
        public string Image { get; set; }

        public string Description { get; set; }

        public string? Title2 { get; set; }
        public string? Title3 { get; set; }

        public string? Description2 { get; set; }
        public string Tags { get; set; }

    }
}
