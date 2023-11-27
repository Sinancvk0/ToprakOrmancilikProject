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
    public class SliderManager : IGenericService<Slider>, ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public void TAdd(Slider t)
        {
            _sliderDal.Insert(t);
        }

        public void TDelete(Slider t)
        {
        _sliderDal.Delete(t);
        }

        public Slider TGetById(int id)
        {
            return _sliderDal.GetById(id);  
        }

        public List<Slider> TGetList()
        {
           return _sliderDal.GetList();
        }

        public void TUpdate(Slider t)
        {
           _sliderDal.Update(t);    
        }
    }
}
