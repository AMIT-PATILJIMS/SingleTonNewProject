using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonNewProject
{
    internal sealed class SingletonDemo
    {
        private static int counter = 0;

        private static SingletonDemo instance = null;
        public static SingletonDemo GetInsurance
        {
            get
            {
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
    }
}
