//------------------------------------------------------------------------------
// <auto-generated>
// Author:JamesZou QQ:576948819
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM11.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class Department:BaseService<MODEL.Department>,CRM11.IService.IDepartment
    {
    		IRespository.IDepartment iSonDal = null;
            public override void SetIDAL()
            {
                iSonDal = base.DBSession.Department;
    			base.iBaseDal = iSonDal;
            }
    }
}