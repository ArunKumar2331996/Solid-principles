namespace LSK_principle.Utils
{
    public class ContractEmployee : IEmployee
    {
        public int AppraisalAmount()
        {
            return 100000;
        }

        public int Bonus()
        {
            return 10000;
        }

        public bool WelcomeGift()
        {
            return true;
        }
    }
}
