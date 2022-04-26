using System;

namespace CSharp.LabExercise2
{
    internal class Program
    {
        static void Number1()
        {
            Console.WriteLine("Five Unique Numbers Between 10 and 100");

            int[] arraySize = new int[5];
            int lowestPossibleInput = 10;
            int highestPossibleInput = 100;
            int counter = 0;
            int inputNumber;

            while (counter < arraySize.Length)
            {
                Console.Write("\nEnter number: ");
                inputNumber = Convert.ToInt32(Console.ReadLine());

                if (inputNumber >= lowestPossibleInput && inputNumber <= highestPossibleInput)
                {
                    if (Array.Exists(arraySize, checkInputNumber => checkInputNumber == inputNumber))
                    {
                        Console.WriteLine("{0} has already been entered!", inputNumber);
                    }
                    else
                    {
                        arraySize[counter] = inputNumber;
                        counter++;

                        foreach (int arrayIndex in arraySize)
                        {
                            if (arrayIndex > 0)
                            {
                                Console.Write("{0}  ", arrayIndex);
                            }
                        }
                        Console.Write("\n");
                    }
                }
                else
                {
                    Console.WriteLine("Number must be between 10 and 100!");
                }
            }
        }

        class Lasagna
        {
            int expectedOventime = 40;
            int timeToPrepEachLayer = 2;

            public void ExpectedMinutesInOven()
            {
                Console.WriteLine("Expected oven time in minutes is {0}.\n", expectedOventime);
            }

            public void RemainingMinutesInOven(int actualMinutesInOven)
            {
                int RemainingMinutesInOven = expectedOventime - actualMinutesInOven;
                Console.WriteLine("Time the lasagna still has to remain in the oven: {0} minutes\n", RemainingMinutesInOven);
            }

            public void PreparationTimeInMinutes(int numOfLayersAdded)
            {
                int PreparationTimeInMinutes = numOfLayersAdded * timeToPrepEachLayer;
                Console.WriteLine("You spent {0} minutes preaparing the lasagna.\n", PreparationTimeInMinutes);
            }

            public void ElapsedTimeInMinutes(int numOfLayersAdded, int timeInOven)
            {
                int ElapsedTimeInMinutes = (numOfLayersAdded * 2) + timeInOven;
                Console.WriteLine("The time you've worked on cooking the lasagna is {0} minutes.\n", ElapsedTimeInMinutes);
            }
        }

        static void Number2()
        {
            Console.WriteLine("\nLucian's Anniversary dinner: Exquisite Lasagna\n");

            var lasagna = new Lasagna();
            bool continueToInput = true;

            while (continueToInput)
            {
                Console.WriteLine("1. Expected oven time in minutes");
                Console.WriteLine("2. Remaining oven time in minutes");
                Console.WriteLine("3. Preparation time in minutes");
                Console.WriteLine("4. Elapsed time in minutes");
                Console.WriteLine("5. Exit\n");
                Console.Write("Select Task: ");

            switch (Console.ReadLine())
                {
                    case "1":
                        lasagna.ExpectedMinutesInOven();
                        break;
                    case "2":
                        Console.Write("Input the Time the lasagna has been in the oven: ");
                        int actualTime = Convert.ToInt32(Console.ReadLine());

                        if (actualTime < 0)
                        {
                            Console.WriteLine("Invalid Input\n");
                        }
                        else if (actualTime >= 40)
                        {
                            lasagna.RemainingMinutesInOven(actualTime);
                            Console.WriteLine("Remove lasagna from oven!\n");
                        }
                        else
                        {

                            lasagna.RemainingMinutesInOven(actualTime);
                        }
                        break;

                    case "3":
                        Console.Write("Input the Number of Layers you added to the lasagna: ");
                        int addedLayers = Convert.ToInt32(Console.ReadLine());

                        lasagna.PreparationTimeInMinutes(addedLayers);
                        break;

                    case "4":
                        Console.Write("Input the Number of Layers you added to the lasagna: ");
                        int addedLayersElapsedTask = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Input the Time the lasagna has been in the oven: ");
                        int actualTimeElapsedTask = Convert.ToInt32(Console.ReadLine());

                        if (actualTimeElapsedTask < 0)
                        {
                            Console.WriteLine("Invalid Input\n");
                        }

                        else if (actualTimeElapsedTask >= 40)
                        {
                            lasagna.ElapsedTimeInMinutes(addedLayersElapsedTask, actualTimeElapsedTask);
                            Console.WriteLine("Remove lasagna from oven!\n");
                        }

                        else if (actualTimeElapsedTask < 40)
                        {
                            lasagna.ElapsedTimeInMinutes(addedLayersElapsedTask, actualTimeElapsedTask);
                        }
                        break;

                    case "5":
                        Environment.Exit(-1);
                        break;

                    default:
                        Console.WriteLine("Choose from available selection only.\n");
                        break;
                }
            } 
        }

            static void Main(string[] args)
            {
                Number1();
                Number2();
            }
    }
}