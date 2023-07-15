using System;
using System.IO;
using System.Linq;
using Lab03_Review;
using Xunit;

namespace Lab03_ReviewTest
{
    public class UnitTest1
    {
        [Fact]
        public void Challenge1_Test1()
        {
            // Arrange
            string input = "2 3 4";
            int expectedProduct = 24;

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge1();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    int actualProduct = int.Parse(actualOutput.Split(':').Last().Trim());
                    Assert.Equal(expectedProduct, actualProduct);
                }
            }
        }

        [Fact]
        public void Challenge1_Test2()
        {
            // Arrange
            string input = "1 2 3 4 5";
            int expectedProduct = 6;

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge1();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    int actualProduct = int.Parse(actualOutput.Split(':').Last().Trim());
                    Assert.Equal(expectedProduct, actualProduct);
                }
            }
        }

        [Fact]
        public void Challenge1_Test3()
        {
            // Arrange
            string input = "2";
            int expectedProduct = 2;

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge1();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    int actualProduct = int.Parse(actualOutput.Split(':').Last().Trim());
                    Assert.Equal(expectedProduct, actualProduct);
                }
            }
        }

        [Fact]
        public void Challenge1_Test4()
        {
            // Arrange
            string input = "-2 3 -4";
            int expectedProduct = 8;

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge1();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    int actualProduct = int.Parse(actualOutput.Split(':').Last().Trim());
                    Assert.Equal(expectedProduct, actualProduct);
                }
            }
        }

        [Fact]
        public void Challenge2_Test1()
        {
            // Arrange
            string input = "5";
            double expectedAverage = 3.6;

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge2();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    double actualAverage = double.Parse(actualOutput.Split(':').Last().Trim());
                    Assert.Equal(expectedAverage, actualAverage, 1);
                }
            }
        }

        [Fact]
        public void Challenge2_Test2()
        {
            // Arrange
            string input = "3";
            double expectedAverage = 0;

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge2();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    double actualAverage = double.Parse(actualOutput.Split(':').Last().Trim());
                    Assert.Equal(expectedAverage, actualAverage);
                }
            }
        }

        [Fact]
        public void Challenge4_Test1()
        {
            // Arrange
            string input = "2, 2, 3, 3, 3, 4";
            int expectedMostFrequent = 3;

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge4();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    int actualMostFrequent = int.Parse(actualOutput.Split(':').Last().Trim());
                    Assert.Equal(expectedMostFrequent, actualMostFrequent);
                }
            }
        }

        [Fact]
        public void Challenge5_Test1()
        {
            // Arrange
            string input = "5, 5, 5, 5, 5";
            int expectedMaxValue = 5;

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge5();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    int actualMaxValue = int.Parse(actualOutput.Split(':').Last().Trim());
                    Assert.Equal(expectedMaxValue, actualMaxValue);
                }
            }
        }

        [Fact]
        public void Challenge9_Test1()
        {
            // Arrange
            string input = "This is a test sentence.";
            string[] expectedOutput = { "This: 4", "is: 2", "a: 1", "test: 4", "sentence.: 9" };

            // Act
            using (StringReader sr = new StringReader(input))
            {
                Console.SetIn(sr);
                using (StringWriter sw = new StringWriter())
                {
                    Console.SetOut(sw);

                    Program.Challenge9();

                    // Assert
                    string actualOutput = sw.ToString().Trim();
                    string[] actualArray = actualOutput.Split(", ");
                    Assert.Equal(expectedOutput, actualArray);
                }
            }
        }
    }
}
