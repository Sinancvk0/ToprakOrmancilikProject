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
    public class MessageManager : IGenericService<Message>, IMessageService
    {
        private readonly IMessageDal _message;

        public MessageManager(IMessageDal message)
        {
            _message = message;
        }

        public void TAdd(Message t)
        {
            _message.Insert(t);

        }

        public void TDelete(Message t)
        {
            _message?.Delete(t);
        }

        public Message TGetById(int id)
        {
            return _message.GetById(id);    
        }

        public List<Message> TGetList()
        {
           return _message.GetList();
        }

        public void TUpdate(Message t)
        {
           _message.Update(t);  
        }
    }
}
