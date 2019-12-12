using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Scene1Script : MonoBehaviour
{
    public DiaryTexts introScreen;
    public Button introImage;
    bool canClick = false;

    bool notif = false;

    //declares all the buttons for the player's choices -SD
    public Button response1;
    public Button response2;
    public Button response3;
    public Button response4;
    public Button response5;
    public Button response6;

    //declares all the buttons for Katie's Speech -SD
    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
    public Button KatieSpeech5;

    //declares all the buttons for Robin's Speech -SD
    public Button RobinSpeech1;
    public Button RobinSpeech2;
    public Button RobinSpeech3;
    public Button RobinSpeech4;
    public Button RobinSpeech5;
    public Button RobinSpeech6;

    //declares all the buttons for Katie's thought bubbles -SD
    public Button ThoughtBubble1;
    public Button ThoughtBubble2;
    public Button ThoughtBubble3;
    public Button ThoughtBubble4;

    //declares all the buttons for the email text -SD
    //public Button EmailText1;
    //public Button EmailText2;
    //public Button EmailText3;
    //public Button EmailText4;
    public Button EmailText5;

    public Button Email;
    public Button SocialMedia;
    public Button Messages;
    public GameObject NotificationRed;
    public GameObject NotificationMessage;
    public Button Options;

   

    public Button KatieResp1;
    public Button KatieResp2;
    public Button KatieResp3;
    public Button KatieResp4;
    public Button KatieResp5;
    public Button KatieResp6;

    //all the main raw images for the character and the phone -SD

    public GameObject KatieSad;
    public GameObject KatieHappy;
    public RawImage Phone;
    public Button transparentResponse;
    public RawImage EmailBackground;
    //phone headings
   // public RawImage RobinName;
   // public RawImage EmailName;
//
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(introPanel()); //start panel timer (to make it disappear)

        //gets rid of all the objects we don't want to appear on the screen at the start of the game -SD
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
     
        KatieResp1.gameObject.SetActive(false);
        KatieResp2.gameObject.SetActive(false);
        KatieResp3.gameObject.SetActive(false);
        KatieResp4.gameObject.SetActive(false);
        KatieResp5.gameObject.SetActive(false);
        KatieResp6.gameObject.SetActive(false);

        KatieHappy.gameObject.SetActive(false);
        Phone.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        KatieSpeech5.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(false);
        RobinSpeech3.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(false);

       
        ThoughtBubble1.gameObject.SetActive(false);

        ThoughtBubble2.gameObject.SetActive(false);
        ThoughtBubble3.gameObject.SetActive(false);
        ThoughtBubble4.gameObject.SetActive(false);

        NotificationRed.SetActive(false);
        NotificationMessage.SetActive(false);

        EmailBackground.gameObject.SetActive(false);
        //EmailText1.gameObject.SetActive(false);
        //EmailText2.gameObject.SetActive(false);
        //EmailText3.gameObject.SetActive(false);
        //EmailText4.gameObject.SetActive(false);
        EmailText5.gameObject.SetActive(false);

        //RobinName.gameObject.SetActive(false);
        //EmailName.gameObject.SetActive(false);

        //When each specified button is pressed, it will call the specified method from below and run the appropriate actions accordingly -SD
        //After the introPanel disappears, the first image will be Katie in her room and the text coming in to the thought bubble in a typewriter fashion - SD
        Button Intro = introImage.GetComponent<Button>();
        Intro.onClick.AddListener(TB1);
        Button t1 = ThoughtBubble1.GetComponent<Button>();
        t1.onClick.AddListener(TB2);
        Button t2 = ThoughtBubble2.GetComponent<Button>();
        t2.onClick.AddListener(TB3);
        Button t3 = ThoughtBubble3.GetComponent<Button>();
        t3.onClick.AddListener(MesNotif);

        Button mes = Messages.GetComponent<Button>();
        mes.onClick.AddListener(KSpeech1);

        Button KS1 = KatieSpeech1.GetComponent<Button>();
        KS1.onClick.AddListener(RobinReply1);
        Button RS1 = RobinSpeech1.GetComponent<Button>();
        RS1.onClick.AddListener(KSpeech2);
        Button KS2 = KatieSpeech2.GetComponent<Button>();
        KS2.onClick.AddListener(RobinReply2);
        Button RS2 = RobinSpeech2.GetComponent<Button>();
        RS2.onClick.AddListener(KSpeech3);
        Button KS3 = KatieSpeech3.GetComponent<Button>();
        KS3.onClick.AddListener(RobinReply3);
        Button RS3 = RobinSpeech3.GetComponent<Button>();
        RS3.onClick.AddListener(Email1);

        //Button E1 = EmailText1.GetComponent<Button>();
        //E1.onClick.AddListener(Email2);
        //Button E2 = EmailText2.GetComponent<Button>();
        //E2.onClick.AddListener(Email3);
        //Button E3 = EmailText3.GetComponent<Button>();
        //E3.onClick.AddListener(Email4);
        //Button E4 = EmailText4.GetComponent<Button>();
        //E4.onClick.AddListener(Email5);
        Button E5 = EmailText5.GetComponent<Button>();
        E5.onClick.AddListener(KSpeech4);
        Button KS4 = KatieSpeech4.GetComponent<Button>();
        KS4.onClick.AddListener(Choice1);
        Button R1 = response1.GetComponent<Button>();
        R1.onClick.AddListener(KatieResponse1);
        Button R2 = response2.GetComponent<Button>();
        R2.onClick.AddListener(KatieResponse2);
        Button R3 = response3.GetComponent<Button>();
        R3.onClick.AddListener(KatieResponse3);
        Button R4 = response4.GetComponent<Button>();
        R4.onClick.AddListener(KatieResponse4);
        Button R5 = response5.GetComponent<Button>();
        R5.onClick.AddListener(KatieResponse5);
        Button R6 = response6.GetComponent<Button>();
        R6.onClick.AddListener(KatieResponse6);

        Button KR1 = KatieResp1.GetComponent<Button>();
        KR1.onClick.AddListener(RobinReply4);
        Button KR2 = KatieResp2.GetComponent<Button>();
        KR2.onClick.AddListener(RobinReply4);
        Button KR3 = KatieResp3.GetComponent<Button>();
        KR3.onClick.AddListener(RobinReply5);
        Button KR4 = KatieResp4.GetComponent<Button>();
        KR4.onClick.AddListener(RobinReply5);
        Button KR5 = KatieResp5.GetComponent<Button>();
        KR5.onClick.AddListener(RobinReply6);
        Button KR6 = KatieResp6.GetComponent<Button>();
        KR6.onClick.AddListener(RobinReply6);

        Button RS6 = RobinSpeech6.GetComponent<Button>();
        RS6.onClick.AddListener(KSpeech5);
        Button KS5 = KatieSpeech5.GetComponent<Button>();
        KS5.onClick.AddListener(TB4);
    }

    // Update is called once per frame
    //void Update()
    //{
    //    Debug.Log(timeToIntroEnd);
    //}

    void TB1()
    {
        //the first thought bubble will be displayed" -SD
        if (canClick)
        {
            introScreen.gameObject.SetActive(false);
            ThoughtBubble1.gameObject.SetActive(true);
        }
    }

    void TB2()
    {
        //the second thought bubble will be displayed saying "Will the 25th time refreshing make a difference?" -SD
       ThoughtBubble1.gameObject.SetActive(false);
       ThoughtBubble2.gameObject.SetActive(true);
    }

    void TB3()
    {
        //the third thought bubble will be displayed saying "It’s been over a week. I don’t think I got it.." -SD
        ThoughtBubble2.gameObject.SetActive(false);
        ThoughtBubble3.gameObject.SetActive(true);
        //notif = true;
        //Debug.Log("notification On");
    }

    void MesNotif()
    {
        //the third thought bubble will be displayed saying "It’s been over a week. I don’t think I got it.." -SD
        ThoughtBubble3.gameObject.SetActive(false);
        NotificationMessage.SetActive(true);
        NotificationRed.SetActive(true);
    }

    void KSpeech1()
    {
        //Katie's first speech bubble appears on screen saying "I’m not getting the marketing job, am I?" -SD
        NotificationRed.gameObject.SetActive(false);
        NotificationMessage.SetActive(false);
        Phone.gameObject.SetActive(true);
        //RobinName.gameObject.SetActive(true);
        StartCoroutine(KatieMessage1());
        KatieSad.gameObject.SetActive(false);
        transparentResponse.gameObject.SetActive(false);
    }

    void RobinReply1()
    {
        //The phone and Robin's first speech bubble appears on screen saying "Don’t say that! I think it went better than you think" -SD
        

    
       // KatieSpeech1.gameObject.SetActive(false);
        
        RobinSpeech1.gameObject.SetActive(true);
    }

    void KSpeech2()
    {
        //Katie's second speech bubble appears on screen saying "That boss of yours.. omg, she was so scary during the interview" -SD


        KatieSpeech2.gameObject.SetActive(true);
    }

    void RobinReply2()
    {
        //The phone and Robin's second speech bubble appears on screen saying "Other people say that too (smiley face) but I think she’s cool. Breaking the glass ceiling and stuff (smiley face)" -SD


        
        RobinSpeech2.gameObject.SetActive(true);

        
    }

    void KSpeech3()
    {
        //Katie's third speech bubble appears on screen saying "Oh well, I guess I’ll like her if she gives me the job… Talk to you later" -SD
        
   
        KatieSpeech3.gameObject.SetActive(true);

        KatieSpeech2.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
    }

    void RobinReply3()
    {
        //The phone and Robin's third speech bubble appears on screen saying "Keep it together man. Ciao" -SD

        
        Phone.gameObject.SetActive(true);
       // RobinName.gameObject.SetActive(true);
        RobinSpeech3.gameObject.SetActive(true);

        
        
    }

    void Email1()
    {
        //The phone and the first email speech bubble appears on screen saying "Good afternoon Ms Anderson" -SD
       // RobinName.gameObject.SetActive(false);
        RobinSpeech3.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        //EmailName.gameObject.SetActive(true);
        //EmailText1.gameObject.SetActive(true);
        EmailText5.gameObject.SetActive(true);
        EmailBackground.gameObject.SetActive(true);
        Phone.gameObject.SetActive(false);
    }

    void Email2()
    {
        //The phone and the second email speech bubble appears on screen saying "I am pleased to inform you that after interviewing a lot of candidates," - SD

        //EmailText1.gameObject.SetActive(false);
       // EmailText2.gameObject.SetActive(true);
    }

    void Email3()
    {
        //The phone and the third email speech bubble appears on screen saying "the HR team and I decided to offer you the marketing intern/assistant position in our company" - SD

        //EmailText2.gameObject.SetActive(false);
       // EmailText3.gameObject.SetActive(true);
    }

    void Email4()
    {
        //The phone and the fourth email speech bubble appears on screen saying "You are expected to be at the office this Monday 24th of March at 9:00 am." - SD

        //EmailText1.gameObject.SetActive(false);
        //EmailText2.gameObject.SetActive(false);
        //EmailText3.gameObject.SetActive(false);
        //EmailText4.gameObject.SetActive(true);
    }

    void Email5()
    {
        //The phone and the final email speech bubble appears on screen saying "We are looking forward to making you part of the team. Kind Regards, Amina Azzi" - SD
       //EmailText5.gameObject.SetActive(true);
    }

    void KSpeech4()
    {
        
        //Katie's fourth speech bubble appears on screen saying "I got the job! I am telling everyone" -SD
        Phone.gameObject.SetActive(false);
        //EmailName.gameObject.SetActive(false);
        //EmailText4.gameObject.SetActive(false);
        EmailText5.gameObject.SetActive(false);
        KatieHappy.gameObject.SetActive(true);
        KatieSpeech4.gameObject.SetActive(true);
        EmailBackground.gameObject.SetActive(false);
    }

    void Choice1()
    {
        //the choice buttons will appear on screen prompting the user to pick between them
        KatieSpeech4.gameObject.SetActive(false);
        response1.gameObject.SetActive(true);
        response2.gameObject.SetActive(true);
        transparentResponse.gameObject.SetActive(true);
        Handheld.Vibrate();
    }

    void KatieResponse1()
    {
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        KatieHappy.gameObject.SetActive(false);
        transparentResponse.gameObject.SetActive(false);
        Phone.gameObject.SetActive(true);
        //RobinName.gameObject.SetActive(true);
        KatieResp1.gameObject.SetActive(true);


        RobinSpeech5.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(false);
    }

    void KatieResponse2()
    {
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        transparentResponse.gameObject.SetActive(false);
        Phone.gameObject.SetActive(true);
        //RobinName.gameObject.SetActive(true);
        KatieResp2.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(false);
    }

    void RobinReply4()
    {
        //The phone and Robin's fourth speech bubble appears on screen saying "I told you were overreacting! Congrats!" and the choice buttons will appear on screen prompting the user to pick between them-SD
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
      

        RobinSpeech4.gameObject.SetActive(true);

        RobinSpeech5.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(false);

        response3.gameObject.SetActive(true);
        response4.gameObject.SetActive(true);

        Handheld.Vibrate();
    }

    void KatieResponse3()
    {
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);

        KatieResp3.gameObject.SetActive(true);
    }

    void KatieResponse4()
    {
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
       

        KatieResp4.gameObject.SetActive(true);
    }

    void RobinReply5()
    {
        //The phone and Robin's fifth speech bubble appears on screen saying "Well, I have a list of requests……" and the choice buttons will appear on screen prompting the user to pick between them-SD
       // KatieResp4.gameObject.SetActive(false);

        RobinSpeech5.gameObject.SetActive(true);
        response5.gameObject.SetActive(true);
        response6.gameObject.SetActive(true);


        

        Handheld.Vibrate();
    }

    void KatieResponse5()
    {
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);

        KatieResp1.gameObject.SetActive(false);
        KatieResp2.gameObject.SetActive(false);
        KatieResp3.gameObject.SetActive(false);
        KatieResp4.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(false);

        KatieResp5.gameObject.SetActive(true);
    }

    void KatieResponse6()
    {
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);

        KatieResp5.gameObject.SetActive(false);
        KatieResp2.gameObject.SetActive(false);
        KatieResp1.gameObject.SetActive(false);
        KatieResp4.gameObject.SetActive(false);
        KatieResp3.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(false);


        KatieResp6.gameObject.SetActive(true);
    }

    void RobinReply6()
    {
        //The phone and Robin's sixth speech bubble appears on screen saying "Starting with a few drinks is not a bad idea (smiley face)"-SD
        
        RobinSpeech6.gameObject.SetActive(true);
    }

    void KSpeech5()
    {
        //Katie's fifth speech bubble appears on screen saying "Perfect I’ll call you in ten to tell you where to meet! Ciao!" -SD
  
        KatieSpeech5.gameObject.SetActive(true);
    }

    void TB4()
    {
        // the fourth thought bubble will be displayed saying "I can’t believe it’s actually happening! I can take a break finally…”" - SD
        KatieSpeech5.gameObject.SetActive(false);
        ThoughtBubble4.gameObject.SetActive(true);
        RobinSpeech4.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(false);
        //RobinName.gameObject.SetActive(false);
        Phone.gameObject.SetActive(false);
        KatieResp1.gameObject.SetActive(false);
        KatieResp2.gameObject.SetActive(false);
        KatieResp3.gameObject.SetActive(false);
        KatieResp4.gameObject.SetActive(false);
        KatieResp5.gameObject.SetActive(false);
        KatieResp6.gameObject.SetActive(false);
        transparentResponse.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(true);
    }

    IEnumerator introPanel() //panel timer
    {
        //canClick = false;
        yield return new WaitForSeconds(1f);
        canClick = true;
    }

    IEnumerator KatieMessage1()
    {
        yield return new WaitForSeconds(0.7f);
        KatieSpeech1.gameObject.SetActive(true);
    }
}
