using eLearning.Data.Nh.Mapper;
using FluentNHibernate.Cfg;
using FluentNHibernate.Cfg.Db;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eLearning.Data.Nh.DatabaseContext
{
   public class SessionFactory
    {
       private static ISessionFactory CreateSessionFactory()
       {
              
           ISessionFactory issesionFactory = Fluently.Configure()
               .Database(MsSqlConfiguration.MsSql2005 
               .ConnectionString("Server=WIN-OMVHBO6HFS4;Database=eLearning; Integrated Security=SSPI;"))
               .Mappings(m => m.FluentMappings.AddFromAssemblyOf<StudentMapper>())
               .BuildSessionFactory();
           return issesionFactory;
       }
    }
}
