using BookClassLibrary;

namespace BookTestProject
{
    [TestClass]
    public class ABook
    {
        [TestMethod]
        public void CanHaveATitle() //Tests to see if Title which is "T" works
        {
            var sut = new Book();
            sut.BookTitle= "T";
            Assert.AreEqual("T", sut.BookTitle);
        }

        [TestMethod]
        public void CanHaveAPrice() //Tests to see if price which is 1 works
        {
            var sut = new Book();
            sut.BookPrice = 1;
            Assert.AreEqual(1, sut.BookPrice);  
        }
    }
}