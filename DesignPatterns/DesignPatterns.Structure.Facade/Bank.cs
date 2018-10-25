using System;

namespace DesignPatterns.Structure.Facade
{
    /// <summary>
    /// A SubSystem ClassA
    /// </summary>
    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Checking bank for " + c.Name);
            return true;
        }
    }
}
