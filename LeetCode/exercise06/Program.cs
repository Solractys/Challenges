string s = "MCMXCIV";
int res = 0;
int prev = 0;

Dictionary<char, int> hashMap =
    new Dictionary<char, int>
    {
        { 'M', 1000 },
        { 'D', 500 },
        { 'C', 100 },
        { 'L', 50 },
        { 'X', 10 },
        { 'V', 5 },
        { 'I', 1 }
    };

    for (int i = s.Length - 1; i >= 0; i--)
    {
        if (prev <= hashMap[s[i]])
            res += hashMap[s[i]];
        else if (prev > hashMap[s[i]])
            res -= hashMap[s[i]];
        prev = hashMap[s[i]];
    }
    Console.WriteLine(res);