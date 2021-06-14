using System;
using System.Collections.Generic;
using System.Text;

namespace AnaliseCombinatoria
{
	public abstract class AnaliseCombinatoria
	{
		public abstract double CalculaOperacao(int N, int P = 0);
		public static double Fatorial (int N)
		{
			if (N == 1 || N==0)
				return 1;

			else
				return N * Fatorial(N - 1);
		}

	}
}
