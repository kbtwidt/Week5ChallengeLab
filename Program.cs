namespace Week5ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Part 1");
            int[] nums1 = [4, 1, 2, 1, 2];
            Console.Write("Array: ");
            foreach (int num in nums1)
            {
                Console.Write(num + " ");
            }
            Console.Write($"\nNumber only appearing once: {SingleNumber(nums1)}");

            Console.WriteLine("\nPart 2");
            int[] nums2 = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            Console.Write("Array: ");
            foreach (int num in nums2)
            {
                Console.Write(num + " ");
            }
            Console.Write($"\nThe missing number in the array is: {MissingNumber(nums2)}");
        }
        static int SingleNumber(int[] nums)
        {
            HashSet<int> seen = new HashSet<int>();

            foreach (int num in nums)
            {
                if (seen.Contains(num))
                {
                    seen.Remove(num);
                }
                else
                {
                    seen.Add(num);
                }
            }
            return seen.First();
        }

        static int MissingNumber(int[] nums)
        {
            long n = nums.Length;
            long expectedSum = n * (n + 1) / 2;
            long actualSum = 0;

            foreach (int num in nums)
            {
                actualSum += num;
            }
            return (int)(expectedSum - actualSum);
        }
    }
}
