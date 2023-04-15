internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[10] {7,9,8,10,6,5,4,3,2,1 };
        for (int i = 0; i < array.Length-1; i++) 
        {
            for (int j = 0; j < array.Length-1-i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j+1];
                    array[j+1] = temp;
                }
            }
        }
        Console.WriteLine(string.Join(", ",array));
    }
}