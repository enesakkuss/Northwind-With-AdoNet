using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheNorthwind.Business
{
    public class CommandResult
    {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public string ErrorMessage { get; set; }

        public static CommandResult Success (string message)
        {
            var result = new CommandResult ();
            result.IsSuccess= true;
            result.Message = message;
            return result;
        }
        public static CommandResult Failed(string message, Exception ex) 
        { 
            var result=new CommandResult();
            result.IsSuccess=false;
            result.Message = message;
            result.ErrorMessage = ex.ToString();
            return result;
        }
    }
}
