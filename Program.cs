using System;

namespace ExercicioEquacao2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      double a, b, c, delta, x1, x2;

      Console.WriteLine("- - - Equação do segundo grau - - -");
      Console.WriteLine("Digite o valor das letras a, b, c.\n");
      Console.Write("(a): ");
      a = double.Parse(Console.ReadLine());
      Console.Write("(b): ");
      b = Double.Parse(Console.ReadLine());
      Console.Write("(c): ");
      c = Double.Parse(Console.ReadLine());

      delta = Math.Pow(b, 2) - 4 * a * c;
      x1 = (-b + Math.Sqrt(delta)) / (2 * a);
      x2 = (-b - Math.Sqrt(delta)) / (2 * a);


      if (a == 0)
      {
        Console.WriteLine("Não é uma equação de segundo grau!");
      }
      else if (delta < 0)
      {
        Console.WriteLine($"Como delta é igual a {delta:N2} a equação não possui raízes reais!");
      }
      else
      {
        Console.WriteLine($"\nO valor de delta é: {delta:N2}");
        Console.WriteLine($"x¹ = {x1:N2}");
        Console.WriteLine($"x² = {x2:N2}");
      }
        
    }
  }
}
