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
    public class QuestionManager : IGenericService<Question>, IQuestionService
    {
        private readonly IQuestion _question;

        public QuestionManager(IQuestion question)
        {
            _question = question;
        }

        public void TAdd(Question t)
        {
          _question.Insert(t);
        }

        public void TDelete(Question t)
        {
           _question.Delete(t); 
        }

        public Question TGetById(int id)
        {
            return _question.GetById(id);
        }

        public List<Question> TGetList()
        {
           return _question.GetList();
        }

        public void TUpdate(Question t)
        {
           _question.Update(t); 
        }
    }
}
