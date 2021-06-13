using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookDIDemo
{
    public class OvenService : IOvenService
    {
        public string Bake(string whatFood)
        {
            return $"{whatFood} has been baked!";
        }
    }
}
