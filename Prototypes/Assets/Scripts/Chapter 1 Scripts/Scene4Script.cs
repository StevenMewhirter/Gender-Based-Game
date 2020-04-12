using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Events;

public class Scene4Script : MonoBehaviour
{
    public DiaryTexts transitionScreen;
    public Button transitionImage;
    bool canClick = false;

    //Changing of textures to convey emotions for katie
    public Texture KatieSad;
    public Texture KatieAngry;
    public Texture KatieNeutral;
    public Texture KatieWorried;
    public Texture KatieHappy;
    public GameObject ImageOfKatie;

    public Texture JasonSad;
    public Texture JasonAngry;
    public Texture JasonNeutral;
    public Texture JasonHappy;
    public GameObject ImageOfJason;

    public Texture AminaNeutral;
    public Texture AminaHappy;
    public GameObject ImageOfAmina;


    public Button[] PlayerResponses;
    private UnityAction[] PlayerResponseFunctionsToCall;
    public Button[] Interactive;
    private UnityAction[] InteractiveFunctionsToCall;
    public Button[] KatieSpeech;
    private UnityAction[] KatieSpeechFunctionsToCall;
    public Button[] ThoughtBubbles;
    private UnityAction[] ThoughtBubblesFunctionsToCall;
    public Button[] BossResponses;
    private UnityAction[] BossResponsesFunctionsToCall;
    public Button[] JasonResponses;
    private UnityAction[] JasonFunctionsToCall;
    public Texture[] KatieEmotions;
    public GameObject[] Blocks;

    //buttons for responses
    public GameObject FirstBlock;
    public GameObject SecondBlock;

    //Buttons for speech
   
    public Button KatieSpeech9;

   

   

    public RawImage MC;
    public RawImage Boss;
    public RawImage CoWorker;

    public Text response;
    public Text responseKatie;
    public Text responseKatie1;
    public Text responseJason;
    public Text responseJason2;
    public Text responseKatie2;

    public TextAsset textFile; //stores the text file
    public string[] dialogue; //creates a list of each text line

    public int currentLine;
    public int currentLine1;
    public int currentLine2;
    public int currentLine3;
    public int currentLine4;
    public int currentLine5;
    public int endLine;

    //Animators for characters sliding in

    public Animator KatieAnimator;
    public Animator JasonAnimator;
    public Animator AminaAnimator;
    public Animator Background;

    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(transitionPanel());
        KatieSpeech9.gameObject.SetActive(false);

        Button Transition = transitionImage.GetComponent<Button>();
        Transition.onClick.AddListener(Starting);

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

        for (int responseIndex = 0; responseIndex < JasonResponses.Length; ++responseIndex)
        {
            JasonResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            KatieSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < BossResponses.Length; ++responseIndex)
        {
            BossResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            ThoughtBubbles[responseIndex].gameObject.SetActive(false);
        }


        if (textFile != null) // checks if there is text
        {
            dialogue = (textFile.text.Split('\n'));// retreiving the dialogue from file and split it into spaces

        }

        if (endLine == 0) // stops the text at the last line
        {
            endLine = dialogue.Length - 1;
        }

        ThoughtBubblesFunctionsToCall = new UnityAction[]
        {
            ResponseA,
            ResponseB,
            ResponseC,
            ResponseD,
            ResponseE,
            ResponseF
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
            KSpeech1,
            KSpeech2,
            KSpeech3,
            KSpeech4,
            KSpeechResponse1,
            KSpeech5,
            KSpeech6,
            KSpeech7,
            KSpeech8

        };



        BossResponsesFunctionsToCall = new UnityAction[]
        {
           ASpeech1,
           ASpeech2,
           ASpeech3,
           ASpeech4
          
        };

        JasonFunctionsToCall = new UnityAction[]
        {
            JSpeech1,
            JSpeech2,
             JSpeech3,
            JSpeech4,
            JSpeech5,
             JSpeech6,
            JSpeech7,
          
           
        };
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

        for (int responseIndex = 0; responseIndex < BossResponses.Length; ++responseIndex)
        {
            AddListenerToBossResponsesButton(BossResponses[responseIndex], BossResponsesFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            AddListenerToKatieSpeechButton(KatieSpeech[responseIndex], KatieSpeechFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < JasonResponses.Length; ++responseIndex)
        {
            AddListenerToJasonResponsesButton(JasonResponses[responseIndex], JasonFunctionsToCall[responseIndex]);
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

    private void AddListenerToJasonResponsesButton(Button JasonResponses, UnityEngine.Events.UnityAction JasonFunctionsToCall)
    {
        JasonResponses.onClick.AddListener(JasonFunctionsToCall);
    }


    // Update is called once per frame
    void Update()
    {
        
        responseKatie.text = dialogue[currentLine]; //checks current line
        response.text = dialogue[currentLine1];
        responseKatie1.text = dialogue[currentLine2];
        responseKatie2.text = dialogue[currentLine5];
        responseJason.text = dialogue[currentLine3];
        responseJason2.text = dialogue[currentLine4];
        
        KatieAnimator.SetBool("KatieNeutral", true);
    }

    void Starting()
    {
        if (canClick)
        {
            KatieAnimator.SetBool("KatieNeutral", true);
            MC.gameObject.SetActive(true);
            KatieSpeech[0].gameObject.SetActive(true);
            transitionScreen.gameObject.SetActive(false);
        }
    }

    void KSpeech1()
    {
        KatieSpeech[0].gameObject.SetActive(false);
        KatieSpeech[1].gameObject.SetActive(true);
    }
    void KSpeech2()
    {

        KatieSpeech[1].gameObject.SetActive(false);
        KatieSpeech[2].gameObject.SetActive(true);

    }
    void KSpeech3()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech[2].gameObject.SetActive(false);
        KatieSpeech[3].gameObject.SetActive(true); 
        
    }
    void KSpeech4()
    {
        KatieSpeech[3].gameObject.SetActive(false);
        BossResponses[0].gameObject.SetActive(true);
        Boss.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", true);
        AminaAnimator.SetBool("AminaNeutral", true);
    }
    void ASpeech1()
    {
        Boss = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Boss.texture = (Texture)AminaHappy;
        BossResponses[0].gameObject.SetActive(false);
        BossResponses[1].gameObject.SetActive(true);

    }
    void ASpeech2()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;

        Boss = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Boss.texture = (Texture)AminaNeutral;
        BossResponses[1].gameObject.SetActive(false);
        KatieSpeech[4].gameObject.SetActive(true);
        KatieSpeech[4].interactable = false; // makes button non iteractable
        
        MC.gameObject.SetActive(true);
        Boss.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
        FirstBlock.gameObject.SetActive(true);
        ThoughtBubbles[0].gameObject.SetActive(true);
        ThoughtBubbles[1].gameObject.SetActive(true);
        ThoughtBubbles[2].gameObject.SetActive(true);
        Handheld.Vibrate();
    }
    void ResponseA()
    {
        KatieAnimator.SetBool("KatieNeutral", true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        KatieSpeech[4].interactable = true;
        response.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 8; //goes to the next line
        responseKatie.text = dialogue[currentLine]; //checks current line 
        currentLine = 2; //goes to the next line
        FirstBlock.gameObject.SetActive(false);
        ThoughtBubbles[0].gameObject.SetActive(true);
        ThoughtBubbles[1].gameObject.SetActive(true);
        ThoughtBubbles[2].gameObject.SetActive(true);

    }
    void ResponseB()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech[4].interactable = true;
        response.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 9; //goes to the next line
        responseKatie.text = dialogue[currentLine]; //checks current line 
        currentLine = 3; //goes to the next line
        FirstBlock.gameObject.SetActive(false);
        ThoughtBubbles[0].gameObject.SetActive(true);
        ThoughtBubbles[1].gameObject.SetActive(true);
        ThoughtBubbles[2].gameObject.SetActive(true);

    }
    void ResponseC()
    {
        KatieSpeech[4].interactable = true;
        response.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 10; //goes to the next line
        responseKatie.text = dialogue[currentLine]; //checks current line 
        currentLine = 4; //goes to the next line
        FirstBlock.gameObject.SetActive(false);
        ThoughtBubbles[0].gameObject.SetActive(true);
        ThoughtBubbles[1].gameObject.SetActive(true);
        ThoughtBubbles[2].gameObject.SetActive(true);

    }

    void KSpeechResponse1()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;
        KatieSpeech[4].gameObject.SetActive(false);
        BossResponses[2].gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Boss.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        AminaAnimator.SetBool("AminaNeutral", true);
    }
    void ASpeech3()
    {
        JasonResponses[0].gameObject.SetActive(true);
        BossResponses[2].gameObject.SetActive(false);
        Boss.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonNeutral", true);
    }
    void JSpeech1()
    {
        JasonResponses[0].gameObject.SetActive(false);
        BossResponses[3].gameObject.SetActive(true);
        Boss.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        AminaAnimator.SetBool("AminaNeutral", true);
    }
    void ASpeech4()
    {
        JasonResponses[1].gameObject.SetActive(true);
        BossResponses[3].gameObject.SetActive(false);
        Boss.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonNeutral", true);
    }
    void JSpeech2()
    {
        CoWorker = (RawImage)ImageOfJason.GetComponent<RawImage>();

        CoWorker.texture = (Texture)JasonAngry;
        JasonResponses[1].gameObject.SetActive(false);
        KatieSpeech[5].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
    }
    void KSpeech5()
    {
        JasonResponses[2].gameObject.SetActive(true);
        KatieSpeech[5].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        JasonAnimator.SetBool("JasonNeutral", true);

    }
    void JSpeech3()
    {
        KatieSpeech[6].interactable = false;
        JasonResponses[2].gameObject.SetActive(false);
        KatieSpeech[6].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
        SecondBlock.gameObject.SetActive(true);
        ThoughtBubbles[3].gameObject.SetActive(true);
        ThoughtBubbles[4].gameObject.SetActive(true);
        ThoughtBubbles[5].gameObject.SetActive(true);

        Handheld.Vibrate();
    }
    void ResponseD()

    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech[6].interactable = true;
        responseJason.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 24; //goes to the next line
        responseKatie1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 14; //goes to the next line

        responseJason2.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 28; //goes to the next line
        responseKatie2.text = dialogue[currentLine5]; //checks current line 
        currentLine5 = 18; //goes to the next line
        SecondBlock.gameObject.SetActive(false);
        ThoughtBubbles[3].gameObject.SetActive(true);
        ThoughtBubbles[4].gameObject.SetActive(true);
        ThoughtBubbles[5].gameObject.SetActive(true);
    }
    void ResponseE()
    {
        //MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        //MC.texture = (Texture)KatieSad;
        KatieSpeech[6].interactable = true;
        responseJason.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 25; //goes to the next line
        responseKatie1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 15; //goes to the next line

        responseJason2.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 29; //goes to the next line
        responseKatie2.text = dialogue[currentLine5]; //checks current line 
        currentLine5 = 19; //goes to the next line
        SecondBlock.gameObject.SetActive(false);
        ThoughtBubbles[3].gameObject.SetActive(true);
        ThoughtBubbles[4].gameObject.SetActive(true);
        ThoughtBubbles[5].gameObject.SetActive(true);
    }
    void ResponseF()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieAngry;

        KatieSpeech[6].interactable = true;
        responseJason.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 26; //goes to the next line
        responseKatie1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 16; //goes to the next line

        responseJason2.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 30; //goes to the next line
        responseKatie2.text = dialogue[currentLine5]; //checks current line 
        currentLine5 = 20; //goes to the next line
        SecondBlock.gameObject.SetActive(false);
        ThoughtBubbles[3].gameObject.SetActive(true);
        ThoughtBubbles[4].gameObject.SetActive(true);
        ThoughtBubbles[5].gameObject.SetActive(true);
    }
    void KSpeech6()
    {
        CoWorker = (RawImage)ImageOfJason.GetComponent<RawImage>();

        CoWorker.texture = (Texture)JasonNeutral;
        KatieSpeech[6].gameObject.SetActive(false);
        JasonResponses[3].gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        JasonAnimator.SetBool("JasonNeutral", true);

        Handheld.Vibrate();
    }
    void JSpeech4()
    {
        KatieSpeech[7].gameObject.SetActive(true);
        JasonResponses[3].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
    }
   
    void KSpeech7()
    {
        KatieSpeech[7].gameObject.SetActive(false);
        JasonResponses[4].gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        JasonAnimator.SetBool("JasonNeutral", true);
    }
    void JSpeech5()
    {
        CoWorker = (RawImage)ImageOfJason.GetComponent<RawImage>();

        CoWorker.texture = (Texture)JasonSad;
        JasonResponses[4].gameObject.SetActive(false);
        JasonResponses[5].gameObject.SetActive(true);
    }
    void JSpeech6()
    {
        CoWorker = (RawImage)ImageOfJason.GetComponent<RawImage>();

        CoWorker.texture = (Texture)JasonHappy;
        JasonResponses[5].gameObject.SetActive(false);
        KatieSpeech[8].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
    }
    void KSpeech8()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieWorried;
        JasonResponses[6].gameObject.SetActive(true);
        KatieSpeech[8].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        JasonAnimator.SetBool("JasonNeutral", true);
    }
    void JSpeech7()
    {
        JasonResponses[6].gameObject.SetActive(false);
        KatieSpeech9.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
    }

    IEnumerator transitionPanel() //panel timer
    {
        yield return new WaitForSeconds(1f);
        canClick = true;
    }
}


