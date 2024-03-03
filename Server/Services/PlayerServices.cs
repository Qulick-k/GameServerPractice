namespace Server.Services;

public interface IPlayerServices
{
    void DoSomething();
}

public class PlayerServices : IPlayerServices
{
    public void DoSomething()
    {
        Console.WriteLine("hey!");
    }
}

public class MockPlayerServices : IPlayerServices
{
    public void DoSomething()
    {
        Console.WriteLine("hey! from the mock services");
    }
}