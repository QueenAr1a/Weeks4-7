using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minutehand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 minutehand = transform.eulerAngles;
        minutehand.z += -0.12f;
        transform.eulerAngles = minutehand;
    }
}
