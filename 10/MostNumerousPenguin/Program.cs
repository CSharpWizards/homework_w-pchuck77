using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostNumerousPenguin {
	class Program {
		static void Main(string[] args) {
			string mostNumerous1 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Emperor Penguin", "Little Penguin" });
			string mostNumerous2 = GetMostNumerous(new string[] { "Emperor Penguin", "Macaroni Penguin", "Little Penguin", "Emperor Penguin", "Macaroni Penguin", "Macaroni Penguin", "Little Penguin" });
			Console.WriteLine(mostNumerous1);
			Console.WriteLine(mostNumerous2);

			Console.ReadLine();
		}

		static string GetMostNumerous(string[] penguins) {
            int emperorCount = 0;
            int macaroniCount = 0;
            int littleCount = 0;
            for (int i = 0; i <penguins.Length ; i++)
            {
                if (penguins[i]== "Emperor Penguin")
                {
                    emperorCount = emperorCount + 1;
                }
                else if (penguins[i] == "Macaroni Penguin")
                {
                    macaroniCount = macaroniCount + 1;
                }
                else
                {
                    littleCount = littleCount + 1;
                }
            }
            if (emperorCount> macaroniCount && emperorCount> littleCount)
            {
                return "Emperor";
            }
            else if (macaroniCount> littleCount)
            {
                return "Macaroni";
            }
            else
            {
                return "Little";
            }
             
		}
	}
}
