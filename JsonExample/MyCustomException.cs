using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample
{
    public class MyCustomException : Exception
    {
        public override string Message
        {
            get { return $"No properties without {nameof(MyIgnoreAttribute)}!"; } 
        }
    }
}
