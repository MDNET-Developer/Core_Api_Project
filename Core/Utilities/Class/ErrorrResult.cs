using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Class
{
    public class ErrorrResult : Result
    {
        public ErrorrResult(bool succsess, string message) : base(false, message)
        {
        }
    }
}
