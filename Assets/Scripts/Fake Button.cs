using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeButton : MonoBehaviour
{
    public float hoveringdis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 MouseWorld = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            MouseWorld.z = 0;
            float distancefrombutton = Vector3.Distance(transform.position, Input.mousePosition);
        
                 if (distancefrombutton < hoveringdis)
                {
                    Debug.Log("We have clicked the button!");
                }
        }
    }
}
