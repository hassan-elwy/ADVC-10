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

        #region Q3
        //it's geenric that accept multiple types

        public class Pair<Tkey,Tvalue>
        {
            public Tkey Key;
            public Tvalue Value;

            public Pair() { }

            public Pair(Tkey key, Tvalue value)
            {
                Key = key;
                Value = value;
            }

            public void setPair(Tkey key, Tvalue value)
            {
                Key = key; Value = value;
            }

            public Tvalue? GetValue (Tkey key)
            {
                if (key == null || key.ToString() == null) return default; 

                if(key.ToString()==Key.ToString())
                {
                    return Value;
                }
                else
                {

                    return default;
                }

            }

        }
        #endregion

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
        }
    }
}
