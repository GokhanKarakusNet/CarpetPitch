using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Core.DataAccess.EntityFrameworkCore;
using CarpetPitch.DataAccess.Abstract;
using CarpetPitch.Entity.Concrete;

namespace CarpetPitch.DataAccess.Concrete.EntityFrameworkCore
{
    public class EfCompaniesDal : EfEntityRepositoryBase<Company, CarpetPitchDbContext>, ICompaniesDal
    {
    }
}
