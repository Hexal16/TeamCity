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
    }
}