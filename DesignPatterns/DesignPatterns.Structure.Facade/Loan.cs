using System;

namespace DesignPatterns.Structure.Facade
{
    /// <summary>
    /// A SubSystem ClassC
    /// </summary>
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine($"Checking loans for {c.Name}");
            return true;
        }
    }
}
