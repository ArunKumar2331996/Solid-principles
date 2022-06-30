using Xunit;

namespace Open_and_close_principle
{
    public class TestEmployee
    {
        private Employee employee = null;
        public TestEmployee()
        {
            if (employee is null)
            {
                employee = new Employee();
            }
        }

        [Fact]
        public void VerifyIsEmployeeIdInteger()
        {
            var expectedEmpId = 1;
            var actualEmpId = employee.GetEmployeeId();
            Assert.Equal(expectedEmpId, actualEmpId);   

        }
    }
}
