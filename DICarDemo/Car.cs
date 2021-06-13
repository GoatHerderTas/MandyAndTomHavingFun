using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DICarDemo
{
    public class Car
    {
        IEngineService _engineService;

            
        public Car(IEngineService engineService)
        {
            this._engineService = engineService;
        }
        public String MoveForward()
        {
            return _engineService.Move("forward");
        }
        public String MoveBackward()
        {
            return _engineService.Move("backwards");
        }
    }
}
