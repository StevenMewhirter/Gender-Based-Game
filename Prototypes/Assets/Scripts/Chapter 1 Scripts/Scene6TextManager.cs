using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class Scene6TextManager : MonoBehaviour
{

    public float AminaValue;


    public float JasonValue;

    public DiaryTexts transitionScreen;
    public Button transitionImage;
    bool canClick = false;

    public Button[] AminaSpeech;
    private UnityAction[] AminaFunctions;
    public Button[] CoWorkersSpeech;
    private UnityAction[] CoWorkersFunctions;
    public Button[] JasonSpeech;
    private UnityAction[] JasonFunctions;
    public Button[] KatieSpeech;
    private UnityAction[] KatieFunctions;
    public Button[] Responses;
    private UnityAction[] ResponsesFunction;
    public Button RobinSpeech1;
    public Button[] RichardSpeech;
    private UnityAction[] RichardFunction;
    public Button[] Social;
    public Button[] ShowChoices;
    private UnityAction[] ChoicesFunctions;
    public Button WaiterSpeech;
    public GameObject[] Blocks;
    public GameObject ImageOfAmina;
    public GameObject ImageOfBar;
    public GameObject ImageOfJason;
    public GameObject ImageOfKatie;
    public GameObject ImageOfRichard;
    public Texture[] AminaEmotions;
    public Texture[] Bars;
    public Texture[] JasonEmotions;
    public Texture[] KatieEmotions;
    public Texture[] RichardEmotions;
    public RawImage MC;
    public RawImage Amina;
    public RawImage Richard;
    public RawImage Jason;
    public RawImage Bar;
    public Button BottomBackground;
    public RawImage Phone;
    public RawImage EndScreen;
    public GameObject messagesContainer;
    public Animator KatieAnimator;
    public Animator RichardAnimator;
    public Animator JasonAnimator;
    public Animator AminaAnimator;
    public Button ChangeScene;

    // Start is called before the first frame update
    void Start()
    {
        for (int responseIndex = 0; responseIndex < AminaSpeech.Length; ++responseIndex)
        {
            AminaSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < CoWorkersSpeech.Length; ++responseIndex)
        {
            CoWorkersSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < JasonSpeech.Length; ++responseIndex)
        {
            JasonSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            KatieSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Responses.Length; ++responseIndex)
        {
            Responses[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < RichardSpeech.Length; ++responseIndex)
        {
            RichardSpeech[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < ShowChoices.Length; ++responseIndex)
        {
            ShowChoices[responseIndex].gameObject.SetActive(false);
        }

        for (int responseIndex = 0; responseIndex < Blocks.Length; ++responseIndex)
        {
            Blocks[responseIndex].gameObject.SetActive(false);
        }

        BottomBackground.gameObject.SetActive(false);
        ChangeScene.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        Bar.gameObject.SetActive(false);
        ImageOfBar.gameObject.SetActive(false);
        Richard.gameObject.SetActive(false);
        ImageOfRichard.gameObject.SetActive(false);
        WaiterSpeech.gameObject.SetActive(false);
        EndScreen.gameObject.SetActive(false);

        AminaFunctions = new UnityAction[]
        {
            Selection2,
            Waiter,
            RaA
        };

        CoWorkersFunctions = new UnityAction[]
        {
            KSpeech2,
            JaKS,
            JSpeech3
        };

        JasonFunctions = new UnityAction[]
        {
            Selection1,
            RichSpeech2,
            Selection3,
            JSpeech6,
            KSpeech4,
            Selection4,
            Selection5
        };

        KatieFunctions = new UnityAction[]
        {
            EnviroChange1,
            JSpeech1,
            RichSpeech1,
            JSpeech5
        };

        ResponsesFunction = new UnityAction[]
        {
            ShowResponse1,
            ShowResponse2,
            ShowResponse3,
            ShowResponse4,
            ShowResponse5,
            ShowResponse6,
            ShowResponse7,
            ShowResponse8,
            ShowResponse9,
            ShowResponse10,
            ShowResponse11,
            ShowResponse12,
            ShowResponse13,
            ShowResponse14
        };

        RichardFunction = new UnityAction[]
        {
            JSpeech2,
            BS2
        };

        StartCoroutine(transitionPanel());

        Button Transition = transitionImage.GetComponent<Button>();
        Transition.onClick.AddListener(StartMessages);

        //moved this into the StartMessages function to enable it after the transition screen (E.A.)
        //Button robin1 = RobinSpeech1.GetComponent<Button>();
        //robin1.onClick.AddListener(KSpeech1);

        ChoicesFunctions = new UnityAction[]
        {
            ASpeech1,
            BS1,
            JSpeech4,
            JSpeech6,
            End,
            End,
            ASpeech1,
            ASpeech1,
            BS1,
            BS1,
            JSpeech7,
            JSpeech7,
            JSpeech6,
            JSpeech6
        };
        Button W = WaiterSpeech.GetComponent<Button>();
        W.onClick.AddListener(KSpeech3);

        for (int responseIndex = 0; responseIndex < AminaSpeech.Length; ++responseIndex)
        {
            AddListenerToAminaButton(AminaSpeech[responseIndex], AminaFunctions[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < CoWorkersSpeech.Length; ++responseIndex)
        {
            AddListenerToCoWorkerButton(CoWorkersSpeech[responseIndex], CoWorkersFunctions[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < JasonSpeech.Length; ++responseIndex)
        {
            AddListenerToJasonButton(JasonSpeech[responseIndex], JasonFunctions[responseIndex]);
        }
        
        for (int responseIndex = 0; responseIndex < KatieSpeech.Length; ++responseIndex)
        {
            AddListenerToKatieButton(KatieSpeech[responseIndex], KatieFunctions[responseIndex]);
        }
        
        for (int responseIndex = 0; responseIndex < Responses.Length; ++responseIndex)
        {
            AddListenerToResponseButton(Responses[responseIndex], ResponsesFunction[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < RichardSpeech.Length; ++responseIndex)
        {
            AddListenerToRichardButton(RichardSpeech[responseIndex], RichardFunction[responseIndex]);
        }

        for (int responseIndex = 0; responseIndex < ShowChoices.Length; ++responseIndex)
        {
            AddListenerToShowChoicesButton(ShowChoices[responseIndex], ChoicesFunctions[responseIndex]);
        }
    }

    private void AddListenerToAminaButton(Button AminaSpeech, UnityEngine.Events.UnityAction AminaFunctions)
    {
        AminaSpeech.onClick.AddListener(AminaFunctions);
    }

    private void AddListenerToCoWorkerButton(Button CoWorkersSpeech, UnityEngine.Events.UnityAction CoWorkersFunctions)
    {
        CoWorkersSpeech.onClick.AddListener(CoWorkersFunctions);
    }

    private void AddListenerToJasonButton(Button JasonSpeech, UnityEngine.Events.UnityAction JasonFunctions)
    {
        JasonSpeech.onClick.AddListener(JasonFunctions);
    }

    private void AddListenerToKatieButton(Button KatieSpeech, UnityEngine.Events.UnityAction KatieFunctions)
    {
        KatieSpeech.onClick.AddListener(KatieFunctions);
    }

    private void AddListenerToResponseButton(Button Responses, UnityEngine.Events.UnityAction ResponsesFunction)
    {
        Responses.onClick.AddListener(ResponsesFunction);
    }

    private void AddListenerToRichardButton(Button RichardSpeech, UnityEngine.Events.UnityAction RichardFunction)
    {
        RichardSpeech.onClick.AddListener(RichardFunction);
    }

    private void AddListenerToShowChoicesButton(Button ShowChoices, UnityEngine.Events.UnityAction ChoicesFunctions)
    {
        ShowChoices.onClick.AddListener(ChoicesFunctions);
    }

    void Update()
    {

        AminaValueStatic.AValue = AminaValue;
        JasonValueStatic.JValue = JasonValue;
    }

        void StartMessages()
    {
        if (canClick)
        {
            transitionScreen.gameObject.SetActive(false);
            Button robin1 = RobinSpeech1.GetComponent<Button>();
            robin1.onClick.AddListener(KSpeech1);
        }
    }

    void KSpeech1()
    {
        KatieSpeech[0].gameObject.SetActive(true);
        
    }

    void EnviroChange1()
    {
        messagesContainer.SetActive(false);
        KatieSpeech[0].gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(false);
        Phone.gameObject.SetActive(false);
        Bar.gameObject.SetActive(true);
        ImageOfBar.gameObject.SetActive(true);
        Bar = (RawImage)ImageOfBar.GetComponent<RawImage>();
        Bar.texture = (Texture)Bars[0];
        CoWorkersSpeech[0].gameObject.SetActive(true);
    }

    void KSpeech2()
    {
        KatieSpeech[1].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[0];
        CoWorkersSpeech[0].gameObject.SetActive(false);
    }

    void JSpeech1()
    {
        KatieSpeech[1].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        ImageOfJason.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", false);
        JasonAnimator.SetBool("JasonMove", true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonEmotions[0];
        JasonSpeech[0].gameObject.SetActive(true);
    }

    void Selection1()
    {
        MC.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[0];
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        JasonSpeech[0].gameObject.SetActive(false);
        Responses[0].gameObject.SetActive(true);
        Responses[6].gameObject.SetActive(true);
        Responses[7].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(true);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    void ShowResponse1()
    {
        JasonValue += 10f;
        Responses[0].gameObject.SetActive(false);
        Responses[6].gameObject.SetActive(false);
        Responses[7].gameObject.SetActive(false);
        ShowChoices[0].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse7()
    {
        Responses[0].gameObject.SetActive(false);
        Responses[6].gameObject.SetActive(false);
        Responses[7].gameObject.SetActive(false);
        ShowChoices[6].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse8()
    {
        Responses[0].gameObject.SetActive(false);
        Responses[6].gameObject.SetActive(false);
        Responses[7].gameObject.SetActive(false);
        ShowChoices[7].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ASpeech1()
    {
        ShowChoices[0].gameObject.SetActive(false);
        ShowChoices[6].gameObject.SetActive(false);
        ShowChoices[7].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        AminaSpeech[0].gameObject.SetActive(true);
        Amina.gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", false);
        AminaAnimator.SetBool("AminaMove", true);
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.texture = (Texture)AminaEmotions[0];
    }
    void Selection2()
    {
        Responses[1].gameObject.SetActive(true);
        Responses[8].gameObject.SetActive(true);
        Responses[9].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[1];
        AminaAnimator.SetBool("AminaMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        Blocks[0].SetActive(true);
        BottomBackground.gameObject.SetActive(true);
        AminaSpeech[0].gameObject.SetActive(false);
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    void ShowResponse2()
    {
        AminaValue += 10f;
        Blocks[0].SetActive(false);
        Responses[1].gameObject.SetActive(false);
        Responses[8].gameObject.SetActive(false);
        Responses[9].gameObject.SetActive(false);
        AminaSpeech[0].gameObject.SetActive(false);
        ShowChoices[1].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse9()
    {
        Blocks[0].SetActive(false);
        Responses[1].gameObject.SetActive(false);
        Responses[8].gameObject.SetActive(false);
        Responses[9].gameObject.SetActive(false);
        AminaSpeech[0].gameObject.SetActive(false);
        ShowChoices[8].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse10()
    {
        AminaValue -= 10f;
        Blocks[0].SetActive(false);
        Responses[1].gameObject.SetActive(false);
        Responses[8].gameObject.SetActive(false);
        Responses[9].gameObject.SetActive(false);
        AminaSpeech[0].gameObject.SetActive(false);
        ShowChoices[9].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void BS1()
    {
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        ShowChoices[1].gameObject.SetActive(false);
        ShowChoices[8].gameObject.SetActive(false);
        ShowChoices[9].gameObject.SetActive(false);
        Responses[1].gameObject.SetActive(false);
        Responses[8].gameObject.SetActive(false);
        Responses[9].gameObject.SetActive(false);
        AminaSpeech[1].gameObject.SetActive(true);
        Amina.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", false);
        AminaAnimator.SetBool("AminaMove", true);
        ImageOfAmina.gameObject.SetActive(true);
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.texture = (Texture)AminaEmotions[0];
        AminaSpeech[0].gameObject.SetActive(false);
    }

    void Waiter()
    {
        AminaSpeech[1].gameObject.SetActive(false);
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        WaiterSpeech.gameObject.SetActive(true);
    }

    void KSpeech3()
    {
      WaiterSpeech.gameObject.SetActive(false);
        KatieSpeech[2].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        AminaAnimator.SetBool("AminaMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[0];
    }

    void RichSpeech1()
    {
        Bar.gameObject.SetActive(true);
        ImageOfBar.gameObject.SetActive(true);
        Bar = (RawImage)ImageOfBar.GetComponent<RawImage>();
        Bar.texture = (Texture)Bars[1];
        KatieSpeech[2].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", false);
        RichardAnimator.SetBool("RichardMove", true);
        ImageOfRichard.gameObject.SetActive(true);
        Richard = (RawImage)ImageOfRichard.GetComponent<RawImage>();
        Richard.texture = (Texture)RichardEmotions[0];
        RichardSpeech[0].gameObject.SetActive(true);
    }

    void JSpeech2()
    {
        Richard.gameObject.SetActive(false);
        ImageOfRichard.gameObject.SetActive(false);
        RichardSpeech[0].gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        RichardAnimator.SetBool("RichardMove", false);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonEmotions[0];
        JasonSpeech[1].gameObject.SetActive(true);
    }

    void RichSpeech2()
    {
        JasonSpeech[1].gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", false);
        RichardAnimator.SetBool("RichardMove", true);
        ImageOfRichard.gameObject.SetActive(true);
        Richard = (RawImage)ImageOfRichard.GetComponent<RawImage>();
        Richard.texture = (Texture)RichardEmotions[0];
        RichardSpeech[1].gameObject.SetActive(true);
    }

    void BS2()
    {
        Richard.gameObject.SetActive(false);
        ImageOfRichard.gameObject.SetActive(false);
        RichardSpeech[1].gameObject.SetActive(false);
        AminaSpeech[2].gameObject.SetActive(true);
        Amina.gameObject.SetActive(true);
        RichardAnimator.SetBool("RichardMove", false);
        AminaAnimator.SetBool("AminaMove", true);
        ImageOfAmina.gameObject.SetActive(true);
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();
        Amina.texture = (Texture)AminaEmotions[1];
    }

    void RaA()
    {
        AminaSpeech[2].gameObject.SetActive(false);
        CoWorkersSpeech[1].gameObject.SetActive(true);
    }

    void JaKS()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        CoWorkersSpeech[1].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        AminaAnimator.SetBool("AminaMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[0];
        CoWorkersSpeech[2].gameObject.SetActive(true);
    }

    void JSpeech3()
    {
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        CoWorkersSpeech[2].gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", false);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonEmotions[0];
        JasonSpeech[2].gameObject.SetActive(true);
    }

    void Selection3()
    {
        
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        JasonSpeech[2].gameObject.SetActive(false);
        Blocks[1].SetActive(true);
        Responses[2].gameObject.SetActive(true);
        Responses[10].gameObject.SetActive(true);
        Responses[11].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(true);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
        MC.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[0];
    }

    void ShowResponse3()
    {
        JasonSpeech[2].gameObject.SetActive(false);
        Blocks[1].SetActive(false);
        Responses[2].gameObject.SetActive(false);
        Responses[10].gameObject.SetActive(false);
        Responses[11].gameObject.SetActive(false);
        ShowChoices[2].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[1];
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse11()
    {
        JasonValue += 10f;
        JasonSpeech[2].gameObject.SetActive(false);
        Blocks[1].SetActive(false);
        Responses[2].gameObject.SetActive(false);
        Responses[10].gameObject.SetActive(false);
        Responses[11].gameObject.SetActive(false);
        ShowChoices[10].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[0];
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse12()
    {
        JasonValue -= 10f;
        JasonSpeech[2].gameObject.SetActive(false);
        Blocks[1].SetActive(false);
        Responses[2].gameObject.SetActive(false);
        Responses[10].gameObject.SetActive(false);
        Responses[11].gameObject.SetActive(false);
        ShowChoices[11].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[0];
        BottomBackground.gameObject.SetActive(false);
    }

    void JSpeech4()
    {
        ShowChoices[2].gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonEmotions[0];
        JasonSpeech[4].gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
    }

    void KSpeech4()
    {
        JasonSpeech[4].gameObject.SetActive(false);
        Responses[3].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[0];
        KatieSpeech[3].gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
    }

    void JSpeech5()
    {
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        KatieSpeech[3].gameObject.SetActive(false);
        JasonSpeech[5].gameObject.SetActive(true);
        Jason.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", false);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonEmotions[0];
    }

    void Selection4()
    {
        JasonSpeech[5].gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        Blocks[2].SetActive(true);
        Responses[3].gameObject.SetActive(true);
        Responses[12].gameObject.SetActive(true);
        Responses[13].gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[1];
        BottomBackground.gameObject.SetActive(true);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
    }

    void ShowResponse4()
    {
        JasonValue += 10f;
        JasonSpeech[5].gameObject.SetActive(false);
        Blocks[2].SetActive(false);
        Responses[3].gameObject.SetActive(false);
        Responses[12].gameObject.SetActive(false);
        Responses[13].gameObject.SetActive(false);
        ShowChoices[3].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse13()
    {
        JasonSpeech[5].gameObject.SetActive(false);
        Blocks[2].SetActive(false);
        Responses[3].gameObject.SetActive(false);
        Responses[12].gameObject.SetActive(false);
        Responses[13].gameObject.SetActive(false);
        ShowChoices[12].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse14()
    {
        JasonValue -= 10f;
        JasonSpeech[5].gameObject.SetActive(false);
        Blocks[2].SetActive(false);
        Responses[3].gameObject.SetActive(false);
        Responses[12].gameObject.SetActive(false);
        Responses[13].gameObject.SetActive(false);
        ShowChoices[13].gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void JSpeech6()
    {
        ShowChoices[3].gameObject.SetActive(false);
        ShowChoices[12].gameObject.SetActive(false);
        ShowChoices[13].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", false);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonEmotions[0];
        JasonSpeech[3].gameObject.SetActive(false);
        JasonSpeech[5].gameObject.SetActive(false);
        JasonSpeech[6].gameObject.SetActive(true);
        Bar.gameObject.SetActive(true);
        ImageOfBar.gameObject.SetActive(true);
        Bar = (RawImage)ImageOfBar.GetComponent<RawImage>();
        Bar.texture = (Texture)Bars[2];
    }

    void Selection5()
    {
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        JasonSpeech[6].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[1];
        Blocks[3].SetActive(true);
        Responses[4].gameObject.SetActive(true);
        Responses[5].gameObject.SetActive(true);
        if (OptionsScript.vibrateSetting == true)
        {
            Handheld.Vibrate();
        }
        BottomBackground.gameObject.SetActive(true);
    }

    void ShowResponse5()
    {
        JasonValue -= 10f;
        Blocks[3].SetActive(false);
        Responses[4].gameObject.SetActive(false);
        Responses[5].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[2];
        ShowChoices[4].gameObject.SetActive(true);
        JasonSpeech[6].gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse6()
    {
        Blocks[3].SetActive(false);
        Responses[4].gameObject.SetActive(false);
        Responses[5].gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", false);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();
        MC.texture = (Texture)KatieEmotions[2];
        ShowChoices[5].gameObject.SetActive(true);
        JasonSpeech[6].gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        BottomBackground.gameObject.SetActive(false);
    }
    void End()
    {
        Social[0].gameObject.SetActive(false);
        Social[1].gameObject.SetActive(false);
        Social[2].gameObject.SetActive(false);
        Social[3].gameObject.SetActive(false);
        ShowChoices[5].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        ShowChoices[4].gameObject.SetActive(false);
        JasonSpeech[6].gameObject.SetActive(false);
        Responses[4].gameObject.SetActive(false);
        Responses[5].gameObject.SetActive(false);
        EndScreen.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        Bar.gameObject.SetActive(false);
        ImageOfBar.gameObject.SetActive(false);
        ChangeScene.gameObject.SetActive(true);
    }

    void JSpeech7()
    {
        Jason.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", false);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonEmotions[0];
        ShowChoices[10].gameObject.SetActive(false);
        ShowChoices[11].gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        JasonSpeech[3].gameObject.SetActive(true);
        JasonSpeech[2].gameObject.SetActive(false);
    }

    IEnumerator transitionPanel() //panel timer
    {
        yield return new WaitForSeconds(1f);
        canClick = true;
    }
} 