using System;

namespace AnaliseCombinatoria
{
	class Program
	{
		static void Main(string[] args)
		{
			int X = 0;
			do
			{
				Console.Clear();
				Console.WriteLine("Permutação: 1");
				Console.WriteLine("Arranjo: 2");
				Console.WriteLine("Combinação: 3");
				X = int.Parse(Console.ReadLine());

				OP(X);

				Console.WriteLine("Esc- parar");
				Console.WriteLine("Qualquer tecla- Continuar");
			} while (Console.ReadKey().Key != ConsoleKey.Escape);


		}
		static void OP(int X)
		{
			Calculo EfetuaOperacao= new Calculo();
			int N=0, P=0;
			switch (X)
			{
				case 1:

					Console.WriteLine("Digite N:");
					N = int.Parse(Console.ReadLine());

					Console.WriteLine("A permutação de {0} é {1}", N, EfetuaOperacao.EfetuaOperacao(new Permutacao(), N));	

				break;
				case 2:
					Console.WriteLine("Digite N:");
					N = int.Parse(Console.ReadLine());
					Console.WriteLine("Digite P:");
					P = int.Parse(Console.ReadLine());

					Console.WriteLine("O Arranjo de N: {0} e P: {1} é {2}", N,P,  EfetuaOperacao.EfetuaOperacao(new Arranjo(), N, P));
					break;

				case 3:
					Console.WriteLine("Digite N:");
					N = int.Parse(Console.ReadLine());
					Console.WriteLine("Digite P:");
					P = int.Parse(Console.ReadLine());

					Console.WriteLine("A combinação de N: {0} e P: {1} é {2}", N, P, EfetuaOperacao.EfetuaOperacao(new Combinacao(), N, P));
					break;
					
			}

		}
	}
}
