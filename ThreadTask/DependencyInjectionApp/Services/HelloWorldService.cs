namespace DependencyInjectionApp.Services
{
    public interface IHelloWorldService
    {
        string SayHello();
    }

    public class HelloWorldService : IHelloWorldService
    {
        public HelloWorldService()
        {

        }
        public string SayHello()
        {
            return "Good Morning";
        }
    }
}