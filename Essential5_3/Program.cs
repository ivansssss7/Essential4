using Essential5_3;

class Program
{
    static void Main(string[] args)
    {
        Store store = new Store(3);

        store[0] = new Article { TitleGood = "Product1", StoreName = "Store1", Price = 100 };
        store[1] = new Article { TitleGood = "Product2", StoreName = "Store2", Price = 150 };
        store[2] = new Article { TitleGood = "Product3", StoreName = "Store3", Price = 200 };

        //Console.WriteLine(store[1].TitleGood);
        store.DisplayArticleInfo(1);
        store.DisplayArticleInfo(3);
        store.DisplayArticleInfo("Product2"); // Вивід інформації за назвою
        store.DisplayArticleInfo("Product4"); // Вивід інформації за назвою
        Console.ReadLine();

    }
}