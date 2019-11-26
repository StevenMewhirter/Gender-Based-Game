using System.Collections;
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
    public Button response4;
    public Button response5;

    //Buttons for speech
    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
    public Button KatieSpeech5;
    public Button KatieSpeech6;
    public Button KatieSpeech7;
    public Button KatieSpeech8;
    public Button KatieSpeech9;

    public Button AminaSpeech1;
    public Button AminaSpeech2;
    public Button AminaSpeech3;
    public Button AminaSpeech4;

    public Button JasonSpeech1;
    public Button JasonSpeech2;
    public Button JasonSpeech3;
    public Button JasonSpeech4;
    public Button JasonSpeech5;
    public Button JasonSpeech6;
    public Button JasonSpeech7;



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
        KatieSpeech5.gameObject.SetActive(false);
        KatieSpeech6.gameObject.SetActive(false);
        KatieSpeech7.gameObject.SetActive(false);
        KatieSpeech8.gameObject.SetActive(false);
        KatieSpeech9.gameObject.SetActive(false);
        AminaSpeech1.gameObject.SetActive(false);
        AminaSpeech2.gameObject.SetActive(false);
        AminaSpeech3.gameObject.SetActive(false);
        AminaSpeech4.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);
        JasonSpeech2.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(false);
        JasonSpeech4.gameObject.SetActive(false);
        JasonSpeech5.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(false);
        JasonSpeech7.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);

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
        Button KS5 = KatieSpeech5.GetComponent<Button>();
        KS5.onClick.AddListener(KSpeech5);
        Button KS6 = KatieSpeech6.GetComponent<Button>();
        KS6.onClick.AddListener(KSpeech6);
        Button KS7 = KatieSpeech7.GetComponent<Button>();
        KS7.onClick.AddListener(KSpeech7);
        Button KS8 = KatieSpeech8.GetComponent<Button>();
        KS8.onClick.AddListener(KSpeech8);


        Button AS1 = AminaSpeech1.GetComponent<Button>();
        AS1.onClick.AddListener(ASpeech1);
        Button RS1 = response1.GetComponent<Button>();
        RS1.onClick.AddListener(ResponseA);
        Button RS2 = response2.GetComponent<Button>();
        RS2.onClick.AddListener(ResponseB);
        Button RS3 = response3.GetComponent<Button>();
        RS3.onClick.AddListener(ResponseC);
        Button RS4 = response4.GetComponent<Button>();
        RS4.onClick.AddListener(JSpeech3);
        Button RS5 = response5.GetComponent<Button>();
        RS5.onClick.AddListener(JSpeech4);
        Button AS3 = AminaSpeech3.GetComponent<Button>();
        AS3.onClick.AddListener(ASpeech3);
        Button AS4 = AminaSpeech4.GetComponent<Button>();
        AS4.onClick.AddListener(ASpeech4);

        Button JS1 = JasonSpeech1.GetComponent<Button>();
        JS1.onClick.AddListener(JSpeech1);
        Button JS2 = JasonSpeech2.GetComponent<Button>();
        JS2.onClick.AddListener(JSpeech2);
        
        Button JS5 = JasonSpeech5.GetComponent<Button>();
        JS5.onClick.AddListener(JSpeech5);
        Button JS6 = JasonSpeech6.GetComponent<Button>();
        JS6.onClick.AddListener(JSpeech6);
        Button JS7 = JasonSpeech7.GetComponent<Button>();
        JS7.onClick.AddListener(JSpeech7);


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

        Handheld.Vibrate();
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
    void ASpeech4()
    {
        AminaSpeech4.gameObject.SetActive(false);
        JasonSpeech2.gameObject.SetActive(true);
        Boss.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void JSpeech2()
    {
        KatieSpeech5.gameObject.SetActive(true);
        JasonSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech5()
    {
        KatieSpeech5.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(true);
        response4.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);

        Handheld.Vibrate();
    }
    void JSpeech3()
    {
        response4.gameObject.SetActive(false);

        KatieSpeech6.gameObject.SetActive(true);
        JasonSpeech3.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech6()
    {
        KatieSpeech6.gameObject.SetActive(false);
        JasonSpeech4.gameObject.SetActive(true);
        response5.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);

        Handheld.Vibrate();
    }
    void JSpeech4()
    {
        KatieSpeech7.gameObject.SetActive(true);
        JasonSpeech4.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
    }
    void KSpeech7()
    {
        KatieSpeech7.gameObject.SetActive(false);
        JasonSpeech5.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void JSpeech5()
    {
        JasonSpeech5.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(true);
    }
    void JSpeech6()
    {
        JasonSpeech6.gameObject.SetActive(false);
        KatieSpeech8.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech8()
    {
        JasonSpeech7.gameObject.SetActive(true);
        KatieSpeech8.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void JSpeech7()
    {
        JasonSpeech7.gameObject.SetActive(false);
        KatieSpeech9.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
}


