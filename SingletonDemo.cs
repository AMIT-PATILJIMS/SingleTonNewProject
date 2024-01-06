using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonNewProject
{
    // 1. Now we converting class from Lazy Initialization to Non - Lazy Initialization (Eager Loading).
    public class SingletonDemo
    {
        private static int counter = 0;
        /*2. We need to change this null initialization to new SingletonDemo() instance.
          3. We need to change this instance property to readonly.
        */
        private static readonly SingletonDemo instance = new SingletonDemo();

        public static SingletonDemo GetInstance
        {
            /*
             4. Remove this double check locking.
             */
            get
            {
                //5. Now the debugger had hit this application twice due to parallel invoke.
                //6. If you observe the output the counter value is still one.
                //7. Eager loading has created only one singleton instance.
                //8. How this is thread safe ? Answer : The CLR (Common Language Runtime) takes care of this.
                
                return instance;
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
