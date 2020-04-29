using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLastCA_CSharp
{
    class Teams
    {
        public string TeamName { get; set; }

        public Teams(string teamName)
        {
            TeamName = teamName;
        }
        public override string ToString() {
            return $"{TeamName}";
        }

    }

    
}
