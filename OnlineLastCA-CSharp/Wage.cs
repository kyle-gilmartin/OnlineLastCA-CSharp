using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLastCA_CSharp
{
    class Wage
    {
        public int PlayerWage { get; set; }

        public Wage(int playerwage)
        {
            PlayerWage = playerwage;
        }

        public override string ToString()
        {
            return $"{PlayerWage}";
        }
    }
}
