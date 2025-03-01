Console.OutputEncoding = System.Text.Encoding.UTF8;

Dictionary<string, int> premi = new Dictionary<string, int>()
{

    { "🌴", 1 },
    {"🦜", 2 },
    { "👁️", 3 },
    { "🪳", 4 },
    {"🍒",5},
};

Random rnd = new Random();
List<string> listaPremi = new List<string>(premi.Keys);
string[,]griglia = new string[3,3];
bool vincita = false;
int counter = 0;
while (!vincita)
{
    for (int i = 0; i < 3; i++)
    {
    
        for (int j = 0; j < 3; j++)
        {
            griglia[i,j]=listaPremi[rnd.Next(listaPremi.Count)];
        }
    }

    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine($"{griglia[i,0]} {griglia[i,1]} {griglia[i,2]}");
    }

    for (int i = 0; i < 3; i++)
    {
        if (griglia[i, 0] == griglia[i, 1] && griglia[i, 1] == griglia[i, 2])
        {
            
            //vincita=true;
            Console.WriteLine($"hai vinto dopo {counter}");
            break;
        }
    } 
    if ((griglia[0, 0] == griglia[1, 1] && griglia[1, 1] == griglia[2, 2]) ||
             (griglia[0, 2] == griglia[1, 1] && griglia[1, 1] == griglia[2, 0]))
    {
            
        //vincita=true;
        Console.WriteLine($"hai vinto dopo {counter}");
    }

    if
        ((griglia[0, 0] == griglia[0, 1] && griglia[0, 1] == griglia[0, 2]) && // Riga 0
         (griglia[1, 0] == griglia[1, 1] && griglia[1, 1] == griglia[1, 2]) && // Riga 1
         (griglia[2, 0] == griglia[2, 1] && griglia[2, 1] == griglia[2, 2]) && // Riga 2
         (griglia[0, 0] == griglia[1, 0] && griglia[1, 0] == griglia[2, 0]) && // Colonna 0
         (griglia[0, 1] == griglia[1, 1] && griglia[1, 1] == griglia[2, 1]) && // Colonna 1
         (griglia[0, 2] == griglia[1, 2] && griglia[1, 2] == griglia[2, 2]) && // Colonna 2
         (griglia[0, 0] == griglia[1, 1] && griglia[1, 1] == griglia[2, 2]) && // Diagonale principale
         (griglia[0, 2] == griglia[1, 1] && griglia[1, 1] == griglia[2, 0]))
    {
        Console.WriteLine($"hai vinto dopo {counter}");
        vincita = true;
    }
    counter++;
    //Console.ReadKey();
    
    Console.WriteLine("-----------");
    
}
