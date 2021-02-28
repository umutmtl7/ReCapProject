using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class SuccessResult:Result
    {
        //with message
        public SuccessResult(string message) : base(true, message)
        {

        }
        //only bool
        public SuccessResult() : base(true)
        {

        }
    }
}
