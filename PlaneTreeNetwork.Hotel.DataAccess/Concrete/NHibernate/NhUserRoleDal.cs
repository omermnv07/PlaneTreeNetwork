﻿using PlaneTreeNetwork.Core.DataAccess.NHihabernate;
using PlaneTreeNetwork.Hotel.DataAccess.Abstract;
using PlaneTreeNetwork.Hotel.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneTreeNetwork.Hotel.DataAccess.Concrete.NHibernate
{
    public class NhUserRoleDal : NhEntityRepositoryBase<UserRole>, IUserRoleDal
    {
        public NhUserRoleDal(NHibernateHelper nHibernateHelper) : base(nHibernateHelper)
        {

        }
    }
}
