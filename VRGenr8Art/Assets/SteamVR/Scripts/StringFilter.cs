using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.SteamVR.Scripts
{
    public class StringFilter
    {
        //cube
        string box = "box";

        //scale...
        string scaleinX = "scale in x";
        string scaleinY = "scale in Y";
        string scaleinZ = "scale in Z";

        //move...
        string moveLeft = "move left";
        string moveRight = "move right";
        string moveUp = "move up";
        string moveForward = "move forward";

        //Colors
        string red = "red";
        string yellow = "yellow";
        string green = "green";
        string orange = "orange";
        string blue = "blue";

        List<string> arrData;
        public StringFilter()
        {
          arrData  = new List<string>(){box, scaleinX, scaleinY, scaleinZ, moveForward, moveLeft, moveRight, moveUp, red, yellow, orange, green, blue };
        }

        public string DataProcess(string strM)
        {
            string what = "";
            int index = -1;
            int l = 1;
            foreach(string s in arrData)
            {
                index = strM.IndexOf(s);
                if(index != -1)
                {
                    l = s.Length;
                    what  = strM.Substring(index, l);
                }
            }
            return what;
        }
    }
}
