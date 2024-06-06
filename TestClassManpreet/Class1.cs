using NUnit.Framework;
using NunitDemo;
namespace TestClassManpreet

{
    [TestFixture]
    public class TriangleTest1
    {
        // Manpreet's Test
        [Test]
        public void ValidTriangle_Input60and60and60_OutputValidTriangle()
        {
            // Arrange
       
            int firstAngle = 60;
            int secondAngle = 60;
            int thirdAngle = 60;
            string expected = "The triangle is valid.";
            // Act
            string actual = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);
            Assert.AreEqual(expected, actual);
        }
    }
}