namespace Assignment10
{
    internal class Program
    {

        #region Q1
        /*
        generic works as placeholder for datatypes,
        which allow you write functions and classes adaptable for multiple types
         */

        #endregion
        #region Q2

        public class container<T>
        {
            T? Content;

            public T? GetContent()
            {
                return Content;
            }

            public void AddContent(T content)
            { Content = content; }
        }
        #endregion

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
        }
    }
}
