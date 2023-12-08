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
     
        }

        public void TDelete(Document t)
        {
            throw new NotImplementedException();
        }

        public Document TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Document> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Document t)
        {
            throw new NotImplementedException();
        }
    }
}
