using System;

namespace DesignPatterns.Structure.Facade
{
    /// <summary>
    /// A SubSystem ClassB
    /// </summary>
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine($"Checking credit for {c.Name}");
            return true;
        }
    }
}
