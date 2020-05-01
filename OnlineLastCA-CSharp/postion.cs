using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLastCA_CSharp
{
    class postion
    {
        public string PlayerPostion { get; set; }

        public postion(string postion)
        {
            PlayerPostion = postion;
        }

        public override string ToString()
        {
            return $"{PlayerPostion}";
        }
    }
}
