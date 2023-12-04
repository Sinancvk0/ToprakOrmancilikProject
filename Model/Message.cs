using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Message:BaseModel
    {
        public int Id { get; set; }
        public string NameSurName { get; set; }

        public string YourMail { get; set; }
        public string Text { get; set; }
    }
}
