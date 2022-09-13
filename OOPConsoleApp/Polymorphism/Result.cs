using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConsoleApp.Polymorphism
{
    internal class Result : IResult
    {
        public Result(bool success, string message)
        {
            this.Success = success;
            this.Message = message;
        }

        public Result(bool success)
        {
            this.Success = success;
        }
        public Result(string message)
        {
            this.Message= message;
        }

        public bool Success { get; set; }
        public string Message { get; set ; }
    }
}
