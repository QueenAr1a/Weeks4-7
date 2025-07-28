using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spritechanger : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    //was a script used to mess around with to figure out how to change the tree not used in final draft
  
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spriteRenderer.sprite = newSprite;
        }
    }
}
