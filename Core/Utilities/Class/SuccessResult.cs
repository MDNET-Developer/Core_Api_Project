using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Class
{
    public class SuccessResult : Result
    {
        public SuccessResult(bool succsess, string message) : base(true, message)
        {
        }

        public SuccessResult(bool succsess) : base(true)
        {
        }
    }
}
