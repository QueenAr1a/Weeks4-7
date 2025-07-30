using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class treespawner : MonoBehaviour
{
    public Slider FuelBar;
    public float Maxfuel = 100;
    public float minfuel;
    public float fueltake;
    public float currentfuel;
    public GameObject prefabToSpawn;
    public float Treecount;
    bool treespawn = false;
    public float timer = 0;
    bool gamestateon = true;
    public GameObject Panel;
    // using this to actually get the trees to spawn
    // Start is called before the first frame update
    void Start()
    {
        currentfuel = Maxfuel;
        FuelBar.value = currentfuel / Maxfuel;
        Treecount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (gamestateon == true)
        {


            

            if (treespawn == true)
            {
                GameObject spawnedtree = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                // this gets the tree and spawns it at teh position of the spawner 
                Destroy(spawnedtree, 10);
                treespawn = false;
            }
        }

        if (timer > 30)
        {
            gamestateon = false;
            Panel.SetActive(true);
        }
        
    }


        
    public void OnTreeSpawn()
    {

        if (currentfuel > minfuel)
        {
           
            treespawn = true;
            currentfuel -= fueltake;
            FuelBar.value = currentfuel / Maxfuel;
            Treecount += 1;
        }


    }

    public void OnRefuel()
    {
        if (gamestateon == true)
        {
            currentfuel = Maxfuel;
        }
    }

}
