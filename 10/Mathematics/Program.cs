using System;

namespace Mathematics {
	class Program {
		static void Main(string[] args) {
			Console.WriteLine(Sum(3, Multiply(7, 9)));
			Console.ReadLine();
		}
        static int Multiply(int a,int b)
        {
            return a * b;
        
        }
        static int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
