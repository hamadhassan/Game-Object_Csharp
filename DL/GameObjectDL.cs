using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCaseStudy.BL;

namespace GameCaseStudy.DL
{
    internal class GameObjectDL
    {
        public static List<GameObject> gameObjectsList=new List<GameObject>();

        public static void setIntoGameObjectList(GameObject newSetting)
        {
            gameObjectsList.Add(newSetting);
        }
    }
}
