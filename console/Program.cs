
class Program{
    static void Main(string[] args){
        Console.WriteLine("Hello, World!");
        String? s = null;
        int[] array=[1,2,3,4,5];
        var maRange = array[1..^2];
        Console.WriteLine(string.Join(", ",maRange));
    }


}

public class Eleve(){
    //this is a property (propriété)
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public int Age { get; set; }
    //this is a field (champ)
    private string _nom;
}
public interface ITest{
    void Test();
}
