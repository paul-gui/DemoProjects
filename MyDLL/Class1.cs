using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDLL
{
    /// <summary>
    /// aceasta este o clasa
    /// </summary>
    public class Class1
    {
        public int var1;
        public Class1()
        {

        }

        public Class1(int a)
        {
            int tmp = a;
        }

        public Class1(int a, int b)
        {

        }

        /// <summary>
        /// Aduna a + b
        /// </summary>
        /// <param name="a">primul termen</param>
        /// <param name="b">al doilea termen</param>
        /// <returns></returns>
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
