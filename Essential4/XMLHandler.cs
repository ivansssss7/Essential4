using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4
{
    class XMLHandler:AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Opening XML document");
        }
        public override void Create()
        {
            Console.WriteLine("Creating XML document");
        }
        public override void Change()
        {
            Console.WriteLine("Changing XML document");
        }
        public override void Save()
        {
            Console.WriteLine("Saving XML document");
        }
    }
}
