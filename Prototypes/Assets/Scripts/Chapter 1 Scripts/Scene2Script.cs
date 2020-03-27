using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Events;

public class Scene2Script : MonoBehaviour
{
    public DiaryTexts transitionScreen;
    public Button transitionImage;
    bool canClick = false;


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
    public Button[] BossResponses;
    private UnityAction[] BossResponsesFunctionsToCall;
    public Button[] RichardResponses;
    private UnityAction[] RichardFunctionsToCall;
    public Texture[] KatieEmotions;
    public GameObject[] Blocks;

    public Texture KatieSad;
    public Texture KatieAngry;
    public Texture KatieNeutral;
    public Texture KatieHappy;
    public GameObject ImageOfKatie;

    
    public Texture RichardAngry;
    public Texture RichardNeut;
    public Texture RichardHappy;
    public GameObject ImageOfRichard;

    public Texture AminaNeutral;
    public Texture AminaHappy;
    public Texture AminaAngry;
    public GameObject ImageOfAmina;

    public Texture Background2;
    public GameObject ImageOfBackground;



    public Button BossSpeech1;//Text box to hold text
    public Button BossSpeech2;//Text box to hold text
    public Button BossSpeech3;

    public Button response1;
    public Button response2;
    public Button response3;
    public Button response4;
    public Button response5;
    public Button response6;
    public Button response7;
    public Button response8;
    public Button response9;

    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
    public Button KatieSpeech5;
    public Button KatieSpeech6;
    public Button KatieSpeech7;
    public Button KatieSpeech8;
    public Button RichardSpeech1;
    public Button RichardSpeech2;
    public Button RichardSpeech3;
    public Button RichardSpeech4;
    public Button RichardSpeech5;
    public Button RichardSpeech6;
    public Button RichardSpeech7;

    public Button RobinSpeech1;
    public Button RobinSpeech2;


    public RawImage MC;
    public RawImage Boss;

    public RawImage CoWorker;
    public RawImage Richard;
    public RawImage Background;
    //  public GameObject CoWorkerNeutral;


    public Text ResponseKatie1;
    public Text ResponseKatie2;
    public Text ResponseKatie3;
    public Text ResponseBoss1;
    public Text ResponseRichard1;

    public TextAsset textFile; //stores the text file
    public string[] dialogue; //creates a list of each text line

    public int currentLine;
    public int currentLine1;
    public int currentLine2;
    public int currentLine3;
    public int currentLine4;
    public int endLine;

    public Animator KatieNeutralAnimator;
    public Animator AminaNeutralAnimator;
    public Animator RobinNeutralAnimator;
    public Animator RichardNeutralAnimator;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(transitionPanel());

        //gets rid of all the objects we don't want to appear on the screen at the start of the game -SD
        for (int responseIndex = 0; responseIndex < Blocks.Length; ++responseIndex)
        {
            Blocks[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Interactive.Length; ++responseIndex)
        {
            Interactive[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < PlayerResponses.Length; ++responseIndex)
        {
            PlayerResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < RichardResponses.Length; ++responseIndex)
        {
            RichardResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            KatieSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            RobinSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < BossResponses.Length; ++responseIndex)
        {
            BossResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            ThoughtBubbles[responseIndex].gameObject.SetActive(false);
        }

        Button Transition = transitionImage.GetComponent<Button>();
        Transition.onClick.AddListener(Speech1);

        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);

        Boss.gameObject.SetActive(false);
   
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(false);
        //CoWorkerNeutral.gameObject.SetActive(false);
        // CoWorker.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(false);
        BossSpeech2.gameObject.SetActive(false);
        BossSpeech3.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        KatieSpeech5.gameObject.SetActive(false);
        KatieSpeech6.gameObject.SetActive(false);
        KatieSpeech7.gameObject.SetActive(false);
        KatieSpeech8.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(false);
        RichardSpeech3.gameObject.SetActive(false);
        RichardSpeech4.gameObject.SetActive(false);
        RichardSpeech5.gameObject.SetActive(false);
        RichardSpeech6.gameObject.SetActive(false);
        RichardSpeech7.gameObject.SetActive(false);
        //RobinSpeech1.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(false);
        RobinNeutralAnimator.SetBool("RobinNeutral", true);

        Button Intro = transitionImage.GetComponent<Button>();
        Intro.onClick.AddListener(Speech1);

        ThoughtBubblesFunctionsToCall = new UnityAction[]
        {
            ResponseG,
            ResponseB,
            ResponseS,
            RichResponse1,
            RichResponse2,
            RichResponse3,
            RichResponse4,
            RichResponse5,
            RichResponse6,
        };

        InteractiveFunctionsToCall = new UnityAction[]
        {
            //Read,
            //Interactibles,
            //viewPhoto,
            //Interactibles
        };
        

        KatieSpeechFunctionsToCall = new UnityAction[]
        {
           Speech3,
           Speech5,
           Speech7,
           Speech11,
           Speech14,
           Speech16,
           Speech18,

           
        };

        RobinSpeechFunctionsToCall = new UnityAction[]
        {
           Speech2,
           Speech4,
        };

        BossResponsesFunctionsToCall = new UnityAction[]
        {
           Speech6,
           Speech8,
           Speech9
        };

        RichardFunctionsToCall = new UnityAction[]
        {
           Speech10,
           Speech12,
           Speech13,
           Speech15,
           Speech17,
           Speech19
        };

        //PlayerResponseFunctionsToCall = new UnityAction[]
        //{
        //    KatieResponse1,
        //    KatieResponse2,
        //    KatieResponse3,
        //    KatieResponse4,
        //    KatieResponse5,
        //    KatieResponse6
        //};

        if (textFile != null) // checks if there is text
        {
            dialogue = (textFile.text.Split('\n'));// retreiving the dialogue from file and split it into spaces

        }

        if (endLine == 0) // stops the text at the last line
        {
            endLine = dialogue.Length - 1;
        }

        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieEmotions[0];

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

        for (int responseIndex = 0; responseIndex <BossResponses.Length; ++responseIndex)
        {
            AddListenerToBossResponsesButton(BossResponses[responseIndex], BossResponsesFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            AddListenerToKatieSpeechButton(KatieSpeech[responseIndex], KatieSpeechFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            AddListenerToRobinSpeechButton(RobinSpeech[responseIndex], RobinSpeechFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RichardResponses.Length; ++responseIndex)
        {
            AddListenerToRichardResponsesButton(RichardResponses[responseIndex], RichardFunctionsToCall[responseIndex]);
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

    private void AddListenerToBossResponsesButton(Button KatieResponses, UnityEngine.Events.UnityAction KatieResponsesFunctionsToCall)
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

    private void AddListenerToRichardResponsesButton(Button EmailResponses, UnityEngine.Events.UnityAction EmailFunctionsToCall)
    {
        EmailResponses.onClick.AddListener(EmailFunctionsToCall);
    }
        


    private void SceneChange()
    {
        throw new NotImplementedException();
    }


    void Update()
    {
        ResponseBoss1.text = dialogue[currentLine1]; //checks current line  
        ResponseKatie1.text = dialogue[currentLine]; //checks current line  
        ResponseKatie2.text = dialogue[currentLine3]; //checks current line  
        ResponseKatie3.text = dialogue[currentLine4]; //checks current line 
        ResponseRichard1.text = dialogue[currentLine2]; //checks current line  
    }
    void Speech1()
    {
        KatieSpeech1.gameObject.SetActive(true);
        RobinSpeech1.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        CoWorker.gameObject.SetActive(false);
    }
    void Speech2()
    {
        RobinSpeech2.gameObject.SetActive(true);
        KatieSpeech1.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        RobinNeutralAnimator.SetBool("RobinNeutral", true);
    }
    void Speech3()
    {
        KatieSpeech2.gameObject.SetActive(true);
        RobinSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        CoWorker.gameObject.SetActive(false);
    }
    void Speech4()
    {
        Boss.gameObject.SetActive(true);
        Boss = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Boss.texture = (Texture)AminaAngry;
        KatieSpeech2.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
       
        AminaNeutralAnimator.SetBool("AminaNeutral", true);

    }
    void Speech5()
    {
        KatieSpeech3.interactable = false; // makes button non iteractable
        KatieSpeech3.gameObject.SetActive(true);
        BossSpeech1.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Boss.gameObject.SetActive(false);
        response1.gameObject.SetActive(true);
        response2.gameObject.SetActive(true);
        response3.gameObject.SetActive(true);


        Handheld.Vibrate();
    }
    void Speech6()
    {
        KatieSpeech3.gameObject.SetActive(false);
        BossSpeech2.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Boss.gameObject.SetActive(true);
        AminaNeutralAnimator.SetBool("AminaNeutral", true);
    }
    void Speech7()
    {
        Background = (RawImage)ImageOfBackground.GetComponent<RawImage>();

        Background.texture = (Texture)Background2;
        Boss = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Boss.texture = (Texture)AminaNeutral;
        BossSpeech3.gameObject.SetActive(true);
        BossSpeech2.gameObject.SetActive(false);
        Boss.gameObject.SetActive(true);
        
    }
    void Speech8()
    {
        BossSpeech3.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(true);
        Boss.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech9()
    {
        KatieSpeech4.interactable = false; // makes button non iteractable
        KatieSpeech4.gameObject.SetActive(true);
        RichardSpeech1.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
        response4.gameObject.SetActive(true);
        response5.gameObject.SetActive(true);
        response6.gameObject.SetActive(true);


        Handheld.Vibrate();
    }

    void Speech10()
    {
        KatieSpeech4.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech11()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;
        RichardSpeech3.gameObject.SetActive(true);
        RichardSpeech2.gameObject.SetActive(false);
    }
    void Speech12()
    {
        RichardSpeech3.gameObject.SetActive(false);
        KatieSpeech5.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
    }
    void Speech13()
    {
        RichardSpeech4.gameObject.SetActive(true);
        KatieSpeech5.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech14()
    {
        Richard = (RawImage)ImageOfRichard.GetComponent<RawImage>();

        Richard.texture = (Texture)RichardAngry;
        RichardSpeech4.gameObject.SetActive(false);
        KatieSpeech6.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
    }
    void Speech15()
    {
        RichardSpeech5.gameObject.SetActive(true);
        KatieSpeech6.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech16()
    {
        KatieSpeech7.interactable = false; // makes button non iteractable
        RichardSpeech5.gameObject.SetActive(false);
        KatieSpeech7.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
        response7.gameObject.SetActive(true);
        response8.gameObject.SetActive(true);
        response9.gameObject.SetActive(true);

        Handheld.Vibrate();
    }
    void Speech17()
    {
        RichardSpeech6.gameObject.SetActive(true);
        KatieSpeech7.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech18()
    {
        Richard = (RawImage)ImageOfRichard.GetComponent<RawImage>();

        Richard.texture = (Texture)RichardHappy;
        RichardSpeech6.gameObject.SetActive(false);
        KatieSpeech8.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
    }
    void Speech19()
    {
        RichardSpeech7.gameObject.SetActive(true);
        KatieSpeech8.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void ResponseG()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        KatieSpeech3.interactable = true; // makes button iteractable
        KatieSpeech3.gameObject.SetActive(true);
        ResponseBoss1.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 1; //goes to the next line
        ResponseKatie1.text = dialogue[currentLine]; //checks current line 
        currentLine = 4; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }

    void ResponseB()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech3.interactable = true; // makes button iteractable
        KatieSpeech3.gameObject.SetActive(true);
        ResponseBoss1.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 2; //goes to the next line
        ResponseKatie1.text = dialogue[currentLine]; //checks current line 
        currentLine = 6; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        
    }
    void ResponseS()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieAngry;
        KatieSpeech3.interactable = true; // makes button iteractable
        KatieSpeech3.gameObject.SetActive(true);
        ResponseBoss1.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 1; //goes to the next line
        ResponseKatie1.text = dialogue[currentLine]; //checks current line 
        currentLine = 5; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }


    void RichResponse1()
    {
        KatieSpeech4.interactable = true; // makes button iteractable
        KatieSpeech4.gameObject.SetActive(true);
        ResponseRichard1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 10; //goes to the next line
        ResponseKatie2.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 13; //goes to the next line
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
    }
    void RichResponse2()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech4.interactable = true; // makes button iteractable
        KatieSpeech4.gameObject.SetActive(true);
        ResponseRichard1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 10; //goes to the next line
        ResponseKatie2.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 14; //goes to the next line
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
    }
    void RichResponse3()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieAngry;
        KatieSpeech4.interactable = true; // makes button iteractable
        KatieSpeech4.gameObject.SetActive(true);
        ResponseRichard1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 11; //goes to the next line
        ResponseKatie2.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 15; //goes to the next line
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
    }
    void RichResponse4()
    {
        KatieSpeech7.interactable = true; // makes button iteractable
        KatieSpeech7.gameObject.SetActive(true);
        ResponseKatie3.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 17; //goes to the next line
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
    }
    void RichResponse5()
    {
        KatieSpeech7.interactable = true; // makes button iteractable
        KatieSpeech7.gameObject.SetActive(true);
        ResponseKatie3.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 18; //goes to the next line
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
    }
    void RichResponse6()
    {
        KatieSpeech7.interactable = true; // makes button iteractable
        KatieSpeech7.gameObject.SetActive(true);
        ResponseKatie3.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 19; //goes to the next line
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
    }

    IEnumerator transitionPanel() //panel timer
    {
        yield return new WaitForSeconds(1f);
        canClick = true;
    }
}
