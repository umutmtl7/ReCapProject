using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public class ErrorResult:Result
    {
        //with message
        public ErrorResult(string message):base(false,message)
        {

        }
        //only bool
        public ErrorResult():base(false)
        {

        }
    }
}
