using System;

namespace Accumulator {
    class Program {

        /// <summary>
        /// Program sete value of a lower and upper variable equal to the lowest and highest values in an array.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args) {
            //var total = 0;
            //for  (int num = 0; num <= 50; num++) {
            //    if (num % 5 == 0 || num % 7 == 0) //checks if dividible by 5 or 7
            //    total += num;
            //}
            //Console.WriteLine($"The Answer is {total}");

            int[] ints = {
                754, 233, 509, 792, 700, 596, 833, 658, 998, 742,
                187, 754, 308, 914, 489, 867, 717, 586, 929, 467,
                460, 241, 770, 324, 599, 259, 120, 800, 336, 609,
                690, 134, 598, 249, 282, 574, 334, 956, 659, 214,
                435, 643, 809, 874, 906, 620, 328, 369, 426, 561
            };
            var upper = 0;
            var lower = 1000;
            foreach (var i in ints) {
                if (i < lower)
                    lower = i;
                if(i > upper)
                    upper = i;
                }
            Console.WriteLine($"The lowest number is {lower} and the highest number is {upper}");
        }
    }
}
