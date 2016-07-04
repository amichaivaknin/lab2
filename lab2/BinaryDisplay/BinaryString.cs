using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDisplay
{
    public class BinaryString
    {
        public int Cnt { get; private set; }

        public string IntToBinary(int num)
        {
            int len = (int) (Math.Log(num)/Math.Log(2) + 1);
            int i = 0;
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
                i++;
            }

            return s;
        }

    }
}
