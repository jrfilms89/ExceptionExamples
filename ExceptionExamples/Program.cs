using System;

namespace ExceptionExamples {
    class Program {
        static void Main(string[] args) {
            try {
                Run();
            } catch (UserExceptions ex) {
                Console.WriteLine($"{ex.NumberInError}: {ex.Message}");
            } catch (Exception ex) {
                Console.WriteLine($"{ex.Message}");
            }
        }
        static void Run() {
            
                Test();
                var ex = new UserExceptions("This exception was forced!");
                ex.NumberInError = 69;
                throw ex;
            
        }

        static void Test() {
            try {
                var num = 1;
                var denom = 0;
                var ans = num / denom;
            } catch (DivideByZeroException ex) {
                Console.WriteLine($"Exception occured : {ex.Message}");
            }
        }
    }
}
