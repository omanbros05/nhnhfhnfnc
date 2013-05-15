using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace SOA
{
    public partial interface ISystemService
    {
        /// <summary>
        /// 初始化实体类
        /// <remarks></remarks>
        /// <example></example>
        /// <code></code>
        /// </summary>
        /// <param name="entity">实体类</param>
        //[OperationContract, NetDataContract]
        EntityInterface EntityInit(EntityInterface entity);

        /// <summary>
        /// 更新实体类到数据库
        /// </summary>
        /// <param name="entity">实体类</param>
        //[OperationContract, NetDataContract]
        EntityInterface EntityUpdate(EntityInterface entity);

        /// <summary>
        /// 删除实体类
        /// </summary>
        /// <param name="entity">实体类</param>
        ////[OperationContract, NetDataContract]
        void EntityRemove(EntityInterface entity);
    }
}
