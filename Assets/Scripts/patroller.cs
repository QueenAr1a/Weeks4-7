using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class patroller : MonoBehaviour
{
    public Vector3 start;
    public Vector3 end;
    public float current;
    public float duration;
    bool moveforward = true;
    // Start is called before the first frame update
    void Start()
    {
  

    }

    // Update is called once per frame
    void Update()
    {

        if (moveforward)
        {
            current += Time.deltaTime;
            if (end == transform.position)
            {
                moveforward = false;
            }
        }
        else
        {
           
           current -= Time.deltaTime / 3f;

            if (start == transform.position)
            {
                moveforward = true;
            }
        }
        //current += Time.deltaTime;
        //this makes it move to the position over a amount of time corrisponding to delta time
        Vector3 output = Vector3.Lerp(start, end, current);
        transform.position = output;
        //this will move the output from the lerp to the object

    }
}
