using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonNewProject
{
    public class SingletonDemo
    {
        private static int counter = 0;

        private static SingletonDemo instance = null;

        private static readonly object obj = new object();
        public static SingletonDemo GetInstance
        {
            get
            {
                /*
                 * Since lock is very expensive operation, that's why we use Double check locking.
                 */
                if (instance == null)
                {
                    /*
                     * lock is very expensive operation, we should avoid this.
                     */
                    lock (obj)
                    {
                        /*
                         This is known as lazy initialization in Singleton design pattern. 
                         But it will not work in multi-threaded environment.
                         */
                        if (instance == null)
                        {
                            instance = new SingletonDemo();
                        }
                    }
                }
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
