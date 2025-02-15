using System.Text;
using System.Threading.Channels;

Console.OutputEncoding = System.Text.Encoding.UTF8;

Dictionary<string, int> premi = new Dictionary<string, int>()
{

    { "🌴", 1 },
    {"🦜", 2 },
    { "👁️", 3 },
    { "🪳", 4 },
    {"🍒",5},
};
var papagallo = premi.Keys.ElementAt(1);
int valorePapagallo = premi.Values.ElementAt(1)*5;
string scarabeo = premi.Keys.ElementAt(3);
int valoreScarabeo = premi.Values.ElementAt(3)*8;
Random rnd = new Random();
int credito = 500;
Console.WriteLine("Premere invio per giocarea");
while (credito > 0)
{
    var randomPremi1=premi.Keys.ElementAt(rnd.Next(0, premi.Keys.Count));
    var randomPremi2 = premi.Keys.ElementAt(rnd.Next(0, premi.Keys.Count));
    var randomPremi3 = premi.Keys.ElementAt(rnd.Next(0, premi.Keys.Count));
    Console.ReadKey();
    Console.WriteLine($"{randomPremi1} {randomPremi2} {randomPremi3}");
    
    if (randomPremi1 == papagallo && randomPremi2 == papagallo &&
        randomPremi3 == papagallo)
    {
        credito += valorePapagallo;
        Console.WriteLine("tripleta di PAPAGALLI");
    }
    
    
    else if (randomPremi1 == premi.Keys.ElementAt(3) && randomPremi2 == premi.Keys.ElementAt(3) &&
             randomPremi3 == premi.Keys.ElementAt(3))
    {
        credito += valoreScarabeo;
        Console.WriteLine("Lo SCARABEO");
    }
    
    else if (randomPremi1 == randomPremi2 && randomPremi1 == randomPremi3)
    {
        credito += 2;
    }

    else
    {
        credito--;
    }
    


    Console.WriteLine(($"credito residuo: {credito}"));
}
