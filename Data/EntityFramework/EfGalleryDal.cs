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
    public class EfGalleryDal : GenericRepository<Gallery>, IGalleryDal
    {
        public EfGalleryDal(AppDbContext context) : base(context)
        {
        }
    }
}
