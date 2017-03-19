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
        string scaleinY2 = "scale why";
        string scaleinZ = "scale Z";
        string scaleinZ2 = "scale Zeed";
        string bigger = "big";
        string small = "small";

        //move...
        string moveLeft = "move left";
        string moveRight = "move right";
        string moveUp = "move up";
        string moveUp2 = "up";
        string moveDown = "move down";
        string moveDown2 = "down";
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
        string rotateY2 = "rotate why";
        string rotateZ = "rotate Z";
        string rotate = "rotate";

        List<string> arrData;
        public StringFilter()
        {
          arrData  = new List<string>(){ cube, rotateZ, rotateY, rotateX, box, rotateY2, scaleinX, scaleinY, scaleinY2, small, scaleinZ, moveUp2, scaleinZ2, moveForward, bigger, moveDown2, rotate, moveBackward, moveLeft, moveRight, moveUp, moveDown, red, yellow, orange, green, blue };
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
