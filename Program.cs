using System;

namespace senai.operadores.ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Média de preço dos produtos");

            Console.WriteLine("informe o preço do 1° produto");
            float prod1 = float.Parse(Console.ReadLine());

            Console.WriteLine("informe o preço do 2° produto");
            float prod2 = float.Parse(Console.ReadLine());

            Console.WriteLine("informe o preço do 3° produto");
            float prod3 = float.Parse(Console.ReadLine());

            Console.WriteLine("informe o preço do 4° produto");
            float prod4 = float.Parse(Console.ReadLine());

            Console.WriteLine("informe o preço do 5° produto");
            float prod5 = float.Parse(Console.ReadLine());

            float total = ( prod1 + prod2 + prod3 + prod4 + prod5 );

            Console.WriteLine("O total da compra é: " + total);
            
            float media = (float)( total/ 5 );

            Console.WriteLine("O Gasto médio é: " + media);
        }
    }
}
