﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CLogicaProgramsl
{
    internal class Perfectnumber1
    {
        public bool Factors(int Number, int Potential_Factor)
        {
            if (Number % Potential_Factor == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Perfectnum()
        {
            int check = 0;
            Console.WriteLine("enter the number tat you to check");
            int Number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= Number /2; i++)
            {
                if (Factors(Number, i))
                {
                    check += i;
                }
            }
            if (check == Number)
            {
                Console.WriteLine(Number + "is a perfect a number");
            }
            else
            {
                Console.WriteLine(Number + "is a perfect not a number");
            }
        }
    }
}
