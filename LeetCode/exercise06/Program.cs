string s = "III";
// char [] number = s.ToCharArray();
Dictionary<char, int> hashMap =
    new Dictionary<char, int>{
    { 'I' , 1 },
    { 'II' , 2 },
    { 'III' , 3 },
    { 'IV' , 4 }
};
for (int i = 0; i < hashMap.Count; i++)
{
    //WHY YOU DONT PRINT??????????????
    Console.WriteLine(hashMap[s[i]]);
}