using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Core.Entities;

namespace CarpetPitch.Entity.Concrete
{
    public class City : IEntity
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public string PostalCode { get; set; }
        public Country Country  { get; set; }
        public int? CountryId { get; set; }
    }
}
