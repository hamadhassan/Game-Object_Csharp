using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCaseStudy.BL;
using GameCaseStudy.DL;
using GameCaseStudy.UL;
using System.Threading;

namespace GameCaseStudy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GameObject direction = new GameObject();
            GameObjectDL.setIntoGameObjectList(direction);
            while (true)
            {
                Thread.Sleep(100);
                foreach (GameObject game in GameObjectDL.gameObjectsList)
                {
                    game.erase();
                    game.move();
                    GameObjectUL.draw(game.getShape());
                }
                
            }
        }
      
    }
}
