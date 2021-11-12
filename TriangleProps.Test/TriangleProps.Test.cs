using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Triangle.Test
{
    [TestClass]
    public class TestTriangle
    {

        [TestMethod]
        public void AcuteAngle()
        {
            Assert.AreEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(18, 19, 20));
            Assert.AreEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(17, 19, 20));
            Assert.AreEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(16, 19, 20));
            Assert.AreEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(15, 19, 20));
            Assert.AreEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(14, 19, 20));
            Assert.AreNotEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(18, 18, 18));
            Assert.AreNotEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(18, 3, 20));
            Assert.AreNotEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(18, 4, 20));
            Assert.AreNotEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(18, 5, 20));
            Assert.AreNotEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(18, 6, 20));
            Assert.AreNotEqual("Остроугольный", Triangle.TriangleProps.GetTrinagleType(5, 3, 4));
        }

        [TestMethod]
        public void ObtuseAngle()
        {
            Assert.AreEqual("Тупоугольный", Triangle.TriangleProps.GetTrinagleType(29,49,33));
            Assert.AreNotEqual("Тупоугольный", Triangle.TriangleProps.GetTrinagleType(3, 3, 3));
            Assert.AreNotEqual("Тупоугольный", Triangle.TriangleProps.GetTrinagleType(3, 4, 5));
            Assert.AreNotEqual("Тупоугольный", Triangle.TriangleProps.GetTrinagleType(18, 19, 20));
            Assert.AreNotEqual("Тупоугольный", Triangle.TriangleProps.GetTrinagleType(0, 4, 5));
        }

        [TestMethod]
        public void Equilateral()
        {
            Assert.AreEqual("Равносторонний", Triangle.TriangleProps.GetTrinagleType(6, 6, 6));
            Assert.AreEqual("Равносторонний", Triangle.TriangleProps.GetTrinagleType(16, 16, 16));
            Assert.AreEqual("Равносторонний", Triangle.TriangleProps.GetTrinagleType(26, 26, 26));
            Assert.AreNotEqual("Равносторонний", Triangle.TriangleProps.GetTrinagleType(26, 23, 242346));
            Assert.AreNotEqual("Равносторонний", Triangle.TriangleProps.GetTrinagleType(21426, 231424, 242346));
            Assert.AreNotEqual("Равносторонний", Triangle.TriangleProps.GetTrinagleType(24246, 22313, 242346));
        }

        [TestMethod]
        public void Right()
        {
            Assert.AreEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(3, 4, 5));
            Assert.AreEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(5, 12, 13));
            Assert.AreEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(7, 24, 25));
            Assert.AreEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(9, 12, 15));
            Assert.AreEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(11, 60, 61));
            Assert.AreEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(12,35,37));
            Assert.AreNotEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(6,6,6));
            Assert.AreNotEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(29, 49, 33));
            Assert.AreNotEqual("Прямоугольный", Triangle.TriangleProps.GetTrinagleType(15, 19, 20));

        }

        [TestMethod]
        public void NotTriangle()
        {
            Assert.AreEqual("Не треугольник", Triangle.TriangleProps.GetTrinagleType(0, 4, 5));
            Assert.AreEqual("Не треугольник", Triangle.TriangleProps.GetTrinagleType(1000, 4, 5));
            Assert.AreEqual("Не треугольник", Triangle.TriangleProps.GetTrinagleType(0, 4, 0));
            Assert.AreNotEqual("Не треугольник", Triangle.TriangleProps.GetTrinagleType(6, 6, 6));
            Assert.AreNotEqual("Не треугольник", Triangle.TriangleProps.GetTrinagleType(29, 49, 33));
            Assert.AreNotEqual("Не треугольник", Triangle.TriangleProps.GetTrinagleType(18, 19, 20));
            Assert.AreNotEqual("Не треугольник", Triangle.TriangleProps.GetTrinagleType(3, 4, 5));
        }
    }
}
