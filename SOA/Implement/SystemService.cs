using System;
using System.Collections.Generic;
using System.Text;

namespace SOA
{
    [Serializable]
    public partial class SystemService : ISystemService
    {
        /// <summary>
        /// 初始化实体类
        /// </summary>
        /// <param name="entity"></param>
        public EntityInterface EntityInit(EntityInterface entity)
        {
            try
            {
                AssertLogin();
                entity.SystemService = this;
                entity.Init();

                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 更新实体类
        /// </summary>
        /// <param name="entity"></param>
        public EntityInterface EntityUpdate(EntityInterface entity)
        {
            try
            {
                AssertLogin();
                entity.SystemService = this;
                entity.Update();

                return entity;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// 删除实体类
        /// </summary>
        /// <param name="entity"></param>
        public void EntityRemove(EntityInterface entity)
        {
            try
            {
                AssertLogin();
                entity.SystemService = this;
                entity.Remove();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        /// <summary>
        /// 判断是否已登录
        /// </summary>
        protected void AssertLogin()
        {
            //if (ActiveUser == null)
            //    throw new CustomException("活动用户未登录或已超时，请重新登录系统");
        }
    }
}
