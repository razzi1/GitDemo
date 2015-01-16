using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    internal class Program
    {

        protected internal Program()
        {
            
        }

        static void Main(string[] args)
        {
            var p = new Program();
            p.MyMain();
        }

        // Method that returns anonymous type as object
        internal object ReturnAnonymous()
        {
            return new { City = "Prague", Name = "Tomas" };
        }

        // Application entry-point
        void MyMain()
        {
            // Get instance of anonymous type with 'City' and 'Name' properties
            // Return anonymous
            // Demo local commit changes
            object o = ReturnAnonymous();

            // This call to 'Cast' method converts first parameter (object) to the
            // same type as the type of second parameter - which is in this case 
            // anonymous type with 'City' and 'Name' properties
            var typed = Cast(o, new { City = "", Name = "" });
            // new changes
            Console.WriteLine("Name={0}, City={1}", typed.Name, typed.City);
        }

        // Cast method - thanks to type inference when calling methods it 
        // is possible to cast object to type without knowing the type name
        T Cast<T>(object obj, T type)
        {
            return (T)obj;
        }
    }

    class A
    {
        public A() : base()
        {
            
        }
        void Method1()
        {
            var p = new Program();

        }
    }

    class B : Program
    {
        public B() :base()
        {
            
        }
        void Method1()
        {
            var p = new Program();
        }
    }
}
