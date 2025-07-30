using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class treespawner : MonoBehaviour
{
    public Slider FuelBar; // most of these explain themselves but ill do it to, this is getting the fuel slider
    public float Maxfuel = 100; //setting sliders macx fuel and making it a flaat
    public float minfuel;// float for min fuel
    public float fueltake; // float for fuel take
    public float currentfuel;// 
    public GameObject prefabToSpawn; // this is the tree for the spawner to spawn
    public float Treecount; // this is a float to count the number of trees spawned
    bool treespawn = false; // this sets the variable tree spawn to false so its not just keep spawning trees
    public float timer = 0; // just a timer to count the amount of time passed
    bool gamestateon = true;// lets all the game code run
    public GameObject Panel; // gets the game over panel for reference
    // using this to actually get the trees to spawn
    // Start is called before the first frame update
    void Start()
    {
        currentfuel = Maxfuel;
        // sets the current fuel in the machine to be equal to max fuel
        FuelBar.value = currentfuel / Maxfuel;
        //makes the fuel bar reflect it
        Treecount = 0; // setting tree count to 0
    }

    // Update is called once per frame
    void Update()
    {
        // starts the timer
        timer += Time.deltaTime;
       
        if (gamestateon == true) // basically says if the game state is true then run the game code
        {


            

            if (treespawn == true)
            {
                //if the variable tree spawn is set true (happens when you click the button) then spawn a tree
                GameObject spawnedtree = Instantiate(prefabToSpawn, transform.position, Quaternion.identity);
                // this gets the tree and spawns it at teh position of the spawner 
                Destroy(spawnedtree, 10);
                // destroys tree after 10 seconds
                treespawn = false;
                //sets tree spawn back to false so it doesnt spawn another one
            }
        }
        // if timer is up then it sets the game state to false (stops running game) and shows the game endscreen)
        if (timer > 30)
        {
            gamestateon = false;
            Panel.SetActive(true);
        }
        
    }


        
    public void OnTreeSpawn() // this is maped so its only used when the tree spawn is clicked
    {

        if (currentfuel > minfuel) // to make sure you have fuel
        {
           
            treespawn = true; //then spawns 1 tree
            currentfuel -= fueltake; //takes away some fuel
            FuelBar.value = currentfuel / Maxfuel; //makes the fuel bar refelct that
            Treecount += 1; // adds to the tree count
        }


    }

    public void OnRefuel() // for it refuel is pressed
    {
        if (gamestateon == true) 
        {
            //makes current fuel equal to make fuel
            currentfuel = Maxfuel;
            FuelBar.value = currentfuel / Maxfuel;//makes bar reflect

        }
    }

}
