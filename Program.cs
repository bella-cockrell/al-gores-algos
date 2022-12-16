using System.Text;
using AlGoreIthms = Algorithms.Algorithms;

namespace al_gores_algos;
class Program
{
    static void Main(string[] args)
    {
        string[] listOfAlgorithms = {"Binary Search"};
        var concatListOfAlgorithms = string.Join("\n", listOfAlgorithms);

        Console.WriteLine("Which algorithm would you like to try from this list?" + "\n" + concatListOfAlgorithms);
        var userInput = Console.ReadLine();

        while (!Array.Exists(listOfAlgorithms, element => element == userInput)) 
        {
            Console.WriteLine("That's not in the list, silly -- pick another one!");
            userInput = Console.ReadLine();
        }

        switch(userInput)
        {
            case "Binary Search":
                Console.WriteLine("Cool, you want BINARY SEARCH!");
                //AlGoreIthms.BinarySearch;
                break;

            default:
                Console.WriteLine("Something's gone wrong!");
                break;
        }
    }
}
