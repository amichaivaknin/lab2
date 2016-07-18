using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDisplay
{
    //Not working for negative numbers
    public class BinaryString
    {
        public int Cnt { get; private set; }

        public string IntToBinary(int num)
        {
            //Clever. Though, when adding this type of calculation, is better to explain them using comments.
            int len = (int) (Math.Log(num)/Math.Log(2) + 1);
            int i = 0;

            //You should consider using a stringBuilder with capacity 32 (sizeof(32)*8).
            //It should be more performant than string concatenations.
            string s = null;

            if (len <= 0)
            {
                s = "0";
            }

            while (i < len)
            {
                if ((num & (1 << i)) != 0)
                {

                    Cnt++;
                    s = '1' + s;
                }
                else
                {
                    s = '0' + s;
                }

                //You could have used a for loop
                i++;
            }

            return s;
        }

    }
}
