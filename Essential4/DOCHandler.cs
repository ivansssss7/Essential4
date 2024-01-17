using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4
{
    class DOCHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Opening DOC document");
        }
        public override void Create()
        {
            Console.WriteLine("Creating DOC document");
        }
        public override void Change()
        {
            Console.WriteLine("Changing DOC document");
        }
        public override void Save()
        {
            Console.WriteLine("Saving DOC document");
        }
    }
}
