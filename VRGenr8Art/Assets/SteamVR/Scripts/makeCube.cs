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

    private GameObject myCube;
    
    public float Red = 1f;
    public float Green = 1f;
    public float Blue = 1f;

    public float rotX = 0;
    public float rotY = 0;
    public float rotZ = 0;

    void Start()
    {
        myCube = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // Update is called once per frame
    //cube

    //scale...
    //scale in X 3 times..
    //scale in Y 2 times...
    //scale scale in Z 1.5 times...

    //move...
    //move left 3, 
    //move right 2,
    //move up 5,

    void Update()
    {
        float r = checkMinMax(Red);
        float g = checkMinMax(Green);
        float b = checkMinMax(Blue);

        myCube.transform.localScale = new Vector3(xSize, ySize, zSize);
        myCube.transform.position = new Vector3(xPos, yPos, zPos);
        myCube.transform.Rotate(Vector3.right, rotX);
        myCube.transform.Rotate(Vector3.left, rotZ);
        myCube.transform.Rotate(Vector3.up, rotY);
        myCube.GetComponent<Renderer>().material.color = new Color(r, g, b, 255);

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
