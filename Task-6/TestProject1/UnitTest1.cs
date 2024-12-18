using static Task_6.Program;
using NUnit;


namespace TestProject
{
    public class Tests
    {
        [Test]
        public void TestFermatValidCase()
        {
            
            Assert.IsFalse(CheckFermat(3, 4, 5, 3));
        }

        [Test]
        public void TestFermatInvalidCase()
        {
            
            Assert.IsFalse(CheckFermat(1, 2, 3, 2)); 
        }

        [Test]
        public void TestFermatEdgeCase()
        {
           
            Assert.IsTrue(CheckFermat(1, 2, 3, 1)); 
        }

        [Test]
        public void TestFermatWithZero()
        {
            
            Assert.IsFalse(CheckFermat(0, 0, 0, 2));
        }
    }
}