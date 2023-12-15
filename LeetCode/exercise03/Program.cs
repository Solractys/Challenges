public class Solution {
    public string DestCity(IList<IList<string>> paths) {
        HashSet<string> origem = new HashSet<string>();
        HashSet<string> destino = new HashSet<string>();
        foreach (var path in paths) {
            origem.Add(path[0]);
            destino.Add(path[1]);
        }
        foreach (var cidade in destino) {
            if (!origem.Contains(cidade)) {
                return cidade;
            }
        }
        return "";
    }
static void Main(string[] args) {
    
}
}