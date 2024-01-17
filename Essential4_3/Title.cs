using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Essential4_3
{
    class Title:DocumentPart
    {
        protected override string GetDefaultContent()
        {
            return "Заголовок відсутній.";
        }
    }
}
