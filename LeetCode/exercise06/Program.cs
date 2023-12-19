string s = "III";
// string [] number = s.TostringArray();
Dictionary<string, int> hashMap =
    new Dictionary<string, int>{
    { 'I' , 1 },
    { 'II' , 2 },
    { 'III' , 3 },
    { 'IV' , 4 }
};
for (int i = s.Length; i < hashMap.Count; i++)
{
    //WHY YOU DONT PRINT??????????????
    Console.WriteLine(hashMap[s[i]]);
}