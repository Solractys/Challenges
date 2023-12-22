class Program
{
    static void Main()
    {
        string s = "0110101";
        string[] parts = new string[s.Length + 1];

        for (int i = 0; i <= s.Length; i++)
        {
            parts[i] = s.Substring(0, i) + "," + s.Substring(i);

            int zerosCountt = parts[i].Split(",")[0].Count(c => c == '0');
            int onesCountt = parts[i].Split(",")[1].Count(c => c == '1');
            

        }

    // Exibir as partes armazenadas na array

        foreach (string part in parts)
        {
            Console.WriteLine(part);
        }
    }
}