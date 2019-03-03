using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    public class CreateTable
    {   
        public void TableNumbers()
        {
            int[] TN = new int[38];

            for (int count = 0; count < 38; count++)
            {
                if (count == 37)
                {
                    break;
                }
                TN[count] = count;
            }

            TN[37] = 0;

            Board.Numbers = TN;

        }

        public void TableColors()
        {
            string[] TC = new string[38];
            TC[0] = "Green";

            for (int count = 1; count < 38; count++)
            {
                TC[count] = "Red";

                if (count == 18)
                {
                    ++count;
                    TC[count] = "Red";

                }
                if (count == 36)
                {
                    break;
                }
                ++count;
                TC[count] = "Black";

                if (count == 10)
                {
                    ++count;
                    TC[count] = "Black";
                }

                if (count == 28)
                {
                    ++count;
                    TC[count] = "Black";
                }
            }
            TC[37] = "Double Zero Green";

            Board.Colors = TC;
        }
    }
}
