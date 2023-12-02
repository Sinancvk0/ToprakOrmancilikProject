using Bussiness.Services;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Content
{
    public class QuestionManager : IGenericService<Question>, IQuestionService
    {
        public void TAdd(Question t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Question t)
        {
            throw new NotImplementedException();
        }

        public Question TGetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Question> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Question t)
        {
            throw new NotImplementedException();
        }
    }
}
