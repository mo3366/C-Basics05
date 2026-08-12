namespace C_Basics05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 01
            //Add a private string password = "secret"; field to a Book class. Try to print it from Main (outside the class). What happens, and why?

            //Book book = new Book();
            //Console.WriteLine(book.password);
            // No compilation will happen because private can be accessed inside the same class only
            #endregion

            #region Question 02
            //Add an internal int copiesInStock = 5; field to Book. Print it from Main. Does it compile? Why ?

            //Book book = new Book();
            //Console.WriteLine(book.copiesInStock);
            //compilation will happen because internal can be accessed from anywhere inside the same project 
            #endregion

            #region Question 03
            //Add a public string Title; field to Book. Set it and print it from Main.

            Book book = new Book();
            book.Title = "momen";
            Console.WriteLine(book.Title);
            //compilation will happen because internal can be accessed from anywhere inside the same project 
            #endregion

            #region Question 04
            //Declare an enum Genre { Fiction, NonFiction, Science }. Add a Genre property to Book, assign it Genre.Science, and print it.

            //Book book = new Book();
            //book.Genre = Genre.Science;
            //Console.WriteLine(book.Genre);
            #endregion

            #region Question 05
            //Using the Genre enum above, print the underlying int value of Genre.Fiction, Genre.NonFiction, and Genre.Science by casting each to int.
           
            Console.WriteLine((int)Genre.Fiction);
            Console.WriteLine((int)Genre.NonFiction);
            Console.WriteLine((int)Genre.Science);
            #endregion

            #region Question 06
            //Given int genreNumber = 1;, cast it into a Genre value and print the result.

            //int genreNumber = 1;
            //Genre genre = (Genre)genreNumber;
            //Console.WriteLine(genre);

            #endregion


            #region Question 07
            //Given Genre genre = Genre.Fiction;, convert it into a string using ToString() and print it.

            //Genre genre = Genre.Fiction;
            //string text = genre.ToString();
            //Console.WriteLine(text);

            #endregion

            #region Question 08
            //Given string genreText = "Science";, convert it into a Genre value using Enum.Parse() and print the result.

            //string genreText = "Science";
            //Genre genre = Enum.Parse<Genre>(genreText);
            //Console.WriteLine(genre);


            #endregion


        }
    }
}
