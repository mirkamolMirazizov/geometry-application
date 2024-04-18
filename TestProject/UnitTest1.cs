using classLibrary;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SquareTestArea()
        {
            var square = new Square(5);
            var result = square.CalculateArea();
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void RectangleTestArea()
        {
            var rectangle = new Rectangle(3, 5);
            var result = rectangle.CalculateArea();
            Assert.AreEqual(25, result);
        }

        [TestMethod]
        public void TriangleTestArea()
        {
            var triangle = new Triangle(3, 5, 8);
            var result = triangle.CalculateArea();
            Assert.AreEqual(25, result);
        }
    }
}