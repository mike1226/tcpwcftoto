namespace Toto.Services
{
    public class RequestDTO
    {
        /// <summary>
        ///     调用的服务号
        /// </summary>
        public string Port { get; set; }

        /// <summary>
        ///     请求用户名
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        ///     请求正文
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        ///     校验码
        /// </summary>
        public string ChkCode { get; set; }
    }
}