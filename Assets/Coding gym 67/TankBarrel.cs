using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankBarrel : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Mousepositioninworldspace = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Mousepositioninworldspace.z = 0f;

        Vector3 start = transform.position;
        Vector3 end = Mousepositioninworldspace;
        Vector3 direction = end - start;

        transform.up = direction;
    }
}
