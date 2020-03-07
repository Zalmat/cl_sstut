using System;
using System.Collections.Generic;
using System.Text;

namespace cl_sstut
{
    /// <summary>
    /// Заносим в память ShopToken и ServiceCode
    /// </summary>
    public class SignatureGeneration
    {
      public readonly string ShopToken;
      public readonly string ServiceCode;
        public SignatureGeneration(string token, string serviceCode)
        {
            ServiceCode = serviceCode;
            ShopToken = token;
        }
        /// <summary>
        /// Заносим все значения кроме шопа и сервиса для формирования подписи
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GetSign(string[] data)
        {
            string rezult = "";
            for (int i = 0; i < data.Length; i++)
            {
                if (!string.IsNullOrEmpty(data[i]))
                    rezult += data[i] + "&";
                i++;
            }

           string result = ServiceCode + rezult + ShopToken;

            return HashText.CkassaMD5(result);
        }
        public string dddd(string token, string serviceCode)
        {
            string aaaa = token;
            return aaaa;
        }
    }
    

}