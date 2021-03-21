using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Business.Abstract;
using CarpetPitch.DataAccess.Abstract;
using CarpetPitch.Entity.Concrete;

namespace CarpetPitch.Business.Concrete.Managers
{
   public class CarperPitchesManager:ICarpetPitchesService
   {
       private readonly ICarpetPitchesDal _carpetPitchesDal;

       public CarperPitchesManager(ICarpetPitchesDal carpetPitchesDal)
       {
           _carpetPitchesDal = carpetPitchesDal;
       }
        public CarpetPitches Add(CarpetPitches carpetPitches)
        {
            return _carpetPitchesDal.Add(carpetPitches);
        }

        public async Task<CarpetPitches> AddAsync(CarpetPitches carpetPitches)
        {
            return await _carpetPitchesDal.AddAsync(carpetPitches);
        }

        public CarpetPitches Update(CarpetPitches carpetPitches)
        {
            return _carpetPitchesDal.Update(carpetPitches);
        }

        public async Task<CarpetPitches> UpdateAsync(CarpetPitches carpetPitches)
        {
            return await _carpetPitchesDal.UpdateAsync(carpetPitches);
        }

        public void Delete(CarpetPitches carpetPitches)
        {
            _carpetPitchesDal.Delete(carpetPitches);
        }

        public CarpetPitches GetById(int id)
        {
            return _carpetPitchesDal.Get(d => d.CpId == id);
        }

        public List<CarpetPitches> GetList()
        {
            return _carpetPitchesDal.GetAll();
        }

        public List<CarpetPitches> getListByCitiesId(int cityId)
        {
            return _carpetPitchesDal.GetAll(d=>d.CityId==cityId);
        }
    }
}
