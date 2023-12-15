using System;
using System.Text;
class Program 
{
    public class Solution {
    public string IntToRoman(int num) {
        var map = new Dictionary<int, string>();

        map.Add(1000, "M");
        map.Add(900, "CM");
        map.Add(500, "D");
        map.Add(400, "CD");
        map.Add(100, "C");
        map.Add(90, "XC");
        map.Add(50, "L");
        map.Add(40, "XL");
        map.Add(10, "X");
        map.Add(9, "IX");
        map.Add(5, "V");
        map.Add(4, "IV");
        map.Add(1, "I");

        var converter  = new StringBuilder();

        foreach (var pares in map) {
            int digit = num / pares.Key;
            while (digit-- > 0) {
                converter.Append(map[pares.Key]);
            }
            num = num % pares.Key;
        }
        return converter.ToString();
    }
}

static void Main(string[] args) {
    
}
}