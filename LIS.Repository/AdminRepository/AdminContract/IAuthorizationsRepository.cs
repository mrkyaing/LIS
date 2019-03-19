﻿
using LIS.Core.DataModel;
using LIS.Repository.CommonRepository.CommonContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LIS.Repository.AdminRepository.AdminContract {
    public interface IAuthorizationsRepository : IRepository<Authorizations>
    {
        //Here Customized Methods
        List<Authorizations> GetControllerAndAction();
    }

}