using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookDIDemo
{
    public class CookApp
    {
        IOvenService _ovenService;
        public CookApp(IOvenService ovenService)
        {
            this._ovenService = ovenService;
        }

        public string cook(string cookWhat)
        {
            return this._ovenService.Bake(cookWhat);
        }

    }
}
