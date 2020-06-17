using System;

namespace Accumulator {
    class Program {
        static void Main(string[] args) {
            var total = 0;
            for  (int num = 0; num <= 50; num++) {
                if (num % 5 == 0 || num % 7 == 0) //checks if dividible by 5 or 7
                total += num;
            }
            Console.WriteLine($"The Answer is {total}");
        }
    }
}
