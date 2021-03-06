﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class Scene2Script : MonoBehaviour
{
    public Button BossSpeech1;//Text box to hold text
    public Button BossSpeech2;//Text box to hold text

    public Button response1;
    public Button response2;
    public Button response3;

    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button RobinSpeech1;
    public Button RobinSpeech2;

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
        
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        Boss.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        // CoWorker.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(false);
        BossSpeech2.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        //RobinSpeech1.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(false);

        if (textFile != null) // checks if there is text
        {
            dialogue = (textFile.text.Split('\n'));// retreiving the dialogue from file and split it into spaces
 
        }

        if(endLine == 0) // stops the text at the last line
        {
            endLine = dialogue.Length - 1; 
        }

        Button r1 = response1.GetComponent<Button>();
        r1.onClick.AddListener(ResponseG);
        Button r2 = response2.GetComponent<Button>();
        r2.onClick.AddListener(ResponseB);
        Button r3 = response3.GetComponent<Button>();
        r3.onClick.AddListener(ResponseS);
        Button RS1 = RobinSpeech1.GetComponent<Button>();
        RS1.onClick.AddListener(Speech1);
        Button KS1 = KatieSpeech1.GetComponent<Button>();
        KS1.onClick.AddListener(Speech2);
        Button RS2 = RobinSpeech2.GetComponent<Button>();
        RS2.onClick.AddListener(Speech3);
        Button KS2 = KatieSpeech2.GetComponent<Button>();
        KS2.onClick.AddListener(Speech4);
        

    }

    private void SceneChange()
    {
        throw new NotImplementedException();
    }

    void Update()
    {
        response.text = dialogue[currentLine]; //checks current line  
    }
    void Speech1()
    {
        KatieSpeech1.gameObject.SetActive(true);
        RobinSpeech1.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void Speech2()
    {
        RobinSpeech2.gameObject.SetActive(true);
        KatieSpeech1.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void Speech3()
    {
        KatieSpeech2.gameObject.SetActive(true);
        RobinSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void Speech4()
    {
        KatieSpeech2.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Boss.gameObject.SetActive(true);
        response1.gameObject.SetActive(true);
        response2.gameObject.SetActive(true);
        response3.gameObject.SetActive(true);

        Handheld.Vibrate();
    }
    void ResponseG()
    {
        BossSpeech2.gameObject.SetActive(true);
        response.text = dialogue[currentLine]; //checks current line 
        currentLine = 1; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }

    void ResponseB()
    {
        BossSpeech2.gameObject.SetActive(true);
        response.text = dialogue[currentLine]; //checks current line 
        currentLine = 2; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        
    }
    void ResponseS()
    {
        BossSpeech2.gameObject.SetActive(true);
        response.text = dialogue[currentLine]; //checks current line 
        currentLine = 1; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        
    }
  
}
