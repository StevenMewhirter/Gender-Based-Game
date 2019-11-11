﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Scene4Script : MonoBehaviour
{
    //buttons for responses
    public Button response1;
    public Button response2;
    public Button response3;
    //Buttons for speech
    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
    public Button AminaSpeech1;
    public Button AminaSpeech2;
    public Button AminaSpeech3;
    public Button AminaSpeech4;
    public Button JasonSpeech1;


    public RawImage MC;
    public RawImage Boss;
    public RawImage CoWorker;

    public Text response;

    public TextAsset textFile; //stores the text file
    public string[] dialogue; //creates a list of each text line

    public int currentLine;
    public int endLine;

    // Start is called before the first frame update
    void Start()
    {
       
        Boss.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        AminaSpeech1.gameObject.SetActive(false);
        AminaSpeech2.gameObject.SetActive(false);
        AminaSpeech3.gameObject.SetActive(false);
        AminaSpeech4.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);

        if (textFile != null) // checks if there is text
        {
            dialogue = (textFile.text.Split('\n'));// retreiving the dialogue from file and split it into spaces

        }

        if (endLine == 0) // stops the text at the last line
        {
            endLine = dialogue.Length - 1;
        }


        Button KS1 = KatieSpeech1.GetComponent<Button>();
        KS1.onClick.AddListener(KSpeech1);
        Button KS2 = KatieSpeech2.GetComponent<Button>();
        KS2.onClick.AddListener(KSpeech2);
        Button KS3 = KatieSpeech3.GetComponent<Button>();
        KS3.onClick.AddListener(KSpeech3);
        Button KS4 = KatieSpeech4.GetComponent<Button>();
        KS4.onClick.AddListener(KSpeech4);
        Button AS1 = AminaSpeech1.GetComponent<Button>();
        AS1.onClick.AddListener(ASpeech1);
        Button RS1 = response1.GetComponent<Button>();
        RS1.onClick.AddListener(ResponseA);
        Button RS2 = response2.GetComponent<Button>();
        RS2.onClick.AddListener(ResponseB);
        Button RS3 = response3.GetComponent<Button>();
        RS3.onClick.AddListener(ResponseC);
        Button AS3 = AminaSpeech3.GetComponent<Button>();
        AS3.onClick.AddListener(ASpeech3);
        Button JS1 = JasonSpeech1.GetComponent<Button>();
        JS1.onClick.AddListener(JSpeech1);

    }

    // Update is called once per frame
    void Update()
    {
        response.text = dialogue[currentLine]; //checks current line  
    }
    void KSpeech1()
    {
        KatieSpeech1.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(true);
    }
    void KSpeech2()
    {
        KatieSpeech3.gameObject.SetActive(true);
        KatieSpeech2.gameObject.SetActive(false);
       
    }
    void KSpeech3()
    {
        KatieSpeech4.gameObject.SetActive(true);
        KatieSpeech3.gameObject.SetActive(false);
        
    }
    void KSpeech4()
    {
        KatieSpeech4.gameObject.SetActive(false);
        AminaSpeech1.gameObject.SetActive(true);
        Boss.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
    }
    void ASpeech1()
    {
        AminaSpeech2.gameObject.SetActive(true);
        AminaSpeech1.gameObject.SetActive(false);
        response1.gameObject.SetActive(true);
        response2.gameObject.SetActive(true);
        response3.gameObject.SetActive(true);
    }
    void ResponseA()
    {
        AminaSpeech3.gameObject.SetActive(true);
        AminaSpeech2.gameObject.SetActive(false);
        response.text = dialogue[currentLine]; //checks current line 
        currentLine = 0; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }
    void ResponseB()
    {
        AminaSpeech3.gameObject.SetActive(true);
        AminaSpeech2.gameObject.SetActive(false);
        response.text = dialogue[currentLine]; //checks current line 
        currentLine = 1; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }
    void ResponseC()
    {
        AminaSpeech3.gameObject.SetActive(true);
        AminaSpeech2.gameObject.SetActive(false);
        response.text = dialogue[currentLine]; //checks current line 
        currentLine = 2; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }

    void ASpeech3()
    {
        AminaSpeech3.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(true);
        Boss.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void JSpeech1()
    {
        AminaSpeech4.gameObject.SetActive(true);
        JasonSpeech1.gameObject.SetActive(false);
        Boss.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
}
