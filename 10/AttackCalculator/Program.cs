using System;

namespace AttackCalculator {
	class Program {
		static void Main(string[] args) {
			double attack1 = GetReducedAttack(50, 100, 20); // 10
			double attack2 = GetReducedAttack(20, 80, 60);  // 15
			Console.WriteLine("Сила атаки монстра 1: " + attack1);
			Console.WriteLine("Сила атаки монстра 2: " + attack2);

			Console.ReadLine();
		}

		static double GetReducedAttack(double health, double maxHealth, double maxAttack) {
		}
	}
}
