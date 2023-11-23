namespace HeapSortTesting
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            uint numOfBaseOperations = 0;
            int[] arr = RandomInputGenerator.GenerateRandomNumArray(1024, 0, 1000);
            numOfBaseOperations += HeapSort(arr);
            Console.WriteLine($"Sorted, number of base operations:{numOfBaseOperations}");
        }

        static uint HeapSort(int[] array)
        {
            uint numOfOperations = 0;

            int n = array.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                numOfOperations += Heapify(array, n, i);
            }

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = array[0];
                array[0] = array[i];
                array[i] = temp;
                ++numOfOperations;

                numOfOperations += Heapify(array, i, 0);
            }

            return numOfOperations;
        }

        static uint Heapify(int[] array, int n, int i)
        {
            uint numOfOperations = 0;

            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;

            if (left < n && array[left] > array[largest])
            {
                ++numOfOperations;
                largest = left;
            }

            if (right < n && array[right] > array[largest])
            {
                ++numOfOperations;
                largest = right;
            }

            if (largest != i)
            {
                int temp = array[i];
                array[i] = array[largest];
                array[largest] = temp;
                ++numOfOperations;

                numOfOperations += Heapify(array, n, largest);
            }

            return numOfOperations;
        }
    }
}