using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circlemover : MonoBehaviour
{
    bool ifSpaceIsPressed;
    bool ifRightIsPressed;
    bool ifUpIsPressed;
    bool ifDownIsPressed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // bool ifSpaceIsPressed = Input.GetKeyDown(KeyCode.Escape);

        Vector3 newRightPosition = transform.position + Vector3.right * 0.001f;

        Vector3 newUpPosition = transform.position + Vector3.up * 0.1f;

        Vector3 newDownPosition = transform.position + Vector3.up * -0.1f;




        bool ifRightIsPressed = Input.GetKey(KeyCode.RightArrow);
        
        if (ifRightIsPressed == true)
        {
            transform.position = newRightPosition;
        }


        bool ifUpIsPressed = Input.GetKeyUp(KeyCode.UpArrow);

        if (ifUpIsPressed == true)
        {
            transform.position = newUpPosition;
        }

        bool ifDownIsPressed = Input.GetKeyDown(KeyCode.DownArrow);
       if (ifDownIsPressed == true)
        {
            transform.position = newDownPosition;
        }
    }
}
