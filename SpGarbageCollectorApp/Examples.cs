using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpGarbageCollectorApp
{
    class Employee : IDisposable
    {
        public string Name { get; set; } = "";
        public int Age { get; set; } = 1;

        public Employee()
        {
            Name = "Anonim";
            Age = 1;
            Console.WriteLine("Employee construct");
        }

        //~Employee()
        //{
        //    Console.WriteLine("Employee destruct");
        //}

        public void Dispose()
        {
            Console.WriteLine("Employee dispose");
        }
    }
    public class Examples
    {
        public static void GarbageCollectorExample()
        {
            Console.WriteLine($"TotalMemory {GC.GetTotalMemory(false)}");

            Employee bob = new();

            Console.WriteLine($"TotalMemory {GC.GetTotalMemory(false)}");

            Employee employee;
            for (int i = 0; i < 10000; i++)
                employee = new();

            Console.WriteLine($"TotalMemory {GC.GetTotalMemory(false)}");
            Console.WriteLine($"Bob Generation {GC.GetGeneration(bob)}");

            GC.Collect();
            //GC.WaitForPendingFinalizers();

            Console.WriteLine($"TotalMemory {GC.GetTotalMemory(false)}");
            Console.WriteLine($"Bob Generation {GC.GetGeneration(bob)}");
        }

        public static void DisposableExample()
        {
            Func();

            //using Employee employee = new();

            //for (int i = 0; i < 100; i++)
            //{
            //    using (employee = new Employee())
            //    {

            //    }

            //}

            //Thread.Sleep(2000);

            
        }

        public static void Func()
        {
            using Employee employee = new();

            Console.WriteLine(employee.Name);
        }
    }
}
