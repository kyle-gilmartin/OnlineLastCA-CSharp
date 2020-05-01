using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineLastCA_CSharp
{
    class players
    {
        public string Name{ get; set; }
        public List<born> Born { get; set; }
        public List<Club> Club { get; set; }
        public List<postion> Postions { get; set; }
        public List<Wage> Wage { get; set; }
        public List<height> Height { get; set; }


        public players(string name)
        {
            Name = name;
            Born = new List<born>();
            Club = new List<Club>();
            Postions = new List<postion>();
            Wage = new List<Wage>();
            Height = new List<height>();
        }

        public players()
        {
            Born = new List<born>();
            Club = new List<Club>();
            Postions = new List<postion>();
            Wage = new List<Wage>();
            Height = new List<height>();
        }

        public override string ToString()
        {
            return $"{Name}";
        }
    }
}
