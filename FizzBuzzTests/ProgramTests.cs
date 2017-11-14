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
            generator = new FizzBuzz();

            // Act
            var result = generator.Generate(0);
            var expected = "0";

            // Assert
            Assert.AreEqual(result, expected);
        }
    }
}