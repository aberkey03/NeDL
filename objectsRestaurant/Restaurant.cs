using System;
using System.IO;  // include the System.IO namespace

namespace MyApplication
{
  
    class Restaurant
    {
        public string RName
        {
            get; set;
        }
        public int RRate
        {
            get; set;
        }
        public Restaurant()
        {
            RName = null;
            RRate = -1;
        }
        public override string ToString()
        {
            return $"Restaurant: {RName} is rated {RRate}.";
        }
    }
}