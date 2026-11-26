namespace C__Assignment__4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();

            #region Q1: Add a private string password = "secret"; field to Book. Try to print it from Main. What happens, and why?
            Console.WriteLine("Q1 Answer: Compile-time error CS0122 (Book.password is inaccessible due to its protection level).");
            Console.WriteLine("Why: private members are accessible only inside the class that declares them (Book), not from Main.");
            #endregion

            #region Q2: Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why?
            Console.WriteLine($"Copies in stock: {book.copiesInStock}");
            Console.WriteLine($"Copies in stock: {book.copiesInStock}");
            Console.WriteLine("Q2 Answer: Yes, it compiles.");
            Console.WriteLine("Why: internal members are accessible anywhere within the same assembly, and Main is in the same project as Book.");
            #endregion

            #region Q3
            book.Title = "C# Fundamentals";
            Console.WriteLine($"Title: {book.Title}");
            #endregion

            #region Q4
            book.Genre = Genre.Science;
            Console.WriteLine($"Genre: {book.Genre}");   
            #endregion

            #region Q5
            Console.WriteLine($"NonFiction = {(int)Genre.NonFiction}"); 
            Console.WriteLine($"Science = {(int)Genre.Science}");        
            #endregion

            #region Q6:
            int genreNumber = 1;
            Genre genreFromNumber = (Genre)genreNumber;
            Console.WriteLine($"Genre from number: {genreFromNumber}");  
            #endregion

            #region Q7
            Genre genre = Genre.Fiction;
            string genreString = genre.ToString();
            Console.WriteLine($"Genre as string: {genreString}");    
            #endregion

            #region Q8
            string genreText = "Science";
            Genre parsedGenre = (Genre)Enum.Parse(typeof(Genre), genreText);
            Console.WriteLine($"Parsed genre: {parsedGenre}");         
            #endregion

            #region Q9
            string invalidGenreText = "Mystery";
            if (Enum.TryParse(invalidGenreText, out Genre result))
            {
                Console.WriteLine($"Genre: {result}");
            }
            else
            {
                Console.WriteLine("Unknown genre");
            }


            #endregion      
        }

    }
}
