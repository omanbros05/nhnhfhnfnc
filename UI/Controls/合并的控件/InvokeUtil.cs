using System;
using System.Collections.Generic;
using System.Text;
using SOA;
using SOA.ORM;

namespace EnforceUI
{
    public class InvokeUtil
    {
        private static UserInfo activeUser;
        public static UserInfo ActiveUser
        {
            get
            {
                if (activeUser == null)
                    activeUser = new UserInfo { FullName = "台州市安全生产监督管理局", Abb = "台", Address = "台州市某某路333号", Area = "台州市", Post = "315900", Tel = "42546537457"};

                return activeUser;
            }
            set
            {
                activeUser = value;
            }
        }

        /// <summary>
        /// 调度服务实例
        /// </summary>
        private static ISystemService systemService;

        /// <summary>
        /// 调度服务实例
        /// </summary>
        public static ISystemService SystemService
        {
            get
            {
                if (systemService == null)
                {
                    systemService = new SystemService();

                    //EndpointAddress endpointAddress = new EndpointAddress("net.tcp://localhost:8001/SystemService");//服务终结点
                    //systemService = ChannelFactory<ISystemService>.CreateChannel(new NetTcpBinding(), endpointAddress);//使用工厂模式创建服务代理实例
                }

                return systemService;
            }
        }
    }
}
