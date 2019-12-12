using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Scene4Script : MonoBehaviour
{
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



    //buttons for responses
    public GameObject FirstBlock;
    public Button response1;
    public Button response2;
    public Button response3;
    public GameObject SecondBlock;
    public Button response4;
    public Button response5;
    public Button response6;
    //public Button response7;
    //public Button response8;
    //public Button response9;

    //Buttons for speech
    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
    public Button KatieSpeechResponse1;
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
       
        Boss.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        KatieSpeechResponse1.gameObject.SetActive(false);
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
        FirstBlock.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        SecondBlock.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
       

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
        Button KR1 = KatieSpeechResponse1.GetComponent<Button>();
        KR1.onClick.AddListener(KSpeechResponse1);
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
        Button AS2 = AminaSpeech2.GetComponent<Button>();
        AS2.onClick.AddListener(ASpeech2);
        Button RS1 = response1.GetComponent<Button>();
        RS1.onClick.AddListener(ResponseA);
        Button RS2 = response2.GetComponent<Button>();
        RS2.onClick.AddListener(ResponseB);
        Button RS3 = response3.GetComponent<Button>();
        RS3.onClick.AddListener(ResponseC);
        Button R4 = response4.GetComponent<Button>();
        R4.onClick.AddListener(ResponseD);
        Button R5 = response5.GetComponent<Button>();
        R5.onClick.AddListener(ResponseE);
        Button R6 = response6.GetComponent<Button>();
        R6.onClick.AddListener(ResponseF);
        Button AS3 = AminaSpeech3.GetComponent<Button>();
        AS3.onClick.AddListener(ASpeech3);
        Button AS4 = AminaSpeech4.GetComponent<Button>();
        AS4.onClick.AddListener(ASpeech4);

        Button JS1 = JasonSpeech1.GetComponent<Button>();
        JS1.onClick.AddListener(JSpeech1);
        Button JS2 = JasonSpeech2.GetComponent<Button>();
        JS2.onClick.AddListener(JSpeech2);
        Button JS3 = JasonSpeech3.GetComponent<Button>();
        JS3.onClick.AddListener(JSpeech3);
        Button JS4 = JasonSpeech4.GetComponent<Button>();
        JS4.onClick.AddListener(JSpeech4);

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
        
        responseKatie.text = dialogue[currentLine]; //checks current line
        response.text = dialogue[currentLine1];
        responseKatie1.text = dialogue[currentLine2];
        responseKatie2.text = dialogue[currentLine5];
        responseJason.text = dialogue[currentLine3];
        responseJason2.text = dialogue[currentLine4];
        
        KatieAnimator.SetBool("KatieNeutral", true);
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
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech4.gameObject.SetActive(true);
        KatieSpeech3.gameObject.SetActive(false);
        
    }
    void KSpeech4()
    {
        KatieSpeech4.gameObject.SetActive(false);
        AminaSpeech1.gameObject.SetActive(true);
        Boss.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", true);
        AminaAnimator.SetBool("AminaNeutral", true);
    }
    void ASpeech1()
    {
        Boss = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Boss.texture = (Texture)AminaHappy;
        AminaSpeech2.gameObject.SetActive(true);
        AminaSpeech1.gameObject.SetActive(false);
       
    }
    void ASpeech2()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;

        Boss = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Boss.texture = (Texture)AminaNeutral;

        KatieSpeechResponse1.gameObject.SetActive(true);
        KatieSpeechResponse1.interactable = false; // makes button non iteractable
        AminaSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Boss.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
        FirstBlock.gameObject.SetActive(true);
        response1.gameObject.SetActive(true);
        response2.gameObject.SetActive(true);
        response3.gameObject.SetActive(true);


        Handheld.Vibrate();
    }
    void ResponseA()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        KatieSpeechResponse1.interactable = true;
        response.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 8; //goes to the next line
        responseKatie.text = dialogue[currentLine]; //checks current line 
        currentLine = 2; //goes to the next line
        FirstBlock.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }
    void ResponseB()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeechResponse1.interactable = true;
        response.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 9; //goes to the next line
        responseKatie.text = dialogue[currentLine]; //checks current line 
        currentLine = 3; //goes to the next line
        FirstBlock.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }
    void ResponseC()
    {
        KatieSpeechResponse1.interactable = true;
        response.text = dialogue[currentLine1]; //checks current line 
        currentLine1 = 10; //goes to the next line
        responseKatie.text = dialogue[currentLine]; //checks current line 
        currentLine = 4; //goes to the next line
        FirstBlock.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
    }

    void KSpeechResponse1()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;
        KatieSpeechResponse1.gameObject.SetActive(false);
        AminaSpeech3.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Boss.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        AminaAnimator.SetBool("AminaNeutral", true);
    }
    void ASpeech3()
    {
        AminaSpeech3.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(true);
        Boss.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonNeutral", true);
    }
    void JSpeech1()
    {
        AminaSpeech4.gameObject.SetActive(true);
        JasonSpeech1.gameObject.SetActive(false);
        Boss.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        AminaAnimator.SetBool("AminaNeutral", true);
    }
    void ASpeech4()
    {
        AminaSpeech4.gameObject.SetActive(false);
        JasonSpeech2.gameObject.SetActive(true);
        Boss.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonNeutral", true);
    }
    void JSpeech2()
    {
        CoWorker = (RawImage)ImageOfJason.GetComponent<RawImage>();

        CoWorker.texture = (Texture)JasonAngry;
        KatieSpeech5.gameObject.SetActive(true);
        JasonSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
    }
    void KSpeech5()
    {
        KatieSpeech5.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        JasonAnimator.SetBool("JasonNeutral", true);

    }
    void JSpeech3()
    {
        KatieSpeech6.interactable = false;
        KatieSpeech6.gameObject.SetActive(true);
        JasonSpeech3.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
        SecondBlock.gameObject.SetActive(true);
        response4.gameObject.SetActive(true);
        response5.gameObject.SetActive(true);
        response6.gameObject.SetActive(true);

        Handheld.Vibrate();
    }
    void ResponseD()

    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieSad;
        KatieSpeech6.interactable = true;
        responseJason.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 24; //goes to the next line
        responseKatie1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 14; //goes to the next line

        responseJason2.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 28; //goes to the next line
        responseKatie2.text = dialogue[currentLine5]; //checks current line 
        currentLine5 = 18; //goes to the next line
        SecondBlock.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
    }
    void ResponseE()
    {
        //MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        //MC.texture = (Texture)KatieSad;
        KatieSpeech6.interactable = true;
        responseJason.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 25; //goes to the next line
        responseKatie1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 15; //goes to the next line

        responseJason2.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 29; //goes to the next line
        responseKatie2.text = dialogue[currentLine5]; //checks current line 
        currentLine5 = 19; //goes to the next line
        SecondBlock.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
    }
    void ResponseF()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieAngry;

        KatieSpeech6.interactable = true;
        responseJason.text = dialogue[currentLine3]; //checks current line 
        currentLine3 = 26; //goes to the next line
        responseKatie1.text = dialogue[currentLine2]; //checks current line 
        currentLine2 = 16; //goes to the next line

        responseJason2.text = dialogue[currentLine4]; //checks current line 
        currentLine4 = 30; //goes to the next line
        responseKatie2.text = dialogue[currentLine5]; //checks current line 
        currentLine5 = 20; //goes to the next line
        SecondBlock.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
    }
    void KSpeech6()
    {
        CoWorker = (RawImage)ImageOfJason.GetComponent<RawImage>();

        CoWorker.texture = (Texture)JasonNeutral;
        KatieSpeech6.gameObject.SetActive(false);
        JasonSpeech4.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        JasonAnimator.SetBool("JasonNeutral", true);

        Handheld.Vibrate();
    }
    void JSpeech4()
    {
        KatieSpeech7.gameObject.SetActive(true);
        JasonSpeech4.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        //response7.gameObject.SetActive(true);
        //response8.gameObject.SetActive(true);
        //response9.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
    }
   
    void KSpeech7()
    {
        KatieSpeech7.gameObject.SetActive(false);
        JasonSpeech5.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        JasonAnimator.SetBool("JasonNeutral", true);
    }
    void JSpeech5()
    {
        CoWorker = (RawImage)ImageOfJason.GetComponent<RawImage>();

        CoWorker.texture = (Texture)JasonSad;
        JasonSpeech5.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(true);
    }
    void JSpeech6()
    {
        CoWorker = (RawImage)ImageOfJason.GetComponent<RawImage>();

        CoWorker.texture = (Texture)JasonHappy;
        JasonSpeech6.gameObject.SetActive(false);
        KatieSpeech8.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
    }
    void KSpeech8()
    {
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieWorried;
        JasonSpeech7.gameObject.SetActive(true);
        KatieSpeech8.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
        Background.SetBool("SlideToOther", true);
        JasonAnimator.SetBool("JasonNeutral", true);
    }
    void JSpeech7()
    {
        JasonSpeech7.gameObject.SetActive(false);
        KatieSpeech9.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
        Background.SetBool("SlideToOther", false);
        KatieAnimator.SetBool("KatieNeutral", true);
    }
}


