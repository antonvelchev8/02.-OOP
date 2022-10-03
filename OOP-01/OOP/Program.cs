using System;

namespace OOP
{
    class Program 
    {

        static void Main(string[] args)
        {
            Person firstPerson = new Person();

            firstPerson.Name = "Vasil";
            firstPerson.Age = 17;
            firstPerson.IntroduceYourself();
            firstPerson.Age = 17;
            firstPerson.IntroduceYourself();

            firstPerson.Name = "Ivan";
            firstPerson.Age = 18;
            firstPerson.IntroduceYourself();



        }
    }
}




