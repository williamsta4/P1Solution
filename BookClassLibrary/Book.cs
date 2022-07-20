namespace BookClassLibrary
{
    public class Book
    {
       // string? setbookTitle;
        public string? BookTitle { get; set; } 

        public double BookTaxRate { get; set; } = .10;
        public double BookPrice { get; set; } = 0;


        public Book(){ } //default constructor
        public Book(string bookTitle,  double bookPrice) //paramerized constructor
        {
            BookTitle = bookTitle;
            BookPrice = bookPrice;
        }

        public double GetTax(TaxRate taxRate)
        {
            double TotalTaxRate = BookPrice * taxRate.BookTaxRate;
            return TotalTaxRate;
        }
    }
}