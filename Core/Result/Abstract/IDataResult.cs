using Core.Buisness.Utilites.Result.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Buisness.Utilites.Result
{
    public interface IDataResult<T> : IResult
    {
        public T Data { get; } 
    }
}
