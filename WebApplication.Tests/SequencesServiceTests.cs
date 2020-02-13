using NUnit.Framework;
using WebApplication.Service;
using WebApplication.Service.Interfaces;

namespace WebApplication.Tests
{
    [TestFixture]
    public class SequencesServiceTests
    {
        private readonly ISequencesService _sequencesService;

        public SequencesServiceTests()
        {
            _sequencesService = new SequencesService();
        }

        [Test]
        public void Fibonacci_Test()
        {
            var errorResultExpected = -1;

            var r = _sequencesService.Fibonacci(0);
            Assert.AreEqual(errorResultExpected, r);

            r = _sequencesService.Fibonacci(-999);
            Assert.AreEqual(errorResultExpected, r);

            r = _sequencesService.Fibonacci(101);
            Assert.AreEqual(errorResultExpected, r);

            //Fibonacci(1) must return 1
            r = _sequencesService.Fibonacci(1);
            Assert.AreEqual(1, r);
            
            //Fibonacci(2) must return 1
            r = _sequencesService.Fibonacci(2);
            Assert.AreEqual(1, r);

            //Fibonacci(6) must return 8
            r = _sequencesService.Fibonacci(6);
            Assert.AreEqual(8, r);

            r = _sequencesService.Fibonacci(100);
            Assert.AreEqual(354224848179261915075M, r);
        }
    }
}