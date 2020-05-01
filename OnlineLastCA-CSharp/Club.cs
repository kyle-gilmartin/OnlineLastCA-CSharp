using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLastCA_CSharp
{
    class Club
    {
        public string PlayerClub { get; set; }

        public Club(string playerclub)
        {
            PlayerClub = playerclub;
        }

        public override string ToString()
        {
            return $"{PlayerClub}";
        }
    }

   
}
