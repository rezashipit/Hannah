using Chaos.Data.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Nh.Mapper
{
   public class ExceptionDayMapper:ClassMap<ExceptionDay>
    {
       public ExceptionDayMapper()
       {
           Id(x => x.Id).GeneratedBy.Identity();
           Map(x => x.IsOff).CustomType("bool").Not.Nullable();
           Map(x => x.GoTime).Not.Nullable();
           Map(x => x.ReturnTime).Not.Nullable();
       }
    }
}
