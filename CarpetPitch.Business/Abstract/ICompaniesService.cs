using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Entity.Concrete;

namespace CarpetPitch.Business.Abstract
{
    public interface ICompaniesService
    {
        Company Add(Company companies);
        Task<Company> AddAsync(Company companies);
        Company Update(Company companies);
        Task<Company> UpdateAsync(Company companies);
        void Delete(Company companies);
        Company GetById(int id);
        List<Company> GetList();
    }
}
