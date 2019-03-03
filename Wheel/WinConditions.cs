using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    static public class WinConditions
    {
        static public void Numbers()
        {
            Console.WriteLine("---Single Numbers---     35:1 Ratio");
            Console.Write($"Choosing Numbers: ");
            foreach (int x in RolledResults.RolledNumbers)
            {
                Console.Write($"{x} ");
            }
            Console.WriteLine();
            Console.WriteLine($"\nWinning Numbers: ");
            foreach (int x in RolledResults.RolledNumbers)
            {
                Console.Write($"*{x}* ");
            }

        }

        static public void EvenOdd()
        {
            Console.WriteLine("---Even Bets---     1:1 Ratio");
            Console.Write("Choosing Numbers: ");
            foreach (int x in Board.Even)
            {
                Console.Write($" {x} ");
            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");
            foreach (int x in RolledResults.RolledNumbers)
            {
                if(Array.IndexOf(Board.Even, x, 0, Board.Even.Length) > -1)
                {
                    Console.Write($"*{x}* ");
                }        
            }

            Console.WriteLine("\n\n---Odd Bets---     1:1 Ratio");
            Console.Write("Choosing Numbers:");
            foreach(int x in Board.Odd)
            {
                Console.Write($" {x} ");
            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if(Array.IndexOf(Board.Odd, x, 0, Board.Odd.Length) > -1)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
        }

        static public void Color()
        {
            Console.WriteLine("---Black Bets---     1:1 Ratio");
            Console.Write("Choosing Numbers: ");
            for(int count = 0; count < Board.Colors.Length; count++)
            {
                if (Board.Colors[count] == "Black")
                {
                    Console.Write($"{Board.Numbers[count]} ");
                }
            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");
            for(int count = 0; count < RolledResults.RolledColors.Length; count++)
            {
                if (RolledResults.RolledColors[count] == "Black")
                {
                    Console.Write($"*{RolledResults.RolledNumbers[count]}* ");                  
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n---Red Bets---     1:1 Ratio");
            Console.Write("Choosing Numbers: ");
            for (int count = 0; count < Board.Colors.Length; count++)
            {
                if (Board.Colors[count] == "Red")
                {
                    Console.Write($"{Board.Numbers[count]} ");
                }
            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");
            for (int count = 0; count < RolledResults.RolledColors.Length; count++)
            {
                if (RolledResults.RolledColors[count] == "Red")
                {
                    Console.Write($"*{RolledResults.RolledNumbers[count]}* ");

                }
            }
        }

        static public void LowsHighs()
        {
            Console.WriteLine("---Low Bets---     1:1");
            Console.Write("Choosing Numbers: ");
            foreach (int x in Board.Numbers)
            {
                if (x >= 1 && x <= 18)
                {
                    Console.Write($"{x} ");
                }
            }
            Console.WriteLine();
            Console.Write("\nWinnig Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if(x >= 1 && x <= 18)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n---High Bets---     1:1");
            Console.Write("Choosing Numbers: ");
            foreach (int x in Board.Numbers)
            {
                if (x >= 19 && x <= 36)
                {
                    Console.Write($"{x} ");
                }
            }
            Console.WriteLine();
            Console.Write("\nWinnig Numbers: ");
            foreach (int x in RolledResults.RolledNumbers)
            {
                if (x >= 19 && x <= 36)
                {
                    Console.Write($"*{x}* ");
                }
            }
        }

        static public void Dozens()
        {
            Console.WriteLine("---First Dozen Bets---     2:1");
            Console.Write("Choosing Numbers: ");
            foreach(int x in Board.Numbers)
            {
                if (x >= 1 && x <= 12)
                {
                    Console.Write($"{x} ");
                }
            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if (x >= 1 && x <= 12)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n---Second Dozen Bets---     2:1");
            Console.Write("Choosing Numbers: ");
            foreach (int x in Board.Numbers)
            {
                if (x >= 13 && x <= 24)
                {
                    Console.Write($"{x} ");
                }
            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");
            foreach (int x in RolledResults.RolledNumbers)
            {
                if (x >= 13 && x <= 24)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n---Third Dozen Bets---     2:1");
            Console.Write("Choosing Numbers: ");
            foreach (int x in Board.Numbers)
            {
                if (x >= 25 && x <= 36)
                {
                    Console.Write($"{x} ");
                }
            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");
            foreach (int x in RolledResults.RolledNumbers)
            {
                if (x >= 25 && x <= 36)
                {
                    Console.Write($"*{x}* ");
                }
            }
        }

        static public void Columns()
        {
            int[] ColumnArray = new int [12];
            int newarraycount = 0;
            Console.WriteLine("---First Column Bets---     2:1");
            Console.Write("Choosing Numbers: ");
            for (int count = 1; count < Board.Numbers.Length; count++)
            {
                if (count == 37)
                {
                    break;
                }

                Console.Write($"{Board.Numbers[count]} ");
                ColumnArray[newarraycount] = Board.Numbers[count];
                newarraycount++;
                count = count + 2;
                
            }
            newarraycount = 0;
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");

            foreach(int x in RolledResults.RolledNumbers)
            {
                if (Array.IndexOf(ColumnArray, x, 0, 12) > -1)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
            Console.WriteLine("\n---Second Column Bets---     2:1");
            Console.Write("Choosing Numbers: ");
            for (int count = 2; count < Board.Numbers.Length; count++)
            {
                Console.Write($"{Board.Numbers[count]} ");
                ColumnArray[newarraycount] = Board.Numbers[count];
                newarraycount++;
                count = count + 2;

            }
            newarraycount = 0;
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");

            foreach (int x in RolledResults.RolledNumbers)
            {
                if (Array.IndexOf(ColumnArray, x, 0, 12) > -1)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("---Third Column Bets---     2:1");
            Console.Write("Choosing Numbers: ");
            for (int count = 3; count < Board.Numbers.Length; count++)
            {
                Console.Write($"{Board.Numbers[count]} ");
                ColumnArray[newarraycount] = Board.Numbers[count];
                newarraycount++;
                count = count + 2;

            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");

            foreach (int x in RolledResults.RolledNumbers)
            {
                if (Array.IndexOf(ColumnArray, x, 0, 12) > -1)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
        }

        static public void StreetRow()
        {
            int[] firstcolumnarray = new int[12];
            int[] secondcolumnarray = new int[12];
            int[] thirdcolumnarray = new int[12];
            int newarraycount = 0;
            for (int count = 1; count < Board.Numbers.Length; count++)
            {
                if(count == 37)
                {
                    break;
                }

                firstcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            newarraycount = 0;
            for (int count = 2; count < Board.Numbers.Length; count++)
            {
                secondcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            newarraycount = 0;
            for (int count = 3; count < Board.Numbers.Length; count++)
            {
                thirdcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            Console.WriteLine("---Street Row Bets---     11:1");
            Console.Write("Choosing Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if(Array.IndexOf(firstcolumnarray, x, 0, 12) > -1)
                {
                    Console.Write($"{x}-{x + 1}-{x + 2}, ");
                }
                else if (Array.IndexOf(secondcolumnarray, x, 0, 12) > -1)
                {
                    Console.Write($"{x - 1}-{x}-{x + 1}, ");
                }
                else if (Array.IndexOf(thirdcolumnarray, x, 0, 12) > -1)
                {
                    Console.Write($"{x - 2}-{x - 1}-{x}, ");
                }               
            }
            Console.WriteLine();
            Console.Write("\nWinning Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if (x != 0)
                {
                    Console.Write($"*{x}* ");
                }
            }
        }

        static public void DoubleStreetRow()
        {
            int[] firstcolumnarray = new int[12];
            int[] secondcolumnarray = new int[12];
            int[] thirdcolumnarray = new int[12];
            int newarraycount = 0;
            for (int count = 1; count < Board.Numbers.Length; count++)
            {
                if (count == 37)
                {
                    break;
                }

                firstcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            newarraycount = 0;
            for (int count = 2; count < Board.Numbers.Length; count++)
            {
                secondcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            newarraycount = 0;
            for (int count = 3; count < Board.Numbers.Length; count++)
            {
                thirdcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            Console.WriteLine("---Double Street Row Bets---     5:1");
            Console.WriteLine("Choosing Numbers: ");
            foreach (int x in RolledResults.RolledNumbers)
            {
                if (Array.IndexOf(firstcolumnarray, x, 0, 12) > -1)
                {
                    if(x == 1)
                    {
                        Console.WriteLine($"{x}-{x + 1}-{x + 2}-{x + 3}-{x + 4}-{x + 5}, ");
                    }
                    else if (x == 34)
                    {
                        Console.WriteLine($"{x-3}-{x-2}-{x-1}-{x}-{x + 1}-{x + 2}, ");

                    }
                    else
                    {
                        Console.WriteLine($"{x - 3}-{x - 2}-{x - 1}-{x}-{x + 1}-{x + 2} OR {x}-{x + 1}-{x + 2}-{x + 3}-{x + 4}-{x + 5} ");
                    }
                }
                if (Array.IndexOf(secondcolumnarray, x, 0, 12) > -1)
                {
                    if (x == 2)
                    {
                        Console.WriteLine($"{x-1}-{x}-{x + 1}-{x + 2}-{x + 3}-{x + 4}, ");
                    }
                    else if (x == 35)
                    {
                        Console.WriteLine($"{x - 4}-{x - 3}-{x - 2}-{x-1}-{x}-{x + 1}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{x - 4}-{x - 3}-{x - 2}-{x - 1}-{x}-{x + 1} OR {x - 1}-{x}-{x + 1}-{x + 2}-{x + 3}-{x + 4} ");
                    }
                }
                if (Array.IndexOf(thirdcolumnarray, x, 0, 12) > -1)
                {
                    if (x == 3)
                    {
                        Console.WriteLine($"{x - 2}-{x-1}-{x}-{x + 1}-{x + 2}-{x + 3}, ");
                    }
                    else if (x == 36)
                    {
                        Console.WriteLine($"{x - 5}-{x - 4}-{x - 3}-{x - 2}-{x-1}-{x}, ");
                    }
                    else
                    {
                        Console.WriteLine($"{x - 5}-{x - 4}-{x - 3}-{x - 2}-{x - 1}-{x} OR {x - 2}-{x - 1}-{x}-{x + 1}-{x + 2}-{x + 3} ");
                    }
                }
            }
            Console.WriteLine();
            Console.Write("Winning Numbers: ");
            foreach (int x in RolledResults.RolledNumbers)
            {
                if (x != 0)
                {
                    Console.Write($"*{x}* ");
                }
            }
        }

        static public void Split()
        {
            int[] firstcolumnarray = new int[12];
            int[] secondcolumnarray = new int[12];
            int[] thirdcolumnarray = new int[12];
            int newarraycount = 0;
            for (int count = 1; count < Board.Numbers.Length; count++)
            {
                if (count == 37)
                {
                    break;
                }

                firstcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            newarraycount = 0;
            for (int count = 2; count < Board.Numbers.Length; count++)
            {
                secondcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            newarraycount = 0;
            for (int count = 3; count < Board.Numbers.Length; count++)
            {
                thirdcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            Console.WriteLine("---Split Bets---     17:1");
            Console.WriteLine("Choosing Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if(Array.IndexOf(firstcolumnarray, x, 0, 12) > -1)
                {
                    Console.WriteLine($"{x}/{x + 1}");
                }
                else if (Array.IndexOf(secondcolumnarray, x, 0, 12) > -1)
                {
                   Console.WriteLine($"{x - 1}/{x} OR {x}/{x + 1} ");
                }
                else if (Array.IndexOf(thirdcolumnarray, x, 0, 12) > -1)
                {
                    Console.WriteLine($"{x - 1}/{x}");
                }
            }
            Console.WriteLine();
            Console.Write("Winning Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if (x != 0)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
        }

        static public void Corner()
        {
            int[] firstcolumnarray = new int[12];
            int[] secondcolumnarray = new int[12];
            int[] thirdcolumnarray = new int[12];
            int newarraycount = 0;
            for (int count = 1; count < Board.Numbers.Length; count++)
            {
                if (count == 37)
                {
                    break;
                }

                firstcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            newarraycount = 0;
            for (int count = 2; count < Board.Numbers.Length; count++)
            {
                secondcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            newarraycount = 0;
            for (int count = 3; count < Board.Numbers.Length; count++)
            {
                thirdcolumnarray[newarraycount] = Board.Numbers[count];
                count = count + 2;
                newarraycount++;
            }
            Console.WriteLine("---Corner Bets---     8:1");
            Console.WriteLine("Choosing Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if(Array.IndexOf(firstcolumnarray, x, 0, 12) > -1)
                {
                    if (x == 1)
                    {
                        Console.WriteLine($"{x}-{x + 1}-{x + 3}-{x + 4}");
                    }
                    else if(x==34)
                    {
                        Console.WriteLine($"{x - 3}-{x - 2}-{x}-{x + 1} ");
                    }
                    else
                    {
                        Console.WriteLine($"{x - 3}-{x - 2}-{x}-{x + 1} |OR| {x}-{x + 1}-{x + 3}-{x + 4}");
                    }
                }
                else if (Array.IndexOf(secondcolumnarray, x, 0, 12) > -1)
                {
                    if (x == 2)
                    {
                        Console.WriteLine($"{x-1}-{x}-{x + 2}-{x + 3} |OR| {x}-{x+1}-{x+3}-{x+4}");
                    }
                    else if (x == 35)
                    {
                        Console.WriteLine($"{x - 4}-{x - 3}-{x-1}-{x} |OR| {x-3}-{x-2}-{x}-{x+1}");
                    }
                    else
                    {
                        Console.WriteLine($"{x - 4}-{x - 3}-{x - 1}-{x} |OR| {x - 3}-{x - 2}-{x}-{x + 1} |OR| {x - 1}-{x}-{x + 2}-{x + 3} |OR| {x}-{x + 1}-{x + 3}-{x + 4}");
                    }
                }
                else if (Array.IndexOf(thirdcolumnarray, x, 0, 12) > -1)
                {
                    if (x == 3)
                    {
                        Console.WriteLine($"{x-1}-{x}-{x + 2}-{x + 3}");
                    }
                    else if (x == 36)
                    {
                        Console.WriteLine($"{x - 4}-{x - 3}-{x - 1}-{x}");
                    }
                    else
                    {
                        Console.WriteLine($"{x - 4}-{x - 3}-{x - 1}-{x} |OR| {x - 1}-{x}-{x + 2}-{x + 3}");
                    }
                }
            }
            Console.Write("\nWinning Numbers: ");
            foreach(int x in RolledResults.RolledNumbers)
            {
                if (x != 0)
                {
                    Console.Write($"*{x}* ");
                }
            }
            Console.WriteLine();
        }
    }
}
