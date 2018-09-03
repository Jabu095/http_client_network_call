using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace NetworkCalls
{
    public class ResponseErrorData : Exception
    {
        public ResponseErrorData(string msg,HttpStatusCode code):base(msg)
        {
            message = msg;
            status = code;
        }
        public HttpStatusCode status { get; set; }
        public string message { get; set; }
    }

    public static class ResponseMessages
    {
        public static string success = "successful";
        public static string failed = "failed";
        public static string unauthorised = "unAuthorised";
    }
}
