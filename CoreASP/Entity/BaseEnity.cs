using CoreASP.Interface.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreASP.Entity
{
    public abstract class BaseEnity : IEntity
    {
        long version;
        int createdBy;
        DateTime createdDate;
        int changedBy;
        DateTime changedDate;
        Boolean isDelete;
        public abstract int getId();
        public abstract void setId(int id);
    }
}
