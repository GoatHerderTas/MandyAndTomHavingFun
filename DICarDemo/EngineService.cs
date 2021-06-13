using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICarDemo
{
    public class EngineService : IEngineService
    {
        public string Move(string direction)
        {
            if (direction.ToLower() == "forward")
            {
                return "engine is moving car forward";
            }
            else
            {
                return "engine is moving car backward";
            }
        }
    }
}
