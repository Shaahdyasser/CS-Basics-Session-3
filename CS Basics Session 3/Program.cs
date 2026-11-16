namespace CS_Basics_Session_3
{
    //Assignment2
    #region Question 5
    //internal class Q5
    //{
    //    static void Main(string[] args)
    //    {
    //        int pages = 300;

    //        double number = pages;

    //        Console.WriteLine(number);
    //    }
    //}
    #endregion

    #region Question 6
    //class Q6
    //{
    //    static void Main()
    //    {
    //        double price = 49.99;
    //        int result = (int)price;
    //        Console.WriteLine(result);
    //    }
    //}
    #endregion

    #region Question 7
    //class Q7
    //{
    //    static void Main()
    //    {
    //        string pagesText = "464";
    //        int pages = Convert.ToInt32(pagesText);
    //        Console.WriteLine(pages);
    //    }
    //}
    #endregion

    #region Question 8 
    //class Q8
    //{
    //    static void Main()
    //    {
    //        string yearText = "2023";
    //        int year = int.Parse(yearText);
    //        Console.WriteLine(year);

    //        string badText = "abc";
    //        int number;
    //        bool success = int.TryParse(badText, out number);

    //        if (success)
    //        {
    //            Console.WriteLine(number);
    //        }
    //        else
    //        {
    //            Console.WriteLine("Invalid number");
    //        }
    //    }
    //}
    #endregion

    #region Question 9
    //class Q9
    //{
    //    static void Main()
    //    {
    //        int pages = 464;
    //        string text = pages.ToString();

    //        Console.WriteLine(text);
    //        Console.WriteLine(text.GetType());
    //    }
    //}
    #endregion

    #region Question 10
    //class Q10
    //{
    //    static void Main()
    //    {
    //        int copies = 100;
    //        object obj = copies;
    //        int newCopies = (int)obj;

    //        Console.WriteLine(copies);
    //        Console.WriteLine(newCopies);
    //    }
    //}
    #endregion

    #region Question 11
    //class Q11
    //{
    //    static void Main()
    //    {
    //        int? year = null;

    //        Console.WriteLine(year.HasValue);

    //        year = 2023;

    //        Console.WriteLine(year.Value);
    //    }
    //}
    #endregion

    #region Question 12
    //class Q12
    //{
    //    static void Main()
    //    {
    //        string? reviewer = null;

    //        Console.WriteLine(reviewer == null);
    //    }
    //}
    #endregion

    #region Question 13
    //class Book
    //{
    //    public string Title = "C# Book";
    //}

    //class Program
    //{
    //    static void Main()
    //    {
    //        Book? book = null;
    //        string? title = book?.Title;

    //        Console.WriteLine(title);
    //    }
    //}
    #endregion

    #region Question 14
    //class Q14
    //{
    //    static void Main()
    //    {
    //        string? title = null;
    //        Console.WriteLine(title ?? "Untitled");

    //        title ??= "Untitled";
    //        Console.WriteLine(title);
    //    }
    //}
    #endregion

    #region Question 15
    //class Q15
    //{
    //    static void Main()
    //    {
    //        string? name = "Ahmed";
    //        string confirmedName = name!;
    //        Console.WriteLine(confirmedName);
    //    }
    //}
    #endregion

    //Assignment3
    #region Question 1
    //class Q1
    //{
    //    static void Main()
    //    {
    //        int pages = 464;
    //        if (pages > 300)
    //        {
    //            Console.WriteLine("Long Book");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Short Book");
    //        }
    //    }
    //}
    #endregion

    #region Question 2
    //class  Q2
    //{
    //    static void Main()
    //    {
    //        int pages = 464;
    //        bool isAvailable = true;

    //        if (pages > 300 && isAvailable == true)
    //        {
    //            Console.WriteLine("You can borrow this book");
    //        }
    //    }
    //}
    #endregion

    #region Question 3
    //class Q3
    //{
    //    static void Main()
    //    {
    //        string title = "Refactoring";
    //        switch (title)
    //        {
    //            case "Clean Code":
    //                Console.WriteLine("Great choice!");
    //                break;

    //            case "Refactoring":
    //                Console.WriteLine("Nice pick!");
    //                break;

    //            default:
    //                Console.WriteLine("Never heard of it");
    //                break;
    //        }
    //    }
    //}
    #endregion

    #region Question 4
    //class Program
    //{
    //    static void Main()
    //    {
    //        int pages = 464;
    //        string sizeLabel = pages > 300 ? "Long Book" : "Short Book";
    //        Console.WriteLine(sizeLabel);
    //    }
    //}
    #endregion

    #region Question 5
    //class Question5
    //{
    //    static void Main()
    //    {
    //        string[] books = {
    //        "Clean Code",
    //        "The Pragmatic Programmer",
    //        "Refactoring"
    //    };
    //        for (int i = 0; i < books.Length; i++)
    //        {
    //            Console.WriteLine((i + 1) + ". " + books[i]);
    //        }
    //    }
    //}
    #endregion

    #region Question 6
    //class Question6
    //{
    //    static void Main()
    //    {
    //        string[] books = {
    //        "Clean Code",
    //        "The Pragmatic Programmer",
    //        "Refactoring"
    //    };
    //        int i = 0;
    //        while (i < books.Length)
    //        {
    //            Console.WriteLine(books[i]);

    //            i++;
    //        }
    //    }
    //}
    #endregion

    #region Question 7
    //class Question7
    //{
    //    static void Main()
    //    {
    //        int i = 0;
    //        do
    //        {
    //            Console.WriteLine("Checking book...");

    //            i++;
    //        }
    //        while (i < 3);
    //    }
    //}
    #endregion

    #region Question 8
    //class Question8
    //{
    //    static void Main()
    //    {
    //        string[] books = {
    //        "Clean Code",
    //        "The Pragmatic Programmer",
    //        "Refactoring"
    //    };

    //        foreach (string book in books)
    //        {
    //            Console.WriteLine(book);
    //        }
    //    }
    //}
    #endregion

    #region Question 9

    //class Question9
    // {
    //     static void Main()
    //     {
    //         string[] books = {
    //         "Clean Code",
    //         "The Pragmatic Programmer",
    //         "Refactoring"
    //     };

    //         foreach (string book in books)
    //         {
    //             if (book == "Refactoring")
    //             {
    //                 break;
    //             }

    //             Console.WriteLine(book);
    //         }
    //     }
    // }
    #endregion

    #region Question 10 
    //class Question10
    //   {
    //       static void Main()
    //       {
    //           string[] books = {
    //           "Clean Code",
    //           "The Pragmatic Programmer",
    //           "Refactoring"
    //       };
    //           foreach (string book in books)
    //           {
    //               if (book == "The Pragmatic Programmer")
    //               {
    //                   continue;
    //               }

    //               Console.WriteLine(book);
    //           }
    //       }
    //   }
    #endregion

    #region Question 11
    //class Question11
    //{
    //    static void PrintFirstBook(string[] books)
    //    {
    //        if (books.Length == 0)
    //        {
    //            return;
    //        }
    //        Console.WriteLine(books[0]);
    //    }

    //    static void Main()
    //    {
    //        string[] books = {
    //        "Clean Code",
    //        "The Pragmatic Programmer",
    //        "Refactoring"
    //    };

    //        PrintFirstBook(books);
    //    }
    //}
    #endregion
}
