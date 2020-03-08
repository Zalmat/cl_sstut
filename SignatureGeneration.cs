using System;
using System.Collections.Generic;
using System.Text;

namespace cl_sstut
{
    /// <summary>
    /// Заносим в память ShopToken и ShopSecKey
    /// Пример:  SignatureGeneration sg = new SignatureGeneration("ShopToken", "ServiceCode");
    /// Соответственно вывод: Console.WriteLine(sg.GetSign(proverka));
    /// </summary>
    public class SignatureGeneration
    {
      public readonly string ShopToken;
      public readonly string ShopSecKey;
        public SignatureGeneration(string shopSecKey = "", string shopToken = "")
        {
            ShopSecKey = shopSecKey;
            ShopToken = shopToken;
        }
        /// <summary>
        /// Для итогового формирования подписи.
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public string GetSign(string[] data)
        {
            string rezult = "";
            string pullShopTiken = "";
            string pullShopSecKey = "";
            string pullShopAndTik = "";

            for (int i = 0; i < data.Length; i++)
            {
                if (!string.IsNullOrEmpty(data[i]))
                    
                if (data.Length != i + 1) rezult += data[i] + "&";
                else rezult += data[i];


            }

            //В ответах, внезапно, не всегда есть ShopToken  и ShopSecKey потому параметр делаем необязательный (см. пример ответов в документации)
            
            if (!string.IsNullOrEmpty(ShopToken)) pullShopTiken = "&" + ShopToken;
            if (!string.IsNullOrEmpty(ShopSecKey)) pullShopSecKey = "&" + ShopSecKey;
            if (!string.IsNullOrEmpty(ShopSecKey) && !string.IsNullOrEmpty(ShopToken)) pullShopAndTik = "&";
            string result = rezult + pullShopTiken + pullShopAndTik + pullShopSecKey;

            return HashText.CkassaMD5(result);
        }
    }
    

}