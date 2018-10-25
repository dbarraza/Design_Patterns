using System;

namespace DesignPatterns.Structure.Facade
{
    /// <summary>
    /// The 'Facade' class
    /// </summary>
    class Mortgage
    {
        private Bank _bank = new Bank();
        private Credit _credit = new Credit();
        private Loan _loan = new Loan();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine($"{cust.Name} applies for {1:amount} loan\n");

            bool eligible = true;
            // Check creditworthyness of applican
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
