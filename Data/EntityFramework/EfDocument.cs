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
    public class EfDocument : GenericRepository<Document>, IDocumentDal
    {
        public EfDocument(AppDbContext context) : base(context)
        {
        }
    }
}
