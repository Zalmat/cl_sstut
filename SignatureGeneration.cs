using System;
using System.Collections.Generic;
using System.Text;

namespace cl_sstut
{
    /// <summary>
    /// ������� � ������ ShopToken � ServiceCode
    /// ������:  SignatureGeneration sg = new SignatureGeneration("ShopToken", "ServiceCode");
    ///�������������� �����: Console.WriteLine(sg.GetSign(proverka));
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
        /// ��� ��������� ������������ �������.
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
    }
    

}