using System.Diagnostics.Contracts;

class Program
{
    static void Main()
    {
        string s = "011101";
        string[] parts = new string[s.Length + 1];

        int maxSum = 0;

        for (int i = 0; i <= s.Length; i++)
        {
            // parts[i] = s.Substring(0, i) + "," + s.Substring(i);

            int zerosCount = s.Substring(0, i).Count(c => c == '0');
            int onesCount = s.Substring(i).Count(c => c == '1');
            int currentSum = zerosCount + onesCount;

            if (currentSum > maxSum)
            {
                maxSum = currentSum;
            }
        }
        Console.WriteLine( maxSum);
    }
}