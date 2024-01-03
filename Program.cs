

namespace SingleTonNewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonDemo fromEmplyee = SingletonDemo.GetInsurance;

            fromEmplyee.PrintDetails("From Employee");

            SingletonDemo fromStudent = SingletonDemo.GetInsurance;

            fromStudent.PrintDetails("From student");
        }
    }
}