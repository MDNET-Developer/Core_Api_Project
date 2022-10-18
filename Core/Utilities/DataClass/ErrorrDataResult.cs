using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.DataClass
{
    internal class ErrorrDataResult<T> : DataResult<T>
    {
        public ErrorrDataResult(T data, bool succsess, string message) : base(data, false, message)
        {
        }
    }
}
