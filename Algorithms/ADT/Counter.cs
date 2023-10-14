using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms.ADT
{
    public class Counter
    {
        private readonly string name;
        private int count;
        /// <summary>
        /// Create a counter name id
        /// </summary>
        /// <param name="id"></param>
        public Counter(String id)
        {
            name = id;
        }

        /// <summary>
        /// Increase the counter by one
        /// </summary>
        public void Increment()
        {
            count = count + 1;
        }

        /// <summary>
        /// The number increments since creation
        /// </summary>
        /// <returns></returns>
        public int Tally()
        {
            return count;
        }

        public override string ToString()
        {
            return $"{count} {name}";
        }
    }
}
