using System;
using static System.Console;
using System.Threading;

namespace NumberGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            //========================= VERSION 1 =============================
            /*
            Write("Pick a number: ");

            int userNr = int.Parse(ReadLine());

            bool rightNr = userNr == 10;

            string result = rightNr ? "Congratulations, you won!" : "Sorry, wrong number! :'(";

            Write(result);
            */

            //========================= VERSION 2 =============================
            /*
            Write("Pick a number: ");

            int userNr = int.Parse(ReadLine());

            if (userNr == 10)
                Write("Congratulations, you won!");
            
            else if (userNr < 10)
                Write("Sorry, to low!");

            else if (userNr > 10)
                Write("Sorry, too high!");

            ReadLine();
            */

            //==================== VERSION 3  ==============
            /*
            bool gameOn = true;

            while (gameOn)
            {

                Write("Pick a number: ");

                int userNr = int.Parse(ReadLine());

                switch (userNr)
                {
                    case < 10:
                        Write("Sorry, too low! Please try again.");
                        Thread.Sleep(2000);
                        Clear();
                        break;

                    case > 10:
                        Write("Sorry, too high! Please try again.");
                        Thread.Sleep(2000);
                        Clear();
                        break;

                    case 10:
                        Write("Congratulations, you won!");
                        Thread.Sleep(2000);
                        Clear();
                        gameOn = false;
                        break;
                 }

            }
            */

            //====================== VERSION 4 Random.Next() ==================
            /*
            bool gameOn = true;
            Random random = new Random();
            int randomNr = random.Next(100); //Håller mig inom 0-100, annars får man gissa mellan 0 - 2miljarder

            do
            {
                Write("Pick a number: ");
                int userNr = int.Parse(ReadLine());

                if (userNr == randomNr)
                {
                    Write("Congratulations, you won!");
                    Thread.Sleep(2000);
                    Clear();
                    gameOn = false;
                }
                else if (userNr < randomNr)
                {
                    Write("Sorry, too low! Please try again.");
                    Thread.Sleep(2000);
                    Clear();
                }
                else if (userNr > randomNr)
                {
                    Write("Sorry, too high! Please try again.");
                    Thread.Sleep(2000);
                    Clear();
                }

            }
            while (gameOn);

            */

            


           

            

        }
    }
}
