using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Hello World");

//As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se forem compradas pelo menos 12. Escreva um programa que leia o número de maçãs compradas, calcule e escreva o custo total da compra.

    int m;
    Double c;
    String entrada;

    Console.WriteLine ("Número de maçãs compradas");
    entrada = Console.ReadLine();
    m = Int16.Parse(entrada);
    if (m <= 12)
    {
      c = m * 1.30;
    Console.WriteLine ("Custo Total");  
    }
    else
    {
      if (m >= 12)
      c = m * 1.00;
     Console.WriteLine ("Custo Total"); 
      
    }

    
  }
}