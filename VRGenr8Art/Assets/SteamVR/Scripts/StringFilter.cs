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
        string cube = "cube";

        //scale...
        string scaleinX = "scale X";
        string scaleinY = "scale Y";
        string scaleinZ = "scale Z";

        //move...
        string moveLeft = "move left";
        string moveRight = "move right";
        string moveUp = "move up";
        string moveDown = "move down";
        string moveForward = "move forward";
        string moveBackward = "move backward";

        //Colors
        string red = "red";
        string yellow = "yellow";
        string green = "green";
        string orange = "orange";
        string blue = "blue";

        //Rotate
        string rotateX = "rotate X";
        string rotateY = "rotate Y";
        string rotateZ = "rotate Z";

        List<string> arrData;
        public StringFilter()
        {
          arrData  = new List<string>(){ cube, rotateZ, rotateY, rotateX, box, scaleinX, scaleinY, scaleinZ, moveForward, moveBackward, moveLeft, moveRight, moveUp, moveDown, red, yellow, orange, green, blue };
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
