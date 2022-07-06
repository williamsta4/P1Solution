namespace BookClassLibrary
{
    public class Book
    {
        public string BookAuthor { get; set; } = string.Empty;
        public string BookTitle { get; set; } = string.Empty;

        public double BookTaxRate { get; set; } = .10;
        public double BookPrice { get; set; } = 0;


        public Book(){ } //default constructor
        public Book(string bookAuthor, string bookTitle, double bookTaxRate, double bookPrice) //paramerized constructor
        {
            BookAuthor = bookAuthor;
            BookTitle = bookTitle;
            BookTaxRate = bookTaxRate;
            BookPrice = bookPrice;
        }

    }
}