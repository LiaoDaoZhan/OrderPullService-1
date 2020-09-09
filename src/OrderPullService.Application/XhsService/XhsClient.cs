using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using OrderPullService;
using OrderPullService.CurrentShop;

namespace OrderPullService.XhsService
{
    public class XhsClient:Volo.Abp.DependencyInjection.ITransientDependency
    {
        private readonly IHttpClientFactory _httpClient;
        private readonly ICurrentShop _currentShop;
        public XhsClient(IHttpClientFactory httpClient, ICurrentShop currentShop)
        {
            _httpClient = httpClient;
            _currentShop = currentShop;
        }
        private long timestamp;
        private string sign;
        /// <summary>
        /// 获取已经签名的Client对象
        /// </summary>
        /// <param name="@params">请求参数</param>
        /// <param name="action">请求方法</param>
        /// <returns></returns>
        public HttpClient GetSignClient(string action,Dictionary<string, object> @params)
        {
            var url = "/ark/open_api/v0/packages";

            timestamp = DateTime.Now.ToTimestampLong(false);

            Dictionary<string, object> package = new Dictionary<string, object>();
            package.Add("app-key", _currentShop.AppKey);
            package.Add("timestamp", timestamp.ToString());
            var sign = GetSign(@params, package, action);
            package.Add("sign", sign);

            var client = _httpClient.CreateClient(nameof(XhsClient));
            client.DefaultRequestHeaders.Add("app-key", _currentShop.AppKey);
            client.DefaultRequestHeaders.Add("timestamp", timestamp.ToString());
            client.DefaultRequestHeaders.Add("sign", sign);

            return client;

        }
        /// <summary>
        /// 获取Url信息
        /// </summary>
        /// <param name="action"></param>
        /// <param name="params"></param>
        /// <returns></returns>
        public string GetUrl(string action, Dictionary<string, object> @params)
        {
            return _currentShop.ApiUrl + action + GetActionStr(@params);
        }

        private string GetActionStr(Dictionary<string, object> @params)
        {
            var list = @params.OrderBy(x => x.Key).ToList();
            string actionStr = string.Empty;
            actionStr = string.Join("&", list.Select(x => x.Key + "=" + x.Value).ToList());
            return actionStr;
        }
        /// <summary>
        /// 获取签名
        /// </summary>
        /// <param name="PartnerId">ID</param>
        /// <param name="PartnerKey">KEY</param>
        /// <param name="signTemp">参数数组</param>
        /// <returns></returns>
        private string GetSign(Dictionary<string, object> signTemp, Dictionary<string, object> heardParame, string apiName)
        {
            //组建签名参数
            var list = signTemp.ToList();
            list.AddRange(heardParame.ToList());
            string signOld = string.Empty;
            signOld = string.Join("&", list.OrderBy(x => x.Key).Select(x => x.Key + "=" + x.Value).ToList());
            signOld = apiName + "?" + signOld + _currentShop.AppSecret;

            string sign = GetMd5(signOld, 32).ToLower();
            return sign;
        }

        private string GetMd5(string str, int length)
        {
            if (length != 16 && length != 32) throw new System.ArgumentException("Length参数无效,只能为16位或32位");

            System.Security.Cryptography.MD5CryptoServiceProvider MD5 = new System.Security.Cryptography.MD5CryptoServiceProvider();

            byte[] b = MD5.ComputeHash(Encoding.UTF8.GetBytes(str));
            System.Text.StringBuilder StrB = new StringBuilder();
            for (int i = 0; i < b.Length; i++)
                StrB.Append(b[i].ToString("x").PadLeft(2, '0'));
            if (length == 16)
                return StrB.ToString(8, 16);
            else
                return StrB.ToString();


        }
    }
}
