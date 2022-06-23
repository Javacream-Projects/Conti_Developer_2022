using NUnit.Framework;

namespace Javacream.Store.Test;

public class Tests
{
    [SetUp]
    public void Setup()
    {
        Console.WriteLine ("setting up test");
    }

    [Test]
    public void Test1()
    {
        Console.WriteLine ("test1");
        Assert.Pass();
    }
   [Test]
    public void Test2()
    {
        Console.WriteLine ("test2");
        Assert.Pass();
    }
}
