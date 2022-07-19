using BookClassLibrary;


//creates new insatnces of book
var book1 = new Book();
var book2 = new Book();
var book3 = new Book();

//fields
string? Continue = " "; //initalizes the loop to repeat the program unless 9 is entered
double TotalCostWithTax = 0; //creates a variable for the math section of the total with tax
double TotalCostWithoutTax = 0; //creates a variable for the math section of the total
string? PriceInput; //User inputs what price they want 
string? ChoicesInput; //UI what case they want to select
int Choices =0; //parses ChoicesInput to make it not be nullable
string? TaxRateInput; //this is for whatever the user enters for the tax rate


do
{

    //--------MENU--------
    Console.WriteLine("There are no books currently.");
    Console.WriteLine("Please select 1-9");
    Console.WriteLine("1 - Enter the details about book 1:  ");
    Console.WriteLine("2 - Enter the details about book 2:  ");
    Console.WriteLine("3 - Enter the details about book 3:  ");
    Console.WriteLine("4 - Remove the details about book 1:  ");
    Console.WriteLine("5 - Remove the details about book 2:  ");
    Console.WriteLine("6 - Remove the details about book 3:  ");
    Console.WriteLine("7 - Show all books: ");
    Console.WriteLine($"8 - Set the tax rate (current: {book1.BookTaxRate:P2})");  
    Console.WriteLine("9 - Exit");
    //---------------------

    //-------------------------
    ChoicesInput = Console.ReadLine(); //reads the choices the user enters 
    if ( ChoicesInput != null)

    {
        Choices = int.Parse(ChoicesInput);
    }
    //Creates a variable for the total costs of books
    TotalCostWithoutTax = (book1.BookPrice + book2.BookPrice + book3.BookPrice);
    TotalCostWithTax = ((TotalCostWithoutTax) + (TotalCostWithoutTax * book1.BookTaxRate));
    //----------------------------


    switch (Choices)
    {
        case 1: //Book 1 Details

            Console.WriteLine("Please enter the details about book 1: ");
            Console.WriteLine("Title: ");
            book1.BookTitle = Console.ReadLine();
            Console.WriteLine("Price: ");
            PriceInput = Console.ReadLine();
            if (PriceInput != null)
            {
                book1.BookPrice = double.Parse(PriceInput);
                if (book1.BookPrice < 0 || book1.BookPrice > 9999)
                {
                    Console.WriteLine("Invalid cost, please enter a value between 1-9999");
                }

                else
                {
                    Console.WriteLine($"Book 1: {book1.BookTitle}");
                    Console.WriteLine($"Price: $ {book1.BookPrice}");
                }
            }
            break;
        //---------------END OF CASE 1-----------------------



        case 2: //Book 2 Details
            Console.WriteLine("Please enter the details about book 2: ");
            Console.WriteLine("Title: ");
            book2.BookTitle = Console.ReadLine();
            Console.WriteLine("Price: ");
            PriceInput = Console.ReadLine();
            if (PriceInput != null)
            {

                book2.BookPrice = double.Parse(PriceInput);

                if (book2.BookPrice < 0 || book2.BookPrice > 9999)
                {
                    Console.WriteLine("Invalid cost, please enter a value between 1-9999");
                    break;
                }
                else
                {
                    Console.WriteLine($"Book 2: {book2.BookTitle}");
                    Console.WriteLine($"Price: $ {book2.BookPrice}");
                }
            }

            break;
        //-----------------------END OF CASE 2-----------------------




        case 3: //Book 3 Details
            Console.WriteLine("Please enter the details about book 3: ");
            Console.WriteLine("Title: ");
            book3.BookTitle = Console.ReadLine();
            Console.WriteLine("Price: ");
            PriceInput = Console.ReadLine();

            if (PriceInput != null)
            {
                book3.BookPrice = double.Parse(PriceInput);

                if (book3.BookPrice < 0 || book3.BookPrice > 9999)
                {
                    Console.WriteLine("Invalid cost, please enter a value between 1-9999");
                    break;
                }
                else
                {
                    Console.WriteLine($"Book 3: {book3.BookTitle}");
                    Console.WriteLine($"Price: $ {book3.BookPrice}");
                }
            }
            break;
        //--------------END OF CASE 3-----------------------



        case 4://Removes Book 1 Details
            Console.WriteLine("Are you sure you want to remove Book 1's details? (Press Y) ");
            string? removeBookChoice1 = Console.ReadLine();

            if (removeBookChoice1 == "Y") //if user enters Y the details will be removed
            {
                book1.BookTitle = null; //sets title to null    
                book1.BookPrice = 0; //sets price to 0
            }
            else //Error checking for Y
            {
                Console.WriteLine("ERROR WRONG INPUT ");
                Console.WriteLine("Please enter Y to remove Book 1");
                Console.WriteLine("You will be returned to the main menu");
            }
            break;
        //-----------END OF CASE 4-----------------------



        case 5://Removes Book 2 Details
            Console.WriteLine("Are you sure you want to remove Book 2's details? (Press Y) ");
            string? removeBookChoice2 = Console.ReadLine();

            if (removeBookChoice2 == "Y") //if user enters Y the details will be removed
            {
                Console.WriteLine("Book 2 details have now been removed. ");
                book2.BookTitle = null; //sets title to null    
                book2.BookPrice = 0; //sets price to 0 
            }
            else //Error checking for Y
            {
                Console.WriteLine("ERROR WRONG INPUT ");
                Console.WriteLine("Please enter Y to remove Book 2");
                Console.WriteLine("You will be returned to the main menu");
            }
            break;
        //-------END OF CASE 5-----------------------



        case 6: //Removes Book 3 Details
            Console.WriteLine("Are you sure you want to remove Book 3's details? (Press Y) ");
            string? removeBookChoice3 = Console.ReadLine();

            if (removeBookChoice3 == "Y") //if user enters Y the details will be removed
            {
                Console.WriteLine("Book 3 details have now been removed. ");
                book3.BookTitle = null; //sets title to null    
                book3.BookPrice = 0; //sets price to 0 
            }

            else //Error checking for Y
            {
                Console.WriteLine("ERROR WRONG INPUT ");
                Console.WriteLine("Please enter Y to remove Book 3");
                Console.WriteLine("You will be returned to the main menu");
            }
            break;
        //-------END OF CASE 6-----------------------



        case 7: //Show All Books
            int BookCount = 0; //starts book count at 0


           
            //if a book title is not null, it counts one per book
            if (book1.BookTitle != null) {BookCount++;}
            if (book2.BookTitle != null) {BookCount++;}
            if (book3.BookTitle != null) {BookCount++;}
            
            

            //if all books are null
            if (BookCount == 0)
            {
               Console.WriteLine("There are no books. ");
               Console.WriteLine("Book 1: No book");
               Console.WriteLine("Book 2: No book");
               Console.WriteLine("Book 3: No book");
                Console.WriteLine("Total cost: $0.00");
               Console.WriteLine("Press enter to return to the main menu.");           
            }

            //if there is one book
            else if (BookCount == 1)
            {
               Console.WriteLine("There is 1 book. ");
               Console.WriteLine($"Book 1: {book1.BookTitle}");
               Console.WriteLine("Book 2: No book");
               Console.WriteLine("Book 3: No book");
               Console.WriteLine($"Total cost: ${book1.BookPrice:N2}");
               Console.WriteLine("Press enter to return to the main menu.");
            }

            //if there are two books
            else if (BookCount == 2)
            {
                Console.WriteLine("There are 2 books. ");
                Console.WriteLine($"Book 1: {book1.BookTitle}");
                Console.WriteLine($"Book 2: {book2.BookTitle}");
                Console.WriteLine("Book 3: No book");
                Console.WriteLine($"Total cost: ${(book1.BookPrice + book2.BookPrice):N2}");
                Console.WriteLine("Press enter to return to the main menu.");                  
            }

            //if there are three books
            else if (BookCount == 3)
            {
                Console.WriteLine("There are 3 books");
                Console.WriteLine("Book 1: " + book1.BookTitle + " for $" + book1.BookPrice);
                Console.WriteLine("Book 2: " + book2.BookTitle + " for $" + book2.BookPrice);
                Console.WriteLine("Book 3: " + book3.BookTitle + " for $" + book3.BookPrice);
                Console.WriteLine($"Total cost (without tax): ${TotalCostWithoutTax:N2}");
                Console.WriteLine($"Total cost: ${TotalCostWithTax:N2}");
                Console.WriteLine("Press enter to return to the main menu.");
            }
            break;
          //------------END OF CASE 7-------------------



        case 8: //Tax Rate
            Console.WriteLine($"Current tax rate: {book1.BookTaxRate}) ");
            Console.WriteLine("Please enter a new tax rate: ");
            TaxRateInput = Console.ReadLine();
            if (TaxRateInput != null )
            {
                book1.BookTaxRate = double.Parse(TaxRateInput);

                     if (book1.BookTaxRate > 1 || book1.BookTaxRate < 0)
                {
                    Console.WriteLine("Please enter a value 0 to 1 inclusive");
                }
            }
            break;
         //-------END OF CASE 8--------------



        case 9:
            Console.WriteLine("GoodBye!");
            Environment.Exit(0); //exits program immediantly
            break;
        //-------END OF CASE 9--------------



        default: //Error checking for anything other than 1-9
            Console.WriteLine("ERROR!");
            Console.WriteLine("Please enter a valid number 1-9 ");
            break;
    }

    Continue = Console.ReadLine(); //reads user input when menu is prompted to see if the user wants to exit
} while (Continue != "9"); //if UI equals "9" the program continues

