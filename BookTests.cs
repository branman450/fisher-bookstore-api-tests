using System;
using Xunit;

namespace Fisher.Bookstore.Tests
{
    public class BookTests
    {

        [Fact]
        public void AddBookPrice()
        {
            var book = new Models.Book()
            {
            Id =1,
            Title = "My Test Book",
            Price = 9.99
            };

            //Act
            book.ApplyMemberDiscount();
            //Assert
            var discountPrice = 9.99 * .9;
            Assert.Equal(discountPrice, book.Price);




            //book.Price = 7.99;
            //Assert.Equal(7.99, book.Price);

        }
    }
}
