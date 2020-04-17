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

     public float RobinValue = 50;
    

     public float AminaValue = 50;
   

     public float RichardValue = 50;
   

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

    public Button NextScene;
    
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
        Transition.onClick.AddListener(Speech0);
     
        NextScene.gameObject.SetActive(false);

       


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
           
           Speech2,
           Speech4,
           Speech6,
           Speech10,
           Speech13,
           Speech15,
           Speech17,
           Speech19

           
        };

        RobinSpeechFunctionsToCall = new UnityAction[]
        {
           Speech1,
           Speech3
           
        };

        BossResponsesFunctionsToCall = new UnityAction[]
        {
           Speech5,
           Speech7,
           Speech8
        };

        RichardFunctionsToCall = new UnityAction[]
        {
           Speech9,
           Speech11,
           Speech12,
           Speech14,
           Speech16,
           Speech18
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

        //MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        //MC.texture = (Texture)KatieEmotions[0];

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

    private void AddListenerToBossResponsesButton(Button BossResponses, UnityEngine.Events.UnityAction BossResponsesFunctionsToCall)
    {
        BossResponses.onClick.AddListener(BossResponsesFunctionsToCall);
    }

    private void AddListenerToKatieSpeechButton(Button KatieSpeech, UnityEngine.Events.UnityAction KatieSpeechFunctionsToCall)
    {
        KatieSpeech.onClick.AddListener(KatieSpeechFunctionsToCall);
    }

    private void AddListenerToRobinSpeechButton(Button RobinSpeech, UnityEngine.Events.UnityAction RobinSpeechFunctionsToCall)
    {
        RobinSpeech.onClick.AddListener(RobinSpeechFunctionsToCall);
    }

    private void AddListenerToRichardResponsesButton(Button RichardResponses, UnityEngine.Events.UnityAction RichardFunctionsToCall)
    {
        RichardResponses.onClick.AddListener(RichardFunctionsToCall);
    }

        
    private void SceneChange()
    {
        throw new NotImplementedException();
    }

   
    void Update()
    {
        
        AminaValueStatic.AValue = AminaValue;
        RichardValueStatic.RichValue = RichardValue;
        //AminaSlider.value = AminaValue;
        //RichardSlider.value = RichardValue;

        ResponseBoss1.text = dialogue[currentLine1]; //checks current line  
        ResponseKatie1.text = dialogue[currentLine]; //checks current line  
        ResponseKatie2.text = dialogue[currentLine3]; //checks current line  
        ResponseKatie3.text = dialogue[currentLine4]; //checks current line 
        ResponseRichard1.text = dialogue[currentLine2]; //checks current line  

        if (AminaValue <= 40)
        {
          //  ThoughtBubbles[2].gameObject.SetActive(false);
        }

        if (RichardValue <= 40)
        {
            ThoughtBubbles[4].gameObject.SetActive(false);
            ThoughtBubbles[8].gameObject.SetActive(false);
        }
    }
    void Speech0()
    {
        
        if (canClick)
        {
            RobinNeutralAnimator.SetBool("RobinNeutral", true);
            transitionScreen.gameObject.SetActive(false);
            RobinSpeech[0].gameObject.SetActive(true);
            CoWorker.gameObject.SetActive(true);
        }
    }
    void Speech1()
    {
        KatieSpeech[0].gameObject.SetActive(true);
        RobinSpeech[0].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        CoWorker.gameObject.SetActive(false);
    }
    void Speech2()
    {
        RobinSpeech[1].gameObject.SetActive(true);
        KatieSpeech[0].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        RobinNeutralAnimator.SetBool("RobinNeutral", true);
    }
    void Speech3()
    {
        KatieSpeech[1].gameObject.SetActive(true);
        RobinSpeech[1].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        CoWorker.gameObject.SetActive(false);
    }
    void Speech4()
    {
        Boss.gameObject.SetActive(true);
        //Boss = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Boss.texture = (Texture)AminaAngry;
        KatieSpeech[1].gameObject.SetActive(false);
        BossResponses[0].gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
       
        AminaNeutralAnimator.SetBool("AminaNeutral", true);

    }
    void Speech5()
    {
        KatieSpeech[2].interactable = false; // makes button non iteractable
        KatieSpeech[2].gameObject.SetActive(true);
        BossResponses[0].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Boss.gameObject.SetActive(false);
        ThoughtBubbles[0].gameObject.SetActive(true);
        ThoughtBubbles[2].gameObject.SetActive(true);
        ThoughtBubbles[1].gameObject.SetActive(true);


        Handheld.Vibrate();
    }
    void Speech6()
    {
        KatieSpeech[2].gameObject.SetActive(false);
        BossResponses[1].gameObject.SetActive(true);
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
        BossResponses[2].gameObject.SetActive(true);
        BossResponses[1].gameObject.SetActive(false);
        Boss.gameObject.SetActive(true);
        
    }
    void Speech8()
    {
        BossResponses[2].gameObject.SetActive(false);
        RichardResponses[0].gameObject.SetActive(true);
        Boss.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech9()
    {
        KatieSpeech[3].interactable = false; // makes button non iteractable
        KatieSpeech[3].gameObject.SetActive(true);
        RichardResponses[0].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
        ThoughtBubbles[3].gameObject.SetActive(true);
        ThoughtBubbles[4].gameObject.SetActive(true);
        ThoughtBubbles[5].gameObject.SetActive(true);


        Handheld.Vibrate();
    }

    void Speech10()
    {
        KatieSpeech[3].gameObject.SetActive(false);
        RichardResponses[1].gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech11()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;
        RichardResponses[2].gameObject.SetActive(true);
        RichardResponses[1].gameObject.SetActive(false);
    }
    void Speech12()
    {
        RichardResponses[2].gameObject.SetActive(false);
        KatieSpeech[4].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
    }
    void Speech13()
    {
        RichardResponses[3].gameObject.SetActive(true);
        KatieSpeech[4].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech14()
    {
        Richard = (RawImage)ImageOfRichard.GetComponent<RawImage>();

        Richard.texture = (Texture)RichardAngry;
        RichardResponses[3].gameObject.SetActive(false);
        KatieSpeech[5].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
    }
    void Speech15()
    {
        RichardResponses[4].gameObject.SetActive(true);
        KatieSpeech[5].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech16()
    {
        KatieSpeech[6].interactable = false; // makes button non iteractable
        RichardResponses[4].gameObject.SetActive(false);
        KatieSpeech[6].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
        ThoughtBubbles[6].gameObject.SetActive(true);
        ThoughtBubbles[7].gameObject.SetActive(true);
        ThoughtBubbles[8].gameObject.SetActive(true);

        Handheld.Vibrate();
    }
    void Speech17()
    {
        RichardResponses[5].gameObject.SetActive(true);
        KatieSpeech[6].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void Speech18()
    {
        Richard = (RawImage)ImageOfRichard.GetComponent<RawImage>();

        Richard.texture = (Texture)RichardHappy;
        RichardResponses[5].gameObject.SetActive(false);
        KatieSpeech[7].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieNeutralAnimator.SetBool("KatieNeutral", true);
        Richard.gameObject.SetActive(false);
    }
    void Speech19()
    {
        NextScene.gameObject.SetActive(true);
        KatieSpeech[7].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardNeutralAnimator.SetBool("RichardNeutral", true);
    }
    void ResponseG()
    {
        AminaValue -= 10f;
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        KatieSpeech[2].interactable = true; // makes button iteractable
        KatieSpeech[2].gameObject.SetActive(true);
        ResponseBoss1.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 1; //goes to the next line
        ResponseKatie1.text = dialogue[currentLine]; //checks current line 
        currentLine = 4; //goes to the next line
        ThoughtBubbles[0].gameObject.SetActive(false);
        ThoughtBubbles[2].gameObject.SetActive(false);
        ThoughtBubbles[1].gameObject.SetActive(false);
    }

    void ResponseB()
    {
        
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech[2].interactable = true; // makes button iteractable
        KatieSpeech[2].gameObject.SetActive(true);
        ResponseBoss1.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 2; //goes to the next line
        ResponseKatie1.text = dialogue[currentLine]; //checks current line 
        currentLine = 6; //goes to the next line
        ThoughtBubbles[0].gameObject.SetActive(false);
        ThoughtBubbles[1].gameObject.SetActive(false);
        ThoughtBubbles[2].gameObject.SetActive(false);
        
    }
    void ResponseS()
    {
        AminaValue += 10f;
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieAngry;
        KatieSpeech[2].interactable = true; // makes button iteractable
        KatieSpeech[2].gameObject.SetActive(true);
        ResponseBoss1.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 1; //goes to the next line
        ResponseKatie1.text = dialogue[currentLine]; //checks current line 
        currentLine = 5; //goes to the next line
        ThoughtBubbles[0].gameObject.SetActive(false);
        ThoughtBubbles[1].gameObject.SetActive(false);
        ThoughtBubbles[2].gameObject.SetActive(false);
    }


    void RichResponse1()
    {
        KatieSpeech[3].interactable = true; // makes button iteractable
        KatieSpeech[3].gameObject.SetActive(true);
        ResponseRichard1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 10; //goes to the next line
        ResponseKatie2.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 13; //goes to the next line
        ThoughtBubbles[3].gameObject.SetActive(false);
        ThoughtBubbles[4].gameObject.SetActive(false);
        ThoughtBubbles[5].gameObject.SetActive(false);
    }
    void RichResponse2()
    {
        RichardValue += 10f;
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech[3].interactable = true; // makes button iteractable
        KatieSpeech[3].gameObject.SetActive(true);
        ResponseRichard1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 10; //goes to the next line
        ResponseKatie2.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 14; //goes to the next line
        ThoughtBubbles[3].gameObject.SetActive(false);
        ThoughtBubbles[4].gameObject.SetActive(false);
        ThoughtBubbles[5].gameObject.SetActive(false);
    }
    void RichResponse3()
    {
        RichardValue -= 10f;
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieAngry;
        KatieSpeech[3].interactable = true; // makes button iteractable
        KatieSpeech[3].gameObject.SetActive(true);
        ResponseRichard1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 11; //goes to the next line
        ResponseKatie2.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 15; //goes to the next line
        ThoughtBubbles[3].gameObject.SetActive(false);
        ThoughtBubbles[4].gameObject.SetActive(false);
        ThoughtBubbles[5].gameObject.SetActive(false);
    }
    void RichResponse4()
    {
        KatieSpeech[6].interactable = true; // makes button iteractable
        KatieSpeech[6].gameObject.SetActive(true);
        ResponseKatie3.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 17; //goes to the next line
        ThoughtBubbles[6].gameObject.SetActive(false);
        ThoughtBubbles[7].gameObject.SetActive(false);
        ThoughtBubbles[8].gameObject.SetActive(false);
    }
    void RichResponse5()
    {
        RichardValue -= 10f;
        KatieSpeech[6].interactable = true; // makes button iteractable
        KatieSpeech[6].gameObject.SetActive(true);
        ResponseKatie3.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 18; //goes to the next line
        ThoughtBubbles[6].gameObject.SetActive(false);
        ThoughtBubbles[7].gameObject.SetActive(false);
        ThoughtBubbles[8].gameObject.SetActive(false);
    }
    void RichResponse6()
    {
        RichardValue += 10f;
        KatieSpeech[6].interactable = true; // makes button iteractable
        KatieSpeech[6].gameObject.SetActive(true);
        ResponseKatie3.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 19; //goes to the next line
        ThoughtBubbles[6].gameObject.SetActive(false);
        ThoughtBubbles[7].gameObject.SetActive(false);
        ThoughtBubbles[8].gameObject.SetActive(false);
    }

    IEnumerator transitionPanel() //panel timer
    {
        yield return new WaitForSeconds(1f);
        canClick = true;
    }
}
