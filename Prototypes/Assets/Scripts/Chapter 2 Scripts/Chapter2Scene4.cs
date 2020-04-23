using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Chapter2Scene4 : MonoBehaviour
{
    public Button[] Choices;
    private UnityAction[] ChoicesFunctionsToCall;
    public Button[] BadScenarioRobin;
    private UnityAction[] BadRobinFunctionsToCall;
    public Button[] GoodScenarioRobin;
    private UnityAction[] GoodRobinFunctionsToCall;
    //sets up a list of Robin's Speech Buttons - SD
    public Button[] RobinSpeech;
    //sets up a private lists of Unity Actions - SD
    private UnityAction[] RobinSpeechfunctionsToCall;
    public Button[] RobinResponses;
    private UnityAction[] RobinResponsesfunctionsToCall;
    public Button[] BadScenarioKatie;
    private UnityAction[] BadKatieFunctionsToCall;
    public Button[] GoodScenarioKatie;
    private UnityAction[] GoodKatieFunctionsToCall;
    //sets up a list of Katie's Speech Buttons - SD
    public Button[] KatieSpeech;
    public Button[] ThoughtBubbles;
    private UnityAction[] ThoughtBubblesfunctionsToCall;
    //sets up a private list of Unity Actions - SD
    private UnityAction[] KatieSpeechfunctionsToCall;
    //sets up a public list of textures to convey Robin's emotions - SD
    public Texture[] RobinEmotions;
    //sets up a public list of textures to convey Katie's emotions - SD
    public Texture[] KatieEmotions;
    //sets up a GameObject to display the Image Of Katie -SD
    public GameObject ImageOfKatie;
    //sets up a GameObject for the transparent text box - SD
    public GameObject Transparent;
    //sets up a GameObject to display the image of Robin - SD
    public GameObject ImageOfRobin;
    //Sets up a public raw image variable for Robin - SD
    public RawImage Robin;
    //Sets up a public raw image variable for Katie - SD
    public RawImage Katie;
    public GameObject ImageOfBedroom;
    public Texture[] Bedrooms;
    public RawImage Bedroom;
    public Animator KatieAnimator;
    public Animator RobinAnimator;
    public Animator KatieRIAnimator;
    public Animator RobinRIAnimator;
    public Button[] EndingLinks;

    void Start()
    {
        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            Choices[responseIndex].gameObject.SetActive(false);
        }

        //Sets all the Robin Speech Boxes to be deactivated - SD
        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            RobinSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < RobinResponses.Length; ++responseIndex)
        {
            RobinResponses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < GoodScenarioRobin.Length; ++responseIndex)
        {
            GoodScenarioRobin[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < GoodScenarioKatie.Length; ++responseIndex)
        {
            GoodScenarioKatie[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < BadScenarioKatie.Length; ++responseIndex)
        {
            BadScenarioKatie[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < BadScenarioRobin.Length; ++responseIndex)
        {
            BadScenarioRobin[responseIndex].gameObject.SetActive(false);
        }
        //Sets all the Katie Speech Boxes to be deactivated - SD
        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            KatieSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            ThoughtBubbles[responseIndex].gameObject.SetActive(false);
        }
        EndingLinks[0].gameObject.SetActive(false);
        EndingLinks[1].gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        RobinSpeech[0].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
        Bedroom.gameObject.SetActive(true);
        ImageOfBedroom.gameObject.SetActive(true);
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];

        //Declares the functions that will be called when each button in the 
        //list of Katie's speech bubbles is pressed -SD

        GoodKatieFunctionsToCall = new UnityAction[]
        {
            GoodRobin1,
            GoodKatie3,
            GoodKatie4,
            GoodKatie5,
            GoodRobin4,
            GoodRobin7
        };

        GoodRobinFunctionsToCall = new UnityAction[]
        {
            GoodRobin2,
            GoodRobin3,
            GoodKatie2,
            GoodRobin5,
            GoodRobin6,
            GoodKatie6
        };

        BadKatieFunctionsToCall = new UnityAction[]
       {
           BadRobin1
       };

        BadRobinFunctionsToCall = new UnityAction[]
        {
            BadKatie2
        };
        KatieSpeechfunctionsToCall = new UnityAction[]
        {
           RobinSpeech2,
           RobinSpeech4,
           RobinSpeech7,
           RobinSpeech9,
           RobinSpeech11,
           choice1,
           choice2,
           choice2,
           choice2,
           choice3,
           choice3,
           choice3,
           GoodKatie1,
           BadKatie1,
           GoodKatie1
        };


        ChoicesFunctionsToCall = new UnityAction[]
        {
            RobinResponse1,
            RobinResponse2,
            RobinResponse3,
            RobinResponse4,
            RobinResponse5,
            RobinResponse6,
            RobinResponse7,
            RobinResponse8,
            RobinResponse9
        };

        ThoughtBubblesfunctionsToCall = new UnityAction[]
        {
            RobinSpeech12
        };
        //Declares the functions that will be called when each button in the 
        //list of Robin's speech bubbles is pressed -SD
        RobinSpeechfunctionsToCall = new UnityAction[]
      {
        KatieSpeech1,
        RobinSpeech3,
        KatieSpeech2,
        RobinSpeech5,
        RobinSpeech6,
        KatieSpeech3,
        RobinSpeech8,
        KatieSpeech4,
        RobinSpeech10,
        KatieSpeech5,
        ThoughtBubble1,
        KatieSpeech6
      };

        RobinResponsesfunctionsToCall = new UnityAction[]
{
     KatieSpeech7,
     KatieSpeech8,
     KatieSpeech9,
     KatieSpeech10,
     KatieSpeech11,
     KatieSpeech12,
     KatieSpeech13,
     KatieSpeech14,
     KatieSpeech15
};
        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            AddListenerToKatieSpeech(KatieSpeech[responseIndex], KatieSpeechfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            AddListenerToChoices(Choices[responseIndex], ChoicesFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            AddListenerToRobinSpeech(RobinSpeech[responseIndex], RobinSpeechfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RobinResponses.Length; ++responseIndex)
        {
            AddListenerToRobinResponses(RobinResponses[responseIndex], RobinResponsesfunctionsToCall[responseIndex]);
        }
        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            AddListenerToThoughtBubbles(ThoughtBubbles[responseIndex], ThoughtBubblesfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < GoodScenarioKatie.Length; ++responseIndex)
        {
            AddListenerToGoodKatie(GoodScenarioKatie[responseIndex], GoodKatieFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < GoodScenarioRobin.Length; ++responseIndex)
        {
            AddListenerToGoodRobin(GoodScenarioRobin[responseIndex], GoodRobinFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < BadScenarioKatie.Length; ++responseIndex)
        {
            AddListenerToBadKatie(BadScenarioKatie[responseIndex], BadKatieFunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < BadScenarioRobin.Length; ++responseIndex)
        {
            AddListenerToBadRobin(BadScenarioRobin[responseIndex], BadRobinFunctionsToCall[responseIndex]);
        }
    
}
    private void AddListenerToKatieSpeech(Button KatieSpeech, UnityEngine.Events.UnityAction KatieSpeechfunctionsToCall)
    {
        KatieSpeech.onClick.AddListener(KatieSpeechfunctionsToCall);
    }

    private void AddListenerToRobinSpeech(Button RobinSpeech, UnityEngine.Events.UnityAction RobinSpeechfunctionsToCall)
    {
        RobinSpeech.onClick.AddListener(RobinSpeechfunctionsToCall);
    }

    private void AddListenerToBadRobin(Button BadScenarioRobin, UnityEngine.Events.UnityAction BadRobinFunctionsToCall)
    {
        BadScenarioRobin.onClick.AddListener(BadRobinFunctionsToCall);
    }

    private void AddListenerToBadKatie(Button BadScenarioKatie, UnityEngine.Events.UnityAction BadKatieFunctionsToCall)
    {
        BadScenarioKatie.onClick.AddListener(BadKatieFunctionsToCall);
    }
    private void AddListenerToRobinResponses(Button RobinResponses, UnityEngine.Events.UnityAction RobinResponsesfunctionsToCall)
    {
        RobinResponses.onClick.AddListener(RobinResponsesfunctionsToCall);
    }

    private void AddListenerToChoices(Button Choices, UnityEngine.Events.UnityAction ChoicesFunctionsToCall)
    {
        Choices.onClick.AddListener(ChoicesFunctionsToCall);
    }
    private void AddListenerToThoughtBubbles(Button ThoughtBubbles, UnityEngine.Events.UnityAction ThoughtBubblesfunctionsToCall)
    {
        ThoughtBubbles.onClick.AddListener(ThoughtBubblesfunctionsToCall);
    }

    private void AddListenerToGoodKatie(Button GoodScenarioKatie, UnityEngine.Events.UnityAction GoodKatieFunctionsToCall)
    {
        GoodScenarioKatie.onClick.AddListener(GoodKatieFunctionsToCall);
    }

    private void AddListenerToGoodRobin(Button GoodScenarioRobin, UnityEngine.Events.UnityAction GoodRobinFunctionsToCall)
    {
        GoodScenarioRobin.onClick.AddListener(GoodRobinFunctionsToCall);
    }

    void KatieSpeech1()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[0].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[0].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinSpeech2()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        KatieSpeech[0].gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        RobinSpeech[1].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void RobinSpeech3()
    {
        RobinSpeech[2].gameObject.SetActive(true);
        RobinSpeech[1].gameObject.SetActive(false);
    }

    void KatieSpeech2()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[1].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[2].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinSpeech4()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        KatieSpeech[1].gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        RobinSpeech[3].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void RobinSpeech5()
    {
        RobinSpeech[3].gameObject.SetActive(false);
        RobinSpeech[4].gameObject.SetActive(true);
    }

    void RobinSpeech6()
    {
        RobinSpeech[4].gameObject.SetActive(false);
        RobinSpeech[5].gameObject.SetActive(true);
    }

    void KatieSpeech3()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[2].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[5].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinSpeech7()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[1];
        KatieSpeech[2].gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        RobinSpeech[6].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void RobinSpeech8()
    {
        Robin.texture = (Texture)RobinEmotions[0];
        RobinSpeech[6].gameObject.SetActive(false);
        RobinSpeech[7].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void KatieSpeech4()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[3].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[7].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);

    }

    void RobinSpeech9()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        KatieSpeech[3].gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        RobinSpeech[8].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void RobinSpeech10()
    {
        RobinSpeech[8].gameObject.SetActive(false);
        RobinSpeech[9].gameObject.SetActive(true);
    }

    void KatieSpeech5()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[4].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[9].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinSpeech11()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        KatieSpeech[4].gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
        RobinSpeech[10].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void ThoughtBubble1()
    {
        RobinSpeech[10].gameObject.SetActive(false);
        ThoughtBubbles[0].gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);
    }

    void RobinSpeech12()
    {
        Transparent.gameObject.SetActive(false);
        RobinSpeech[11].gameObject.SetActive(true);
        ThoughtBubbles[0].gameObject.SetActive(false);
    }

    void KatieSpeech6()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[5].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[11].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void choice1()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        ImageOfRobin.gameObject.SetActive(true);
        KatieSpeech[5].gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        Choices[0].gameObject.SetActive(true);
        Choices[1].gameObject.SetActive(true);
        Choices[2].gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    void RobinResponse1()
    {
        Choices[0].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(false);
        Choices[2].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[0].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void KatieSpeech7()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[6].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[0].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinResponse2()
    {
        Choices[0].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(false);
        Choices[2].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[1].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void KatieSpeech8()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[7].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[1].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinResponse3()
    {
        Choices[0].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(false);
        Choices[2].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[2].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void KatieSpeech9()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[8].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[2].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void choice2()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        ImageOfRobin.gameObject.SetActive(true);
        KatieSpeech[6].gameObject.SetActive(false);
        KatieSpeech[7].gameObject.SetActive(false);
        KatieSpeech[8].gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        Choices[3].gameObject.SetActive(true);
        Choices[4].gameObject.SetActive(true);
        Choices[5].gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    void RobinResponse4()
    {
        Choices[3].gameObject.SetActive(false);
        Choices[4].gameObject.SetActive(false);
        Choices[5].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[3].gameObject.SetActive(true);
    }

    void KatieSpeech10()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[9].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[3].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinResponse5()
    {
        Choices[3].gameObject.SetActive(false);
        Choices[4].gameObject.SetActive(false);
        Choices[5].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[4].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void KatieSpeech11()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[10].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[4].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinResponse6()
    {
        Choices[3].gameObject.SetActive(false);
        Choices[4].gameObject.SetActive(false);
        Choices[5].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[5].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void KatieSpeech12()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[11].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[5].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void choice3()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[0];
        ImageOfRobin.gameObject.SetActive(true);
        KatieSpeech[9].gameObject.SetActive(false);
        KatieSpeech[10].gameObject.SetActive(false);
        KatieSpeech[11].gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        Choices[6].gameObject.SetActive(true);
        Choices[7].gameObject.SetActive(true);
        Choices[8].gameObject.SetActive(true);
        Transparent.gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    void RobinResponse7()
    {
        Choices[6].gameObject.SetActive(false);
        Choices[7].gameObject.SetActive(false);
        Choices[8].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[6].gameObject.SetActive(true);
    }

    void KatieSpeech13()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[12].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[6].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinResponse8()
    {
        Choices[6].gameObject.SetActive(false);
        Choices[7].gameObject.SetActive(false);
        Choices[8].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[7].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void KatieSpeech14()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[13].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[7].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void RobinResponse9()
    {
        Choices[6].gameObject.SetActive(false);
        Choices[7].gameObject.SetActive(false);
        Choices[8].gameObject.SetActive(false);
        Transparent.gameObject.SetActive(false);
        RobinResponses[8].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void KatieSpeech15()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[1];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[14].gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinResponses[8].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void GoodKatie1()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[2];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        GoodScenarioKatie[0].gameObject.SetActive(true);
        KatieSpeech[14].gameObject.SetActive(false);
        KatieSpeech[12].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void GoodRobin1()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        GoodScenarioKatie[0].gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[2];
        GoodScenarioRobin[0].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void GoodRobin2()
    {
        GoodScenarioRobin[0].gameObject.SetActive(false);
        GoodScenarioRobin[1].gameObject.SetActive(true);
    }

    void GoodRobin3()
    {
        GoodScenarioRobin[1].gameObject.SetActive(false);
        GoodScenarioRobin[2].gameObject.SetActive(true);
    }

    void GoodKatie2()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[2];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        Robin.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(false);
        GoodScenarioKatie[1].gameObject.SetActive(true);
        GoodScenarioRobin[2].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void GoodKatie3()
    {
        GoodScenarioKatie[2].gameObject.SetActive(true);
        GoodScenarioKatie[1].gameObject.SetActive(false);
    }

    void GoodKatie4()
    {
        GoodScenarioKatie[3].gameObject.SetActive(true);
        GoodScenarioKatie[2].gameObject.SetActive(false);
    }

    void GoodKatie5()
    {
        GoodScenarioKatie[4].gameObject.SetActive(true);
        GoodScenarioKatie[3].gameObject.SetActive(false);
    }

    void GoodRobin4()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        GoodScenarioKatie[4].gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[2];
        GoodScenarioRobin[3].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void GoodRobin5()
    {
        GoodScenarioRobin[3].gameObject.SetActive(false);
        GoodScenarioRobin[4].gameObject.SetActive(true);
    }

    void GoodRobin6()
    {
        GoodScenarioRobin[4].gameObject.SetActive(false);
        GoodScenarioRobin[5].gameObject.SetActive(true);
    }

    void GoodKatie6()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[2];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[0];
        Robin.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(false);
        GoodScenarioKatie[5].gameObject.SetActive(true);
        GoodScenarioRobin[5].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void GoodRobin7()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        GoodScenarioKatie[5].gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[2];
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
        EndingLinks[0].gameObject.SetActive(true);
    }

    void BadKatie1()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[2];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[1];
        BadScenarioKatie[0].gameObject.SetActive(true);
        KatieSpeech[13].gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
    }

    void BadRobin1()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[0];
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        BadScenarioKatie[0].gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinEmotions[2];
        BadScenarioRobin[0].gameObject.SetActive(true);
        RobinAnimator.SetBool("RobinMove", true);
        RobinRIAnimator.SetBool("RobinMove", true);
    }

    void BadKatie2()
    {
        Bedroom = (RawImage)ImageOfBedroom.GetComponent<RawImage>();
        Bedroom.texture = (Texture)Bedrooms[2];
        Katie.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.texture = (Texture)KatieEmotions[1];
        BadScenarioRobin[0].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieMove", true);
        KatieRIAnimator.SetBool("KatieMove", true);
        EndingLinks[1].gameObject.SetActive(true);
    }


}
