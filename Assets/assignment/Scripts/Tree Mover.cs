using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeMover : MonoBehaviour
{
    //this script functions to move the frees after they are spawned
    public Sprite wood;
 //this get s the wood sprite so ican change it in the machine
    public SpriteRenderer Tree;
    //this renders the original tree
    public float speed;
  //just controls how fast if goes through the machine
    // Start is called before the first frame update
    void Start()
    {
        Tree = gameObject.GetComponent<SpriteRenderer>();
       
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * speed * Time.deltaTime;
        //moves the tree to the right by the speed in the inspector every frame
        Vector3 TreeposinScreen = Camera.main.WorldToScreenPoint(transform.position);
        //this makes sure the tree is withing the screen point just making it easoier to work with especially with things like speed and screen.width just lets me track its position

        if(TreeposinScreen.x > Screen.width / 3)
            //this slows down the tree when entering the machine to make it look cooler
        {
            speed = 2;
          
        }


        if (TreeposinScreen.x > Screen.width/1.5)
        {
            Tree.sprite = wood;
            //changes the sprite to the wood from the tree
        }
        if (TreeposinScreen.x > Screen.width / 1.7)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            //changes the wood size (was WAY to big)
        }

        if (TreeposinScreen.x > Screen.width / 1.25f)
        {
            speed = 8f;
            //speeds it back up after leaving the machine
        }
    }
}
