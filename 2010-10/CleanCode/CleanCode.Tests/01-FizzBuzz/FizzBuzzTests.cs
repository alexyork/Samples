using System;
using NUnit.Framework;

namespace CleanCode.Tests.FizzBuzz
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private CleanCode.FizzBuzz fizzBuzz;

        [SetUp]
        public void SetUp()
        {
            fizzBuzz = new CleanCode.FizzBuzz();
        }

        [Test]
        public void Should_print_Fizz_for_the_number_3()
        {
            string result = fizzBuzz.GetResult(3);

            result.ShouldBe("Fizz");
        }

        [Test]
        public void Should_print_Buzz_for_the_number_5()
        {
            string result = fizzBuzz.GetResult(5);

            result.ShouldBe("Buzz");
        }

        [Test]
        public void Should_print_FizzBuzz_for_the_number_15()
        {
            string result = fizzBuzz.GetResult(15);

            result.ShouldBe("FizzBuzz");
        }

        [Test]
        public void Should_print_the_number_for_non_multiples_of_3_and_5()
        {
            string result = fizzBuzz.GetResult(7);

            result.ShouldBe("7");
        }
    }

    public static class TestExtensions
    {
        public static void ShouldBe(this string actual, string expected)
        {
            Assert.AreEqual(expected, actual);
        }
    }
}





















    //[TestFixture]
    //public class FizzBuzzTests
    //{
    //    private FizzBuzz _fizzBuzz;

    //    [SetUp]
    //    public void SetUp()
    //    {
    //        _fizzBuzz = new FizzBuzz();
    //    }

    //    [Test]
    //    public void Should_print_Fizz_for_multiples_of_3()
    //    {
    //        var multiples_of_three = new[] {3, 6, 9, 96, 366};

    //        foreach (var number in multiples_of_three)
    //        {
    //            string result = _fizzBuzz.Print(number);
    //            result.ShouldBe("Fizz");
    //        }
    //    }

    //    [Test]
    //    public void Should_print_Buzz_for_multiples_of_5()
    //    {
    //        var multiples_of_five = new[] { 5, 10, 100 };

    //        foreach (var number in multiples_of_five)
    //        {
    //            string result = _fizzBuzz.Print(number);
    //            result.ShouldBe("Buzz");
    //        }
    //    }

    //    [Test]
    //    public void Should_print_FizzBuzz_for_multiples_of_3_and_5()
    //    {
    //        var multiples_of_three_and_five = new[] { 15, 30, 255 };

    //        foreach (var number in multiples_of_three_and_five)
    //        {
    //            string result = _fizzBuzz.Print(number);
    //            result.ShouldBe("FizzBuzz");
    //        }
    //    }

    //    [Test]
    //    public void Should_print_the_number_for_non_multiples_of_3_and_5()
    //    {
    //        var non_multiples = new[] { 7, 2, 19 };

    //        foreach (var number in non_multiples)
    //        {
    //            string result = _fizzBuzz.Print(number);
    //            result.ShouldBe(number.ToString());
    //        }
    //    }
    //}

    //public static class TestExtensions
    //{
    //    public static void ShouldBe(this string actual, string expected)
    //    {
    //        Assert.AreEqual(expected, actual);
    //    }
    //}
