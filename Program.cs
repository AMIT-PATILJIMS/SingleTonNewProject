

namespace SingleTonNewProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(() => NewStudent(), () => NewEmployee());
        }

        private static void NewStudent()
        {
            SingletonDemo fromStudent = SingletonDemo.GetInstance;

            fromStudent.PrintDetails("From student");
        }

        private static void NewEmployee()
        {
            SingletonDemo fromEmplyee = SingletonDemo.GetInstance;

            fromEmplyee.PrintDetails("From Employee");
        }
    }
}