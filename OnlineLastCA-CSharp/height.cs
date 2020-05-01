using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLastCA_CSharp
{
    class height
    {
        public string PlayerHeight { get; set; }

        public height(string playerheight)
        {
            PlayerHeight = playerheight;
        }

        public override string ToString()
        {
            return $"{PlayerHeight}";
        }
    }
}
