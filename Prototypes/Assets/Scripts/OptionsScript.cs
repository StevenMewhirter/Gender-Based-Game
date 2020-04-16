using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsScript : MonoBehaviour
{
    private bool audioSetting = true;
    private bool vibrateSetting = true;
    private bool colourBlindSetting = false;

    [SerializeField]
    private Button audioOn, audioOff, vibrateOn, vibrateOff, colourBlindOn, colourBlindOff, slowSpeed, mediumSpeed, fastSpeed;

    // 1 = slow, 2 = medium, 3 = fast
    public static int textSpeedSetting = 2;

    void Awake()
    {
         
    }


    public void ChangeAudioSettingsON()
    {
        audioSetting = true;
        audioOn.enabled = false;
        audioOff.enabled = true;
        AudioListener.volume = 0.5f;
    }

    public void ChangeAudioSettingsOFF()
    {
        audioSetting = false;
        audioOff.enabled = false;
        audioOn.enabled = true;
        AudioListener.volume = 0f;
    }

    public void ChangeVibrateSettingsON()
    {
        vibrateSetting = true;
        vibrateOn.enabled = false;
        vibrateOff.enabled = true;
    }

    public void ChangeVibrateSettingsOFF()
    {
        vibrateSetting = false;
        vibrateOff.enabled = false;
        vibrateOn.enabled = true;
    }

    public void ChangeColourBlindSettingON()
    {
        colourBlindSetting = true;
        colourBlindOn.enabled = false;
        colourBlindOff.enabled = true;
    }

    public void ChangeColourBlindSettingOFF()
    {
        colourBlindSetting = false;
        colourBlindOff.enabled = false;
        colourBlindOn.enabled = true;
    }

    public void TextSlowSpeed()
    {
        slowSpeed.enabled = false;
        mediumSpeed.enabled = true;
        fastSpeed.enabled = true;

        textSpeedSetting = 1;
    }

    public void TextMediumSpeed()
    {
        slowSpeed.enabled = true;
        mediumSpeed.enabled = false;
        fastSpeed.enabled = true;

        textSpeedSetting = 2;
    }

    public void TextFastSpeed()
    {
        slowSpeed.enabled = true;
        mediumSpeed.enabled = true;
        fastSpeed.enabled = false;

        textSpeedSetting = 3;
    }
}
