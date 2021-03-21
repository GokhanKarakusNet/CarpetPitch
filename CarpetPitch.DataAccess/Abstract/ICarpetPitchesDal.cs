using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Core.DataAccess;
using CarpetPitch.Entity.Concrete;

namespace CarpetPitch.DataAccess.Abstract
{
    public interface ICarpetPitchesDal : IEntityRepository<CarpetPitches>
    {
    }
}
