using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz.Tests
{
    [TestClass()]
    public class ProgramTests
    {
        [TestMethod()]
        public void Generate_GetZero_ReturnZeroString()
        {
            // Arange
            var generator = new FizzBuzzGenerator();

            // Act
            var result = generator.Generate(0);
            var expected = "0";

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void Generate_GetOne_ReturnOneString()
        { // Arange
            var generator = new FizzBuzzGenerator();

            // Act
            var result = generator.Generate(1);
            var expected = "1";

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void Generate_GetThree_ReturnFizz()
        { // Arange
            var generator = new FizzBuzzGenerator();

            // Act
            var result = generator.Generate(3);
            var expected = "Fizz";

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void Generate_GetFive_ReturnBuzz()
        { // Arange
            var generator = new FizzBuzzGenerator();

            // Act
            var result = generator.Generate(5);
            var expected = "Buzz";

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void Generate_GetFifteen_ReturnFizzBuzz()
        { // Arange
            var generator = new FizzBuzzGenerator();

            // Act
            var result = generator.Generate(15);
            var expected = "FizzBuzz";

            // Assert
            Assert.AreEqual(result, expected);
        }

        [TestMethod()]
        public void GenerateList_GetInt_ReturnListWithFizzBuzzValues()
        { // Arange
            var generator = new FizzBuzzGenerator();

            // Act
            var result = generator.GenerateList(16);
            var expected = new string[] { "0", "1", "Fizz", "4", "Buzz", "Fizz", "7", "8", "Fizz", "10", "11", "Fizz", "13", "14", "Fizzbuzz" };

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}