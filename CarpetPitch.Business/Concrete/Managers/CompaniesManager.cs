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
    public class CompaniesManager : ICompaniesService
    {
        private readonly ICompaniesDal _companiesDal;

        public CompaniesManager(ICompaniesDal companiesDal)
        {
            _companiesDal = companiesDal;
        }
        public Company Add(Company companies)
        {
            return _companiesDal.Add(companies);
        }

        public async Task<Company> AddAsync(Company companies)
        {
            return await _companiesDal.AddAsync(companies);
        }

        public Company Update(Company companies)
        {
            return _companiesDal.Update(companies);
        }

        public async Task<Company> UpdateAsync(Company companies)
        {
            return await _companiesDal.UpdateAsync(companies);
        }

        public void Delete(Company companies)
        {
            _companiesDal.Delete(companies);
        }

        public Company GetById(int id)
        {
            return _companiesDal.Get(d=>d.CompanyId==id);
        }

        public List<Company> GetList()
        {
            return _companiesDal.GetAll();
        }
    }
}
