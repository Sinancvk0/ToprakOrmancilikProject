using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class BaseModel
    {
        public int Id { get; set; }

        public string? Title { get; set; }
        public bool isDeleted { get; set; } = false;
        public bool isActive { get; set; } = true;

        public DateTime CreateDate { get; set; } = DateTime.Now;


    }
}
