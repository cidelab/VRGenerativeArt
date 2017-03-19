using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makeCube : MonoBehaviour
{

    // Use this for initialization
    public float xSize = 1;
    public float ySize = 1;
    public float zSize = 1;

    public float xPos = 1;
    public float yPos = 1;
    public float zPos = 1;

    private float span = 3;
    private Color clr = new Color(1, 1, 1);
    private GameObject myCube;
    
    public float Red = 1f;
    public float Green = 1f;
    public float Blue = 1f;

    public float rotX = 0;
    public float rotY = 0;
    public float rotZ = 0;

    Assets.SteamVR.Scripts.StringFilter sf = new Assets.SteamVR.Scripts.StringFilter();
    public string inputString = "";

    void Start()
    {
        if (sf.DataProcess("hey build me a box tra la la la") == "box")
        {
            myCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        }
    }

    void Update()
    {

            //update parameters...
            UpdateParameters();
        
            float r = checkMinMax(Red);
            float g = checkMinMax(Green);
            float b = checkMinMax(Blue);

            myCube.transform.localScale = new Vector3(xSize, ySize, zSize);
            myCube.transform.position = new Vector3(xPos, yPos, zPos);
            myCube.transform.Rotate(Vector3.right, rotX);
            myCube.transform.Rotate(Vector3.left, rotZ);
            myCube.transform.Rotate(Vector3.up, rotY);
            myCube.GetComponent<Renderer>().material.color = clr;
    }

    public void setString(string newStr)
    {
        inputString = newStr;
        Debug.Log(inputString);
    }
    private void UpdateParameters()
    {
        switch (sf.DataProcess(inputString))
        {
            case "scale in x":
                xSize = xSize + span;
                break;
            case "scale in y":
                ySize = ySize + span;
                break;
            case "scale in z":
                zSize = zSize + span;
                break;
            case "move left":
                zPos = zPos + span;
                break;
            case "move right":
                zPos = zPos + span;
                break;
            case "move forward":
                xPos = xPos + span;
                break;
            case "move up":
                yPos = yPos + span;
                break;
            case "red":
                clr = Color.red;
                break;
            case "yellow":
                clr = Color.yellow;
                break;
            case "green":
                clr = Color.green;
                break;
            case "orange":
                clr = Color.green;
                break;
            case "blue":
                clr = Color.blue;
                break;
        }
        inputString = "";
    } 

    private float checkMinMax(float r)
    {
        if (r < 0) {
            r = 0f;
        }
        if (r > 1) {
            r = 1f;
        }

        return r;
    }
}
