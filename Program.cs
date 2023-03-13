namespace IsSorted
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] Array1 = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] Array2 = new[] { 4, 2, 3, 1, 5, 10, 7, 8, 9, 6 };

            bool value1 = IsSorted(Array1);
            bool value2 = IsSorted(Array2);

            Console.WriteLine(value1);
            Console.WriteLine(value2);
        }

        static bool IsSorted(int[] array)
        {
            for (var i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) return false;
            }
            return true;
        }
    }
}