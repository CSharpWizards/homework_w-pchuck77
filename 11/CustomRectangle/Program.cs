using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomRectangle {
	class Program {
		static void Main(string[] args) {
			Rectangle rect1 = new Rectangle();
			rect1.x = 2;
			rect1.y = 2;
			rect1.width = 3;
			rect1.height = 3;
			rect1.symbol = "C";
			rect1.Draw();

			Rectangle rect2 = new Rectangle();
			rect2.x = 7;
			rect2.y = 2;
			rect2.width = 5;
			rect2.height = 4;
			rect2.symbol = "#";
			rect2.Draw();

			Console.ReadLine();
		}
	}
    public class Rectangle
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public string symbol;
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            for (int i = 0; i < width; i++)
            {
                Console.Write(symbol);
            }
            for (int i = 1; i < height-1; i++)
            {
                Console.SetCursorPosition(x, y+i);
                Console.Write(symbol);
                Console.SetCursorPosition(x + width-1, y + i);
                Console.Write(symbol);
            }
            Console.SetCursorPosition(x, y + height-1);
            for (int i = 0; i < width ; i++)
            {
                Console.Write(symbol);
            }
        }

    }
}
