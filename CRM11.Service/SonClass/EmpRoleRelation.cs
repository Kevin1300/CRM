//------------------------------------------------------------------------------
// <auto-generated>
// Author:JamesZou QQ:576948819
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM11.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class EmpRoleRelation:BaseService<MODEL.EmpRoleRelation>,CRM11.IService.IEmpRoleRelation
    {
    		IRespository.IEmpRoleRelation iSonDal = null;
            public override void SetIDAL()
            {
                iSonDal = base.DBSession.EmpRoleRelation;
    			base.iBaseDal = iSonDal;
            }
    }
}
