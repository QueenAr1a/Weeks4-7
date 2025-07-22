using System.Collections;
using System.Collections.Generic;
using System.Xml.Serialization;
using Unity.VisualScripting;
using UnityEngine;

public class Chaser : MonoBehaviour
{

    public Camera gamecam;
  
         public Vector3 newposition;

    public float speed;
    bool ifmouseIsPressed;
    //bool xmaxexceeded = false;
    //bool xminexceeded = false;

    public SpriteRenderer chaserRenderer;


    Vector3 lastclicked = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        ///transform.position = newposition;
        Debug.Log("helloworld");
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 Mousepositioninworldspace = gamecam.ScreenToWorldPoint(Input.mousePosition);
         Mousepositioninworldspace.z = 0f;

        if(Input.GetMouseButtonDown(0))
        {
            lastclicked = Mousepositioninworldspace;
        }

Vector3 start = transform.position;
Vector3 target = lastclicked;
//in strad if input.mouse becasue we want in world space or it throws around
Vector3 directiontomove = target - start;
        transform.position = transform.position + directiontomove * speed;
        ;
        //bool ifRightIsPressed = Input.GetMouseButton(0); 

       // if (ifRightIsPressed == true)
        {
            //transform.position = transform.position + directiontomove * speed;

            Vector3 chaserinscreenspace = gamecam.WorldToScreenPoint(transform.position);
           // Debug.Log("chaser position in screen space")

            float xmin = 0f;
                float xmax = Screen.width;
                float ymin = 0f;
            float ymax = Screen.height;

            //If chaser's x value is less than the xMin
            //If chaser's x value is greater than the xMax
            //If chaser's y value is less than the yMin
            //If chaser's y value is greater than the yMax
            //THEN:
            //Change the colour of the sprite to be red


            //if (transform.position.x > 1920) ;
            // {
            //   bool xmaxexceeded = true;
            // }

            // if(transform.position.x < 0);
            //  {
            //      bool xminexceeded = true;
            //  }

            bool xmaxexceeded = chaserinscreenspace.x >= xmax - 50;
            bool xminexceeded = chaserinscreenspace.x <= xmin + 50;
            Debug.Log("xMaxExceeded = " + xmaxexceeded.ToString());
            Debug.Log("xMinExceeded = " + xminexceeded.ToString());
            if (xmaxexceeded || xminexceeded)
            {
                chaserRenderer.color = Color.red;
            }
            else
            {
                chaserRenderer.color = Color.white;
            }
        }
    }
}
