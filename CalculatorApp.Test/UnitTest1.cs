using Calculator;

namespace CalculatorApp.Test
{
    [TestFixture]
    public class Tests
    {
        public Form1 calculator_app;
        [SetUp]
        public void Setup()
        {
            calculator_app = new Form1();
        }

        [TearDown]
        public void TearDown()
        {
            calculator_app.Dispose();
        }

        [Test]
        public void Addition_Test()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(4, Form1.operation_function(2, 2, '+'));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, Form1.operation_function(-1, 1, '+'));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, Form1.operation_function(0, 0, '+'));
        }
        [Test]
        public void Subtraction_Test()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(2, Form1.operation_function(5, 3, '-'));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(-4, Form1.operation_function(0, 4, '-'));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, Form1.operation_function(-2, -2, '-'));
        }
        [Test]
        public void Multiplication_Test()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(9, Form1.operation_function(3, 3, '*'));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(-4, Form1.operation_function(-2, 2, '*'));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, Form1.operation_function(0, 5, '*'));
        }
        [Test]
        public void Division_Test()
        {
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(5, Form1.operation_function(10, 2, '/'));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(-5, Form1.operation_function(5, -1, '/'));
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(0, Form1.operation_function(0, 3, '/'));
        }
    }
}