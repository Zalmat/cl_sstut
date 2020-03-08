using System;
using System.Security.Cryptography;
using System.Text;

namespace cl_sstut
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "111-11165-4&54d56314-4010-4127-bfc2-9c3ecda766c9&1100&0";
            
            //Проверка шифрования
            Console.WriteLine(HashText.CkassaMD5(text));
            
            //проверка всего алгоритма
            string[] proverka = new string[] {"111aaaa", "222aaaa", "333aaaa", "4444aaaa"};
            SignatureGeneration sg = new SignatureGeneration(shopSecKey: "SHOPSECKEY", shopToken: "shop_token");
            Console.WriteLine( sg.GetSign(proverka));
           
        } 
       
    }
}
