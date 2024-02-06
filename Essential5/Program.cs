using System.Text;

namespace Essential5;

//Використовуючи Visual Studio, створіть проект за шаблоном 
//Console Application.Потрібно: Створити масив розмірністю N елементів, 
//заповнити його довільними цілими значеннями.
//Вивести найбільше значення масиву, найменше значення масиву, 
//загальну суму елементів, середнє арифметичне всіх елементів,
//вивести всі непарні значення.

class Program
{
    static int MaxArr(int[] arr)
    {
        int bigger = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {

            if (bigger < arr[i])
            {
                bigger = arr[i];
            }
        }
        return bigger;
    }
    static int MinArr(int[] arr)
    {
        int smaller = arr[0];
        for (int i = 0; i < arr.Length; i++)
        {

            if (smaller > arr[i])
            {
                smaller = arr[i];
            }
        }
        return smaller;
    }
    static int Sum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum+= arr[i];
        }
        return sum;
    }
    static double Avg(int[] arr)
    {
        double sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }
        return sum/Convert.ToDouble(arr.Length);
    }
    static void NotEven(int[] arr)
    {

        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] % 2 != 0)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
    static void Main()
    {
        Console.OutputEncoding = Encoding.Unicode;
        Random random = new Random();

        int N = random.Next(2,10);

        int[] arr = new int[N];
        for (int i = 0; i < N; i++)
        {
            arr[i] = random.Next(0,99);
        }
        Console.WriteLine("Масив містить такі елементи");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i]);
        }
        Console.WriteLine("Найменше значення "+arr.Min());
        //або 
        Console.WriteLine(MinArr(arr));
        Console.WriteLine("Найбільше значення " + arr.Max());
        //або
        Console.WriteLine(MaxArr(arr));
        Console.WriteLine("Загальна сума елементів " + arr.Sum());
        //або
        Console.WriteLine(Sum(arr));
        Console.WriteLine("Середнє арифметичне елементів " + arr.Average());
        //або
        Console.WriteLine(Avg(arr));
        Console.WriteLine("Всі непарні значення");
        NotEven(arr);
        Console.ReadLine() ;
    }
}