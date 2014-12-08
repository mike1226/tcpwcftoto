using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using Toto.DbModel;

namespace Toto.Logic
{
    public class SystemClass
    {
        /// <summary>
        ///     取得比赛信息
        /// </summary>
        /// <param name="strJsonUser"></param>
        /// <returns></returns>
        public ResponseDTO GetGameList(string strJsonUser)
        {
            var ret = new ResponseDTO();
            try
            {
                using (var db = new TotoLocalDbEntities())
                {
                    ret.RetCode = 0;
                    if (db.T_GAME_KIND != null)
                    {
                        List<T_GAME_KIND> lst = (from k in db.T_GAME_KIND
                            select k).ToList();
                    }

                    ret.RetJson = JsonConvert.SerializeObject((from k in db.T_GAME_KIND select k).ToList());
                }
            }
            catch (Exception)
            {
                ret.RetCode = -1;
                ret.RetMsg = "取得比赛类别失败";
            }
            return ret;
        }
    }
}