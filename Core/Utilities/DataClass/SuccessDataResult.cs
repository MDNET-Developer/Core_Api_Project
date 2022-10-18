using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.DataClass
{
    internal class SuccessDataResult<T> : DataResult<T>
    {
        public SuccessDataResult(T data, bool succsess, string message) : base(data, true, message)
        {
        }
    }
}
