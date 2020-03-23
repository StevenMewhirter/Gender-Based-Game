using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Chapter2Scene4 : MonoBehaviour
{
    //sets up a list of Robin's Speech Buttons - SD
    public Button[] RobinSpeech;
    //sets up a private lists of Unity Actions - SD
    private UnityAction[] RobinSpeechfunctionsToCall;
    //sets up a list of Katie's Speech Buttons - SD
    public Button[] KatieSpeech;
    //sets up a private list of Unity Actions - SD
    private UnityAction[] KatieSpeechfunctionsToCall;
    //sets up a public list of textures to convey Robin's emotions - SD
    public Texture[] RobinEmotions;
    //sets up a public list of textures to convey Katie's emotions - SD
    public Texture[] KatieEmotions;
    //sets up a GameObject to display the Image Of Katie -SD
    public GameObject ImageOfKatie;
    //sets up a GameObject for the transparent text box - SD
    public GameObject Transparent;
    //sets up a GameObject to display the image of Robin - SD
    public GameObject ImageOfRobin;
    //Sets up a public raw image variable for Robin - SD
    public RawImage Robin;
    //Sets up a public raw image variable for Katie - SD
    public RawImage Katie;
    void Start()
    {
        //Sets all the Robin Speech Boxes to be deactivated - SD
        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            RobinSpeech[responseIndex].gameObject.SetActive(false);
        }

        //Sets all the Katie Speech Boxes to be deactivated - SD
        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            KatieSpeech[responseIndex].gameObject.SetActive(false);
        }

        Katie.gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        RobinSpeech[0].gameObject.SetActive(true);

        //Declares the functions that will be called when each button in the 
        //list of Katie's speech bubbles is pressed -SD
        KatieSpeechfunctionsToCall = new UnityAction[]
        {
           RobinSpeech2
        };
        //Declares the functions that will be called when each button in the 
        //list of Robin's speech bubbles is pressed -SD
        RobinSpeechfunctionsToCall = new UnityAction[]
      {
        KatieSpeech1,
        RobinSpeech2
      };

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            AddListenerToKatieSpeech(KatieSpeech[responseIndex], KatieSpeechfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            AddListenerToRobinSpeech(RobinSpeech[responseIndex], RobinSpeechfunctionsToCall[responseIndex]);
        }
    }
    private void AddListenerToKatieSpeech(Button KatieSpeech, UnityEngine.Events.UnityAction KatieSpeechfunctionsToCall)
    {
        KatieSpeech.onClick.AddListener(KatieSpeechfunctionsToCall);
    }

    private void AddListenerToRobinSpeech(Button RobinSpeech, UnityEngine.Events.UnityAction RobinSpeechfunctionsToCall)
    {
        RobinSpeech.onClick.AddListener(RobinSpeechfunctionsToCall);
    }

    void KatieSpeech1()
    {
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[0].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[0].gameObject.SetActive(false);
    }

    void RobinSpeech2()
    {
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        KatieSpeech[0].gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        RobinSpeech[1].gameObject.SetActive(true);
    }
}
