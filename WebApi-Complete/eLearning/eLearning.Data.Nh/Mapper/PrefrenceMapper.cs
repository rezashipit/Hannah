using Chaos.Data.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Nh.Mapper
{
    public class PrefrenceMapper : ClassMap<Prefrence>
    {
        public PrefrenceMapper()
        {
            Id(x => x.Id).GeneratedBy.Identity();
            Map(x => x.Detail).Not.Nullable();

        }
    }
}
