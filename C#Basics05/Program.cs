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
        }
    }
}
