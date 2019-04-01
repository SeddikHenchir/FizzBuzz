using FizzBuzzProj;
using NUnit.Framework;
using System.Text;

namespace Tests
{
    public class FizzBuzzTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void NumericValue()
        {
            Assert.IsTrue(FizzBuzz.CalcFizzBuzz("Hello").ToString().Equals("Valeur invalide"));
        }
        [Test]
        public void NonNegativeValue()
        {
            Assert.IsTrue(FizzBuzz.CalcFizzBuzz("-1").ToString().Equals("Valeur invalide"));
        }
        [Test]
        public void Multiple_3()
        {
            StringBuilder _stbuilder = new StringBuilder() { };
            _stbuilder.AppendLine("Fizz");
            _stbuilder.AppendLine("2");
            _stbuilder.AppendLine("1");
            FizzBuzz.CalcFizzBuzz("3");
            Assert.IsTrue(FizzBuzz.myResult.Equals(_stbuilder));

        }
        [Test]
        public void Multiple_5()
        {
            StringBuilder _stbuilder = new StringBuilder() { };
            _stbuilder.AppendLine("Buzz");
            _stbuilder.AppendLine("4");
            _stbuilder.AppendLine("Fizz");
            _stbuilder.AppendLine("2");
            _stbuilder.AppendLine("1");
            FizzBuzz.CalcFizzBuzz("5");
            Assert.IsTrue(FizzBuzz.myResult.Equals(_stbuilder));
        }
        [Test]
        public void Multiple_5_3()
        {
            StringBuilder _stbuilder = new StringBuilder() { };
            _stbuilder.AppendLine("FizzBuzz");
            _stbuilder.AppendLine("14");
            _stbuilder.AppendLine("13");
            _stbuilder.AppendLine("Fizz");
            _stbuilder.AppendLine("11");
            _stbuilder.AppendLine("Buzz");
            _stbuilder.AppendLine("Fizz");
            _stbuilder.AppendLine("8");
            _stbuilder.AppendLine("7");
            _stbuilder.AppendLine("Fizz");
            _stbuilder.AppendLine("Buzz");
            _stbuilder.AppendLine("4");
            _stbuilder.AppendLine("Fizz");
            _stbuilder.AppendLine("2");
            _stbuilder.AppendLine("1");
            FizzBuzz.CalcFizzBuzz("15");
            Assert.IsTrue(FizzBuzz.myResult.Equals(_stbuilder));
        }
    }
}