using Essential5_2;

namespace Essential4_2;


class Program
{
    static void Main()
    {
        MyMatrix matrix = new MyMatrix(2, 2);

        matrix.FeedMatrix();
        matrix.ShowMatrix();

        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Number of cols - {0}\nNumber of rows - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
        Console.WriteLine(new string('-', 30));

        matrix.ChangeSizeOfMatrix(4, 4);
        matrix.FeedMatrix();
        matrix.ShowMatrix();
        Console.WriteLine(new string('-', 30));
        Console.WriteLine("Number of cols - {0}\nNumber of rows - {1}", matrix.NumberOfCols, matrix.NumberOfRows);
        Console.WriteLine(new string('-', 30));

        matrix[-9, 9] = 123;
        matrix[2, 10] = 2;
    }
}