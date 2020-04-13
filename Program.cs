using System;
using System.Security.Cryptography;
using System.Text;

namespace cl_sstut
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "100-13579-26&5000&0&1676473&c550eb5d-cad1-4e01-a98e-2dc702e3b630&927138ef-f298-4631-9727-248bcb5dd565&false&14400&card&none&SHOP_TOKEN&SHOP_SEC_KEY";
            // ответ 0DB584FB679B0D9DC2EBBD9D4B2E9191
            //Проверка шифрования

            Console.WriteLine("Расчёт со строки: " + HashText.CkassaMD5(text));
            
            //проверка всего алгоритма
            //string[] proverka = new string[] {"111aaaa", "222aaaa", "333aaaa", "4444aaaa"};
            string[] proverka = new string[] 
            {
               "100-13579-26",
               "5000",
               "0",
               "1676473",
               "c550eb5d-cad1-4e01-a98e-2dc702e3b630",
               "927138ef-f298-4631-9727-248bcb5dd565",
               "false",
               "14400",
               "card",
               "none"              
            };
            SignatureGeneration sg = new SignatureGeneration(shopToken: "SHOP_TOKEN", shopSecKey: "SHOP_SEC_KEY");
            Console.WriteLine("Расчёт классом:   "+ sg.GetSign(proverka));
           
        } 
       
    }
}
