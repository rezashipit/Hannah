using Chaos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using FluentNHibernate.Mapping;

namespace Chaos.Data.Nh.Mapper
{
    public class StudentMapper : ClassMap<Students>
    {
        public StudentMapper()
        {
            Id(x=>x.Id).GeneratedBy.Identity();
            Map(x => x.Email).Not.Nullable();
            Map(x => x.LastLoginDate);
            Map(x => x.DateOfBirth);
            Map(x => x.Gender).CustomType<int>();
            Map(x => x.LastName);
            Map(x => x.FirstName);
            Map(x => x.Password);
            Map(x => x.UserName);
        }
    }
}
