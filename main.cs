using System;

class Program {
   public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
string entrada;
    Double qtd, valor ;
    
    Console.WriteLine("Digite quantidade de maçãs");
  
    entrada = Console.ReadLine();


   qtd =  Double.Parse(entrada);
    
if(qtd>=12){
    valor = (qtd*1.00);
    
    Console.WriteLine ("As maçãs custam  " + valor );
    }
      
else{
   valor = (qtd*1.30);
   Console.WriteLine ("As maçãs custam  " + valor );
}
    
  }



}