using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Buisness.Utilites.Result.Abstract
{
    public interface IResult
    {
        public bool Success { get; }
        public string Message { get; }
    }
}
