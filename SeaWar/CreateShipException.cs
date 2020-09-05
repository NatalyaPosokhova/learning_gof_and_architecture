using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SeaWar
{
    public class CreateShipException : Exception
    {
        public CreateShipException(string message, Exception e = null) : base(message, e)
        {
            
        }
       
    }
}
