using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Entity.Concrete;

namespace CarpetPitch.Business.Abstract
{
   public interface ICarpetPitchesService
    {
        CarpetPitches Add(CarpetPitches carpetPitches);
        Task<CarpetPitches> AddAsync(CarpetPitches carpetPitches);
        CarpetPitches Update(CarpetPitches carpetPitches);
        Task<CarpetPitches> UpdateAsync(CarpetPitches carpetPitches);
        void Delete(CarpetPitches carpetPitches);
        CarpetPitches GetById(int id);
        List<CarpetPitches> GetList();
        List<CarpetPitches> getListByCitiesId(int cityId);
    }
}
