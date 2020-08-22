using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.Classes
{
    public class Foods
    {
        public string Name          { get; set; }
        public double StressValue   { get; set; }
        public double LifeValue     { get; set; }
        public double RestValue     { get; set; }
        public double TimeValue     { get; set; }

        public Foods(string name)
        {
            Name = name;
        }
    }
}
