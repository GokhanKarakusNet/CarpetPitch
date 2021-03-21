using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarpetPitch.Core.Entities;

namespace CarpetPitch.Entity.Concrete
{
    public class CarpetPitches : IEntity
    {
        public int CpId { get; set; }
        public string CpName { get; set; }
        public string Description { get; set; }
        public Company Companies { get; set; }
        public int? CompanyId { get; set; }
        public City Cities { get; set; }
        public int? CityId { get; set; }
        public Categories Categories { get; set; }
        public int? CategoryId { get; set; }
        public bool IsActive { get; set; }
        public DateTime OpenTime { get; set; }
        public DateTime CloseTime { get; set; }
        public bool BothRoom { get; set; }
        public bool DressingRoom { get; set; }
        public bool Cafeteria { get; set; }
        public bool Park { get; set; }
        public bool Wifi { get; set; }
        public DateTime TsCreated { get; set; }
        public DateTime TsUpdated { get; set; }
        public string Address { get; set; }
        public decimal CurrentPrice { get; set; }
    }
}
