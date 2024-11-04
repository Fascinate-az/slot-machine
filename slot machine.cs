Console.WriteLine("per giocare inserire almeno 1 euro e premere invio");

var cash = Convert.ToInt32(Console.ReadLine());

var creditoResiduo = cash;

if (cash > 0 ){
    var tentativi = 0;
    Random numGen = new Random();
    string[]simboli = {"piramide","faraone","scarabeo","palma","gatto","cleopatra","occhio di Ra","Falco"};
    while(creditoResiduo>0){
        var tiro1 = simboli[numGen.Next(0,simboli.Length)];
        var tiro2 = simboli[numGen.Next(0,simboli.Length)];
        var tiro3 = simboli[numGen.Next(0,simboli.Length)];
        tentativi++;
        creditoResiduo--;
        
        Console.WriteLine(tiro1 + "." + tiro2 + "."+ tiro3);
        Console.ReadKey();
        if (tiro1 == tiro2 && tiro1 == tiro3){
            creditoResiduo +=5;
            Console.WriteLine("HAI VINTO!!!!!! DOPO " + tentativi + " tentativi\nIl saldo è stato ricaricato di 5 euro.\nOra il tuo saldo disponibile è di " + creditoResiduo + " euro");
            scelta();
            
        }

        if(creditoResiduo <= 0){
            Console.WriteLine("Per continuare a giocare ricaricare il saldo\nPremere 1 per ricararicare il saldo o premere 2 per uscire");
            var sceltaContinuare = Convert.ToInt32(Console.ReadLine());
            if (sceltaContinuare == 1){
                Console.WriteLine("inserire l'importo da ricaricare");
                var ricaricaSaldo = Convert.ToInt32(Console.ReadLine());
                creditoResiduo += ricaricaSaldo;
                Console.WriteLine("il tuo saldo è di " + creditoResiduo + " euro" );
                
                
            }

            else{
                Console.WriteLine("grazie per aver giocato");
                break;
            }

            
        }
        
        
    }
}
else{
    Console.WriteLine("inserire almeno 1 euro");
}


int scelta(){
    Console.WriteLine("per continuare a giocare premere 1 , per uscire 2");
    int continuare = Convert.ToInt32(Console.ReadLine());
    if( continuare == 1){
        Console.WriteLine("Ora il tuo saldo disponibile è di " + creditoResiduo + " euro");
        return creditoResiduo;
    }
    else{
        Console.WriteLine("Grazie per aver giocato\nRitirare il saldo di " + creditoResiduo + " euro" );
        return creditoResiduo;
        

        
    }
    
}

Console.ReadKey();

