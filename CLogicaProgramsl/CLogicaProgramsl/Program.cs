namespace CLogicaProgramsl
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the realtive number to perform some operation");
            Console.WriteLine("Press 1 to perform the perfect number");
            Console.WriteLine("Press 2 to perform the  stopwatch program");
            Console.WriteLine("Press 3 to perform the  revesering a number");
            Console.WriteLine("Press 4 to perform the Fibonacci serioes");
            int problem = Convert.ToInt32(Console.ReadLine());
            switch (problem)
            {
                case 1:
                    Perfectnumber1 Pnum = new Perfectnumber1();
                    Pnum.Perfectnum();
                    break;
                case 2:
                    StopWatch SWatch = new StopWatch();
                    SWatch.StopWatchPrg();
                    break;
                case 3:
                    ResverseNumber RevNum = new ResverseNumber();
                    RevNum.ReverseNum();
                    break;
                case 4:
                    Fibonaci1 fib = new Fibonaci1();
                    fib.fibonacci();
                    break;
            }
        }
    }
}
