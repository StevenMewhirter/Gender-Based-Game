using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{

    private static Sound time = null;
    private AudioSource sound;

    private void Awake()
    {
        if (time == null)
        {
            time = this;
         
            return;
        }
        if (time == this) return;
        Destroy(gameObject);
    }

    void Start()
    {
        sound = GetComponent<AudioSource>();
        sound.Play();
    }
}    