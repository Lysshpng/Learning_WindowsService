using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace MyDemoService
{
    public partial class DemoService : ServiceBase
    {
        public DemoService()
        {
            InitializeComponent();
        }

        #region 服务生命周期

        /// <summary>
        /// 服务开始时执行的代码
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        protected override void OnStart(string[] args)
        {
            // 服务开始时执行的代码
        }

        /// <summary>
        /// 服务停止时执行的代码
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        protected override void OnStop()
        {
            // 服务停止时执行的代码
        }

        /// <summary>
        /// 服务暂停时执行的代码
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        protected override void OnPause()
        {
            // 服务暂停时执行的代码
        }

        /// <summary>
        /// 服务继续时执行的代码
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        protected override void OnContinue()
        {
            // 服务继续时执行的代码
        }

        /// <summary>
        /// 系统关闭时执行的代码
        /// </summary>
        /// <param name=""></param>
        /// <param name=""></param>
        /// <returns></returns>
        protected override void OnShutdown()
        {
            // 系统关闭时执行的代码
        }

        #endregion

    }
}
