using System.Drawing;
using System.Numerics;

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

        public class Pair<Tkey, Tvalue>
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

            public Tvalue? GetValue(Tkey key)
            {
                if (key == null || key.ToString() == null) return default;

                if (key.ToString() == Key.ToString())
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
        #region Q4
        //it's is method that contain generic Type 

        public void Swap<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;


        }
        #endregion

        #region Q5
        public T? FindMax<T>(T[] values) where T : IComparable<T>
        {
            if (values.Length == 0)
            { return default; }

            T max = values[0];

            for (int i = 0; i < values.Length; i++)
            {
                if (max.CompareTo(values[i]) < 0)
                { max = values[i]; }
            }

            return max;
        }
        #endregion

        #region Q6
        //it's interface that use generic types
        public interface IRepository<T>
        {
            void AddMember(T item);

        }
        #endregion
        #region Q7
        //it's constraint at generic,that codition generic to be a struct type (value type)

        public static void ValueSwap<T>(ref T x, ref T y) where T : struct
        {
            T temp = x;
            x = y;
            y = temp;


        }

        #endregion

        #region Q8

        //it's constraint that condition generic to be of class type, (refrence type)

        public static void ReferenceSwap<T>(ref T x, ref T y) where T : class
        {
            T temp = x;
            x = y;
            y = temp;
        }
        #endregion

        #region Q9
        //it's constraint that condition generic to have public paramterless constructor (no abstract,base or static classes)


        public static T CreateObject<T>() where T : new()
        {
            return new T();

        }
        #endregion

        #region Q10
        //it's constrait that condition generic to be of an interface or class that implements that interface

        public static T? FindMaxNumbers<T>(T[] values) where T : INumber<T>
        {
            if (values.Length == 0)
            { return default; }

            T max = values[0];

            for (int i = 0; i < values.Length; i++)
            {
                if (max<values[i])
                { max = values[i]; }
            }

            return max;
        }

        #endregion

        #region Q11
        //it's constarint that condition generic type to be of a base class or it's childs
        public abstract class baseMember
        {
            public int ID { get; set; }
        }
        public class memberHelper<T> where T : baseMember
        {
            public void SetIdToMember(T member, int id)
            {
                member.ID = id;
            }
        }
        #endregion

        #region Q12
        //we condtition helper to recieve only childs of base and not base itself
        public class MemberHelper<T> where T : baseMember, new()
        {
            public T CreateMember(T member, int id)
            {
                member.ID = id;
                return member;
            }

        }
        #endregion

        #region Q13
        //default would be equivalent to default value if generic is not nullable, or to null if generic is nullable
        #endregion

        #region Q14
        public class SafeList<T>
        {
         public int size;
            T[] values;

            public SafeList(int size)
            {
                this.size = size;
                values = new T[size];

            }
            public T? this[int index]
            {
                get { if (index >= 0&&index<values.Length) return values[index]; else return default; }
                set { if (index >=0 &&index<values.Length) values[index] = value; }
            }


        }
        #endregion
        #region Q15
        //make generic not able to be written, but can be returned

        public interface convertIntToType<out T> where T : INumber<T>
        {
            T IntConvertToType(int value);

        }
        #endregion

        #region Q16
        //make generic not able to be Returned, but can be Written

        public interface ContertTypetoInt<in T> where T : INumber<T>
        {
            int TypeConvertToInt(T value);
        }

        #endregion

        #region Q17

        //covariance:make generic type not able to be written, but can be returned

        //contravariance:make generic Type not able to be Returned, but can be Written

        #endregion

        #region Q18

        //static members are shared accross classes with the same type,but it's different with class that has different types

        #endregion
        #region q19
        //childs of generic class need to either stay generic or send the type argument in inheriting

        public class SafeListhelper<T> : SafeList<T>
        {
            SafeListhelper(int size) : base(size) { }

            public int getSize() { return size; }
        }

        public class SafeListhelper : SafeList<int>
        {
            SafeListhelper(int size) : base(size) { }

            public int getSize() { return size; }
        }

        #endregion

        #region Q20

        public class Cache<tKey, tValue>
        {
            tKey key;
            tValue value;

            public void add(tKey k, tValue v)
            {
                this.key = k;
                this.value = v;

            }

            public tValue? get(tKey k)
            {
                if (key == null) return default;

                if (key.ToString() == k.ToString()) { return value; }

                return default;
            }

            public void remove()
            {
                key = default;
                value = default;
            }

            public void Contains()
            {
                Console.WriteLine("Cache contains:");
                Console.WriteLine("Key:" + key);
                Console.WriteLine("value =" + value);
            }




        }
        #endregion

        static void Main(string[] args)
        {

            Console.WriteLine("Hello, World!");
        }
    }
}
