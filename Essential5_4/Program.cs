using System;

namespace Essential5_4
{
    class Program
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Dictionary dictionary = new Dictionary();

            //Console.WriteLine(dictionary["стол", "українська"]); 
            //Console.WriteLine(dictionary["book", "english"]);    
            //Console.WriteLine(dictionary["книга", "русский"]);  

            Console.WriteLine(new string('-', 20));
            // Затримка.
            Console.ReadKey();
        }
    }
}
