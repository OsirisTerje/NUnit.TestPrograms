// NUnit3 Tests,  see documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation 

using MultiTesting31;
using NUnit.Framework;

namespace NUnit.Tests8
{
    [TestFixture]
    public class TestClass
    {

        [Test]
        public void TestSetUp()
        {
            // Add code that runs before each test method

        }

        [Test]
        public void TestMethod2()
        {
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");

        }
      
    }

    


    [TestFixture]
    public class ClassTest
    {
        [Test]
        public void TestMethod()
        {
            var answer = 42;
            Assert.That(answer, Is.EqualTo(42), "Some useful error message");

        }
    }



   
}
