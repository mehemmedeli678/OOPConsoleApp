using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp.Polymorphism
{
    internal class ReturnHelper
    {
        public Result Add(bool succees)
        {

            if (succees)
            {
                return new SuccessResult();
            }
            return new ErrorResult();
        }
    }
}
