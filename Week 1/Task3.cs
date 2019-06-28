using System;
using System.Collections.Generic;
using System.Text;

namespace lab1
{
    class Task3
    {
        public static int[] duplicateElements(int[] n)
        {
            int len = n.Length;
            int[] d = new int[2 * len];
            int cnt = 0;
            for(int i = 0;i < len;i ++)
            {
                d[cnt++] = n[i];
                d[cnt++] = n[i];
                if (cnt >= len * 2) break;
            }
            return d;
        }
    }
}
