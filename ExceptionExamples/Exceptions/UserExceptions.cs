using System;
using System.Collections.Generic;
using System.Text;

namespace ExceptionExamples {
    class UserExceptions : Exception{

        public double NumberInError { get; set; }

        public UserExceptions() : base() { }

        public UserExceptions(string message) : base(message) { }

        public UserExceptions(string message, Exception innerException) : base(message, innerException) { }
    }
}
