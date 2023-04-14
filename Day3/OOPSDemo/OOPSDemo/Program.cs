using System;
namespace OOPSDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 10;
            Emp e0 = new Emp();
            Emp e1 = new Emp(1);
            Emp e2 = new Emp(2);
            Console.WriteLine(e1.EmpId);
            Console.WriteLine();
            Console.WriteLine(e2.EmpId);


        }
    }
    
}
