using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;

public class Scene5Script : MonoBehaviour
{

    public DiaryTexts transitionScreen;
    public Button transitionImage;
    bool canClick = false;

    public Button[] buttons;
    private UnityAction[] functionsToCall;

    // public Button[] RobinsSpeech;
    //  private UnityAction[] RobinsFunction;

    // public Button[] KatieSpeech;
    // private UnityAction[] KatieNormalFunction;

    //  public Button[] Choice;
    //  private UnityAction[] ChoiceFunctions;

    //  public Button[] KatieChoice;
    // private UnityAction[] KatieChoiceFunctions;

    public GameObject KTImage;
    public GameObject RobinsImage;
    public GameObject BgBox;

    public Texture KatieNeutral;
    public Texture KatiesSad;
    public Texture KatiesHappy;
    public Texture KatieAnger;
    public Texture RobinNeutral;
    public Texture RobinsSad;

    public RawImage MainChar;
    public RawImage Robins;

    public Animator RobinAnimator;
    public Animator KatieAnimator;
    public Animator KatieAltAnimator;
    public Animator RobinAltAnimator;

    void Start()
    {

        for (int responseIndex = 0; responseIndex < buttons.Length; ++responseIndex)
        {
            buttons[responseIndex].gameObject.SetActive(false);
        }

        functionsToCall = new UnityAction[]
        {
            Choice1, KatSpeech, RobSpeech, RobSpeech1, KatSpeech1, RobSpeech2, KatSpeech2,
            RobSpeech3, Choice2, KatSpeech3, RobSpeech4, Choice3, KatSpeech4, RobSpeech5,
            KatSpeech5, RobSpeech6
        };

        StartCoroutine(transitionPanel());

        Button Transition = transitionImage.GetComponent<Button>();
        Transition.onClick.AddListener(StartSpeech);

        //took this out to add the transition screen. it is being called exactly above this line. (E.A.)
        //StartSpeech(); 

        //Robins = (RawImage)RobinsImage.GetComponent<RawImage>();
        //Robins.texture = (Texture)RobinsSad;

        for (int responseIndex = 0; responseIndex < buttons.Length - 1; ++responseIndex)
        {
            AddListenerToButton(buttons[responseIndex], functionsToCall[responseIndex]);
        }

    }


    private void AddListenerToButton(Button button, UnityEngine.Events.UnityAction functionToCall)
    {
        button.onClick.AddListener(functionToCall);
    }


    void StartSpeech()
    {
        if (canClick) // added this because of the connection with the transition screen (E.A.)
        {
            // MainChar.gameObject.SetActive(false);

            // BgBox.gameObject.SetActive(false);
            transitionScreen.gameObject.SetActive(false); // added this because of the connection with the transition screen (E.A.)

            buttons[0].gameObject.SetActive(true);
            Robins.gameObject.SetActive(true);

            //Robins = (RawImage)RobinsImage.GetComponent<RawImage>();
            //Robins.texture = (Texture)RobinsSad;

            RobinAnimator.SetBool("RobinNeutral", true);
        }
    }

    void Choice1() 
    {
        buttons[1].gameObject.SetActive(true);
        MainChar.gameObject.SetActive(true);

        BgBox.gameObject.SetActive(true);
        buttons[0].gameObject.SetActive(false);
        Robins.gameObject.SetActive(false);
        //// RobinsAnimator.SetBool("RobinsNeutral", false);

        //MainChar = (RawImage)KTImage.GetComponent<RawImage>();
        //MainChar.texture = (Texture)KatieNeutral;

        KatieAnimator.SetBool("KatieNeutral", true);
    }

    void KatSpeech()
    {
        buttons[1].gameObject.SetActive(false);
        BgBox.gameObject.SetActive(false);
        buttons[2].gameObject.SetActive(true);
        // RobinsSpeech.gameObject.SetActive(false);

        Robins.gameObject.SetActive(false);

        //MainChar = (RawImage)KTImage.GetComponent<RawImage>();
        //MainChar.texture = (Texture)KatiesSad;
        KatieAnimator.SetBool("KatiesSad", true);
    }

    void RobSpeech()
    {
        buttons[2].gameObject.SetActive(false);
        buttons[3].gameObject.SetActive(true);
        MainChar.gameObject.SetActive(false);
        Robins.gameObject.SetActive(true);

        //Robins = (RawImage)RobinsImage.GetComponent<RawImage>();
        //Robins.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);
    }

    void RobSpeech1()
    {
        buttons[4].gameObject.SetActive(true);
        buttons[3].gameObject.SetActive(false);
    }

    void KatSpeech1()
    {
        buttons[5].gameObject.SetActive(true);
        buttons[4].gameObject.SetActive(false);
        MainChar.gameObject.SetActive(true);
        Robins.gameObject.SetActive(false);

        //MainChar = (RawImage)KTImage.GetComponent<RawImage>();
        //MainChar.texture = (Texture)KatiesHappy;

        KatieAnimator.SetBool("KatiesHappy", true);

    }

    void RobSpeech2()
    {
        buttons[5].gameObject.SetActive(false);
        buttons[6].gameObject.SetActive(true);
        MainChar.gameObject.SetActive(false);
        Robins.gameObject.SetActive(true);

        //Robins = (RawImage)RobinsImage.GetComponent<RawImage>();
        //Robins.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);
    }

    void KatSpeech2()
    {
        buttons[7].gameObject.SetActive(true);
        buttons[6].gameObject.SetActive(false);
        MainChar.gameObject.SetActive(true);
        Robins.gameObject.SetActive(false);

        //MainChar = (RawImage)KTImage.GetComponent<RawImage>();
        //MainChar.texture = (Texture)KatieNeutral;

        KatieAnimator.SetBool("KatieNeutral", true);

    }

    void RobSpeech3()
    {
        buttons[7].gameObject.SetActive(false);
        buttons[8].gameObject.SetActive(true);
        MainChar.gameObject.SetActive(false);
        Robins.gameObject.SetActive(true);

        //Robins = (RawImage)RobinsImage.GetComponent<RawImage>();
        //Robins.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);



        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    void Choice2()
    {
        Robins.gameObject.SetActive(false);
        MainChar.gameObject.SetActive(true);
        buttons[8].gameObject.SetActive(false);
        BgBox.gameObject.SetActive(true);

        //MainChar = (RawImage)KTImage.GetComponent<RawImage>();
        //MainChar.texture = (Texture)KatieNeutral;

        KatieAnimator.SetBool("KatieNeutral", true);


        buttons[9].gameObject.SetActive(true);
    }

    void KatSpeech3()
    {
        BgBox.gameObject.SetActive(false);
        buttons[10].gameObject.SetActive(true);
        //buttons[8].gameObject.SetActive(false);
        buttons[9].gameObject.SetActive(false);
        MainChar.gameObject.SetActive(true);
        //  Choice3.gameObject.SetActive(false);
        Robins.gameObject.SetActive(false);

        //MainChar = (RawImage)KTImage.GetComponent<RawImage>();
        //MainChar.texture = (Texture)KatieAnger;

        KatieAnimator.SetBool("KatieAnger", true);

    }

    void RobSpeech4()
    {
        buttons[10].gameObject.SetActive(false);
        buttons[11].gameObject.SetActive(true);

        MainChar.gameObject.SetActive(false);
        Robins.gameObject.SetActive(true);

        //Robins = (RawImage)RobinsImage.GetComponent<RawImage>();
        //Robins.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);

        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    void Choice3()
    {
        BgBox.gameObject.SetActive(true);
        Robins.gameObject.SetActive(false);
        buttons[11].gameObject.SetActive(false);
        buttons[12].gameObject.SetActive(true);
        MainChar.gameObject.SetActive(true);

        //MainChar = (RawImage)KTImage.GetComponent<RawImage>();
        //MainChar.texture = (Texture)KatieNeutral;

        KatieAnimator.SetBool("KatieNeutral", true);
    }

    void KatSpeech4()
    {
        BgBox.gameObject.SetActive(false);
        buttons[13].gameObject.SetActive(true);
        //  buttons[11].gameObject.SetActive(false);
        buttons[12].gameObject.SetActive(false);
        Robins.gameObject.SetActive(false);
    }

    void RobSpeech5()
    {
        buttons[13].gameObject.SetActive(false);
        buttons[14].gameObject.SetActive(true);
        MainChar.gameObject.SetActive(false);
        Robins.gameObject.SetActive(true);

        //Robins = (RawImage)RobinsImage.GetComponent<RawImage>();
        //Robins.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);
    }

    void KatSpeech5()
    {
        buttons[15].gameObject.SetActive(true);
        buttons[14].gameObject.SetActive(false);
        MainChar.gameObject.SetActive(true);
        Robins.gameObject.SetActive(false);

        KatieAnimator.SetBool("KatieNeutral", true);

    }

    void RobSpeech6()
    {
        buttons[15].gameObject.SetActive(false);
        buttons[16].gameObject.SetActive(true);
        MainChar.gameObject.SetActive(false);
        Robins.gameObject.SetActive(true);

        //Robins = (RawImage)RobinsImage.GetComponent<RawImage>();
        //Robins.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);
    }

    IEnumerator transitionPanel() //panel timer
    {
        yield return new WaitForSeconds(1f);
        canClick = true;
    }
}
