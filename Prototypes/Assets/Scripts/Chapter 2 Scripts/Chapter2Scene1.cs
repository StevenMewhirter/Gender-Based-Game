using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.EventSystems;
public class Chapter2Scene1 : MonoBehaviour
{
    public Button[] ThoughtBubbles;
    private UnityAction[] ThoughtBubblesfunctionsToCall;
    public Button[] RobinSpeech;
    private UnityAction[] RobinSpeechfunctionsToCall;
    public Button[] AminaSpeech;
    private UnityAction[] AminaSpeechfunctionsToCall;
    public Button[] Choices;
    private UnityAction[] ChoicefunctionsToCall;
    public Button[] Responses;
    private UnityAction[] ResponsesfunctionsToCall;

    public RawImage Robin;
    public RawImage Amina;
    // Start is called before the first frame update
    void Start()
    {
        for (int responseIndex = 0; responseIndex < Responses.Length; ++responseIndex)
        {
            Responses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            Choices[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < ThoughtBubbles.Length; ++responseIndex)
        {
            ThoughtBubbles[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            RobinSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < AminaSpeech.Length; ++responseIndex)
        {
            AminaSpeech[responseIndex].gameObject.SetActive(false);
        }
        ThoughtBubbles[0].gameObject.SetActive(true);
        Amina.gameObject.SetActive(false);

        AminaSpeechfunctionsToCall = new UnityAction[]
      {
            AminaSpeech2,
            RobinSpeech2,
            Choice,
            RobinSpeech6,
            RobinSpeech5,
            AminaSpeech7,
            AminaSpeech8,
            RobinSpeech8
      };

        ResponsesfunctionsToCall = new UnityAction[]
      {
            AminaSpeech5,
            AminaSpeech4
      };

        RobinSpeechfunctionsToCall = new UnityAction[]
        {
            AminaSpeech1,
            AminaSpeech3,
            RobinSpeech7,
            RobinSpeech7,
            AminaSpeech6,
            RobinSpeech8
        };

        ThoughtBubblesfunctionsToCall = new UnityAction[]
        {
         ThoughtBubble2,
        ThoughtBubble3,
        ThoughtBubble4,
        RSpeech1,
        };

        ChoicefunctionsToCall = new UnityAction[]
        {
            Response1,
            Response2
        };

		for (int responseIndex = 0; responseIndex< ThoughtBubbles.Length; ++responseIndex)
		{
			AddListenerToThoughtBubbles(ThoughtBubbles[responseIndex], ThoughtBubblesfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < AminaSpeech.Length; ++responseIndex)
        {
            AddListenerToAminaSpeech(AminaSpeech[responseIndex], AminaSpeechfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RobinSpeech.Length; ++responseIndex)
        {
            AddListenerToRobinSpeech(RobinSpeech[responseIndex], RobinSpeechfunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Choices.Length; ++responseIndex)
        {
            AddListenerToChoices(Choices[responseIndex], ChoicefunctionsToCall[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < Responses.Length; ++responseIndex)
        {
            AddListenerToResponses(Responses[responseIndex], ResponsesfunctionsToCall[responseIndex]);
        }
    }
        private void AddListenerToThoughtBubbles(Button ThoughtBubbles, UnityEngine.Events.UnityAction ThoughtBubblesfunctionsToCall)
    {
        ThoughtBubbles.onClick.AddListener(ThoughtBubblesfunctionsToCall);
    }

    private void AddListenerToResponses(Button Responses, UnityEngine.Events.UnityAction ResponsesfunctionsToCall)
    {
        Responses.onClick.AddListener(ResponsesfunctionsToCall);
    }

    private void AddListenerToChoices(Button Choices, UnityEngine.Events.UnityAction ChoicefunctionsToCall)
    {
        Choices.onClick.AddListener(ChoicefunctionsToCall);
    }
    private void AddListenerToAminaSpeech(Button AminaSpeech, UnityEngine.Events.UnityAction AminaSpeechfunctionsToCall)
    {
        AminaSpeech.onClick.AddListener(AminaSpeechfunctionsToCall);
    }

    private void AddListenerToRobinSpeech(Button RobinSpeech, UnityEngine.Events.UnityAction RobinSpeechfunctionsToCall)
    {
        RobinSpeech.onClick.AddListener(RobinSpeechfunctionsToCall);
    }

    void ThoughtBubble2()
    {
        ThoughtBubbles[0].gameObject.SetActive(false);
        ThoughtBubbles[1].gameObject.SetActive(true);
    }

    void ThoughtBubble3()
    {
        ThoughtBubbles[1].gameObject.SetActive(false);
        ThoughtBubbles[2].gameObject.SetActive(true);
    }

    void ThoughtBubble4()
    {
        ThoughtBubbles[2].gameObject.SetActive(false);
        ThoughtBubbles[3].gameObject.SetActive(true);
    }

    void RSpeech1()
    {
      ThoughtBubbles[3].gameObject.SetActive(false);
      RobinSpeech[0].gameObject.SetActive(true);
    }

    void AminaSpeech1()
    {
        Robin.gameObject.SetActive(false);
        RobinSpeech[0].gameObject.SetActive(false);
        Amina.gameObject.SetActive(true);
        AminaSpeech[0].gameObject.SetActive(true);
    }

    void AminaSpeech2()
    {
        AminaSpeech[1].gameObject.SetActive(true);
        AminaSpeech[0].gameObject.SetActive(false);
    }

    void RobinSpeech2()
    {
        AminaSpeech[1].gameObject.SetActive(false);
        Amina.gameObject.SetActive(false);
        RobinSpeech[1].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
    }

    void AminaSpeech3()
    {
        RobinSpeech[1].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        Amina.gameObject.SetActive(true);
        AminaSpeech[2].gameObject.SetActive(true);
    }

    void Choice()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[2].gameObject.SetActive(false);
        Choices[1].gameObject.SetActive(true);
        Choices[0].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
    }

    void Response1()
    {
        Choices[1].gameObject.SetActive(false);
        Choices[0].gameObject.SetActive(false);
        Responses[1].gameObject.SetActive(true);
    }

    void Response2()
    {
        Choices[1].gameObject.SetActive(false);
        Choices[0].gameObject.SetActive(false);
        Responses[0].gameObject.SetActive(true);
    }

    void AminaSpeech4()
    {
        Responses[1].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        Amina.gameObject.SetActive(true);
        AminaSpeech[3].gameObject.SetActive(true);
    }

    void AminaSpeech5()
    {
        Responses[0].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        Amina.gameObject.SetActive(true);
        AminaSpeech[4].gameObject.SetActive(true);
    }
    void RobinSpeech5()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[3].gameObject.SetActive(false);
        RobinSpeech[3].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
    }

    void RobinSpeech6()
    {
        Amina.gameObject.SetActive(false);
        AminaSpeech[4].gameObject.SetActive(false);
        RobinSpeech[2].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
    }

    void RobinSpeech7()
    {
        RobinSpeech[3].gameObject.SetActive(false);
        RobinSpeech[2].gameObject.SetActive(false);
        RobinSpeech[4].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
    }

    void AminaSpeech6()
    {
        RobinSpeech[4].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        Amina.gameObject.SetActive(true);
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

    void RobinSpeech8()
    {
        Amina.gameObject.gameObject.SetActive(false);
        AminaSpeech[7].gameObject.SetActive(false);
        RobinSpeech[5].gameObject.SetActive(true);
        Robin.gameObject.SetActive(true);
    }
}
