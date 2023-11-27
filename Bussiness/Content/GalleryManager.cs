using Bussiness.Services;
using Data.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Content
{
    public class GalleryManager : IGenericService<Gallery>, IGalleryService
    {
        private readonly IGalleryDal _galleryDal;

        public GalleryManager(IGalleryDal galleryDal)
        {
            _galleryDal = galleryDal;
        }

        public void TAdd(Gallery t)
        {
           _galleryDal.Insert(t);
        }

        public void TDelete(Gallery t)
        {
          _galleryDal.Delete(t);    
        }

        public Gallery TGetById(int id)
        {
            return _galleryDal.GetById(id); 
        }

        public List<Gallery> TGetList()
        {
           return _galleryDal.GetList();    
        }

        public void TUpdate(Gallery t)
        {
            _galleryDal.Update(t);
           
        }
    }
}
