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
        public static SingletonDemo GetInsurance
        {
            get
            {
                /*
                 This is known as lazy initialization in Singleton design pattern. 
                 But it will not work in multi-threaded environment.
                 */
                if (instance == null)
                {
                    instance = new SingletonDemo();
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

        public class NewClass : SingletonDemo
        {
            
        }
    }
}
