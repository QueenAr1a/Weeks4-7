using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Hero : MonoBehaviour
{
    //AT THE VERY TOP MAKE SURE ITS USING using UnityEngine.UI or it wont work
    public Slider HealthBar;
    public float Maxhealth = 100;
    public float minhealth;
    public float damage;
    public float currenthealth;
    // Start is called before the first frame update
    void Start()
    {
        currenthealth = Maxhealth;
        HealthBar.value = currenthealth / Maxhealth;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnDamageClick()
    {
        currenthealth -= damage;
        HealthBar.value = currenthealth / Maxhealth;

    }

    public void OnHealthChange(float health)
    {
        
    }

}
