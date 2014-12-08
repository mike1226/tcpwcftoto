using System;
using System.IO;
using System.Reflection;
using System.Threading;
using Newtonsoft.Json;
using Toto.DbModel;

namespace Toto.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class TotoService : ITotoService
    {
        /// <summary>
        ///     调用Services的方法
        /// </summary>
        /// <param name="strPort">服务号</param>
        /// <param name="strDto">请求的DTO(以Json封装)</param>
        /// <returns></returns>
        /// <remarks>
        ///     需要对传送过来的数据进行校验
        ///     传过来的数据包含的内容
        ///     MD5加密字串(保证传输过程中未必修改)
        /// </remarks>
        public string Process(string strDto)
        {
            var usrDto = JsonConvert.DeserializeObject<RequestDTO>(strDto);
            dynamic ret = new ResponseDTO();
            // 1 根据Service号取得调用的方法
            // 2 调用 调用 的方法
            ServiceModel sn = XmlHelper.GetService(usrDto.Port);
            // 如果方法 为空，返回-1
            if (sn == null)
            {
                ret.RetCode = - 2;
                ret.RetMsg = "没有提供此方法的服务！";
            }

            try
            {
                //var usrDto = JsonConvert.DeserializeObject<RequestDTO>(strDto);
                // 应用反射，访问对象

                Assembly ass = Assembly.LoadFrom(Path.Combine(Thread.GetDomain().BaseDirectory, sn.ClassAssembly));
                Type t = ass.GetType(sn.ClassName);
                object o = Activator.CreateInstance(t);
                MethodInfo m = t.GetMethod(sn.ClassMethod);

                ret = m.Invoke(o, new object[] {usrDto.Content});


                t = null;
                ass = null;
                o = null;
                m = null;
            }
            catch (Exception ex)
            {
                ret.RetCode = -2;
                ret.RetMsg = ex.ToString();
            }

            return JsonConvert.SerializeObject(ret);
        }
    }
}