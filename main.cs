using System;

class Program {
   public static void Main (string[] args) {
    Console.WriteLine ("Hello World");
string entrada;
    Double m1, valor ;
    
    Console.WriteLine("Digite quantidade de maçãs");
  
    entrada = Console.ReadLine();


   m1 =  Double.Parse(entrada);
    
if(m1>=12){
    valor = (m1*1.00);
    
    Console.WriteLine ("As maçãs custam  " + valor );
    }
      
else{
   valor = (m1*1.30);
   Console.WriteLine ("As maçãs custam  " + valor );
}
    
  }



}