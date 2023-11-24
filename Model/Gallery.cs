using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Gallery:BaseModel
    {
        public string  Image { get; set; }
        public string? Description { get; set; }
    }
}
