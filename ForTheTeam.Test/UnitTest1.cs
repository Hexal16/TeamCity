using NUnit.Framework;
using ForTheTeam;
namespace ForTheTeam.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetYear_Test()
        {
            var test = new Program();
            var result  = test.GetYear("2019");
            Assert.That(result.Item1, Is.EqualTo(2019));
            Assert.That(result.Item2, Is.Empty);
        }
        
        [Test]
        public void GetYear_Test1()
        {
            var test = new Program();
            var result  = test.GetYear("2020");
            Assert.That(result.Item1, Is.EqualTo(2020));
            Assert.That(result.Item2, Is.Empty);
        }
        
        [Test]
        public void GetYear_Test2()
        {
            var test = new Program();
            var result  = test.GetYear("2020");
            Assert.That(result.Item1, Is.EqualTo(1000));
            Assert.That(result.Item2, Is.Empty);
        }
    }
}