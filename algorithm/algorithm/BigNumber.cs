using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace BigNumber
{
    class BigNumber_1
    {
        public void find()
        {
            int[] arr = { 12, -4, 10, 4, 2, 71, -2, -6 };

            int max = arr[0];

            for (int i =1; i < arr.Length; i++)
            {
                if (max < arr[i])

                    max = arr[i];
            }
            Console.WriteLine("\n\n So lon nhat trong mang la: {0}", max);
        }
    }
}
