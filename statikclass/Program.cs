using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace statikclass
{
    // bunu static olarak yazdığımız zaman aşağıda nesne tanımlamadan, class'ın içeriklirine ulaşabiliyoruz
    // Class'ı sabitlemiş oluyoruz.
    static class User
    {
        public static string name;
        public static string location;
        public static int age;

        public static void Detail()
        {
            Console.WriteLine("Static Method");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            User.name = "serdar";
            User.location = "istanbul";
            User.age = 32;
            Console.WriteLine("Name : {0}", User.name);
            Console.WriteLine("Location : {0}", User.location);
            Console.WriteLine("Age : {0}", User.age);
            User.Detail();
            Console.ReadLine();
        }
    }
}
