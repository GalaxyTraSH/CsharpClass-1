using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace aLotofRandomSteps
{
    class Program
    {
        static void Main(string[] args)
        {
            int stepsTaken = 0;
            int totalSteps = 0;
            int xPos = 0, yPos = 0;
            int i = 0;
            float sumX = 0, sumY = 0;
            Boolean done = true;

            Random random = new Random();//Create a new random instance
            Console.WriteLine("How many steps should Getch take?");
            totalSteps = Convert.ToInt32(Console.ReadLine());

            while (done)
            {
                xPos = yPos = 0;
                for (stepsTaken = 0; stepsTaken <= totalSteps; stepsTaken++)
                {

                    int step = random.Next(100);//generate numbers between 0 - 99
                    switch (step % 4)           //huh, this is actually really cool
                    {
                        case 0:
                            xPos++;
                            break;
                        case 1:
                            xPos--;
                            break;
                        case 2:
                            yPos++;
                            break;
                        case 3:
                            yPos--;
                            break;
                    }
                    i++;//counts loops
                    if (i == 100)
                        done = false;
                    sumX += xPos;
                    sumY += yPos;
                }
            }
            sumX /= 100;
            sumY /= 100;
            Console.WriteLine("I seem to end up at ({0} {1}) a lot...", sumX, sumY);
            Console.ReadKey();
        }
    }
}
//omg im done, yasss
