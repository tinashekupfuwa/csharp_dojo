using System;

namespace csharp_practice_02
{
  class Program
  {
    static void Main(string[] args)
    {

      // // string guess;
      // // int noOfguesses = 10;
      // // int tries = 0;
      // // string keyword = "sadza";
      // // bool validTry = true;

      // // Console.WriteLine("What is the staple food of Zimbabwe");
      // // guess = Console.ReadLine();

      // int[,] numberGrid = {
      //   {1,2},
      //   {3,4},
      //   {5,6}
      // };

      // Console.WriteLine(numberGrid[2, 1]);

      // int[,] myArray = new int[2, 3]; // This is just awa y of declaring arrays when you have no data to fill them.

      // //Exception handling

      Book book1 = new Book("1234", "2345", 200, "R");
      Console.WriteLine(book1.Rating);

    }
  }
}