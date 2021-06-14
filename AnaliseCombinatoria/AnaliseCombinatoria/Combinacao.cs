using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseCombinatoria
{
	public class Combinacao: AnaliseCombinatoria
	{

		public override double CalculaOperacao(int N, int P = 0)
		{
			return AnaliseCombinatoria.Fatorial(N) /(AnaliseCombinatoria.Fatorial(P) * AnaliseCombinatoria.Fatorial(N - P));
		}
	}
}
