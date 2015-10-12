using Chaos.Model.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Nh.Mapper
{
    public class PassengerMapper:ClassMap<Passenger>
    {
        public PassengerMapper()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Name);
            Map(x => x.Suname);
            Map(x => x.Gender).CustomType<int>();
            Map(x => x.SourceLat);
            Map(x => x.SourceLng);
            Map(x => x.DestinatopnLat);
            Map(x => x.DestionationLng);
            Map(x => x.Email);
            Map(x => x.Country);
            Map(x => x.City);
            Map(x => x.Suburb);
            Map(x => x.Address);
            Map(x => x.Phone);
            Map(x => x.Mobile);
            Map(x => x.Password);
            HasMany(x => x.ExceptionDays).LazyLoad();
            HasMany(x => x.Prefers).Cascade.AllDeleteOrphan().LazyLoad();
            HasMany(x => x.TravelTime).Cascade.AllDeleteOrphan().LazyLoad();
        }

    }
}
