using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLastCA_CSharp
{
    class born
    {
        public string PlayerBorn { get; set; }

        public born(string playerborn)
        {
            PlayerBorn = playerborn;

        }

        public override string ToString()
        {
            return $"{PlayerBorn}";
        }
    }
}
