﻿using Chaos.Core.Repository;
using Chaos.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chaos.Data.Nh.Repository
{
   public class NhStudentRepository:NhRepositoryBase<Students,int>,IStudentRepository
    {
    }
}
