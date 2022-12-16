namespace Algorithms
{
    class Algorithms
    {
        public static int? BinarySearch(int[] userInputtedNumbers, int itemToFind)
        {
            var lowestBound = 0;
            var highestBound = userInputtedNumbers.Length - 1;

            while(lowestBound <= highestBound)
            {
                var mid = (lowestBound + highestBound) / 2;
                var guess = userInputtedNumbers[mid];

                if (guess == itemToFind)
                {
                    return mid;
                }
                if (guess > itemToFind)
                {
                    highestBound = mid - 1;
                } else
                {
                    lowestBound = mid + 1;
                }  
            }

            return null;

        }
}
}