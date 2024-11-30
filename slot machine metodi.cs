var cash = 0;
var crediti = 0;
var startTasto = ConsoleKey.NoName;

start(ref cash, ref crediti);
gioco(ref cash, ref crediti,ref startTasto);
Console.ReadKey();





static int start(ref int cash, ref int crediti)
{
    Console.WriteLine("inserire almeno 1 euro e premere 2 volte invio per inizare a giocare");
    bool isValid = int.TryParse(Console.ReadLine(), out cash);
    crediti = cash;
    return crediti;

}

static int gioco(ref int cash, ref int crediti,ref ConsoleKey startTasto)
{
    startTasto = Console.ReadKey().Key;
    if (cash > 0 && startTasto == ConsoleKey.Enter )
    {
        Random random = new Random();
        while (crediti > 0)
        {
            int giro1 = random.Next(1, 7);
            int giro2 = random.Next(1, 7);
            int giro3 = random.Next(1, 7);
            crediti--;
            Console.WriteLine($"{giro1},{giro2},{giro3}");
            if (giro1 == giro2 && giro1 == giro3)
            {
                crediti += 5;
                Console.WriteLine($"hai vinto 5 crediti extra!!!!!!");
            }
            Console.WriteLine($"hai a disposizione {crediti} crediti");

            if (crediti == 0)
            {
                Console.WriteLine("hai esaurito i crediti");
                ricarica(ref cash, ref crediti);
            }
            Console.ReadKey();
        }

    }


    return crediti;
}
static int ricarica(ref int crediti, ref int cash)
{
    Console.WriteLine("premere 1 per ricaricare il tuo saldo o un altro tasto per uscire");
    bool decisione = int.TryParse(Console.ReadLine(), out int ricarica);
    var ricaricaSaldo = 0;
    if (ricarica == 1)
    {
        do
        {
            Console.WriteLine("inserire l'importo da ricarica");
            ricaricaSaldo = int.Parse(Console.ReadLine());

        }
        while (ricaricaSaldo <= 0);
    }
    else
    {
        Console.WriteLine("grazie per aver giocato");
        Environment.Exit(0);
    }
    cash += ricaricaSaldo;
    crediti = cash;

    Console.WriteLine($"il tuo saldo disponibile è di {crediti} premere invio per continuare a giocare");



    return crediti;
}

