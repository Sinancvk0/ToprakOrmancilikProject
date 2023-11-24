using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Product:BaseModel
    {
        public string Image { get; set; }
        public string Description { get; set; }

        public string? Description2 { get; set; }
    }
}
