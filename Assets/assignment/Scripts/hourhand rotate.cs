using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hourhandrotate : MonoBehaviour
{
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 hourhand = transform.eulerAngles;
        // just giving the vector 3 its variables through transform 
        hourhand.z += -12 * Time.deltaTime;
        // making it do one whole rotation in 30 seconds (12 degrees persecond) using delta time for consistancy
        transform.eulerAngles = hourhand;
       
    }
}
