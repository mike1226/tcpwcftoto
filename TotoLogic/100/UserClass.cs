using System;
using Newtonsoft.Json;
using Toto.DbModel;

namespace Toto.Logic
{
    public class UserClass
    {
        /// <summary>
        ///     添加用户
        /// </summary>
        /// <param name="strJsonUser">用户的Json字符串</param>
        /// <returns></returns>
        public ResponseDTO RegUser(string strJsonUser)
        {
            var ret = new ResponseDTO();
            try
            {
                var user = JsonConvert.DeserializeObject<T_USER_BASE>(strJsonUser);
                using (var db = new TotoLocalDbEntities())
                {
                    // 为新用户添加 一个GUID类型的ID;
                    user.USER_ID = Guid.NewGuid().ToString();
                    //  添加一个用户
                    db.T_USER_BASE.Add(user);
                    //保存至DB
                    //db.SaveChanges();
                    db.SaveChanges();

                    ret.RetCode = 0; //返回代码
                    ret.RetJson = JsonConvert.SerializeObject(user); // 返回的数据结构(用Json封装)
                    ret.RetMsg = "添加用户成功 ！"; // 返回的消息 
                }
            }
            catch (Exception ex)
            {
                ret.RetCode = -1;
                ret.RetMsg = ex.ToString();
            }
            return ret;
        }

        /// <summary>
        ///     用户登录
        /// </summary>
        /// <param name="strJsonUser"></param>
        /// <returns></returns>
        public ResponseDTO LoginUser(string strJsonUser)
        {
            var dto = new ResponseDTO();
            return dto;
        }
    }
}