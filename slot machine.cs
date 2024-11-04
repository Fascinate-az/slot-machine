using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using Microsoft.VisualBasic;

Console.WriteLine("inserire almeno 1 euro e premere invio");

var cash = Convert.ToInt32(Console.ReadLine());
var creditoResiduo = cash ;


if(cash > 0){
    Random numbergen = new Random ();
     var tentativi = 0;
    while(creditoResiduo >= 1){

        

        var tiro1 = numbergen.Next(1,2);
        var tiro2 = numbergen.Next(1,2);
        var tiro3 = numbergen.Next(1,2);
        

        Console.WriteLine(tiro1 + "." + tiro2 + "." + tiro3);
        creditoResiduo --;
        tentativi ++;
        Console.ReadKey();
        

        if (tiro1 == tiro2 && tiro1 == tiro3){
            
            Console.WriteLine ("hai vinto dopo " + tentativi + " tentativi");
            Console.ReadKey();
            break;
        
        }
        else if(creditoResiduo == 0){
            Console.WriteLine("credito residuo insufficente");
        }
    }
}
else {
    Console.WriteLine("errore,inserire almeno un euro per giocare");
}

Console.ReadKey();


