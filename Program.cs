using System.Text;
using AlGoreIthms = Algorithms.Algorithms;

namespace al_gores_algos;
class Program
{

    static void Main(string[] args)
    {
        var rejectionMessage = ">>That's not right, silly -- pick another one!";

        var listOfAlgorithms = new Dictionary<string, string>(){
            {"1", "Binary Search"},
            {"2", "Selection Sort"},
        };
        var sb = new StringBuilder();
        foreach (var kvp in listOfAlgorithms)
        {
            sb.Append($"{kvp.Key}. {kvp.Value}" + "\n");
        }
        var concatListOfAlgorithms = sb.ToString();

        Console.WriteLine(">>Which algorithm would you like to try from this list? Input the number." + "\n" + concatListOfAlgorithms);

        var userInput = Console.ReadLine();

        while ((userInput != null) && (!listOfAlgorithms.ContainsKey(userInput))) 
        {
            Console.WriteLine(rejectionMessage);
            userInput = Console.ReadLine();
        }

        switch(userInput)
        {
            case "1":
               BinarySearch();
                break;
            case "2":
                Console.WriteLine("\n >>Cool, you want SELECTION SORT!\n>>Please enter a list of numbers, separated by a space\n>>E.g. 1 2 3 4");

                string? userInputtedStringOfNumbers = Console.ReadLine();

                var parsedList = new List<int>();

                if (!string.IsNullOrEmpty(userInputtedStringOfNumbers))
                {
                    string[]? splitUserInputtedStringOfNumbers = userInputtedStringOfNumbers.Split(" ");

                    foreach(string userInputtedDigit in splitUserInputtedStringOfNumbers )
                    {

                        int number;
                        var success = Int32.TryParse(userInputtedDigit, out number);

                        if (success) {
                            parsedList.Add(number);
                        } else
                        {
                            Console.Write($"Cannot parse '{userInputtedDigit}'");
                        }
                    }
                } 
                else 
                {
                    Console.WriteLine("Can't deal with null!");
                    return;
                }

                var result = AlGoreIthms.SelectionSort(parsedList);

                Console.WriteLine($">>Cool, here's what your numbers look like sorted\n" + String.Join(" ", result));
                break;
            default:
                Console.WriteLine("Something's gone wrong!");
                break;
        }
    }

    private static void BinarySearch()
    {
         Console.WriteLine("\n >>Cool, you want BINARY SEARCH!\n>>Please enter a list of numbers, separated by a space\n>>E.g. 1 2 3 4");

                string? userInputtedStringOfNumbers = Console.ReadLine();

                var binarySearchList = new List<int>();

                if (!string.IsNullOrEmpty(userInputtedStringOfNumbers))
                {
                    string[]? splitUserInputtedStringOfNumbers = userInputtedStringOfNumbers.Split(" ");

                    foreach(string userInputtedDigit in splitUserInputtedStringOfNumbers )
                    {

                        int number;
                        var success = Int32.TryParse(userInputtedDigit, out number);

                        if (success) {
                            binarySearchList.Add(number);
                        } else
                        {
                            Console.Write($"Cannot parse '{userInputtedDigit}'");
                        }
                    }
                } 
                else 
                {
                    Console.WriteLine("Can't deal with null!");
                    return;
                }
                
                binarySearchList.Sort();
                int[] binarySearchArray = binarySearchList.ToArray();

                Console.WriteLine(">>This is what your list looks like after sorting" + "\n>> " + String.Join(" ", binarySearchList));
                Console.WriteLine(">>Which number do you want to find the position of?");
                var userInputtedIndex = Console.ReadLine();

                int indexNumber;
                var indexSuccess = Int32.TryParse(userInputtedIndex, out indexNumber);
                if (indexSuccess)
                {
                    var result = AlGoreIthms.BinarySearch(binarySearchArray, indexNumber);
                    Console.Write($"The index is {result}");
                }
    }
}