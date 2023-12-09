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
    public class DocumentManager : IGenericService<Document>, IDocumentService
    {
        private readonly IDocumentDal _documentDal;

        public DocumentManager(IDocumentDal documentDal)
        {
            _documentDal = documentDal;
        }

        public void TAdd(Document t)
        {
      _documentDal.Insert(t);
     
        }

        public void TDelete(Document t)
        {
            _documentDal.Delete(t);
        }

        public Document TGetById(int id)
        {
           return _documentDal.GetById(id);
        }

        public List<Document> TGetList()
        {
           return _documentDal.GetList();
        }

        public void TUpdate(Document t)
        {
           _documentDal.Update(t);   
        }
    }
}
