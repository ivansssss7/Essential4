using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4
{
    class TXTHandler : AbstractHandler
    {
        public override void Open()
        {
            Console.WriteLine("Opening TXT document");
        }
        public override void Create()
        {
            Console.WriteLine("Creating TXT document");
        }
        public override void Change()
        {
            Console.WriteLine("Changing TXT document");
        }
        public override void Save()
        {
            Console.WriteLine("Saving TXT document");
        }
    }
}
