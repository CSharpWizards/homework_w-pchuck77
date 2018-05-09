using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomPoint {
	class Program {
		static void Main(string[] args) {
			Point point1 = new Point();
			point1.x = 2;
			point1.y = 5;
			point1.symbol = "C";
			point1.Draw();

			Point point2 = new Point();
			point2.x = 6;
			point2.y = 3;
			point2.symbol = "#";
			point2.Draw();

			Console.ReadLine();
		}
	}
}
