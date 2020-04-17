﻿using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System.Collections;


public class Chapter2Scene2 : MonoBehaviour
{
    public DiaryTexts transitionScreen;
    public Button transitionImage;
    bool canClick = false;

    public Button[] KatieSpeech;
    private UnityAction[] KatieSpeechFunctionsToCall;
    public Button[] RobinSpeech;
    private UnityAction[] RobinSpeechFunctionsToCall;
    public Button[] ThoughtBubbles;
    private UnityAction[] ThoughtBubblesFunctionsToCall;


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

    public Text ResponseRobin1;
    public Text ResponseRobin;

    public TextAsset textFile; //stores the text file
    public string[] dialogue; //creates a list of each text line
  
    public int currentLine;
    public int currentLine1;
    public int endLine;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(transitionPanel());
       // KatieSpeech[0].gameObject.SetActive(false);
       

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

        Button Transition = transitionImage.GetComponent<Button>();
        Transition.onClick.AddListener(Speech0);

        ThoughtBubblesFunctionsToCall = new UnityAction[]
        {
           Response,
           Response1,
           Response2

        };

        RobinSpeechFunctionsToCall = new UnityAction[]
       {
          RSpeech

       };
        KatieSpeechFunctionsToCall = new UnityAction[]
        {
            KSpeech
            
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
    void Update()
    {
        ResponseRobin.text = dialogue[currentLine]; //checks current line  
      //  ResponseRobin1.text = dialogue[currentLine1];
    }
        void Speech0()
    {
        if (canClick)
        {
            transitionScreen.gameObject.SetActive(false);
           // KatieSpeech[0].gameObject.SetActive(false);
            RobinSpeech[0].gameObject.SetActive(true);
            Robin.gameObject.SetActive(true);
            Katie.gameObject.SetActive(false);
            RobinSpeech[0].interactable = false;
            ThoughtBubbles[0].gameObject.SetActive(true);
            ThoughtBubbles[2].gameObject.SetActive(true);
            ThoughtBubbles[1].gameObject.SetActive(true);
        }
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
        //Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        //Robin.texture = (Texture)RobinAngry;

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
        
        RobinSpeech[1].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        KatieSpeech[0].gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
    }

    IEnumerator transitionPanel() //panel timer
    {
        yield return new WaitForSeconds(1f);
        canClick = true;
    }
}