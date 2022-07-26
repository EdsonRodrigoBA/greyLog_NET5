using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste.savelog.api.Models
{
    public class LoggerRequest
    {
        public string ApplicationName { get; set; }
        public string Message { get; set; }
        public string InnerException { get; set; }
        public string StackTracer { get; set; }



    }
}
