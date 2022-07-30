using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaseStudy.UL
{
    internal class GameObjectUL
    {
        public static void draw(char[,] shape)
        {
            for(int x = 0; x < shape.GetLength(0); x++)
            {
                for(int y = 0; y < shape.GetLength(1); y++)
                {
                     Console.Write(shape[x,y]);
                }
                Console.WriteLine();
            }
        }
    }
}
