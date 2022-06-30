namespace LSK_principle.Utils
{
    public class PermanentEmployee : IEmployee
    {
        public int AppraisalAmount()
        {
            return 120000;
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
