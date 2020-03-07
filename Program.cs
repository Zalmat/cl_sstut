using System;
using System.Security.Cryptography;
using System.Text;

namespace cl_sstut
{
    class Program
    {
        static void Main(string[] args)
        {
            string servisCode = "109-5804-1";
            string userToken = "USER_TOKEN";

            string text = "111-11165-4&54d56314-4010-4127-bfc2-9c3ecda766c9&1100&0";
            

            Console.WriteLine(HashText.CkassaMD5(text));
            //Console.WriteLine(HashText.CkassaMD5(SignatureGeneration.WalletRide.RegisrtationMerchant(phone: userToken, shopToken: servisCode)));
            
            string[] proverka = new string[] {"8i87i8", "fgdfgd", "dfdfd", "fgdfgd"};
            SignatureGeneration sg = new SignatureGeneration("ShopToken", "ServiceCode");
            Console.WriteLine( sg.GetSign(proverka));
           
        } 
       
    }
}
