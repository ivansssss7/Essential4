using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace Essential4_3;

//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Потрібно: Змінити приклад першого уроку (робота з документом) і 
//створити загальний абстрактний клас для всіх частин документа.

class Program
{
    static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;

        Document document = new Document("Контракт");
        document.Body = "Тіло контракту...";
        document.Footer = "Директор: Іванов І.І.";

        document.Show();
    }
}