using System;

namespace CreditCheck
{
    public class CreditChecker
    {
        public int GetCreditScore(string firstName, string lastName)
        {
            if (firstName == "Alex")
            {
                return 800;
            } else
            {
                return 600;
            }
        }
    }
}
