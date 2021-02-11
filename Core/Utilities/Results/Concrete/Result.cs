using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results.Abstract;
using Microsoft.Data.SqlClient;

namespace Core.Utilities.Results.Concrete
{
    public class Result : IResult
    {

        public Result(bool success, string message) : this(success)
        {
            message = Message;
        }

        public Result(bool success)
        {
            success = Success;
        }

        public bool Success { get; }

        public string Message { get; }
    }
}
