using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class Scene2Script : MonoBehaviour
{
    public DiaryTexts transitionScreen;
    public Button transitionImage;
    bool canClick = false;

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

        Button Transition = transitionImage.GetComponent<Button>();
        Transition.onClick.AddListener(TB1);

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
        Button r4 = response4.GetComponent<Button>();
        r4.onClick.AddListener(RichResponse1);
        Button r5 = response5.GetComponent<Button>();
        r5.onClick.AddListener(RichResponse2);
        Button r6 = response6.GetComponent<Button>();
        r6.onClick.AddListener(RichResponse3);
        Button r7 = response7.GetComponent<Button>();
        r7.onClick.AddListener(RichResponse4);
        Button r8 = response8.GetComponent<Button>();
        r8.onClick.AddListener(RichResponse5);
        Button r9 = response9.GetComponent<Button>();
        r9.onClick.AddListener(RichResponse6);
        Button RS1 = RobinSpeech1.GetComponent<Button>();
        RS1.onClick.AddListener(Speech1);
        Button KS1 = KatieSpeech1.GetComponent<Button>();
        KS1.onClick.AddListener(Speech2);
        Button RS2 = RobinSpeech2.GetComponent<Button>();
        RS2.onClick.AddListener(Speech3);
        Button KS2 = KatieSpeech2.GetComponent<Button>();
        KS2.onClick.AddListener(Speech4);
        Button  BS1 = BossSpeech1.GetComponent<Button>();
        BS1.onClick.AddListener(Speech5);
        Button KS3 = KatieSpeech3.GetComponent<Button>();
        KS3.onClick.AddListener(Speech6);
        Button BS2 = BossSpeech2.GetComponent<Button>();
        BS2.onClick.AddListener(Speech7);
        Button BS3 = BossSpeech3.GetComponent<Button>();
        BS3.onClick.AddListener(Speech8);
        Button RichS1 = RichardSpeech1.GetComponent<Button>();
        RichS1.onClick.AddListener(Speech9);
        Button KS4 = KatieSpeech4.GetComponent<Button>();
        KS4.onClick.AddListener(Speech10);
        Button RichS2 = RichardSpeech2.GetComponent<Button>();
        RichS2.onClick.AddListener(Speech11);
        Button RichS3 = RichardSpeech3.GetComponent<Button>();
        RichS3.onClick.AddListener(Speech12);
        Button KS5 = KatieSpeech5.GetComponent<Button>();
        KS5.onClick.AddListener(Speech13);
        Button RichS4 = RichardSpeech4.GetComponent<Button>();
        RichS4.onClick.AddListener(Speech14);
        Button KS6 = KatieSpeech6.GetComponent<Button>();
        KS6.onClick.AddListener(Speech15);
        Button RichS5 = RichardSpeech5.GetComponent<Button>();
        RichS5.onClick.AddListener(Speech16);
        Button KS7 = KatieSpeech7.GetComponent<Button>();
        KS7.onClick.AddListener(Speech17);
        Button RichS6 = RichardSpeech6.GetComponent<Button>();
        RichS6.onClick.AddListener(Speech18);
        Button KS8 = KatieSpeech8.GetComponent<Button>();
        KS8.onClick.AddListener(Speech19);
        
    }

    void TB1()
    {
        //the first thought bubble will be displayed" -SD
        if (canClick)
        {
            transitionScreen.gameObject.SetActive(false);
            RobinSpeech1.gameObject.SetActive(true);
        }
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
        currentLine = 5; //goes to the next line
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
