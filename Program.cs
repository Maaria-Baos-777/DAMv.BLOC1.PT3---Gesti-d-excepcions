using System;

namespace Program
{
    public class Program
    {
        public static void Main()
        {
            const string MSG_Menu = "------Menu-----";
            const string MSG_Exercises = "Exercises: ";
            const string MSG_Ex1 = "1 - Exercise 1 Try Catch";
            const string MSG_Ex2 = "2 - Exercise 2 Try Catch";
            const string MSG_Ex3 = "3 - Exercise 3 Try Catch";
            const string MSG_Ex4 = "4 - Exercise 4 Try Catch";
            const string MSG_Exit = "0 - Exit";
            const string MSG_Line = "---------------";
            const string MSG_Choose = "Choose a option: ";

            const string MSG_ExitGame = "Exit...";

            int userOption = 0;

            Console.WriteLine(MSG_Menu);
            Console.WriteLine(MSG_Exercises);
            Console.WriteLine(MSG_Ex1);
            Console.WriteLine(MSG_Ex2);
            Console.WriteLine(MSG_Ex3);
            Console.WriteLine(MSG_Ex4);
            Console.WriteLine(MSG_Exit);
            Console.WriteLine(MSG_Line);

            Console.Write(MSG_Choose);
            userOption = Convert.ToInt32(Console.ReadLine());

            while (userOption != 0)
            {
                switch(userOption)
                {
                    case 1:
                        Ex1TryCatch();
                    break;
                    case 2:
                        Ex2TryCatch();
                    break;
                    case 3:
                        Ex3TryCatch();
                    break;
                    case 4:
                        Ex4TryCatch();
                    break;
                    case 0:
                        Console.WriteLine(MSG_ExitGame);
                    break;
                }

                Console.WriteLine();
                Console.WriteLine(MSG_Menu);
                Console.WriteLine(MSG_Exercises);
                Console.WriteLine(MSG_Ex1);
                Console.WriteLine(MSG_Ex2);
                Console.WriteLine(MSG_Ex3);
                Console.WriteLine(MSG_Ex4);
                Console.WriteLine(MSG_Exit);
                Console.WriteLine(MSG_Line);

                Console.Write(MSG_Choose);
                userOption = Convert.ToInt32(Console.ReadLine());
            }

        }

        public static void Ex1TryCatch()
        {
            const string MSG_Potions = "How many potions do you want to buy? ";
            const string MSG_Buy = "You buy {0} potions";
            const string MSG_ErrorNotNumber = "This is not a number! Try again";
            const string MSG_ErrorNumberTooBig = "This number is too big or too small! Try again";
            int userInput = 0;
            bool isCorrect = false;

            while (!isCorrect)
            {
                try
                {
                    Console.Write(MSG_Potions);
                    userInput = int.Parse(Console.ReadLine());
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(MSG_ErrorNotNumber);
                }
                catch (OverflowException)
                {
                    Console.WriteLine(MSG_ErrorNumberTooBig);
                }
            }

            if (isCorrect == true)
            {
                Console.WriteLine(MSG_Buy, userInput);
            }
        }

        public static void Ex2TryCatch()
        {
            const string MSG_GoldTotal = "Introduce the gold total: ";
            const string MSG_MembersGroup = "Introduce the members of the group: ";
            const string MSG_Total = "The total gold what falls to each person is: {0}";
            const string MSG_Error = "You can't distribute the gold between 0 persons";
            const string MSG_ErrorFormat = "Error of format. Please introduce a number";
            const string MSG_ErrorUnexpected = "Error unexpected";

            int goldTotal, membersGroup, total = 0;
            bool isCorrect = false;

            while (!isCorrect)
            {
                try
                {
                    Console.WriteLine(MSG_GoldTotal);
                    goldTotal = int.Parse(Console.ReadLine());
                    Console.WriteLine(MSG_MembersGroup);
                    membersGroup = int.Parse(Console.ReadLine());
                    total = goldTotal / membersGroup; 
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(MSG_ErrorFormat);
                }
                catch(DivideByZeroException)
                {
                    Console.WriteLine(MSG_Error);
                }
                catch(Exception ex)
                {
                    Console.WriteLine($"{MSG_ErrorUnexpected} (" + ex.GetType().Name + "): " + ex.Message);
                }
            }

            if(isCorrect == true)
            {
                Console.WriteLine(MSG_Total, total);
            }
        }

        public static void Ex3TryCatch()
        {
            const string MSG_IntroduceLine = "Introduce the line of the matrix (3x3): ";
            const string MSG_IntroduceColumn = "Introduce the column of the matrix (3x3): ";
            const string MSG_YourChoose = "Your choose is: ";
            const string MSG_Map = "Map: ";

            const string MSG_ErrorFormat = "Error of format. Please introduce a number";
            const string MSG_NumberOutOfRange = "The number is not in the range of the matrix";

            const string MSG_EndOfMap = "End of map consultation";

            string[,] map =
            {
                { "Entrada", "Passadís", "Trampa" },
                { "Tresor", "Corredor", "Drac" },
                { "Armeria", "Pou", "Sortida" }
            };

            int userLine, userColumn;
            bool isCorrect = false;

            while (!isCorrect)
            {
                try
                {
                    Console.Write(MSG_IntroduceLine);
                    userLine = int.Parse(Console.ReadLine());
                    Console.Write(MSG_IntroduceColumn);
                    userColumn = int.Parse(Console.ReadLine());

                    Console.WriteLine(MSG_YourChoose);
                    Console.WriteLine(map[userLine, userColumn]);

                    Console.WriteLine();
                    Console.WriteLine(MSG_Map);
                    for (int i = 0; i < map.GetLength(0); i++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            Console.Write($"{map[i, j]} ");
                        }
                        Console.WriteLine();
                    }
                    Console.WriteLine();
                    isCorrect = true;
                }
                catch (FormatException)
                {
                    Console.WriteLine(MSG_ErrorFormat);
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine(MSG_NumberOutOfRange);
                }
                finally
                {
                    Console.WriteLine(MSG_EndOfMap);
                }
            }
        }

        public static void Ex4TryCatch()
        {
            const string MSG_IntroduceLine = "Introduce the line of the matrix (3x3): ";
            const string MSG_IntroduceColumn = "Introduce the column of the matrix (3x3): ";
            const string MSG_YourChoose = "Your choose is: ";
            const string MSG_Chest = "Chest: ";

            const string MSG_ErrorFormat = "Error of format. Please introduce a number";
            const string MSG_NumberOutOfRange = "The chest or item does not exist";

            const string MSG_EndOfChest = "End of chest consultation";

            int[][] chests =
           {
                new int[] { 10, 20, 30 },
                new int[] { 5, 15 },
                new int[] { 100, 200, 300, 400 },
                new int[] { 50 }
            };

            int userChestLine, userChestColumn;
            bool isCorrect = false;

            while(!isCorrect)
            {
                try
                {
                    Console.WriteLine(MSG_IntroduceLine);
                    userChestLine = int.Parse(Console.ReadLine());
                    Console.WriteLine(MSG_IntroduceColumn);
                    userChestColumn = int.Parse(Console.ReadLine());
                    Console.WriteLine(MSG_YourChoose);
                    Console.WriteLine(chests[userChestLine][userChestColumn]);

                    Console.WriteLine();
                    Console.WriteLine(MSG_Chest);
                    for(int i = 0; i < chests.Length; i++)
                    {
                        Console.WriteLine($"Chest {i}: ");
                        for(int j = 0; j < chests[i].Length; j++)
                        {
                            Console.WriteLine($"{chests[i][j]}");
                        }
                        Console.WriteLine();
                    }

                    isCorrect = true;

                }
                catch(FormatException)
                {
                    Console.WriteLine(MSG_ErrorFormat);
                }
                catch(IndexOutOfRangeException)
                {
                    Console.WriteLine(MSG_NumberOutOfRange);
                }
                finally
                {
                    Console.WriteLine(MSG_EndOfChest);
                }
            }
        }
    }
}