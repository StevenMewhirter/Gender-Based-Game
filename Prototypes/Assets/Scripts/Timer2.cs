using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer2 : MonoBehaviour
{//sets the timer to 30 seconds
    public float timer = 30f;
    //declares a Game Object called TimerUI
    public GameObject TimerUI;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //starts the countdown of the timer
        timer -= Time.deltaTime;


        //if the timer reaches 0'
        if (timer <= 0)
        {
            Destroy(gameObject);
        }
    }
}
