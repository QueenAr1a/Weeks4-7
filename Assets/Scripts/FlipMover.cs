using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FlipMover : MonoBehaviour
{
    public AudioSource moveClickAudioSource;
    public AudioSource stopClickAudioSource;
    public AudioSource flipClickAudioSource;

    public AudioClip stopClickAudioClip;

    public List<AudioClip> flipClickAudioClips;

    public Slider staminaSlider;
    public float maxStamina, minStamina;
    private float currentStamina;
    public float exhaustRate;
    public float exhaustedSpeed;

    public float speed = 3f;
    bool movetrue = false;
    // Start is called before the first frame update
    void Start()
    {
        stopClickAudioSource.clip = stopClickAudioClip;
        currentStamina = maxStamina; 
       
    }

    // Update is called once per frame
    void Update()
    {

       
        if (movetrue == true)
        {
            Vector3 newPosition = transform.position + Vector3.right * speed * Time.deltaTime;

            transform.position = newPosition;
            staminaSlider.value = currentStamina / maxStamina;
            currentStamina -= exhaustRate * Time.deltaTime;

            if (currentStamina < 0 )
            {
                speed = exhaustedSpeed;
            }

        }

    }

    public void Onmoveclick()
    {
        movetrue = true;

        moveClickAudioSource.Play();
    }
    public void Onstopclick()
    {
        movetrue = false;


    }

    public void Onflipclick()
    {
        
        speed *= -1f;
        //takes the clips and randomly selects 1
        // get a number from 0 to the list size and us it
        int randomIndex = UnityEngine.Random.Range(0, flipClickAudioClips.Count);
        //random. range is exclusive, the min is inclusive meaning that it will use
        //the smallest number but max exclusive meaning it uses the number under the max number you put
        AudioClip RandomClip = flipClickAudioClips[randomIndex];
        flipClickAudioSource.PlayOneShot(RandomClip);
    }


}
