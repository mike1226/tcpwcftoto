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
    
    public partial class T_ACCOUNT_CASH
    {
        public int CASH_ID { get; set; }
        public string USER_ID { get; set; }
        public Nullable<int> CASH_MONEY { get; set; }
        public Nullable<System.DateTime> CASH_TIME { get; set; }
        public Nullable<int> CASH_STS { get; set; }
        public string CASH_BANK { get; set; }
        public Nullable<System.DateTime> CASH_MT_TIME { get; set; }
        public string CASH_CHKCOD { get; set; }
    }
}