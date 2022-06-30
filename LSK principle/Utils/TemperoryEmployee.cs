namespace LSK_principle.Utils
{
    public class TemperoryEmployee : IEmployee
    {
        public int AppraisalAmount()
        {
            return 80000;
        }

        /// <summary>
        /// There is no bonus for temporary employees
        /// </summary>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public int Bonus()
        {
            // Since we implemented the common interface we need to do like this which is a bad design.
            // rather we can have a seperate interface for this or we can skip this particular method on invocation
            // by adding a IF condition.
            throw new System.NotImplementedException();
        }

        public bool WelcomeGift()
        {
            return false;
        }
    }
}
