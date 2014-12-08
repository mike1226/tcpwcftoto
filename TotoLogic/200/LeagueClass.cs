using System;
using Newtonsoft.Json;
using Toto.DbModel;

namespace Toto.Logic
{
    /// <summary>
    /// 赛事信息处理
    /// </summary>
    public class LeagueClass
    {
        /// <summary>
        /// 注册联赛信息
        /// </summary>
        /// <param name="strJsonData"></param>
        /// <returns></returns>
        public ResponseDTO RegistLeague(string strJsonData)
        {
            var ret = new ResponseDTO();
            try
            {

                var obj = JsonConvert.DeserializeObject<T_LEAGUE >(strJsonData);
                using (var db = new TotoLocalDbEntities())
                {
                    // 将图片存储至本地
                    // 将存储后的图片路径保存至DB
                    db.T_LEAGUE.Add(obj);
                    db.SaveChanges();
                    ret.RetCode = 0;  //返回代码
                    ret.RetJson = JsonConvert.SerializeObject(obj); // 返回的数据结构(用Json封装)
                    ret.RetMsg = "添加赛事类型成功 ！";  // 返回的消息 
                }
            }
            catch (Exception ex)
            {
                ret.RetCode = -1;
                ret.RetMsg = ex.ToString();
            }
            return ret;
            
        }

    }
}
