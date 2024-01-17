using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4_3
{
    abstract class DocumentPart
    {
        protected string content;

        public string Content
        {
            private get
            {
                if (content != null)
                    return content;
                else
                    return GetDefaultContent();
            }
            set
            {
                content = value;
            }
        }

        protected abstract string GetDefaultContent();

        public void Show(ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
