//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Toto.DbModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class T_GAME_BET
    {
        public int BET_ID { get; set; }
        public Nullable<int> GAME_ID { get; set; }
        public Nullable<int> BET_KIND { get; set; }
        public Nullable<double> BETA { get; set; }
        public Nullable<double> BETB { get; set; }
        public Nullable<double> BETC { get; set; }
        public Nullable<System.DateTime> BET_TIME { get; set; }
        public Nullable<bool> GET_SINGLE { get; set; }
    }
}
