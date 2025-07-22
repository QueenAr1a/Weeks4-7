using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMover : MonoBehaviour
{
    // class variables here!!
    
    public float speed;
    public float xmax;
    public float xmin;


    // Start is called before the first frame update
    void Start()
    {
        //Vector3: 3 Coords X, y, z.  0, 20, 25
        // type   Nameofvariable =
        // Vector3 newPosition = new Vector3(transform.position.x, transform.position.y, transform.position.z)
       
        

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position + Vector3.right * speed;

        transform.position = newPosition;

        bool ifsquareisoutofbounds = transform.position.x > xmax || transform.position.x < xmin;

        if (ifsquareisoutofbounds)
        {
            speed = speed * -1;
            //speed = -speed
            //speed *= -1
        }

        
    }
}
