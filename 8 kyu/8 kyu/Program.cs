
public class Kata
{
    [STAThread]
    static void Main()
    {
        int[] arr1 = Flip('R', new int[] { 3, 2, 1, 2 });
        int[] arr2 = Flip('L', new int[] { 1, 4, 5, 3, 5 });

        foreach (var item in arr2)
        {
            Console.Write(item + " ");
        }
    }

    public static int[] Flip(char dir, int[] arr)
    {
        Array.Sort(arr);
        if (dir == 'L')
            Array.Reverse(arr);

        return arr;
    }
}

