using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4_3
{
    class Document
    {
        Title title = null;
        Body body = null;
        Footer footer = null;

        void InitializeDocument()
        {
            this.title = new Title();
            this.body = new Body();
            this.footer = new Footer();
        }

        public Document(string title)
        {
            InitializeDocument();
            this.title.Content = title;
        }

        public void Show()
        {
            this.title.Show(ConsoleColor.Yellow);
            this.body.Show(ConsoleColor.Blue);
            this.footer.Show(ConsoleColor.Green);
        }

        public string Body
        {
            set
            {
                this.body.Content = value;
            }
        }

        public string Footer
        {
            set
            {
                this.footer.Content = value;
            }
        }
    }
}
