using Data.Abstract;
using Data.Repository;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.EntityFramework
{
    public class EfMessage : GenericRepository<Message>, IMessageDal
    {
        public EfMessage(AppDbContext context) : base(context)
        {
        }
    }
}
