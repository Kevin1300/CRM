﻿
 //------------------------------------------------------------------------------
// <auto-generated>
// 数据仓储接口，作用：
// 1.调用EF容器 批量 执行 sql语句
// 2.方便通过 子接口属性直接 获取 对应数据表的操作接口对象
// </auto-generated>
//------------------------------------------------------------------------------

namespace CRM11.IRespository
{
    using System;
    public partial interface IDBSession
    {
        IDepartment Department 
    	{ 
    		get;
    	}
    
        IEmployee Employee 
    	{ 
    		get;
    	}
    
        IEmpRoleRelation EmpRoleRelation 
    	{ 
    		get;
    	}
    
        IPermission Permission 
    	{ 
    		get;
    	}
    
        IRole Role 
    	{ 
    		get;
    	}
    
        IRolePerRelationship RolePerRelationship 
    	{ 
    		get;
    	}
    
        IVipPermssion VipPermssion 
    	{ 
    		get;
    	}
    
    }
}