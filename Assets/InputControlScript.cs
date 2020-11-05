using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputControlScript : MonoBehaviour
{

    public GameObject upCube;
    public GameObject downCube;
    public GameObject leftCube;
    public GameObject rightCube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        //Up arrowkkey
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            print("Up arrow key is pressed");
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0,1,0);
        }
        else if(Input.GetKeyUp(KeyCode.UpArrow))
        {
            print("Up arrow key is released");
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //W key
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("W key is pressed");
            upCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.W))
        {
            print("W key is released");
            upCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //Down arrowkey
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            print("Down arrow key is pressed");
            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            print("Down arrow key is released");
            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //S key
        if (Input.GetKeyDown(KeyCode.S))
        {
            print("S key is pressed");
            downCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            print("S key is released");
            downCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //Left arrowkey
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("Left arrow key is pressed");
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            print("Left arrow key is released");
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //A key
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("A key is pressed");
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            print("A key is released");
            leftCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //Right arrowkey
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("Right arrow key is pressed");
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            print("Right arrow key is released");
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }

        //Right arrowkey
        if (Input.GetKeyDown(KeyCode.D))
        {
            print("D key is pressed");
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(0, 1, 0);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            print("D key is released");
            rightCube.GetComponent<MeshRenderer>().material.color = new Color(1, 1, 1);
        }
    }
}
