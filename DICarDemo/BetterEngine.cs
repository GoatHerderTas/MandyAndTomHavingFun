using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICarDemo
{
    public class BetterEngine : IEngineService
    {
        public string Move(string direction)
        {
            if (direction.ToLower() == "forward")
            {
                return "BETTER engine is moving car forward FASTER";
            }
            else
            {
                return "BETTER engine is moving car backward FASTER";
            }
        }
    }
}
