namespace HeapSortTesting
{
    public static class RandomInputGenerator
    {
        public static int[] GenerateRandomNumArray(int size, int min_bound, int max_bound)
        {
            Random random = new Random();
            int[] array = new int[size];

            for (int i = 0; i < size; i++)
            {
                array[i] = random.Next(min_bound, max_bound); 
            }

            return array;
        }
    }
}