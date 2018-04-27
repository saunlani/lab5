using System;

namespace lab5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Factorial Calculator!\n");

            bool keepitmovin = true;

            while (keepitmovin)
            {
                Console.Write("Enter an integer that's greater than 0 but less than 10:  ");

                string userinput = Console.ReadLine();
                int usernum;
                bool validnumber = int.TryParse(userinput, out usernum);

                if (validnumber && usernum > 0 && usernum < 10)
                {

                    int i;
                    for (i = usernum - 1; i >= 1; i--)
                    {
                        usernum = usernum * i;
                    }
                    long factorial = usernum;
                        Console.WriteLine($"\nThe factorial of {userinput} is " + factorial);

                    bool playagain = true;
                    while (playagain)
                    {
                        Console.Write("\nContinue? (y/n):  ");
                        string yeyorney = Console.ReadLine();
                        yeyorney = yeyorney.ToLower();

                        if (yeyorney == "y")
                        {
                            keepitmovin = true;
                            playagain = false;
                            Console.WriteLine();
                        }
                        else if (yeyorney == "n")
                        {
                            playagain = false;
                            keepitmovin = false;

                        }
                        else
                        {
                            Console.WriteLine("You did not enter y or n, try again. ");
                            continue;


                        }
                    }
                }
                else
                {
                    Console.WriteLine("\nYou did not enter a valid number.\n");
                }
            }

        }

    }
}

