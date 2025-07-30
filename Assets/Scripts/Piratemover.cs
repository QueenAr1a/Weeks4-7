using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Piratemover : MonoBehaviour
{
    bool right;
    bool left;
    bool up;
        bool down;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newUPos = transform.position + Vector3.up * 1f * Time.deltaTime;

        Vector3 newDPos = transform.position + Vector3.up * -1f * Time.deltaTime;

        Vector3 newLPos = transform.position + Vector3.right * -1f * Time.deltaTime;

        Vector3 newRPos = transform.position + Vector3.right * 1f * Time.deltaTime;

        bool right = Input.GetKey(KeyCode.D);

        bool left = Input.GetKey(KeyCode.A);

        bool up = Input.GetKey(KeyCode.W);

        bool down = Input.GetKey(KeyCode.S);

        if (right == true)
        {
            transform.position = newRPos;
        }


        if (left == true)
        {
            transform.position = newLPos;
        }

        if (up == true)
        {
            transform.position = newUPos;
        }
        if (down == true)
        {
            transform.position = newDPos;
        }



    }
}
