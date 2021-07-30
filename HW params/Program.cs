using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_params
{
    class Program
    {
        static void Main(string[] args)
        {
            #region question 1

            Console.WriteLine(SumOfParams(5, 3, 7, 8));

            #endregion

            #region question 2

            Console.WriteLine($"\n{CheckABC(7)}");
            Console.WriteLine($"{CheckABC(7, 5)}");
            Console.WriteLine($"{CheckABC(7, 5, 3)}");

            #endregion

            #region question 3

            Console.WriteLine($"\n{CheckABC(a: 1, c: 10)}");

            #endregion

            #region question 4

            Console.WriteLine($"{MultiplyNumBy3(5)}");

            #endregion

            #region question 5

            Phone myPhone1 = new Phone(battery: 70);
            Phone myPhone2 = new Phone(model: "WowPhone");
            Phone myPhone3 = new Phone(screenSize: 14.2F);
            Phone myPhone4 = new Phone(cameraQuality: "480p");

            #endregion
        }

        public static int SumOfParams(params int[] myNumbers)
        {
            int sum = 0;
            int howManyNum = myNumbers.Length;
            for (int i = 0; i < myNumbers.Length; i++)
            {
                switch (Array.IndexOf(myNumbers, myNumbers[i]))
                {
                    case 0:
                        sum += myNumbers[i];
                        break;
                    case 1:
                        sum += myNumbers[i] * myNumbers[i];
                        break;
                    case 2:
                        sum += myNumbers[i] * myNumbers[i] * myNumbers[i];
                        break;
                    case 3:
                        sum += myNumbers[i] * myNumbers[i] * myNumbers[i] * myNumbers[i];
                        break;
                }
            }
            return sum;
        }

        public static int CheckABC(int a, int b = 1, int c = -1)
        {
            return a * b * c;
        }

        public static int MultiplyNumBy3(in int userNum)
        {
            return userNum * 3;
        }
    }
}
