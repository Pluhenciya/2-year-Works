using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal record Entrant
    {
        public string Name { get; set; }

        public int Class { get; set; }

        public double AverageScore { get; set; }

        public Entrant():this("Человек X", 12, 6.0)
        {
        }

        public Entrant(string name, int @class, double averageScore)
        {
            Name = name;
            Class = @class;
            AverageScore = averageScore;
        }
    }
}
