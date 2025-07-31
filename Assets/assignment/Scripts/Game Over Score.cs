using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    // setting all the public variables ill need to set for the game
    public GameObject spawner; //this is to attach to the spawner so i can take the tree count
    public treespawner count; //the script that i take the variable from
    public GameObject Dobetter; // these next 3 are different endings enabled using SETACTIVE depending on tree count as end screens
    public GameObject OKIG;
    public GameObject MODEL;
    public TextMeshProUGUI treecoun; // the text objeect to display the score
    
    // Start is called before the first frame update
    void Start()
    {
    //so in start here we are getting access to everything we need to to use the count
    
      spawner = GameObject.Find("Spawner");    //https://docs.unity3d.com/6000.0/Documentation/ScriptReference/GameObject.Find.html
        //this finds the game object in the scene in this case its the spawner
        treespawner count = GetComponent<treespawner>();
        // then im using this to esentailly rip the script from it and label it a variable (count)
        



    }

    // Update is called once per frame
    void Update()
        
    {
        // next im getting the specific variable from the script using this here
        treecoun.text = count.Treecount.ToString();
        //this rips count(the script).Treecount (the variable in it) and displays it using treecoun.text
        if (count.Treecount < 30) 
        {
            //this says if the score is less than 30 display the fail text
            Dobetter.SetActive(true);
        }

        if (count.Treecount > 30 && count.Treecount < 60)
        {
            //if score is between 30 and 60 then display passing grade
            OKIG.SetActive(true);
        }

        if (count.Treecount > 60)
        {
            // if score is above 60 then display above passing grade
            MODEL.SetActive(true);
        }
    }

}
