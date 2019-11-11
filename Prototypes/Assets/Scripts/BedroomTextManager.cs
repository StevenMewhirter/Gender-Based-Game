using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class BedroomTextManager : MonoBehaviour
{
    public Button response1;
    public Button response2;
    public Button response3;
    public Button response4;
    public Button response5;
    public Button response6;

    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
    public Button KatieSpeech5;

    public Button RobinSpeech1;
    public Button RobinSpeech2;
    public Button RobinSpeech3;
    public Button RobinSpeech4;
    public Button RobinSpeech5;
    public Button RobinSpeech6;

    public Button ThoughtBubble1;
    public Button ThoughtBubble2;
    public Button ThoughtBubble3;
    public Button ThoughtBubble4;

    public Button EmailText1;
    public Button EmailText2;
    public Button EmailText3;
    public Button EmailText4;
    public Button EmailText5;

    public RawImage Katie;
    public RawImage Phone;
    

    // Start is called before the first frame update
    void Start()
    {
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        // Katie.gameObject.SetActive(false);
        Phone.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        KatieSpeech5.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(false);
        RobinSpeech3.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(false);
        //ThoughtBubble1.gameObject.SetActive(false);
        ThoughtBubble2.gameObject.SetActive(false);
        ThoughtBubble3.gameObject.SetActive(false);
        ThoughtBubble4.gameObject.SetActive(false);
        EmailText1.gameObject.SetActive(false);
        EmailText2.gameObject.SetActive(false);
        EmailText3.gameObject.SetActive(false);
        EmailText4.gameObject.SetActive(false);
        EmailText5.gameObject.SetActive(false);

        Button t1 = ThoughtBubble1.GetComponent<Button>();
        t1.onClick.AddListener(TB2);
        Button t2 = ThoughtBubble2.GetComponent<Button>();
        t2.onClick.AddListener(TB3);
        Button t3 = ThoughtBubble3.GetComponent<Button>();
        t3.onClick.AddListener(KSpeech1);
        Button KS1 = KatieSpeech1.GetComponent<Button>();
        KS1.onClick.AddListener(RobinReply1);
        Button RS1 = RobinSpeech1.GetComponent<Button>();
        RS1.onClick.AddListener(KSpeech2);
        Button KS2 = KatieSpeech2.GetComponent<Button>();
        KS2.onClick.AddListener(RobinReply2);
        Button RS2 = RobinSpeech2.GetComponent<Button>();
        RS2.onClick.AddListener(KSpeech3);
        Button KS3 = KatieSpeech3.GetComponent<Button>();
        KS3.onClick.AddListener(RobinReply3);
        Button RS3 = RobinSpeech3.GetComponent<Button>();
        RS3.onClick.AddListener(Email1);
        Button E1 = EmailText1.GetComponent<Button>();
        E1.onClick.AddListener(Email2);
        Button E2 = EmailText2.GetComponent<Button>();
        E2.onClick.AddListener(Email3);
        Button E3 = EmailText3.GetComponent<Button>();
        E3.onClick.AddListener(Email4);
        Button E4 = EmailText4.GetComponent<Button>();
        E4.onClick.AddListener(Email5);
        Button E5 = EmailText5.GetComponent<Button>();
        E5.onClick.AddListener(KSpeech4);
        Button KS4 = KatieSpeech4.GetComponent<Button>();
        KS4.onClick.AddListener(Choice1);
        Button R1 = response1.GetComponent<Button>();
        R1.onClick.AddListener(RobinReply4);
        Button R2 = response2.GetComponent<Button>();
        R2.onClick.AddListener(RobinReply4);
        Button R3 = response3.GetComponent<Button>();
        R3.onClick.AddListener(RobinReply5);
        Button R4 = response4.GetComponent<Button>();
        R4.onClick.AddListener(RobinReply5);
        Button R5 = response5.GetComponent<Button>();
        R5.onClick.AddListener(RobinReply6);
        Button R6 = response6.GetComponent<Button>();
        R6.onClick.AddListener(RobinReply6);
        Button RS6 = RobinSpeech6.GetComponent<Button>();
        RS6.onClick.AddListener(KSpeech5);
        Button KS5 = KatieSpeech5.GetComponent<Button>();
        KS5.onClick.AddListener(TB4);
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    void TB2()
    {
       ThoughtBubble1.gameObject.SetActive(false);
       ThoughtBubble2.gameObject.SetActive(true);
    }

    void TB3()
    {
        ThoughtBubble2.gameObject.SetActive(false);
        ThoughtBubble3.gameObject.SetActive(true);
    }

    void KSpeech1()
    {
        ThoughtBubble3.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(true);
    }

    void RobinReply1()
    {
        Katie.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
        Phone.gameObject.SetActive(true);
        RobinSpeech1.gameObject.SetActive(true);
    }

    void KSpeech2()
    {
        Phone.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(false);
        Katie.gameObject.SetActive(true);
        KatieSpeech2.gameObject.SetActive(true);
    }

    void RobinReply2()
    {
        Katie.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        Phone.gameObject.SetActive(true);
        RobinSpeech2.gameObject.SetActive(true);
    }

    void KSpeech3()
    {
        Phone.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(false);
        Katie.gameObject.SetActive(true);
        KatieSpeech3.gameObject.SetActive(true);
    }

    void RobinReply3()
    {
        Katie.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        Phone.gameObject.SetActive(true);
        RobinSpeech3.gameObject.SetActive(true);
    }

    void Email1()
    {
        RobinSpeech3.gameObject.SetActive(false);
        EmailText1.gameObject.SetActive(true);
    }

    void Email2()
    {
        EmailText1.gameObject.SetActive(false);
        EmailText2.gameObject.SetActive(true);
    }

    void Email3()
    {
        EmailText2.gameObject.SetActive(false);
        EmailText3.gameObject.SetActive(true);
    }

    void Email4()
    {
        EmailText3.gameObject.SetActive(false);
        EmailText4.gameObject.SetActive(true);
    }

    void Email5()
    {
        EmailText4.gameObject.SetActive(false);
        EmailText5.gameObject.SetActive(true);
    }

    void KSpeech4()
    {
        Phone.gameObject.SetActive(false);
        EmailText5.gameObject.SetActive(false);
        Katie.gameObject.SetActive(true);
        KatieSpeech4.gameObject.SetActive(true);
    }

    void Choice1()
    {
        KatieSpeech4.gameObject.SetActive(false);
        response1.gameObject.SetActive(true);
        response2.gameObject.SetActive(true);
    }

    void RobinReply4()
    {
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        Phone.gameObject.SetActive(true);
        RobinSpeech4.gameObject.SetActive(true);
        response3.gameObject.SetActive(true);
        response4.gameObject.SetActive(true);
    }

    void RobinReply5()
    {
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(true);
        response5.gameObject.SetActive(true);
        response6.gameObject.SetActive(true);
    }

    void RobinReply6()
    {
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(true);
    }

    void KSpeech5()
    {
        RobinSpeech6.gameObject.SetActive(false);
        Phone.gameObject.SetActive(false);
        Katie.gameObject.SetActive(true);
        KatieSpeech5.gameObject.SetActive(true);
    }

    void TB4()
    {
        KatieSpeech5.gameObject.SetActive(false);
        ThoughtBubble4.gameObject.SetActive(true);
    }
}
