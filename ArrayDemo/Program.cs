namespace ArrayDemo
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("Enter number of Students");
            int num = Convert.ToInt32(Console.ReadLine());
            int[] marksList = new int[num];
            for (int i = 0; i < marksList.Length; i++)
            {
                Console.WriteLine($"Enter marks for student {i + 1}");
                marksList[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0;i < marksList.Length;i++)
            {
                Console.WriteLine(marksList[i]);
            }
        }

    }
}