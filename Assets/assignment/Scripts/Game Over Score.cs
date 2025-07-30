using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOverScore : MonoBehaviour
{
    public GameObject spawner;
    public treespawner count;

    public TextMeshProUGUI treecoun;
    
    // Start is called before the first frame update
    void Start()
    {
    
      spawner = GameObject.Find("Spawner");    //https://docs.unity3d.com/6000.0/Documentation/ScriptReference/GameObject.Find.html
        treespawner count = GetComponent<treespawner>();
        



    }

    // Update is called once per frame
    void Update()
    {
        treecoun.text = count.Treecount.ToString();
            
    
    }

}
