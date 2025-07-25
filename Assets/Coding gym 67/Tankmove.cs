using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tankmove : MonoBehaviour
{
    bool right;
    bool left;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newLPos = transform.position + Vector3.right * -1f* Time.deltaTime;

        Vector3 newRPos = transform.position + Vector3.right * 1f * Time.deltaTime;

        bool right = Input.GetKey(KeyCode.D);

        bool left = Input.GetKey(KeyCode.A);

        if (right == true)
        {
            transform.position = newRPos;
        }


        if (left == true)
        {
            transform.position = newLPos;
        }

    }
}
