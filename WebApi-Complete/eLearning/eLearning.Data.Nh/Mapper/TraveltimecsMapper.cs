using Chaos.Data.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Nh.Mapper
{
    public class TraveltimecsMapper : ClassMap<TravelTime>
    {
        public TraveltimecsMapper()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.GoingTime).Not.Nullable();
            Map(x => x.ReturnTime).Not.Nullable();
            Map(x => x.DayOfWeek).CustomType<int>().Not.Nullable();
        }
    }
}
