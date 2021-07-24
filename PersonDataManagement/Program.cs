using System;

namespace PersonDataManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating Person Data Management System");
            DataManagement management = new DataManagement();
            management.CreateList();
            management.RetrivePersonAgeLessThan60();
            management.RetrivePersonAgeBetween13And18();
            Console.Read();
        }
    }
}
