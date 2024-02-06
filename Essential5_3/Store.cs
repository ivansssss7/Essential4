using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential5_3
{
    class Store
    {
        private Article[] articles;

        // Конструктор класу Store, в якому ви можете ініціалізувати ваш масив articles
        public Store(int size)
        {
            articles = new Article[size];
        }

        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                    return articles[index];
                else
                    return null; 
            }
            set
            {
                if (index >= 0 && index < articles.Length)
                    articles[index] = value;
            }
        }

        public void DisplayArticleInfo(int index)
        {
            Article article = this[index];

            if (article != null)
            {
                Console.WriteLine($"Title: {article.TitleGood}, Store: {article.StoreName}, Price: {article.Price} UAH");
            }
            else
            {
                Console.WriteLine("Article not found");
            }
        }

        public void DisplayArticleInfo(string title)
        {
            bool found = false;

            foreach (var article in articles)
            {
                if (article != null && article.TitleGood == title)
                {
                    Console.WriteLine($"Title: {article.TitleGood}, Store: {article.StoreName}, Price: {article.Price} UAH");
                    found = true;
                    break;
                }
            }

            if (!found)
            {
                Console.WriteLine($"Article with title '{title}' not found");
            }
        }

    }
}
