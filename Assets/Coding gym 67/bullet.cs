using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    private Vector3 start;
    //position of spawn
    private Vector3 end;
    // position of the mouse when spawned
    private float timepassed;
     public float duration;
    Vector3 lastclicked = Vector3.zero;
    // Start is called before the first frame update
    void Start()
    {
        start = transform.position;
        end = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        end.z = 0;
        Destroy(gameObject, duration);
    }

    // Update is called once per frame
    void Update()
    {
        timepassed += Time.deltaTime / duration;

        Vector3 output = Vector3.Lerp(start, end, timepassed);
        transform.position = output;
    }
}
