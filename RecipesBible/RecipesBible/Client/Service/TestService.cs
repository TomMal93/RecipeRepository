namespace RecipesBible.Client.Service
{
    public interface ITestService
    {
        void Test();
    }
    public class TestService : ITestService
    {
        public TestService()
        {

        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}
