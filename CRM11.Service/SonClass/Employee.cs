//------------------------------------------------------------------------------
// <auto-generated>
// Author:JamesZou QQ:576948819
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM11.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee:BaseService<MODEL.Employee>,CRM11.IService.IEmployee
    {
    		IRespository.IEmployee iSonDal = null;
            public override void SetIDAL()
            {
                iSonDal = base.DBSession.Employee;
    			base.iBaseDal = iSonDal;
            }
    }
}
