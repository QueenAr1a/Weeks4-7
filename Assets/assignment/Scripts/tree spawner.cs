using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treespawner : MonoBehaviour
{
    public GameObject prefabToSpawn;
    // using this to actually get the trees to spawn
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool leftclick = Input.GetMouseButtonDown(0);
        //this just tests if the left mouse button has been clicked so it knows to spawn a tree
        if (leftclick)
        {
            GameObject spawnedtree = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
            // this gets the tree and spawns it at teh position of the spawner 
            Destroy(spawnedtree, 10);
           //this destroys the tree after 20 seconds i know that seems long but i had it at 10 and on lower frame rates it would tend to not finish before disappearing
        }
    }
}
