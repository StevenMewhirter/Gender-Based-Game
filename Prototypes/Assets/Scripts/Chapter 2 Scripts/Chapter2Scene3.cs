using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Chapter2Scene3 : MonoBehaviour
{
    public Button[] Choices;
    private UnityAction[] ChoicesFunctionToCall;
    private string AminaClue;
    private string JasonClue;
    private string RichardClue;

    public Text ClueBox;
    public GameObject Transparent;

    //public Button[] Thought;
    //private UnityAction[] ThoughtFunctionToCall;

    public Button[] Robin;
    private UnityAction[] RobinFunctionToCall;

    public Button[] Amina;
    private UnityAction[] AminaFunctionToCall;

    public Button[] Richard;
    private UnityAction[] RichardFunctionToCall;

    public Button[] Jason;
    private UnityAction[] JasonFunctionToCall;

    public Button[] Clue;
    private UnityAction[] ClueFunctionToCall;

    public RawImage RobinRawIm;
    //public Texture RobinNeutral;
    //public Texture RobinSad;
    public Texture[] RobinEmotions;
    public GameObject RobinImage;

    public RawImage AminaRawIm;
    //public Texture AminaNeutral;
    //public Texture AminaHappy;
    public Texture[] AminaEmotions;
    public GameObject AminaImage;
    public GameObject AminaHead;

    public RawImage JasonRawIm;
    //public Texture JasonNeutral;
    //public Texture JasonAngry;
    public Texture[] JasonEmotions;
    public GameObject JasonImage;
    public GameObject JasonHead;

    public RawImage RichardRawIm;
    //public Texture RichardNeutral;
    //public Texture RichardAngry;
    public Texture[] RichardEmotions;
    public GameObject RichardImage;
    public GameObject RichardHead;

    public GameObject Background;
    public GameObject EndBackground;
    public Button NextScene;

    public Animator RobinRIAnimator;
    public Animator AminaRIAnimator;
    public Animator JasonRIAnimator;
    public Animator RichardRIAnimator;
    public Animator AminaAnimator;


    void Start()
    {
        NextScene.gameObject.SetActive(false);
        AminaRawIm.gameObject.SetActive(false);
        JasonRawIm.gameObject.SetActive(false);
        RichardRawIm.gameObject.SetActive(false);
        EndBackground.gameObject.SetActive(false);
        ClueBox.gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
     
        AminaHead.gameObject.SetActive(false);
        JasonHead.gameObject.SetActive(false);
        RichardHead.gameObject.SetActive(false);

        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            Choices[responseIndex].gameObject.SetActive(false);
        }

        //for (int responseIndex = 0; responseIndex < Thought.Length; ++responseIndex)
        //{
        //    Thought[responseIndex].gameObject.SetActive(false);
        //}

        for (int responseIndex = 0; responseIndex < Robin.Length; ++responseIndex)
        {
            Robin[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Amina.Length; ++responseIndex)
        {
            Amina[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Richard.Length; ++responseIndex)
        {
            Richard[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Jason.Length; ++responseIndex)
        {
            Jason[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Clue.Length; ++responseIndex)
        {
            Clue[responseIndex].gameObject.SetActive(false);
        }


        //Robin[0].gameObject.SetActive(true);
        //RobinRawIm.gameObject.SetActive(true);
        //RobinImage.gameObject.SetActive(true);
        //Background.gameObject.SetActive(true);

        RSpeech1();


        ChoicesFunctionToCall = new UnityAction[]
        {
           //RSpeech4, RSpeech5, RSpeech6, RSpeech13, RSpeech14, RSpeech15, RSpeech21, RSpeech22, RSpeech23
            RSpeech4, 
            RSpeech5,
            RSpeech6,
            RSpeech13,
            RSpeech14,
            RSpeech15,
            RSpeech21,
            RSpeech22,
            RSpeech23
        };

        //ThoughtFunctionToCall = new UnityAction[]
        //{
        //    ASpeech2, ASpeech3, ASpeech4, JSpeech3, JSpeech4, JSpeech5, RiSpeech2,
        //    RiSpeech3, RiSpeech4
        //};

        RobinFunctionToCall = new UnityAction[]
        {
            //RSpeech2, RSpeech3, ASpeech1, ASpeech2, ASpeech3, ASpeech4, RSpeech8, RSpeech9, RSpeech10, JSpeech1, 
            //JSpeech2, Choice2, JSpeech3, JSpeech4, JSpeech5, RSpeech17, RSpeech18, RSpeech19, 
            //RiSpeech1, Choice3, RiSpeech2, RiSpeech3, RiSpeech4, RSpeech25

            RSpeech2,
            RSpeech3,
            ASpeech1,
            ASpeech2,
            ASpeech3,
            ASpeech4,
            RSpeech8,
            RSpeech9,
            RSpeech10,
            JSpeech1,
            JSpeech2,
            Choice2,
            JSpeech3,
            JSpeech4,
            JSpeech5,
            RSpeech17,
            RSpeech18,
            RSpeech19,
            RiSpeech1,
            Choice3,
            RiSpeech2,
            RiSpeech3,
            RiSpeech4,
            RSpeech25,
            AminaClues
        };

        AminaFunctionToCall = new UnityAction[]
        {
            //Choice1, RSpeech7, RSpeech7, RSpeech7
            Choice1,
            RSpeech7,
            RSpeech7,
            RSpeech7
        };

        RichardFunctionToCall = new UnityAction[]
        {
            // RSpeech20, RSpeech24, RSpeech24, RSpeech24
            RSpeech20,
            RSpeech24,
            RSpeech24,
            RSpeech24
        };

        JasonFunctionToCall = new UnityAction[]
        {
            //RSpeech11, RSpeech12, RSpeech16, RSpeech16, RSpeech16
            RSpeech11,
            RSpeech12,
            RSpeech16,
            RSpeech16,
            RSpeech16
        };

        ClueFunctionToCall = new UnityAction[]
        {
            JasonClues,
            RichardClues,
            RSpeech26
        };

        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            AddListenerToChoices(Choices[responseIndex], ChoicesFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Robin.Length - 1; ++responseIndex)
        {
            AddListenerToRobin(Robin[responseIndex], RobinFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Amina.Length; ++responseIndex)
        {
            AddListenerToAmina(Amina[responseIndex], AminaFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Richard.Length; ++responseIndex)
        {
            AddListenerToRichard(Richard[responseIndex], RichardFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Jason.Length; ++responseIndex)
        {
            AddListenerToJason(Jason[responseIndex], JasonFunctionToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Clue.Length; ++responseIndex)
        {
            AddListenerToClues(Clue[responseIndex], ClueFunctionToCall[responseIndex]);
        }
    }

    private void AddListenerToChoices(Button Choices, UnityEngine.Events.UnityAction ChoiceFunctionToCall)
    {
        Choices.onClick.AddListener(ChoiceFunctionToCall);
    }

    private void AddListenerToRobin(Button Robin, UnityEngine.Events.UnityAction RobinFunctionToCall)
    {
        Robin.onClick.AddListener(RobinFunctionToCall);
    }

    private void AddListenerToAmina(Button Amina, UnityEngine.Events.UnityAction AminaFunctionToCall)
    {
        Amina.onClick.AddListener(AminaFunctionToCall);
    }

    private void AddListenerToRichard(Button Richard, UnityEngine.Events.UnityAction RichardFunctionToCall)
    {
        Richard.onClick.AddListener(RichardFunctionToCall);
    }

    private void AddListenerToJason(Button Jason, UnityEngine.Events.UnityAction JasonFunctionToCall)
    {
        Jason.onClick.AddListener(JasonFunctionToCall);
    }

    private void AddListenerToClues(Button Clue, UnityEngine.Events.UnityAction ClueFunctionToCall)
    {
        Clue.onClick.AddListener(ClueFunctionToCall);
    }

    //I must ask all of them and see if I can help Katie in any way
    void RSpeech1()
    {
        Background.gameObject.SetActive(true);
        RobinRawIm.gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);
        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];

        RobinRIAnimator.SetBool("RobinMove", false);
        Robin[0].gameObject.SetActive(true);
    }

    //They are all busy, so I should be careful what I say and be quick. Lets start with Amina
    void RSpeech2()
    {
        Robin[0].gameObject.SetActive(false);

        Robin[1].gameObject.SetActive(true);
    }

    //Hey Amina, can I ask you something about Katie?
    void RSpeech3()
    {
        Robin[1].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        AminaAnimator.SetBool("AminaMove", true);
        Robin[2].gameObject.SetActive(true);
    }

    //Sure, what is it?
    void ASpeech1()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[2].gameObject.SetActive(false);
        //AminaRIAnimator.SetBool("AminaMove", true);
        AminaAnimator.SetBool("AminaMove", true);
        AminaRawIm.gameObject.SetActive(true);
        Amina[0].gameObject.SetActive(true);

        AminaRawIm = (RawImage)AminaImage.GetComponent<RawImage>();
        AminaRawIm.texture = (Texture)AminaEmotions[0];

    }

    void Choice1()
    {
        AminaRawIm.gameObject.SetActive(false);
        Amina[0].gameObject.SetActive(false);

        RobinRIAnimator.SetBool("RobinMove", true);
        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];

        RobinRawIm.gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);

        Choices[0].gameObject.SetActive(true);
        Choices[1].gameObject.SetActive(true);
        Choices[2].gameObject.SetActive(true);

        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    //Did Katie leave before you?
    void RSpeech4()
    {
        Choices[0].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(false);
        Choices[2].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        Robin[3].gameObject.SetActive(true);
        
    }

    //She stayed with jason after I left
    void ASpeech2()
    {
        Robin[3].gameObject.SetActive(false);
        RobinRawIm.gameObject.SetActive(false);

        AminaRawIm.gameObject.SetActive(true);
        Amina[1].gameObject.SetActive(true);

        AminaRawIm = (RawImage)AminaImage.GetComponent<RawImage>();
        AminaRawIm.texture = (Texture)AminaEmotions[0];

        AminaClue = "Katie stayed with Jason after Amina left";
    }
    
    //Did Katie talk about work?
    void RSpeech5()
    {

        Choices[0].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(false);
        Choices[2].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        Robin[4].gameObject.SetActive(true);
    }

    //No, we didn't talk about work that night
    void ASpeech3()
    {
        Robin[4].gameObject.SetActive(false);
        
        RobinRawIm.gameObject.SetActive(false);

        AminaRawIm.gameObject.SetActive(true);
        
        Amina[2].gameObject.SetActive(true);

        AminaRawIm = (RawImage)AminaImage.GetComponent<RawImage>();
        AminaRawIm.texture = (Texture)AminaEmotions[0];

        AminaClue = "No clue collected.";
    }

    //I talked to Katie. She is home and she said she is ill
    void RSpeech6()
    {
        Choices[0].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(false);
        Choices[2].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        Robin[5].gameObject.SetActive(true);


    }

    //Thanks for letting me know, Robin. I will try contacting her again
    void ASpeech4()
    {
        Robin[5].gameObject.SetActive(false);
        
        RobinRawIm.gameObject.SetActive(false);

        AminaRawIm.gameObject.SetActive(true);
        
        Amina[3].gameObject.SetActive(true);

        AminaClue = "Amina looked relieved when she heard Katie was OK";

        AminaRawIm = (RawImage)AminaImage.GetComponent<RawImage>();
        AminaRawIm.texture = (Texture)AminaEmotions[1];
    }

    //Thanks, Amina
    void RSpeech7()
    {
        AminaRawIm.gameObject.SetActive(false);
        Amina[1].gameObject.SetActive(false);
        Amina[2].gameObject.SetActive(false);
        Amina[3].gameObject.SetActive(false);
        

        RobinRawIm.gameObject.SetActive(true);
        
        Robin[6].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[1];
    }

    //Hmm, Amina didnt really notice anything
    void RSpeech8()
    {
        
        Robin[6].gameObject.SetActive(false);

        Transparent.gameObject.SetActive(true);
        Robin[7].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];
    }

    //lets ask Jason now
    void RSpeech9()
    {
        Robin[7].gameObject.SetActive(false);
        Robin[8].gameObject.SetActive(true);
    }

    //Whats up, Jason? How are you keeping?
    void RSpeech10()
    {
        Robin[8].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        Robin[9].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[1];
    }

    //Hello, gorgeous. Not bad, not bad... yourself?
    void JSpeech1()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[9].gameObject.SetActive(false);
        JasonRIAnimator.SetBool("JasonTestBool", true);
        JasonRawIm.gameObject.SetActive(true);

        Jason[0].gameObject.SetActive(true);

        JasonRawIm = (RawImage)JasonImage.GetComponent<RawImage>();
        JasonRawIm.texture = (Texture)JasonEmotions[1];
    }

    //Could be better. I wanted to be there on Friday, but I had a family emergency
    void RSpeech11()
    {
        JasonRawIm.gameObject.SetActive(false);
        Jason[0].gameObject.SetActive(false);
        
        RobinRawIm.gameObject.SetActive(true);
        Robin[10].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[2];
    }

    //oh, yeah. I had a really great time
    void JSpeech2()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[10].gameObject.SetActive(false);
        

        JasonRawIm.gameObject.SetActive(true);

        Jason[1].gameObject.SetActive(true);

        JasonRawIm = (RawImage)JasonImage.GetComponent<RawImage>();
        JasonRawIm.texture = (Texture)JasonEmotions[1];
    }

    //yeah, about that...
    void RSpeech12()
    {
        JasonRawIm.gameObject.SetActive(false);
        Jason[1].gameObject.SetActive(false);

        RobinRawIm.gameObject.SetActive(true);
        Robin[11].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];
    }

    void Choice2()
    {
        Robin[11].gameObject.SetActive(false);

        Choices[3].gameObject.SetActive(true);
        Choices[4].gameObject.SetActive(true);
        Choices[5].gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);

        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    //Do you remember if Katie had a lot to drink?
    void RSpeech13()
    {
        Robin[12].gameObject.SetActive(true);

        Choices[3].gameObject.SetActive(false);
        Choices[4].gameObject.SetActive(false);
        Choices[5].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[2];
    }

    //Oh, yeah. She shouldnt drink that much. It's not safe for girls like her
    void JSpeech3()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[12].gameObject.SetActive(false);

        JasonRawIm.gameObject.SetActive(true);
        Jason[2].gameObject.SetActive(true);

        JasonClue = "Jason said Katie was drunk";

        JasonRawIm = (RawImage)JasonImage.GetComponent<RawImage>();
        JasonRawIm.texture = (Texture)JasonEmotions[0];
    }

    //Did you tell her anything that could've made her upset?
    void RSpeech14()
    {
        Robin[13].gameObject.SetActive(true);

        Choices[3].gameObject.SetActive(false);
        Choices[4].gameObject.SetActive(false);
        Choices[5].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
    }

    //Why would you say that? Did she tell you anything like that? God sake
    void JSpeech4()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[13].gameObject.SetActive(false);

        JasonRawIm.gameObject.SetActive(true);
        Jason[3].gameObject.SetActive(true);

        JasonRawIm = (RawImage)JasonImage.GetComponent<RawImage>();
        JasonRawIm.texture = (Texture)JasonEmotions[3];

        JasonClue = "Jason was angry when Robin asked if he had an argument with Katie";
    }

    //Did you two leave the pub together or seperately?
    void RSpeech15()
    {
        Robin[14].gameObject.SetActive(true);

        Choices[3].gameObject.SetActive(false);
        Choices[4].gameObject.SetActive(false);
        Choices[5].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
    }

    //Nah, I dont remember. But I always stay till late; you can never have enough drinks!
    void JSpeech5()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[14].gameObject.SetActive(false);

        JasonRawIm.gameObject.SetActive(true);
        Jason[4].gameObject.SetActive(true);

        JasonRawIm = (RawImage)JasonImage.GetComponent<RawImage>();
        JasonRawIm.texture = (Texture)JasonEmotions[1];

        JasonClue = "No clue collected.";
    }

    //thanks jason
    void RSpeech16()
    {
        JasonRawIm.gameObject.SetActive(false);
        Jason[2].gameObject.SetActive(false);
        Jason[3].gameObject.SetActive(false);
        Jason[4].gameObject.SetActive(false);

        RobinRawIm.gameObject.SetActive(true);
        Robin[15].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];
    }

    //right, that was awkward
    void RSpeech17()
    {
        Robin[15].gameObject.SetActive(false);

        Robin[16].gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[2];
    }

    //I think Richard was there, too. I better ask him as well
    void RSpeech18()
    {
        Robin[16].gameObject.SetActive(false);

        Robin[17].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];
    }

    //Hi there! How are you today, Richard?
    void RSpeech19()
    {
        Robin[17].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        Robin[18].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[1];
    }

    //Ahh, same old, same old. Still recovering from friday night. I drunk waaaay too much
    void RiSpeech1()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[18].gameObject.SetActive(false);

        RichardRawIm.gameObject.SetActive(true);
        Richard[0].gameObject.SetActive(true);

        RichardRawIm = (RawImage)RichardImage.GetComponent<RawImage>();
        RichardRawIm.texture = (Texture)RichardEmotions[2];
    }

    //Oh, sorry to hear that! Since you mentioned it, I have some questions about that night
    void RSpeech20()
    {
        RichardRawIm.gameObject.SetActive(false);
        Richard[0].gameObject.SetActive(false);

        RobinRawIm.gameObject.SetActive(true);
        Robin[19].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[2];
    }

    void Choice3()
    {
        Robin[19].gameObject.SetActive(false);

        Choices[6].gameObject.SetActive(true);
        Choices[7].gameObject.SetActive(true);
        Choices[8].gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    //Do you remember if Jason was acting weird, or was drunk?
    void RSpeech21()
    {
        Choices[6].gameObject.SetActive(false);
        Choices[7].gameObject.SetActive(false);
        Choices[8].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        Robin[20].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];
    }

    //When isnt he weird and annoying?
    void RiSpeech2()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[20].gameObject.SetActive(false);

        RichardRawIm.gameObject.SetActive(true);
        Richard[1].gameObject.SetActive(true);

        RichardRawIm = (RawImage)RichardImage.GetComponent<RawImage>();
        RichardRawIm.texture = (Texture)RichardEmotions[1];

        RichardClue = "Richard said Jason urged Katie to drink more";
    }

    //Was Katie sad or worried about something?
    void RSpeech22()
    {
        Choices[6].gameObject.SetActive(false);
        Choices[7].gameObject.SetActive(false);
        Choices[8].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        Robin[21].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[2];
    }

    //No, she was having fun. She tried at least, if you consider Jason was there
    void RiSpeech3()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[21].gameObject.SetActive(false);

        RichardRawIm.gameObject.SetActive(true);
        Richard[2].gameObject.SetActive(true);

        RichardClue = "Richard said Katie was fine before he left";

        RichardRawIm = (RawImage)RichardImage.GetComponent<RawImage>();
        RichardRawIm.texture = (Texture)RichardEmotions[0];
    }

    //Are you sure you didnt say something insulting to Katie?
    void RSpeech23()
    {
        Choices[6].gameObject.SetActive(false);
        Choices[7].gameObject.SetActive(false);
        Choices[8].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        Robin[22].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];
    }

    //Im not always rude, OK? Im just stressed lately. I didnt tell her anything
    void RiSpeech4()
    {
        RobinRawIm.gameObject.SetActive(false);
        Robin[22].gameObject.SetActive(false);

        RichardRawIm.gameObject.SetActive(true);
        Richard[3].gameObject.SetActive(true);
        RichardClue = "No clue collected.";

        RichardRawIm = (RawImage)RichardImage.GetComponent<RawImage>();
        RichardRawIm.texture = (Texture)RichardEmotions[3];
    }

    //Thanks, Richard.
    void RSpeech24()
    {
        RichardRawIm.gameObject.SetActive(false);
        Richard[1].gameObject.SetActive(false);
        Richard[2].gameObject.SetActive(false);
        Richard[3].gameObject.SetActive(false);

        RobinRawIm.gameObject.SetActive(true);
        Robin[23].gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];
    }

    //So I think I know where this is going... I should check all the clues I gathered again.
    void RSpeech25()
    {
        Robin[23].gameObject.SetActive(false);

        Robin[24].gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);
    }

    void AminaClues()
    {
        RobinRawIm.gameObject.SetActive(false);
        Background.gameObject.SetActive(false);
        Robin[24].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);

        EndBackground.gameObject.SetActive(true);
        AminaHead.gameObject.SetActive(true);
        ClueBox.gameObject.SetActive(true);
        Clue[0].gameObject.SetActive(true);

        ClueBox.text = AminaClue;
    }

    void JasonClues()
    {
        AminaHead.gameObject.SetActive(false);
        Clue[0].gameObject.SetActive(false);

        JasonHead.gameObject.SetActive(true);
        ClueBox.text = JasonClue;
        Clue[1].gameObject.SetActive(true);
    }

    void RichardClues()
    {
        JasonHead.gameObject.SetActive(false);
        Clue[1].gameObject.SetActive(false);

        RichardHead.gameObject.SetActive(true);
        Clue[2].gameObject.SetActive(true);
        ClueBox.text = RichardClue;
    }

    //I have to talk to Katie again. Maybe I can help her
    void RSpeech26()
    {
        EndBackground.gameObject.SetActive(false);
        RichardHead.gameObject.SetActive(false);
        ClueBox.gameObject.SetActive(false);
        Transparent.gameObject.SetActive(true);
        Clue[2].gameObject.SetActive(false);

        Background.gameObject.SetActive(true);
        RobinRawIm.gameObject.SetActive(true);
        NextScene.gameObject.SetActive(true);

        RobinRawIm = (RawImage)RobinImage.GetComponent<RawImage>();
        RobinRawIm.texture = (Texture)RobinEmotions[0];
    }
}