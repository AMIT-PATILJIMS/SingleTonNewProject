using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonNewProject
{
    // 1. Now we converting class from Non - Lazy Initialization (Eager Loading) to Lazy Initialization.
    public class SingletonDemo
    {
        private static int counter = 0;
        /*
         2. We will use Lazy keyword in .Net 4.0
         3. After that create the instance using lambda expression.
        */
        private static readonly Lazy<SingletonDemo> instance = new Lazy<SingletonDemo>(() => new SingletonDemo());

        public static SingletonDemo GetInstance
        {
            get
            {
                /*
                 * 4. In order to get singleton instance we need to return value.
                 */
                return instance.Value;
            }
        }

        private SingletonDemo()
        {
            counter++;
            Console.WriteLine("counter value is " + counter.ToString());
        }
        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
