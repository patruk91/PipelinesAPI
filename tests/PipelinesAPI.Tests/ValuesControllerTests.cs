using NUnit.Framework;
using PipelinesAPI.Controllers;

namespace PipelinesAPI.Tests
{
    public class ValuesControllerTests
    {
        ValuesController controller;

        [SetUp]
        public void Setup()
        {
            controller = new ValuesController();
        }

        [Test]
        public void ReturnValueFromGetIsNotNull()
        {
            var actual = controller.Get().Value;
            Assert.That(controller.Get().Value, Is.Not.Null);
        }

        [Test]
        public void ReturnValueIsEqualToExpected()
        {
            var actual = controller.Get().Value;
            var expected = new string[] { "value1", "value2" };
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void ReturnValueIsEqualToValue()
        {
            var actual = controller.Get(1).Value;
            var expected = "value";
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}