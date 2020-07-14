using System;
using Class1.Services;

namespace Class1
{
    class Program
    {
        static void Main(string[] args)
        {
            var name = UserInfo.GetName();
            var age = UserInfo.GetAge();
            Console.WriteLine("Name: {0}\nAge: {1}",name,age);
            Console.WriteLine("My name is {0}, and i am {1} year old",name,age);

        }
    }
}
