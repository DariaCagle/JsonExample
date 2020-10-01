using System;

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
