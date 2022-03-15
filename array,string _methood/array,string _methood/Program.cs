using System;

namespace array_string__methood
{
    class Program
    {
        static void Main(string[] args)
        {

            

            string sentence1 = "bU tasKI metHodla yAzmAliSiz";

           string lower = sentence1.ToLower();

            string sentence2 = lower.Replace("b", "B").Replace("tasKI", "Taski").Replace("metHodla","Methodla").Replace("yAzmAliSiz","Yazmalisiz");

            Console.WriteLine(sentence2);
           


        }


    }
}
