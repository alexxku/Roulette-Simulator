using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Table;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTable();
            Console.WriteLine("Rolling...");
            Thread.Sleep(3000);
            Console.Clear();
            RollBall();
            Console.WriteLine("\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.Numbers();
            Console.WriteLine("\n\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.EvenOdd();
            Console.WriteLine("\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.Color();
            Console.WriteLine("\n\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.LowsHighs();
            Console.WriteLine("\n\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.Dozens();
            Console.WriteLine("\n\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.Columns();
            Console.WriteLine("\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.StreetRow();
            Console.WriteLine("\n\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.DoubleStreetRow();
            Console.WriteLine("\n\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.Split();
            Console.WriteLine("\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            WinConditions.Corner();
            Console.WriteLine("\n\nPress Enter To Continue...");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Thank You for using this Roulette simulator program !\n\nPress Enter To Exit...");
            Console.ReadLine();

        }

        static void CreateTable()
        {
            CreateTable createTable = new CreateTable();
            createTable.TableNumbers();
            createTable.TableColors();

        }

        static void RollBall()
        {
            BallRolls begin = new BallRolls();

            begin.BR(Board.Numbers, Board.Colors);

            Console.WriteLine("--- Rolled ! ---");
            for(int count = 0; count < RolledResults.RolledNumbers.Length; count++)
            {
                Console.WriteLine($"{RolledResults.RolledNumbers[count]} : {RolledResults.RolledColors[count]}");
            }
        }

    }
}
