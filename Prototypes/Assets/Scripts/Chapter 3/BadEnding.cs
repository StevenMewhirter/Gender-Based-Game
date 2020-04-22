using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BadEnding : MonoBehaviour
{
    public Button[] AminaSpeech;
    public Button[] Choices;
    public Button[] KatieSpeech;
    public Button[] Responses;
    public Button[] RobinSpeech;
    public Button TransparentResponse;
    public GameObject ImageOfAmina;
    public GameObject ImageOfKatie;
    public GameObject ImageOfRobin;
    public RawImage Amina;
    public RawImage Katie;
    public RawImage Robin;
    public Texture[] AminaEmotions;
    public Texture[] KatieEmotions;
    public Texture[] RobinEmotions;
    private UnityAction[] AminaSpeechfunctionsToCall;
    private UnityAction[] ChoicesfunctionsToCall;
    private UnityAction[] KatieFunctions;
    private UnityAction[] ResponsesfunctionsToCall;
    private UnityAction[] RobinSpeechfunctionsToCall;
    void Start()
    {
        for (int responseIndex = 0; responseIndex < AminaSpeech.Length; ++responseIndex)
        {
            AminaSpeech[responseIndex].gameObject.SetActive(false);
        }


        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            Choices[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            KatieSpeech[responseIndex].gameObject.SetActive(false);
        }
        for (int responseIndex = 0; responseIndex < Responses.Length; ++responseIndex)
        {
            Responses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            RobinSpeech[responseIndex].gameObject.SetActive(false);
        }

        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.gameObject.SetActive(true);
        Robin.texture = (Texture)RobinEmotions[0];
        RobinSpeech[0].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);

        AminaSpeechfunctionsToCall = new UnityAction[]
        {
            AminaSpeech2,
            RobinSpeech3,
            RobinSpeech6,
            KatieSpeech1,
            AminaSpeech6,
            AminaSpeech7,
            AminaSpeech8,
            KatieSpeech4,
            AminaSpeech10,
            KatieSpeech8,
            AminaSpeech12,
            KatieSpeech9,
            AminaSpeech14,
            AminaSpeech15,
            KatieSpeech10,
            AminaSpeech17,
            KatieSpeech11,
            AminaSpeech19,
            KatieSpeech12,
            AminaSpeech21,
            KatieSpeech13,
            AminaSpeech23,
            AminaSpeech24,
            AminaSpeech25,
            AminaSpeech26,
            KatieSpeech14,
            KatieSpeech21,
            KatieSpeech21,
            AminaSpeech30,
            AminaSpeech30,
            AminaSpeech32,
            AminaSpeech32
        };


        ChoicesfunctionsToCall = new UnityAction[]
{
           AminaResponse1,
           AminaResponse3,
           AminaResponse5,
           AminaResponse6,
           AminaResponse7,
           AminaResponse8,
           AminaResponse9,
           AminaResponse10,
           AminaResponse11,
           AminaResponse13
};

        KatieFunctions = new UnityAction[]
         {
               choices2,
               AminaSpeech5,
               AminaSpeech5,
               KatieSpeech5,
               choices3,
               AminaSpeech9,
               AminaSpeech9,
               AminaSpeech11,
               AminaSpeech13,
               AminaSpeech16,
               AminaSpeech18,
               AminaSpeech20,
               AminaSpeech22,
               choices4,
               KatieSpeech16,
               KatieSpeech17,
               AminaSpeech27,
               KatieSpeech19,
               KatieSpeech20,
               AminaSpeech28,
               KatieSpeech22,
               choices5,
               KatieSpeech24,
               AminaSpeech29,
               KatieSpeech26,
               AminaSpeech31
         };

        ResponsesfunctionsToCall = new UnityAction[]
        {
         AminaResponse2,
         RobinSpeech8,
         AminaResponse4,
         RobinSpeech9,
         KatieSpeech2,
         KatieSpeech3,
         KatieSpeech6,
         KatieSpeech7,
         KatieSpeech15,
         KatieSpeech18,
         AminaResponse12,
         KatieSpeech23,
         KatieSpeech25
        };


        RobinSpeechfunctionsToCall = new UnityAction[]
        {
      RobinSpeech2,
      AminaSpeech1,
      RobinSpeech4,
      RobinSpeech5,
      AminaSpeech3,
      RobinSpeech7,
      choices1,
      RobinSpeech10,
      RobinSpeech10,
      RobinSpeech11,
      RobinSpeech12,
      AminaSpeech4
        };

        for (int responseIndex = 0; responseIndex < AminaSpeech.Length; ++responseIndex)
        {
            AddListenerToAminaSpeech(AminaSpeech[responseIndex], AminaSpeechfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            AddListenerToChoices(Choices[responseIndex], ChoicesfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            AddListenerToKatieButton(KatieSpeech[responseIndex], KatieFunctions[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Responses.Length; ++responseIndex)
        {
            AddListenerToResponses(Responses[responseIndex], ResponsesfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            AddListenerToRobinSpeech(RobinSpeech[responseIndex], RobinSpeechfunctionsToCall[responseIndex]);
        }
    }
    private void AddListenerToAminaSpeech(Button AminaSpeech, UnityEngine.Events.UnityAction AminaSpeechfunctionsToCall)
    {
        AminaSpeech.onClick.AddListener(AminaSpeechfunctionsToCall);
    }

    private void AddListenerToChoices(Button Choices, UnityEngine.Events.UnityAction ChoicesfunctionsToCall)
    {
        Choices.onClick.AddListener(ChoicesfunctionsToCall);
    }

    private void AddListenerToKatieButton(Button KatieSpeech, UnityEngine.Events.UnityAction KatieFunctions)
    {
        KatieSpeech.onClick.AddListener(KatieFunctions);
    }
    private void AddListenerToResponses(Button Responses, UnityEngine.Events.UnityAction ResponsesfunctionsToCall)
    {
        Responses.onClick.AddListener(ResponsesfunctionsToCall);
    }
    private void AddListenerToRobinSpeech(Button RobinSpeech, UnityEngine.Events.UnityAction RobinSpeechfunctionsToCall)
    {
        RobinSpeech.onClick.AddListener(RobinSpeechfunctionsToCall);
    }
    void RobinSpeech2()
    {
        RobinSpeech[0].gameObject.SetActive(false);
        RobinSpeech[1].gameObject.SetActive(true);
    }
    void AminaSpeech1()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        AminaSpeech[0].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[1].gameObject.SetActive(false);
    }

    void AminaSpeech2()
    {
        AminaSpeech[0].gameObject.SetActive(false);
        AminaSpeech[1].gameObject.SetActive(true);
    }
    void RobinSpeech3()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[1].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.gameObject.SetActive(true);
        Robin.texture = (Texture)RobinEmotions[0];
        RobinSpeech[2].gameObject.SetActive(true);
    }
    void RobinSpeech4()
    {
        RobinSpeech[2].gameObject.SetActive(false);
        RobinSpeech[3].gameObject.SetActive(true);
    }

    void RobinSpeech5()
    {
        RobinSpeech[3].gameObject.SetActive(false);
        RobinSpeech[4].gameObject.SetActive(true);
    }
    void AminaSpeech3()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        AminaSpeech[2].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[4].gameObject.SetActive(false);
    }
    void RobinSpeech6()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[2].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.gameObject.SetActive(true);
        Robin.texture = (Texture)RobinEmotions[0];
        RobinSpeech[5].gameObject.SetActive(true);
    }
    void RobinSpeech7()
    {
        RobinSpeech[5].gameObject.SetActive(false);
        RobinSpeech[6].gameObject.SetActive(true);
    }
    void choices1()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        Choices[0].gameObject.SetActive(true);
        Choices[1].gameObject.SetActive(true);
        Handheld.Vibrate();
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[6].gameObject.SetActive(false);
        TransparentResponse.gameObject.SetActive(true);
    }
    void AminaResponse1()
    {
        Choices[0].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(false);
        Responses[0].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }

    void AminaResponse2()
    {
        Responses[0].gameObject.SetActive(false);
        Responses[1].gameObject.SetActive(true);
    }
    void RobinSpeech8()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Responses[1].gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.gameObject.SetActive(true);
        Robin.texture = (Texture)RobinEmotions[0];
        RobinSpeech[7].gameObject.SetActive(true);
    }
    void AminaResponse3()
    {
        Choices[0].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(false);
        Responses[2].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }

    void AminaResponse4()
    {
        Responses[2].gameObject.SetActive(false);
        Responses[3].gameObject.SetActive(true);
    }
    void RobinSpeech9()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfRobin.gameObject.SetActive(true);
        Responses[3].gameObject.SetActive(false);
        Robin = (RawImage)ImageOfRobin.GetComponent<RawImage>();
        Robin.gameObject.SetActive(true);
        Robin.texture = (Texture)RobinEmotions[0];
        RobinSpeech[8].gameObject.SetActive(true);
    }
    void RobinSpeech10()
    {
        RobinSpeech[8].gameObject.SetActive(false);
        RobinSpeech[9].gameObject.SetActive(true);
    }
    void RobinSpeech11()
    {
        RobinSpeech[9].gameObject.SetActive(false);
        RobinSpeech[10].gameObject.SetActive(true);
    }
    void RobinSpeech12()
    {
        RobinSpeech[10].gameObject.SetActive(false);
        RobinSpeech[11].gameObject.SetActive(true);
    }
    void AminaSpeech4()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        AminaSpeech[3].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfRobin.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        RobinSpeech[11].gameObject.SetActive(false);
        RobinSpeech[7].gameObject.SetActive(false);
    }

    void KatieSpeech1()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[3].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[0].gameObject.SetActive(true);
    }
    void choices2()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        Choices[2].gameObject.SetActive(true);
        Choices[3].gameObject.SetActive(true);
        Handheld.Vibrate();
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[0].gameObject.SetActive(false);
        TransparentResponse.gameObject.SetActive(true);
    }
    void AminaResponse5()
    {
        Choices[2].gameObject.SetActive(false);
        Choices[3].gameObject.SetActive(false);
        Responses[4].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech2()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[1].gameObject.SetActive(true);
        Responses[4].gameObject.SetActive(false);
    }
    void AminaResponse6()
    {
        Choices[2].gameObject.SetActive(false);
        Choices[3].gameObject.SetActive(false);
        Responses[5].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech3()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[2].gameObject.SetActive(true);
        Responses[5].gameObject.SetActive(false);
    }
    void AminaSpeech5()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        AminaSpeech[4].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[1].gameObject.SetActive(false);
        KatieSpeech[2].gameObject.SetActive(false);
    }

    void AminaSpeech6()
    {
        AminaSpeech[4].gameObject.SetActive(false);
        AminaSpeech[5].gameObject.SetActive(true);
    }
    void AminaSpeech7()
    {
        AminaSpeech[5].gameObject.SetActive(false);
        AminaSpeech[6].gameObject.SetActive(true);
    }
    void AminaSpeech8()
    {
        AminaSpeech[6].gameObject.SetActive(false);
        AminaSpeech[7].gameObject.SetActive(true);
    }
    void KatieSpeech4()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[7].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[3].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech5()
    {
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[3].gameObject.SetActive(false);
        KatieSpeech[4].gameObject.SetActive(true);
    }
    void choices3()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        Choices[4].gameObject.SetActive(true);
        Choices[5].gameObject.SetActive(true);
        Handheld.Vibrate();
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[4].gameObject.SetActive(false);
        TransparentResponse.gameObject.SetActive(true);
    }
    void AminaResponse7()
    {
        Choices[4].gameObject.SetActive(false);
        Choices[5].gameObject.SetActive(false);
        Responses[6].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech6()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[5].gameObject.SetActive(true);
        Responses[6].gameObject.SetActive(false);
    }
    void AminaResponse8()
    {
        Choices[4].gameObject.SetActive(false);
        Choices[5].gameObject.SetActive(false);
        Responses[7].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech7()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[6].gameObject.SetActive(true);
        Responses[7].gameObject.SetActive(false);
    }
    void AminaSpeech9()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        AminaSpeech[8].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[6].gameObject.SetActive(false);
        KatieSpeech[5].gameObject.SetActive(false);

    }
    void AminaSpeech10()
    {
        AminaSpeech[8].gameObject.SetActive(false);
        AminaSpeech[9].gameObject.SetActive(true);
    }
    void KatieSpeech8()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[9].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[7].gameObject.SetActive(true);
    }
    void AminaSpeech11()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[10].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[7].gameObject.SetActive(false);
    }
    void AminaSpeech12()
    {
        AminaSpeech[10].gameObject.SetActive(false);
        AminaSpeech[11].gameObject.SetActive(true);
    }
    void KatieSpeech9()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[11].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[8].gameObject.SetActive(true);
    }
    void AminaSpeech13()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[12].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[8].gameObject.SetActive(false);
    }
    void AminaSpeech14()
    {
        AminaSpeech[12].gameObject.SetActive(false);
        AminaSpeech[13].gameObject.SetActive(true);
    }
    void AminaSpeech15()
    {
        AminaSpeech[13].gameObject.SetActive(false);
        AminaSpeech[14].gameObject.SetActive(true);
    }
    void KatieSpeech10()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[14].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[9].gameObject.SetActive(true);
    }
    void AminaSpeech16()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[15].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[9].gameObject.SetActive(false);
    }
    void AminaSpeech17()
    {
        AminaSpeech[15].gameObject.SetActive(false);
        AminaSpeech[16].gameObject.SetActive(true);
    }
    void KatieSpeech11()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[16].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[10].gameObject.SetActive(true);
    }
    void AminaSpeech18()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[17].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[10].gameObject.SetActive(false);
    }
    void AminaSpeech19()
    {
        AminaSpeech[17].gameObject.SetActive(false);
        AminaSpeech[18].gameObject.SetActive(true);
    }
    void KatieSpeech12()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[18].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[11].gameObject.SetActive(true);
    }
    void AminaSpeech20()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[19].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[11].gameObject.SetActive(false);
    }
    void AminaSpeech21()
    {
        AminaSpeech[19].gameObject.SetActive(false);
        AminaSpeech[20].gameObject.SetActive(true);
    }
    void KatieSpeech13()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[20].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[12].gameObject.SetActive(true);
    }
    void AminaSpeech22()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[21].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[12].gameObject.SetActive(false);
    }
    void AminaSpeech23()
    {
        AminaSpeech[21].gameObject.SetActive(false);
        AminaSpeech[22].gameObject.SetActive(true);
    }
    void AminaSpeech24()
    {
        AminaSpeech[22].gameObject.SetActive(false);
        AminaSpeech[23].gameObject.SetActive(true);
    }
    void AminaSpeech25()
    {
        AminaSpeech[23].gameObject.SetActive(false);
        AminaSpeech[24].gameObject.SetActive(true);
    }
    void AminaSpeech26()
    {
        AminaSpeech[24].gameObject.SetActive(false);
        AminaSpeech[25].gameObject.SetActive(true);
    }
    void KatieSpeech14()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[25].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[13].gameObject.SetActive(true);
    }
    void choices4()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        Choices[6].gameObject.SetActive(true);
        Choices[7].gameObject.SetActive(true);
        Handheld.Vibrate();
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[13].gameObject.SetActive(false);
        TransparentResponse.gameObject.SetActive(true);
    }
    void AminaResponse9()
    {
        Choices[6].gameObject.SetActive(false);
        Choices[7].gameObject.SetActive(false);
        Responses[8].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech15()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[14].gameObject.SetActive(true);
        Responses[8].gameObject.SetActive(false);
    }
    void KatieSpeech16()
    {
        KatieSpeech[14].gameObject.SetActive(false);
        KatieSpeech[15].gameObject.SetActive(true);
    }
    void KatieSpeech17()
    {
        KatieSpeech[15].gameObject.SetActive(false);
        KatieSpeech[16].gameObject.SetActive(true);
    }
    void AminaSpeech27()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[26].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[16].gameObject.SetActive(false);
    }
    void AminaResponse10()
    {
        Choices[6].gameObject.SetActive(false);
        Choices[7].gameObject.SetActive(false);
        Responses[9].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech18()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[17].gameObject.SetActive(true);
        Responses[9].gameObject.SetActive(false);
    }
    void KatieSpeech19()
    {
        KatieSpeech[17].gameObject.SetActive(false);
        KatieSpeech[18].gameObject.SetActive(true);
    }
    void KatieSpeech20()
    {
        KatieSpeech[18].gameObject.SetActive(false);
        KatieSpeech[19].gameObject.SetActive(true);
    }
    void AminaSpeech28()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[27].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[19].gameObject.SetActive(false);
    }
    void KatieSpeech21()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[26].gameObject.SetActive(false);
        AminaSpeech[27].gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[20].gameObject.SetActive(true);
    }
    void KatieSpeech22()
    {
        KatieSpeech[20].gameObject.SetActive(false);
        KatieSpeech[21].gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
    }
    void choices5()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        Choices[8].gameObject.SetActive(true);
        Choices[9].gameObject.SetActive(true);
        Handheld.Vibrate();
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[21].gameObject.SetActive(false);
        TransparentResponse.gameObject.SetActive(true);
    }
    void AminaResponse11()
    {
        Choices[8].gameObject.SetActive(false);
        Choices[9].gameObject.SetActive(false);
        Responses[10].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void AminaResponse12()
    {
        Responses[10].gameObject.SetActive(false);
        Responses[11].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech23()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[0];
        KatieSpeech[22].gameObject.SetActive(true);
        Responses[11].gameObject.SetActive(false);
    }
    void KatieSpeech24()
    {
        KatieSpeech[22].gameObject.SetActive(false);
        KatieSpeech[23].gameObject.SetActive(true);
    }
    void AminaSpeech29()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[1];
        AminaSpeech[28].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[23].gameObject.SetActive(false);
    }
    void AminaSpeech30()
    {
        AminaSpeech[28].gameObject.SetActive(false);
        AminaSpeech[29].gameObject.SetActive(true);
    }
    void AminaResponse13()
    {
        Choices[8].gameObject.SetActive(false);
        Choices[9].gameObject.SetActive(false);
        Responses[12].gameObject.SetActive(true);
        TransparentResponse.gameObject.SetActive(false);
    }
    void KatieSpeech25()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(true);
        Katie = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        Katie.gameObject.SetActive(true);
        Katie.texture = (Texture)KatieEmotions[1];
        KatieSpeech[24].gameObject.SetActive(true);
        Responses[12].gameObject.SetActive(false);
    }
    void KatieSpeech26()
    {
        KatieSpeech[24].gameObject.SetActive(false);
        KatieSpeech[25].gameObject.SetActive(true);
    }
    void AminaSpeech31()
    {
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.gameObject.SetActive(true);
        Amina.texture = (Texture)AminaEmotions[0];
        AminaSpeech[30].gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        KatieSpeech[25].gameObject.SetActive(false);
    }
    void AminaSpeech32()
    {
        AminaSpeech[30].gameObject.SetActive(false);
        AminaSpeech[31].gameObject.SetActive(true);
    }
}

