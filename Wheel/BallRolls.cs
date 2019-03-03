using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    public class BallRolls
    {

        public void BR(int [] Number, string [] Color)
        {
            int count = 0;

            Random random = new Random();

            int[] tempNumbers = new int[10];
            string[] tempColors = new string[10];

            while (count < 10)
            {
                int Index = random.Next(Number.Length);
                tempNumbers[count] = Number[Index];
                tempColors[count] = Color[Index];
                count++;
            }

            RolledResults.RolledNumbers = tempNumbers;
            RolledResults.RolledColors = tempColors;

        }


    }
}
