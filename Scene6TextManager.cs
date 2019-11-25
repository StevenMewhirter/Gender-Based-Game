using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using System;

public class Scene6TextManager : MonoBehaviour
{
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
    public Button response10;
    public Button response11;
    public Button response12;
    public Button response13;
    public Button response14;

    public Button JasonSpeech1;
    public Button JasonSpeech2;
    public Button JasonSpeech3;
    public Button JasonSpeech4;
    public Button JasonSpeech5;
    public Button JasonSpeech6;
    public Button JasonSpeech7;

    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;

    public Button RobinSpeech1;

    public Button RichardSpeech1;
    public Button RichardSpeech2;

    public Button RichardandAminaSpeech;
    public Button JasonAndKatieSpeech;
    public Button CoworkerSpeech;
    public Button WaiterSpeech;

    public RawImage Katie;
    public RawImage Amina;
    public RawImage Jason;
    public RawImage Richard;
    public RawImage Phone;
    public RawImage BarExterior;
    public RawImage BarInterior;
    public RawImage EndScreen;
    public RawImage BackBackground;
    // Start is called before the first frame update
    void Start()
    {

        BossSpeech1.gameObject.SetActive(false);
        BossSpeech2.gameObject.SetActive(false);
        BossSpeech3.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
        response13.gameObject.SetActive(false);
        response14.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);
        JasonSpeech2.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(false);
        JasonSpeech4.gameObject.SetActive(false);
        JasonSpeech5.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(false);
        JasonSpeech7.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(false);
        //RobinSpeech1.gameObject.SetActive(false);
        RichardandAminaSpeech.gameObject.SetActive(false);
        JasonAndKatieSpeech.gameObject.SetActive(false);
        CoworkerSpeech.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        Amina.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        Richard.gameObject.SetActive(false);
        //phone.gameObject.SetActive(false);
        BarInterior.gameObject.SetActive(false);
        //BarExterior.gameObject.SetActive(false);
        WaiterSpeech.gameObject.SetActive(false);
        EndScreen.gameObject.SetActive(false);

        Button robin1 = RobinSpeech1.GetComponent<Button>();
        robin1.onClick.AddListener(KSpeech1);
        Button K1 = KatieSpeech1.GetComponent<Button>();
        K1.onClick.AddListener(EnviroChange1);
        Button Co = CoworkerSpeech.GetComponent<Button>();
        Co.onClick.AddListener(KSpeech2);
        Button K2 = KatieSpeech2.GetComponent<Button>();
        K2.onClick.AddListener(JSpeech1);
        Button r1 = response1.GetComponent<Button>();
        r1.onClick.AddListener(Choice2);
        Button r7 = response7.GetComponent<Button>();
        r7.onClick.AddListener(Choice2);
        Button r8 = response8.GetComponent<Button>();
        r8.onClick.AddListener(Choice2);
        Button r2 = response2.GetComponent<Button>();
        r2.onClick.AddListener(BS1);
        Button r9 = response9.GetComponent<Button>();
        r9.onClick.AddListener(BS1);
        Button r10 = response10.GetComponent<Button>();
        r10.onClick.AddListener(BS1);
        Button A1 = BossSpeech2.GetComponent<Button>();
        A1.onClick.AddListener(Waiter);
        Button W = WaiterSpeech.GetComponent<Button>();
        W.onClick.AddListener(KSpeech3);
        Button K3 = KatieSpeech3.GetComponent<Button>();
        K3.onClick.AddListener(RichSpeech1);
        Button Rich1 = RichardSpeech1.GetComponent<Button>();
        Rich1.onClick.AddListener(JSpeech2);
        Button J1 = JasonSpeech2.GetComponent<Button>();
        J1.onClick.AddListener(RichSpeech2);
        Button Rich2 = RichardSpeech2.GetComponent<Button>();
        Rich2.onClick.AddListener(BS2);
        Button A2 = BossSpeech3.GetComponent<Button>();
        A2.onClick.AddListener(RaA);
        Button RaA1 = RichardandAminaSpeech.GetComponent<Button>();
        RaA1.onClick.AddListener(JaKS);
        Button JaK = JasonAndKatieSpeech.GetComponent<Button>();
        JaK.onClick.AddListener(JSpeech3);
        Button r3 = response3.GetComponent<Button>();
        r3.onClick.AddListener(JSpeech4);
        Button r11 = response11.GetComponent<Button>();
        r11.onClick.AddListener(JSpeech7);
        Button r12 = response12.GetComponent<Button>();
        r12.onClick.AddListener(JSpeech7);
        Button JS5 = JasonSpeech5.GetComponent<Button>();
        JS5.onClick.AddListener(KSpeech4);
        Button JS6 = JasonSpeech4.GetComponent<Button>();
        JS6.onClick.AddListener(JSpeech6);
        Button K4 = KatieSpeech4.GetComponent<Button>();
        K4.onClick.AddListener(JSpeech5);
        Button r4 = response4.GetComponent<Button>();
        r4.onClick.AddListener(JSpeech6);
        Button r13 = response13.GetComponent<Button>();
        r13.onClick.AddListener(JSpeech6);
        Button r14 = response14.GetComponent<Button>();
        r14.onClick.AddListener(JSpeech6);
        Button r5 = response5.GetComponent<Button>();
        r5.onClick.AddListener(End);
        Button r6 = response6.GetComponent<Button>();
        r6.onClick.AddListener(End);
    }


    void Update()
    {
     
    }

    void KSpeech1()
    {
        KatieSpeech1.gameObject.SetActive(true);
        RobinSpeech1.gameObject.SetActive(false);
        Katie.gameObject.SetActive(true);
        Phone.gameObject.SetActive(false);
    }

    void EnviroChange1()
    {
        KatieSpeech1.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        BarExterior.gameObject.SetActive(false);
        BarInterior.gameObject.SetActive(true);
        CoworkerSpeech.gameObject.SetActive(true);
    }

    void KSpeech2()
    {
        KatieSpeech2.gameObject.SetActive(true);
        Katie.gameObject.SetActive(true);
        CoworkerSpeech.gameObject.SetActive(false);
    }

    void JSpeech1()
    {
        KatieSpeech2.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        JasonSpeech1.gameObject.SetActive(true);
        response1.gameObject.SetActive(true);
        response7.gameObject.SetActive(true);
        response8.gameObject.SetActive(true);

        Handheld.Vibrate();
    }
    
    void Choice2()
    {
        response2.gameObject.SetActive(true);
        response9.gameObject.SetActive(true);
        response10.gameObject.SetActive(true);
        response1.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(true);
        Amina.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);

        Handheld.Vibrate();
    }

    void BS1()
    {
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech2.gameObject.SetActive(true);
        Amina.gameObject.SetActive(true);
        BossSpeech1.gameObject.SetActive(false);
    }

    void Waiter()
    {
        BossSpeech2.gameObject.SetActive(false);
        Amina.gameObject.SetActive(false);
        WaiterSpeech.gameObject.SetActive(true);
    }

    void KSpeech3()
    {
      WaiterSpeech.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(true);
        Katie.gameObject.SetActive(true);
    }

    void RichSpeech1()
    {
        KatieSpeech3.gameObject.SetActive(false);
        Katie.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardSpeech1.gameObject.SetActive(true);
    }

    void JSpeech2()
    {
        Richard.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        JasonSpeech2.gameObject.SetActive(true);
    }

    void RichSpeech2()
    {
        JasonSpeech2.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardSpeech2.gameObject.SetActive(true);
    }

    void BS2()
    {
        Richard.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(false);
        BossSpeech3.gameObject.SetActive(true);
        Amina.gameObject.SetActive(true);
    }

    void RaA()
    {
        BossSpeech3.gameObject.SetActive(false);
        RichardandAminaSpeech.gameObject.SetActive(true);
    }

    void JaKS()
    {
        Amina.gameObject.SetActive(false);
        RichardandAminaSpeech.gameObject.SetActive(false);
        Katie.gameObject.SetActive(true);
        JasonAndKatieSpeech.gameObject.SetActive(true);
    }

    void JSpeech3()
    {
        Katie.gameObject.SetActive(false);
        JasonAndKatieSpeech.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        JasonSpeech3.gameObject.SetActive(true);
        response3.gameObject.SetActive(true);
        response11.gameObject.SetActive(true);
        response12.gameObject.SetActive(true);

        Handheld.Vibrate();
    }

    void JSpeech4()
    {
        JasonSpeech3.gameObject.SetActive(false);
        JasonSpeech5.gameObject.SetActive(true);
        response3.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
    }

    void KSpeech4()
    {
        JasonSpeech5.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        Katie.gameObject.SetActive(true);
        KatieSpeech4.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
    }

    void JSpeech5()
    {
        Katie.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(true);
        Jason.gameObject.SetActive(true);
        response4.gameObject.SetActive(true);
        response13.gameObject.SetActive(true);
        response14.gameObject.SetActive(true);

        Handheld.Vibrate();
    }

    void JSpeech6()
    {
        JasonSpeech4.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(false);
        JasonSpeech7.gameObject.SetActive(true);
        response5.gameObject.SetActive(true);
        response6.gameObject.SetActive(true);
        BarExterior.gameObject.SetActive(true);
        BarInterior.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response13.gameObject.SetActive(false);
        response14.gameObject.SetActive(false);

        Handheld.Vibrate();
    }

    void End()
    {
        JasonSpeech7.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        BarExterior.gameObject.SetActive(false);
        EndScreen.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        BackBackground.gameObject.SetActive(false);
    }

    void JSpeech7()
    {
        JasonSpeech4.gameObject.SetActive(true);
        JasonSpeech3.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
    }
}