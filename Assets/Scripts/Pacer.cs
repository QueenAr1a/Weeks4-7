using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacer : MonoBehaviour
{
    public float speed;
    //public Camera gameCamera;
    //can be used instead of main camera if multiple cameras but cant be used in a prefab
    /// </summary>

    private int direction = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * direction;

        Vector3 pacerPositionInScreenSpace = Camera.main.WorldToScreenPoint(transform.position);

        if (pacerPositionInScreenSpace.x > Screen.width)
        {
            direction *= -1;
        }
        if (pacerPositionInScreenSpace.x < 0)
        {
            direction *= -1;
        }


    }
}