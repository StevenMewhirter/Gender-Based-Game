using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;


public class Chapter2Scene2 : MonoBehaviour
{
    public GameObject transition;

    public Button[] KatieSpeech;
    private UnityAction[] KatieSpeechFunctionsToCall;
    public Button[] RobinSpeech;
    private UnityAction[] RobinSpeechFunctionsToCall;
    public Button[] ThoughtBubbles;
    private UnityAction[] ThoughtBubblesFunctionsToCall;
    public Button[] Interactive;
    private UnityAction[] InteractiveFunctionsToCall;

    public Button Laptop;
    public Button Diary;
    public Button KatieInter;
    public Button Bin;
    public Button NextLevel;

    public Texture KatieSad;
    public Texture KatieAngry;
    public Texture KatieNeutral;
    public Texture KatieHappy;
    public GameObject ImageOfKatie;

    public Texture RobinSad;
    public Texture RobinAngry;
    public Texture RobinHappy;
    public Texture RobinNeutral;
    public GameObject ImageOfRobin;
  

    public RawImage Robin;
    public RawImage Katie;

    public Text ResponseRobin2;
    public Text ResponseRobin1;
    public Text ResponseRobin;
    public Text ResponseKatie;
    public Text clue;

    public TextAsset textFile; //stores the text file
    public string[] dialogue; //creates a list of each text line
  
    public int currentLine;
    public int currentLine1;
    public int currentLine2;
    public int currentLine3;
    public int currentLine4;
    public int endLine;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waitForTransition());
        Bin.gameObject.SetActive(false);
        Diary.gameObject.SetActive(false);
        KatieInter.gameObject.SetActive(false);
        Laptop.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        NextLevel.gameObject.SetActive(false);
        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            KatieSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            RobinSpeech[responseIndex].gameObject.SetActive(false);
        }
        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            ThoughtBubbles[responseIndex].gameObject.SetActive(false);
        }
        for (int responseIndex = 0; responseIndex < Interactive.Length; ++responseIndex)
        {
            Interactive[responseIndex].gameObject.SetActive(false);
        }
        RobinSpeech[0].gameObject.SetActive(true);
        //Button Transition = transitionImage.GetComponent<Button>();
        //Transition.onClick.AddListener(Speech0);

        ThoughtBubblesFunctionsToCall = new UnityAction[]
        {
           Response,
           Response1,
           Response2,
           Response3,
           Response4

        };

        RobinSpeechFunctionsToCall = new UnityAction[]
       {
          RSpeech,
          RSpeech1,
          RSpeech2,
          RSpeech3,
          RSpeech4,
          Interactibles

       };
        KatieSpeechFunctionsToCall = new UnityAction[]
        {
            KSpeech,
            KSpeech1,
            KSpeech2,
            KSpeech3
            
        };

        InteractiveFunctionsToCall = new UnityAction[]
       {
           viewBin,
             Interactibles,
           viewDiary,
             Interactibles,
           viewKatie,
             Interactibles,
           viewLaptop,
             Interactibles
       };

        if (textFile != null) // checks if there is text
        {
            dialogue = (textFile.text.Split('\n'));// retreiving the dialogue from file and split it into spaces

        }

        if (endLine == 0) // stops the text at the last line
        {
            endLine = dialogue.Length - 1;
        }


        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            AddListenerToThoughtButton(ThoughtBubbles[responseIndex], ThoughtBubblesFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            AddListenerToKatieSpeechButton(KatieSpeech[responseIndex], KatieSpeechFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            AddListenerToRobinSpeechButton(RobinSpeech[responseIndex], RobinSpeechFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Interactive.Length; ++responseIndex)
        {
            AddListenerToInteractiveButton(Interactive[responseIndex], InteractiveFunctionsToCall[responseIndex]);
        }
    }
    private void AddListenerToThoughtButton(Button ThoughtBubbles, UnityEngine.Events.UnityAction ThoughtBubblesFunctionsToCall)
    {
        ThoughtBubbles.onClick.AddListener(ThoughtBubblesFunctionsToCall);
    }
    private void AddListenerToKatieSpeechButton(Button KatieSpeech, UnityEngine.Events.UnityAction KatieSpeechFunctionsToCall)
    {
        KatieSpeech.onClick.AddListener(KatieSpeechFunctionsToCall);
    }

    private void AddListenerToRobinSpeechButton(Button RobinSpeech, UnityEngine.Events.UnityAction RobinSpeechFunctionsToCall)
    {
        RobinSpeech.onClick.AddListener(RobinSpeechFunctionsToCall);
    }
    private void AddListenerToInteractiveButton(Button Interactive, UnityEngine.Events.UnityAction InteractiveFunctionsToCall)
    {
        Interactive.onClick.AddListener(InteractiveFunctionsToCall);
    }
    void Update()
    {
        ResponseRobin.text = dialogue[currentLine]; //checks current line  
        ResponseRobin1.text = dialogue[currentLine1];
        ResponseRobin2.text = dialogue[currentLine3];
        ResponseKatie.text = dialogue[currentLine2];
        clue.text = dialogue[currentLine4];
    }
        void Speech0()
    {
        //if (canClick)
        //{
            //transitionScreen.gameObject.SetActive(false);
           // KatieSpeech[0].gameObject.SetActive(false);
            RobinSpeech[0].gameObject.SetActive(true);
            Robin.gameObject.SetActive(true);
           
            RobinSpeech[0].interactable = false;
            ThoughtBubbles[0].gameObject.SetActive(true);
            ThoughtBubbles[2].gameObject.SetActive(true);
            ThoughtBubbles[1].gameObject.SetActive(true);
        //}
    }
    void Response()
    {

        RobinSpeech[0].interactable = true; // makes button iteractable
        ResponseRobin.text = dialogue[currentLine]; //checks current line 
        currentLine = 2; //goes to the next line
        ThoughtBubbles[0].gameObject.SetActive(false);
        ThoughtBubbles[2].gameObject.SetActive(false);
        ThoughtBubbles[1].gameObject.SetActive(false);
    }
    void Response1()
    {
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinSad;

        RobinSpeech[0].interactable = true; // makes button iteractable
        ResponseRobin.text = dialogue[currentLine]; //checks current line 
        currentLine = 3; //goes to the next line
        ThoughtBubbles[0].gameObject.SetActive(false);
        ThoughtBubbles[2].gameObject.SetActive(false);
        ThoughtBubbles[1].gameObject.SetActive(false);
    }
    void Response2()
    {
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinAngry;

        RobinSpeech[0].interactable = true; // makes button iteractable
        ResponseRobin.text = dialogue[currentLine]; //checks current line 
        currentLine = 4; //goes to the next line
        ThoughtBubbles[0].gameObject.SetActive(false);
        ThoughtBubbles[2].gameObject.SetActive(false);
        ThoughtBubbles[1].gameObject.SetActive(false);
    }
    void RSpeech()
    {
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieSad;
        RobinSpeech[0].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        KatieSpeech[0].gameObject.SetActive(true);
        Katie.gameObject.SetActive(true);
    }
    void KSpeech()
    {
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinSad;
        RobinSpeech[1].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        KatieSpeech[0].gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
    }
    void RSpeech1()
    {
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieSad;
        RobinSpeech[1].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        KatieSpeech[1].gameObject.SetActive(true);
        Katie.gameObject.SetActive(true);
    }
    void KSpeech1()
    {
        //Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        //Robin.texture = (Texture)RobinNeutral;
        RobinSpeech[2].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        KatieSpeech[1].gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
    }
    void RSpeech2()
    {
        //Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        //Robin.texture = (Texture)RobinNeutral;
        RobinSpeech[2].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        KatieSpeech[2].gameObject.SetActive(true);
        Katie.gameObject.SetActive(true);
    }
    void KSpeech2()
    {
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;
        RobinSpeech[3].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        KatieSpeech[2].gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        RobinSpeech[3].interactable = false;
        ThoughtBubbles[4].gameObject.SetActive(true);
        ThoughtBubbles[3].gameObject.SetActive(true);
    }
   

    void Response3()
    {
        ResponseKatie.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 9; //goes to the next line
        RobinSpeech[3].interactable = true; // makes button iteractable
        ResponseRobin1.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 6; //goes to the next line
        ResponseRobin2.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 12; //goes to the next line
        clue.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 15; //goes to the next line
        ThoughtBubbles[3].gameObject.SetActive(false);
        ThoughtBubbles[4].gameObject.SetActive(false);
        Destroy(KatieInter.gameObject);
       
    }
    void Response4()
    {
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinAngry;
        RobinSpeech[3].interactable = true; // makes button iteractable
        ResponseRobin1.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 7; //goes to the next line
        ResponseKatie.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 10; //goes to the next line
        ResponseRobin2.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 13; //goes to the next line
        clue.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 16; //goes to the next line
        ThoughtBubbles[4].gameObject.SetActive(false);
        ThoughtBubbles[3].gameObject.SetActive(false);
        
    }
    void RSpeech3()
    {
        //Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        //Robin.texture = (Texture)RobinNeutral;
        RobinSpeech[3].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        KatieSpeech[3].gameObject.SetActive(true);
        Katie.gameObject.SetActive(true);
    }
    void KSpeech3()
    {
        //Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        //Robin.texture = (Texture)RobinNeutral;

        RobinSpeech[4].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        KatieSpeech[3].gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
    }
    void RSpeech4()
    {
      //  Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        //Robin.texture = (Texture)RobinNeutral;

        RobinSpeech[5].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        RobinSpeech[4].gameObject.SetActive(false);
       

    }

    IEnumerator waitForTransition()
    {
        yield return new WaitForSeconds(8f);
        transition.SetActive(false);
        //ThoughtBubbles[0].gameObject.SetActive(true);
        Speech0();
    }

    void Interactibles()
    {
        RobinSpeech[5].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        Interactive[0].gameObject.SetActive(true);
        Interactive[1].gameObject.SetActive(false);
        Interactive[2].gameObject.SetActive(true);
        Interactive[3].gameObject.SetActive(false);
        Interactive[4].gameObject.SetActive(true);
        Interactive[5].gameObject.SetActive(false);
        Interactive[6].gameObject.SetActive(true);
        Interactive[7].gameObject.SetActive(false);
        Bin.gameObject.SetActive(true);
        NextLevel.gameObject.SetActive(true);
    }
    void viewLaptop()
    {
        Interactive[0].gameObject.SetActive(false);
        Interactive[1].gameObject.SetActive(false);
        Interactive[2].gameObject.SetActive(false);
        Interactive[3].gameObject.SetActive(false);
        Interactive[4].gameObject.SetActive(false);
        Interactive[5].gameObject.SetActive(false);
        Interactive[6].gameObject.SetActive(false);
        Interactive[7].gameObject.SetActive(true);
        Laptop.gameObject.SetActive(false);
        KatieInter.gameObject.SetActive(false);
        Bin.gameObject.SetActive(false);
        Diary.gameObject.SetActive(false);
        NextLevel.gameObject.SetActive(false);
    }
    void viewDiary()
    {
        Interactive[0].gameObject.SetActive(false);
        Interactive[1].gameObject.SetActive(false);
        Interactive[2].gameObject.SetActive(false);
        Interactive[3].gameObject.SetActive(true);
        Interactive[4].gameObject.SetActive(false);
        Interactive[5].gameObject.SetActive(false);
        Interactive[6].gameObject.SetActive(false);
        Interactive[7].gameObject.SetActive(false);
        Laptop.gameObject.SetActive(false);
        KatieInter.gameObject.SetActive(false);
        Bin.gameObject.SetActive(false);
        Diary.gameObject.SetActive(false);
        NextLevel.gameObject.SetActive(false);
    }
    void viewKatie()
    {
        Interactive[0].gameObject.SetActive(false);
        Interactive[1].gameObject.SetActive(false);
        Interactive[2].gameObject.SetActive(false);
        Interactive[3].gameObject.SetActive(false);
        Interactive[4].gameObject.SetActive(false);
        Interactive[5].gameObject.SetActive(true);
        Interactive[6].gameObject.SetActive(false);
        Interactive[7].gameObject.SetActive(false);
        Laptop.gameObject.SetActive(false);
        KatieInter.gameObject.SetActive(false);
        Bin.gameObject.SetActive(false);
        Diary.gameObject.SetActive(false);
        NextLevel.gameObject.SetActive(false);
    }
    void viewBin()
    {
        Interactive[0].gameObject.SetActive(false);
        Interactive[1].gameObject.SetActive(true);
        Interactive[2].gameObject.SetActive(false);
        Interactive[3].gameObject.SetActive(false);
        Interactive[4].gameObject.SetActive(false);
        Interactive[5].gameObject.SetActive(false);
        Interactive[6].gameObject.SetActive(false);
        Interactive[7].gameObject.SetActive(false);
        Laptop.gameObject.SetActive(false);
        KatieInter.gameObject.SetActive(false);
        Bin.gameObject.SetActive(false);
        Diary.gameObject.SetActive(false);
        NextLevel.gameObject.SetActive(false);
    }
}
