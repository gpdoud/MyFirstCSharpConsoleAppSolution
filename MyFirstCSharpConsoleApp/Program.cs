using System;

namespace MyFirstCSharpConsoleApp {
    class Program {

        static void Main(string[] args) {

            for(var i = 1; i <= 30; i++) {
                if(i % 3 == 0 && i % 5 == 0) {
                    Console.Write("FizzBuzz ");
                    continue;
                }
                if(i % 3 == 0) {
                    Console.Write("Fizz ");
                    continue;
                }
                if (i % 5 == 0) {
                    Console.Write("Buzz ");
                    continue;
                }
                Console.Write($"{i} ");
            }

        }

    }
}
