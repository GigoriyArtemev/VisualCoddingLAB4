using System;

namespace VisualCoddingLAB4.Models
{
    public class RomanNumberException : Exception
    {
        public RomanNumberException(string message)
            : base(message)
        { }
    }
}