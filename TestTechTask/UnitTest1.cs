using TechTaskMindBox;
using TechTaskMindBox.Figure;

namespace TestTechTask
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CircleIsExists()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Figure circle = new Circle(-1);
            });
        }

        [TestMethod]
        public void CircleSquareR1()
        {
            Figure circle = new Circle(1);

            Assert.AreEqual(circle.GetSquare(), Math.PI);
        }

        [TestMethod]
        public void CircleSquareR3()
        {
            Figure circle = new Circle(3);

            Assert.AreEqual(circle.GetSquare(), Math.PI * 3 * 3);
        }

        [TestMethod]
        public void TriangleIsNotExists1()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Figure triangle = new Triangel(1, 1, 3);
            });
        }
        

        [TestMethod]
        public void TriangleIsNotExists2()
        {
            Assert.ThrowsException<ArgumentException>(() =>
            {
                Figure triangle = new Triangel(1, 0, 3);
            });
        }

        [TestMethod]
        public void TriangleSquare1()
        {
            Figure triangle = new Triangel(3, 4, 5);

            Assert.AreEqual(triangle.GetSquare(), 6d);
        }

        [TestMethod]
        public void TriangleSquare2()
        {
            Figure triangle = new Triangel(8, 5, 5);

            Assert.AreEqual(triangle.GetSquare(), 12d);
        }

        [TestMethod]
        public void TriangleIsRight()
        {
            Figure triangle = new Triangel(3, 4, 5);

            Assert.IsTrue(((Triangel)triangle).IsRightangel());
        }

        [TestMethod]
        public void TriangleIsNotRight()
        {
            Figure triangle = new Triangel(4, 4, 5);

            Assert.IsFalse(((Triangel)triangle).IsRightangel());
        }
    }
}