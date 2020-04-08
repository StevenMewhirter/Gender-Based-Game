using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsScript : MonoBehaviour
{
    public bool audioSetting;
    public bool vibrateSetting;
    public bool colourBlindSetting;

    // 1 = slow, 2 = medium, 3 = fast
    public int textSpeedSetting;

    public static GameObject audioManager;

    // Start is called before the first frame update
    void awake()
    {
        audioSetting = true;
        vibrateSetting = true;
        colourBlindSetting = false;
        textSpeedSetting = 2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeAudioSettings()
    {
        if (audioSetting == false)
        {
            audioSetting = true;
        }
        else
        {
            audioSetting = false;
        }
    }

    void ChangeVibrateSettings()
    {
        if (vibrateSetting == false)
        {
            vibrateSetting = true;
        }
        else
        {
            vibrateSetting = false;
        }
    }
}
