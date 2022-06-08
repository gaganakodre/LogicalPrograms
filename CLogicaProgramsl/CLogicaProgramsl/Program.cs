namespace CLogicaProgramsl
{
    class program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the realtive number to perform some operation");
            Console.WriteLine("Press 1 to perform the perfect number");
            int problem = Convert.ToInt32(Console.ReadLine());
            switch (problem)
            {
                case 1:
                    Perfectnumber1 Pnum = new Perfectnumber1();
                    Pnum.Perfectnum();
                    break;
            }
        }
    }
}
