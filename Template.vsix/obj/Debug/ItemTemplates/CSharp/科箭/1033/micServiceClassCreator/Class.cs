/*----------------------------------------------------------------
 Copyright (C) 2018 上海科箭软件科技有限公司版权所有

 创建者：   $username$
 创建时间： $time$
 文件：    $itemname$.cs
 功能描述：

----------------------------------------------------------------*/
namespace $rootnamespace$
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using AutoMapper;
    using Quantum.FrameworkNetCore.Protocol.RpcProtocol;
    using Quantum.FrameworkNetCore.Rpc.Server;
    using Quantum.FrameworkNetCore.ExceptionEx;
    using Quantum.FrameworkNetCore.DB.EFEx.DynamicSearch;

    /// <summary>
    /// $safeitemname$接口实现
    /// </summary>
    public class $safeitemname$ : QuantumRpcBaseServer<$safeitemname$Args, $safeitemname$Result>
	{
        /// <summary>
        /// $safeitemname$接口实现
        /// </summary>
        /// <param name="valueArgs">传入参数</param>
        /// <param name="code">传出状态码</param>
        /// <returns>接口返回值</returns>
        protected override $safeitemname$Result Process($safeitemname$Args valueArgs, out StatusCode code)
        {
            code = StatusCode.OK;
            return null;
        }

        /// <summary>
        /// 修改默认授权设定
        /// </summary>
        /// <param name="args">参数</param>
        /// <param name="code">状态码</param>
        /// <returns>授权成功与否</returns>
        protected override bool Check($safeitemname$Args args, out StatusCode code)
        {
            return base.CheckLogin(args, out code);
        }
    }
}
