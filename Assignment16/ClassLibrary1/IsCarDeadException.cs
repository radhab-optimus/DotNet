using System;

namespace ClassLibrary1
{
    public class IsCarDeadException : Exception
    {
        public IsCarDeadException() : base()
        { }
        public IsCarDeadException(string message)
            : base(message)
        { }
    }
}