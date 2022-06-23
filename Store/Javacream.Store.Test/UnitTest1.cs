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
        Assert.Pass();
    }
}