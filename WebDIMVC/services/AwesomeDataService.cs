using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebDIMVC.services
{
    public class AwesomeDataService : IAwesomeDataService
    {
        public string GetData(int id)
        {
            return "Here it is";
        }
    }
}
