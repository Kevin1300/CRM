//------------------------------------------------------------------------------
// <auto-generated>
// Author:JamesZou QQ:576948819
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM11.Service
{
    using System;
    using System.Collections.Generic;
    
    public partial class VipPermssion:BaseService<MODEL.VipPermssion>,CRM11.IService.IVipPermssion
    {
    		IRespository.IVipPermssion iSonDal = null;
            public override void SetIDAL()
            {
                iSonDal = base.DBSession.VipPermssion;
    			base.iBaseDal = iSonDal;
            }
    }
}
