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

        public static List<int> SelectionSort(List<int> list) 
        {
            var newArray = new List<int>();

            foreach (int i in Enumerable.Range(0, list.Count))
            {
                var smallestIndex = FindSmallest(list.ToArray());
                newArray.Append(list[smallestIndex]);
                list.RemoveAt(smallestIndex);
            }

            return newArray; 
        }

        private static int FindSmallest(int[] array)
        {
            var smallest = array[0];
            var smallestIndex = 0;

            foreach (int i in Enumerable.Range(0, array.Length))
            {
                if (array[i] < smallest)
                {
                    smallest = array[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }
}
}