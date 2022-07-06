using BookClassLibrary; 


Console.WriteLine("There are no books currently.");
Console.WriteLine("Please select 1-9");
Console.WriteLine("1 - Enter the details about book 1:  ");
Console.WriteLine("2 - Enter the details about book 2:  ");
Console.WriteLine("3 - Enter the details about book 3:  ");
Console.WriteLine("4 - Remove the details about book 1:  ");
Console.WriteLine("5 - Remove the details about book 2:  ");
Console.WriteLine("6 - Remove the details about book 3:  ");
Console.WriteLine("7 - Show all books: ");
Console.WriteLine("8 - Set the tax rate (current: 10%) ");
Console.WriteLine("9 - Exit");

int choices = int.Parse(Console.ReadLine());

//creates new insatnces of book
var book1 = new Book();
var book2 = new Book();
var book3 = new Book();
//var showAllBooks = new Book();

//int start;
string Continue = "Yes";
//Console.WriteLine("Please press 1 to start");
//start =  int.Parse(Console.ReadLine());

do 
{
    //int choices = int.Parse(Console.ReadLine());
    switch (choices)
    {
        case 1:
            Console.WriteLine("Please enter the details about book 1: ");
            Console.WriteLine("Title: ");
            book1.BookTitle = Console.ReadLine();
            Console.WriteLine("Author");
            book1.BookAuthor = Console.ReadLine();
            Console.WriteLine("Price: ");
            
            book1.BookPrice = double.Parse(Console.ReadLine());
            Console.WriteLine($"Book 1: {book1.BookTitle} by {book1.BookAuthor}");
            Console.WriteLine($"Price: $ {book1.BookPrice}");
            break;

        case 2:
            Console.WriteLine("Please enter the details about book 2: ");
            Console.WriteLine("Title: ");
            book2.BookTitle = Console.ReadLine();
            Console.WriteLine("Author");
            book2.BookAuthor = Console.ReadLine();
            Console.WriteLine("Price: ");
            book2.BookPrice = double.Parse(Console.ReadLine());
            Console.WriteLine($"Book 2: {book2.BookTitle} by {book2.BookAuthor}");
            Console.WriteLine($"Price: $ {book2.BookPrice}");
            break;


        case 3:
            Console.WriteLine("Please enter the details about book 3: ");
            Console.WriteLine("Title: ");
            book3.BookTitle = Console.ReadLine();
            Console.WriteLine("Author");
            book3.BookAuthor = Console.ReadLine();
            Console.WriteLine("Price: ");
            book2.BookPrice = double.Parse(Console.ReadLine());
            Console.WriteLine($"Book 1: {book3.BookTitle} by {book3.BookAuthor}");
            Console.WriteLine($"Price: $ {book3.BookPrice}");
            break;

        case 4:
            Console.WriteLine("Remove Book 1 details: ");
            book1.BookTitle = "";
            book1.BookAuthor = "";
            book1.BookPrice = 0;

            break;

        case 5:
            Console.WriteLine("Remove Book 2 details: ");
            book2.BookTitle = "";
            book2.BookAuthor = "";
            book2.BookPrice = 0;
            break; 

        case 6:
            Console.WriteLine("Remove Book 3 details: ");
            book3.BookTitle = "";
            book3.BookAuthor = "";
            book3.BookPrice = 0;
            break;

        case 7:
            Console.WriteLine("Show All Books");
            Console.WriteLine(book1.BookTitle + "by " + book1.BookAuthor + "for " + book1.BookPrice);
            Console.WriteLine(book2.BookTitle + "by" + book2.BookAuthor + "for " + book2.BookPrice);
            Console.WriteLine(book3.BookTitle + "by" + book3.BookAuthor + "for " + book3.BookPrice);
            Console.WriteLine("Total cost: $ " + 
                            (book1.BookPrice + book2.BookPrice + book3.BookPrice * book1.BookTaxRate) +
                             (book1.BookPrice + book2.BookPrice + book3.BookPrice));
            break;

        case 8:
            Console.WriteLine("Set the tax rate (current: 10%) ");
            book1.BookTaxRate = double.Parse(Console.ReadLine());
            break;

        case 9:
      
            Environment.Exit(0);
            break;
            

        default:
            Console.WriteLine("ERROR!");
            Console.WriteLine("Please enter a valid number 1-9 ");
            break;
    }



  }while (Continue != "Yes") ;

Console.WriteLine("Would you like to continue? Type 'Yes' to continue. ");
Continue = Console.ReadLine();


Console.WriteLine("Goodbye");