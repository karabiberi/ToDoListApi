using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Buisness.Utilites.Exceptions
{
    public class AlreadyExistException : Exception
    {
        public AlreadyExistException(string message) : base(message)
        {
        }
        public AlreadyExistException() : base("Bu veri zaten mevcut!!")
        {

        }
    }
}
