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
            Console.WriteLine("Press 5 to perform the  prime number program");
            Console.WriteLine("Press 6 to perform the  coupon number program");
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
                    ReverseNumber RevNum = new ReverseNumber();
                    RevNum.ReverseNum();
                    break;

                case 4:
                    Fibonaci1 fib = new Fibonaci1();
                    fib.fibonacci();
                    break;
                case 5:
                    PrimeNumber pnum = new PrimeNumber();
                    pnum.PrimeNum();
                    break;
                case 6:
                    CouponNumber cnum = new CouponNumber();
                    cnum.CoupoNum();
                    break;
            }
        }
    }
}
