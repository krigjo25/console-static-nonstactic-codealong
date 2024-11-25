using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static__non_static_functions.lib
{
    internal class Stats
    {
        private int __i__;
        private int __sum__;

        // Initializing an auto created property CTRL + R + E
        public int I__ { get => __i__; private set => __i__ = value; }
        public int Sum__ { get => __sum__; private set => __sum__ = value; }
        public float Average => (float)Sum__ / I__;
        public void Increment(int ints)
        {
            //  Add n to array | increment
            Sum__ += ints; 
            I__++;
        }
        public void ShowStats()
        {
            //  Initialize the sum
            int sum = Sum__;
 
        }

        private int Sum()
        {
            return Sum__;
        }
    }
