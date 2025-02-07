﻿using Bussiness.Services;
using Data.Abstract;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness.Content
{
    public class ContactManager : IGenericService<Contact>, IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void TAdd(Contact t)
        {
            _contactDal.Insert(t);  
           
        }

        public void TDelete(Contact t)
        {
            _contactDal.Delete(t);
        }

        public Contact TGetById(int id)
        {
          return _contactDal.GetById(id);   
        }

        public List<Contact> TGetList()
        {
         return _contactDal.GetList();
        }

        public void TUpdate(Contact t)
        {
           _contactDal.Update(t);   
        }
    }
}
