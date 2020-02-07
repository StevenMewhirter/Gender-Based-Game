﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Scene1Script : MonoBehaviour
{
    public DiaryTexts introScreen;
    public Button introImage;
    bool canClick = false;
    bool notif = false;
    public Button[] PlayerResponses;
    private UnityAction[] PlayerResponseFunctionsToCall;
    public Button[] Interactive;
    private UnityAction[] InteractiveFunctionsToCall;
    public Button[] KatieSpeech;
    private UnityAction[] KatieSpeechFunctionsToCall;
    public Button[] RobinSpeech;
    private UnityAction[] RobinSpeechFunctionsToCall;
    public Button[] ThoughtBubbles;
    private UnityAction[] ThoughtBubblesFunctionsToCall;
    public Button[] KatieResponses;
    private UnityAction[] KatieResponsesFunctionsToCall;
    public Button[] EmailResponses;
    private UnityAction[] EmailFunctionsToCall;
    public Button level2;
    //declares all the buttons for the player's choices -SD
    public GameObject firstblock;
    public GameObject secondblock;
    //public int moveUp = 150;
    public Button Email;
    public Button SocialMedia;
    public Button Messages;
    public GameObject NotificationRed;
    public GameObject NotificationMessage;
    public Button Options;
    public GameObject chatContainer;
    public GameObject choiceContainerForMessage;
    //all the main raw images for the character and the phone -SD
    public Texture KatieSad;
    public Texture KatieHappy;
    public GameObject ImageOfKatie;
    public RawImage MC;
    public RawImage Phone;
    public Button transparentResponse;
    public RawImage EmailBackground;
    //animators for katie
    public Animator KatieAnimator;
    //
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(introPanel()); //start panel timer (to make it disappear)

        //gets rid of all the objects we don't want to appear on the screen at the start of the game -SD
        firstblock.gameObject.SetActive(false);
        secondblock.gameObject.SetActive(false);

        for (int responseIndex = 0; responseIndex < Interactive.Length; ++responseIndex)
        {
            Interactive[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < PlayerResponses.Length; ++responseIndex)
        {
            PlayerResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < KatieResponses.Length; ++responseIndex)
        {
            KatieResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            KatieSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            RobinSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < EmailResponses.Length; ++responseIndex)
        {
            EmailResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            ThoughtBubbles[responseIndex].gameObject.SetActive(false);
        }

        Phone.gameObject.SetActive(false);
        choiceContainerForMessage.SetActive(false);
        level2.gameObject.SetActive(false);
        NotificationRed.SetActive(false);
        NotificationMessage.SetActive(false);
        EmailBackground.gameObject.SetActive(false);

        //When each specified button is pressed, it will call the specified method from below and run the appropriate actions accordingly -SD
        //After the introPanel disappears, the first image will be Katie in her room and the text coming in to the thought bubble in a typewriter fashion - SD
        Button Intro = introImage.GetComponent<Button>();
        Intro.onClick.AddListener(TB1);

        ThoughtBubblesFunctionsToCall = new UnityAction[]
        {
            TB2,
            TB3,
            MesNotif,
            Interactibles
        };

        InteractiveFunctionsToCall = new UnityAction[]
        {
            Read,
            Interactibles,
            viewPhoto,
            Interactibles
        };
        Button mes = Messages.GetComponent<Button>();
        mes.onClick.AddListener(KSpeech1);

        KatieSpeechFunctionsToCall = new UnityAction[]
        {
            RobinReply1,
            RobinReply2,
            RobinReply3,
           Choice1,
           TB4
        };

        RobinSpeechFunctionsToCall = new UnityAction[]
        {
            KSpeech2,
            KSpeech3,
            Email1,
            RobinReply4,
           RobinReply5,
            KSpeech5
        };

        EmailFunctionsToCall = new UnityAction[]
        {
           KSpeech4,
        };

        PlayerResponseFunctionsToCall = new UnityAction[]
        {
            KatieResponse1,
            KatieResponse2,
            KatieResponse3,
            KatieResponse4,
            KatieResponse5,
            KatieResponse6
        };

        KatieResponsesFunctionsToCall = new UnityAction[]
        {
            RobinReply4,
            RobinReply4,
            RobinReply5,
            RobinReply5,
            RobinReply6,
            RobinReply6
        };

        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;

        for (int responseIndex = 0; responseIndex < Interactive.Length; ++responseIndex)
        {
            AddListenerToInteractiveButton(Interactive[responseIndex], InteractiveFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            AddListenerToThoughtButton(ThoughtBubbles[responseIndex], ThoughtBubblesFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < PlayerResponses.Length; ++responseIndex)
        {
            AddListenerToPlayerResponsesButton(PlayerResponses[responseIndex], PlayerResponseFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < KatieResponses.Length; ++responseIndex)
        {
            AddListenerToKatieResponsesButton(KatieResponses[responseIndex], KatieResponsesFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            AddListenerToKatieSpeechButton(KatieSpeech[responseIndex], KatieSpeechFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            AddListenerToRobinSpeechButton(RobinSpeech[responseIndex], RobinSpeechFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < EmailResponses.Length; ++responseIndex)
        {
            AddListenerToEmailResponsesButton(EmailResponses[responseIndex], EmailFunctionsToCall[responseIndex]);
        }
    }

    private void AddListenerToInteractiveButton(Button Interactive, UnityEngine.Events.UnityAction InteractiveFunctionsToCall)
    {
        Interactive.onClick.AddListener(InteractiveFunctionsToCall);
    }

    private void AddListenerToThoughtButton(Button ThoughtBubbles, UnityEngine.Events.UnityAction ThoughtBubblesFunctionsToCall)
    {
        ThoughtBubbles.onClick.AddListener(ThoughtBubblesFunctionsToCall);
    }

    private void AddListenerToPlayerResponsesButton(Button KatieResponses, UnityEngine.Events.UnityAction PlayerResponseFunctionsToCall)
    {
        KatieResponses.onClick.AddListener(PlayerResponseFunctionsToCall);
    }

    private void AddListenerToKatieResponsesButton(Button KatieResponses, UnityEngine.Events.UnityAction KatieResponsesFunctionsToCall)
    {
        KatieResponses.onClick.AddListener(KatieResponsesFunctionsToCall);
    }

    private void AddListenerToKatieSpeechButton(Button KatieSpeech, UnityEngine.Events.UnityAction KatieSpeechFunctionsToCall)
    {
        KatieSpeech.onClick.AddListener(KatieSpeechFunctionsToCall);
    }

    private void AddListenerToRobinSpeechButton(Button RobinSpeech, UnityEngine.Events.UnityAction RobinSpeechFunctionsToCall)
    {
        RobinSpeech.onClick.AddListener(RobinSpeechFunctionsToCall);
    }

    private void AddListenerToEmailResponsesButton(Button EmailResponses, UnityEngine.Events.UnityAction EmailFunctionsToCall)
    {
        EmailResponses.onClick.AddListener(EmailFunctionsToCall);
    }

    void TB1()
    {
        //the first thought bubble will be displayed" -SD
        if (canClick)
        {
            introScreen.gameObject.SetActive(false);
            ThoughtBubbles[0].gameObject.SetActive(true);
        }
    }

    void TB2()
    {
        //the second thought bubble will be displayed saying "Will the 25th time refreshing make a difference?" -SD
        ThoughtBubbles[0].gameObject.SetActive(false);
        ThoughtBubbles[1].gameObject.SetActive(true);
    }

    void TB3()
    {
        //the third thought bubble will be displayed saying "It’s been over a week. I don’t think I got it.." -SD
        ThoughtBubbles[1].gameObject.SetActive(false);
        ThoughtBubbles[2].gameObject.SetActive(true);
    }

    void MesNotif()
    {
        //the third thought bubble will be displayed saying "It’s been over a week. I don’t think I got it.." -SD
        ThoughtBubbles[2].gameObject.SetActive(false);
        NotificationMessage.SetActive(true);
        NotificationRed.SetActive(true);
    }

    void KSpeech1()
    {
        //Katie's first speech bubble appears on screen saying "I’m not getting the marketing job, am I?" -SD
        NotificationRed.gameObject.SetActive(false);
        NotificationMessage.SetActive(false);
        Phone.gameObject.SetActive(true);
        StartCoroutine(KatieMessage1());
        transparentResponse.gameObject.SetActive(false);
    }

    void RobinReply1()
    {
        //The phone and Robin's first speech bubble appears on screen saying "Don’t say that! I think it went better than you think" -SD
        RobinSpeech[0].gameObject.SetActive(true);
        KatieSpeech[0].interactable = false;
    }

    void KSpeech2()
    {
        //Katie's second speech bubble appears on screen saying "That boss of yours.. omg, she was so scary during the interview" -SD
        KatieSpeech[1].gameObject.SetActive(true);
        RobinSpeech[0].interactable = false;
    }

    void RobinReply2()
    {
        //The phone and Robin's second speech bubble appears on screen saying "Other people say that too (smiley face) but I think she’s cool. Breaking the glass ceiling and stuff (smiley face)" -SD
        RobinSpeech[1].gameObject.SetActive(true);
        KatieSpeech[1].interactable = false;
    }

    void KSpeech3()
    {
        //Katie's third speech bubble appears on screen saying "Oh well, I guess I’ll like her if she gives me the job… Talk to you later" -SD
        KatieSpeech[2].gameObject.SetActive(true);
        RobinSpeech[1].interactable = false;
        KatieSpeech[0].gameObject.SetActive(false);
    }

    void RobinReply3()
    {
        //The phone and Robin's third speech bubble appears on screen saying "Keep it together man. Ciao" -SD
        Phone.gameObject.SetActive(true);
        RobinSpeech[2].gameObject.SetActive(true);
        KatieSpeech[2].interactable = false;
        moveMessagesUp(150);
    }

    void Email1()
    {
        //The phone and the first email speech bubble appears on screen saying "Good afternoon Ms Anderson" -SD
        RobinSpeech[0].gameObject.SetActive(false);
        RobinSpeech[2].gameObject.SetActive(false);
        RobinSpeech[1].gameObject.SetActive(false);
        KatieSpeech[1].gameObject.SetActive(false);
        KatieSpeech[2].gameObject.SetActive(false);
        EmailResponses[0].gameObject.SetActive(true);
        EmailBackground.gameObject.SetActive(true);
        Phone.gameObject.SetActive(false);
    }

    void KSpeech4()
    {

        //Katie's fourth speech bubble appears on screen saying "I got the job! I am telling everyone" -SD
        Phone.gameObject.SetActive(false);
        EmailResponses[0].gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieHappy;
        KatieSpeech[3].gameObject.SetActive(true);
        EmailBackground.gameObject.SetActive(false);
    }

    void Choice1()
    {
        //the choice buttons will appear on screen prompting the user to pick between them
        choiceContainerForMessage.SetActive(true);
        KatieSpeech[3].gameObject.SetActive(false);
        PlayerResponses[0].gameObject.SetActive(true);
        PlayerResponses[1].gameObject.SetActive(true);
        transparentResponse.gameObject.SetActive(true);
        Handheld.Vibrate();
    }

    void KatieResponse1()
    {
        PlayerResponses[0].gameObject.SetActive(false);
        PlayerResponses[1].gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        transparentResponse.gameObject.SetActive(false);
        Phone.gameObject.SetActive(true);
        StartCoroutine(KatieMessage2());
        RobinSpeech[4].gameObject.SetActive(false);
        RobinSpeech[5].gameObject.SetActive(false);
    }

    void KatieResponse2()
    {
        PlayerResponses[0].gameObject.SetActive(false);
        PlayerResponses[1].gameObject.SetActive(false);
        transparentResponse.gameObject.SetActive(false);
        Phone.gameObject.SetActive(true);
        StartCoroutine(KatieMessage3());
        ImageOfKatie.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        RobinSpeech[4].gameObject.SetActive(false);
        RobinSpeech[5].gameObject.SetActive(false);
    }

    void RobinReply4()
    {
        //The phone and Robin's fourth speech bubble appears on screen saying "I told you were overreacting! Congrats!" and the choice buttons will appear on screen prompting the user to pick between them-SD
        PlayerResponses[4].gameObject.SetActive(false);
        PlayerResponses[5].gameObject.SetActive(false);
        RobinSpeech[3].gameObject.SetActive(true);
        RobinSpeech[4].gameObject.SetActive(false);
        RobinSpeech[5].gameObject.SetActive(false);
        firstblock.gameObject.SetActive(true);
        PlayerResponses[2].gameObject.SetActive(true);
        PlayerResponses[3].gameObject.SetActive(true);
        Handheld.Vibrate();
    }

    void KatieResponse3()
    {
        firstblock.gameObject.SetActive(false);
        PlayerResponses[2].gameObject.SetActive(false);
        PlayerResponses[3].gameObject.SetActive(false);
        KatieResponses[2].gameObject.SetActive(true);
    }

    void KatieResponse4()
    {
        PlayerResponses[2].gameObject.SetActive(false);
        PlayerResponses[3].gameObject.SetActive(false);
        KatieResponses[3].gameObject.SetActive(true);
    }

    void RobinReply5()
    {
        //The phone and Robin's fifth speech bubble appears on screen saying "Well, I have a list of requests……" and the choice buttons will appear on screen prompting the user to pick between them-SD
        RobinSpeech[4].gameObject.SetActive(true);
        secondblock.gameObject.SetActive(true);
        PlayerResponses[4].gameObject.SetActive(true);
        PlayerResponses[5].gameObject.SetActive(true);
        Handheld.Vibrate();
    }

    void KatieResponse5()
    {
        secondblock.gameObject.SetActive(false);
        PlayerResponses[4].gameObject.SetActive(false);
        PlayerResponses[5].gameObject.SetActive(false);
        KatieResponses[0].gameObject.SetActive(false);
        KatieResponses[1].gameObject.SetActive(false);
        KatieResponses[2].gameObject.SetActive(false);
        KatieResponses[3].gameObject.SetActive(false);
        RobinSpeech[3].gameObject.SetActive(false);
        RobinSpeech[4].gameObject.SetActive(false);
        KatieResponses[4].gameObject.SetActive(true);
    }

    void KatieResponse6()
    {
        PlayerResponses[4].gameObject.SetActive(false);
        PlayerResponses[5].gameObject.SetActive(false);
        KatieResponses[4].gameObject.SetActive(false);
        KatieResponses[1].gameObject.SetActive(false);
        KatieResponses[0].gameObject.SetActive(false);
        KatieResponses[3].gameObject.SetActive(false);
        KatieResponses[2].gameObject.SetActive(false);
        RobinSpeech[3].gameObject.SetActive(false);
        RobinSpeech[4].gameObject.SetActive(false);
        KatieResponses[5].gameObject.SetActive(true);
    }

    void RobinReply6()
    {
        //The phone and Robin's sixth speech bubble appears on screen saying "Starting with a few drinks is not a bad idea (smiley face)"-SD
        RobinSpeech[5].gameObject.SetActive(true);
    }

    void KSpeech5()
    {
        //Katie's fifth speech bubble appears on screen saying "Perfect I’ll call you in ten to tell you where to meet! Ciao!" -SD
        KatieSpeech[4].gameObject.SetActive(true);
    }

    void TB4()
    {
        // the fourth thought bubble will be displayed saying "I can’t believe it’s actually happening! I can take a break finally…”" - SD
        KatieSpeech[4].gameObject.SetActive(false);
        ThoughtBubbles[3].gameObject.SetActive(true);
        RobinSpeech[3].gameObject.SetActive(false);
        RobinSpeech[4].gameObject.SetActive(false);
        RobinSpeech[5].gameObject.SetActive(false);
        Phone.gameObject.SetActive(false);
        KatieResponses[0].gameObject.SetActive(false);
        KatieResponses[1].gameObject.SetActive(false);
        KatieResponses[2].gameObject.SetActive(false);
        KatieResponses[3].gameObject.SetActive(false);
        KatieResponses[4].gameObject.SetActive(false);
        KatieResponses[5].gameObject.SetActive(false);
        transparentResponse.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieHappy;
    }

    void Interactibles()
    {
        Interactive[0].gameObject.SetActive(true);
        Interactive[1].gameObject.SetActive(false);
        level2.gameObject.SetActive(true);
        Interactive[2].gameObject.SetActive(true);
        Interactive[3].gameObject.SetActive(false);
        transparentResponse.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        ThoughtBubbles[3].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
    }

    void Read()
    {
        Interactive[0].gameObject.SetActive(false);
        Interactive[1].gameObject.SetActive(true);
        Interactive[2].gameObject.SetActive(false);
        level2.gameObject.SetActive(false);
    }

    void viewPhoto()
    {
        Interactive[0].gameObject.SetActive(false);
        Interactive[2].gameObject.SetActive(false);
        Interactive[3].gameObject.SetActive(true);
        level2.gameObject.SetActive(false);
    }

    IEnumerator introPanel() //panel timer
    {
        yield return new WaitForSeconds(1f);
        canClick = true;
    }

    IEnumerator KatieMessage1()
    {
        yield return new WaitForSeconds(0.7f);
        KatieSpeech[0].gameObject.SetActive(true);
    }

    IEnumerator KatieMessage2()
    {
        yield return new WaitForSeconds(0.7f);
        KatieResponses[0].gameObject.SetActive(true);
    }
    IEnumerator KatieMessage3()
    {
        yield return new WaitForSeconds(0.7f);
        KatieResponses[1].gameObject.SetActive(true);
    }

    public void moveMessagesUp(float boxHeight)
    {
        chatContainer.transform.position += new Vector3(0, boxHeight, 0);
    }
}