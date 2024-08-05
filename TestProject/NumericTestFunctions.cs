namespace TestProject
{
    [TestFixture]
    public class NumericTestFunctions
    {
        NumericLibrary.NumericFunctions numericFunctions;
        [SetUp]
        public void Setup()
        {
            numericFunctions = new NumericLibrary.NumericFunctions();

        }

        [Test]
        public void AddNumbers1()
        {
            int actual = numericFunctions.AddNumbers(10, 2);
            int expected = 12;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddNumbers3()
        {
            //NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            int actual = numericFunctions.AddNumbers(1,1);
            int expected = 2;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddNumbers4()
        {
            //NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            int actual = numericFunctions.AddNumbers(11, 11);
            int expected = 22;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void AddNumbers5()
        {
            //NumericLibrary.NumericFunctions numericFunctions = new NumericLibrary.NumericFunctions();
            int actual = numericFunctions.AddNumbers(10, 10);
            int expected = 20;
            Assert.AreEqual(expected, actual);
        }

        [TestCase(1,1,2)]
        [TestCase(2,1,3)]
        [TestCase(20, 10, 30)]
        [TestCase(2, 11, 13)]
        [TestCase(0, 1, 1)]
        public void AddNumbers(int num1, int num2,int expected)
        {
            int actual = numericFunctions.AddNumbers(num1,num2);
            Assert.AreEqual(expected, actual);
        }

        
    } 
}