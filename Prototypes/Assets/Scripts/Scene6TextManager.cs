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


    public Button ShowChoice1;
    public Button ShowChoice2;
    public Button ShowChoice3;
    public Button ShowChoice4;
    public Button ShowChoice5;
    public Button ShowChoice6;
    public Button ShowChoice7;
    public Button ShowChoice8;
    public Button ShowChoice9;
    public Button ShowChoice10;
    public Button ShowChoice11;
    public Button ShowChoice12;
    public Button ShowChoice13;
    public Button ShowChoice14;

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

    public GameObject KatieNeutral;
    public GameObject KatieHappy;
    public GameObject KatieAngry;

    public GameObject AminaHappy;
    public GameObject AminaNeutral;
    public GameObject JasonHappy;
    public GameObject JasonNeutral;
    public GameObject RichardHappy;
    public RawImage Phone;
    public RawImage BarExterior;
    public RawImage BarInterior;
    public RawImage EndScreen;
    public Button Email;
    public Button SocialMedia;
    public Button Messages;
    public Button Options;
    public RawImage RobinName;
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
        KatieHappy.gameObject.SetActive(false);
        ShowChoice1.gameObject.SetActive(false);
        ShowChoice2.gameObject.SetActive(false);
        ShowChoice3.gameObject.SetActive(false);
        ShowChoice4.gameObject.SetActive(false);
        ShowChoice5.gameObject.SetActive(false);
        ShowChoice6.gameObject.SetActive(false);
        ShowChoice7.gameObject.SetActive(false);
        ShowChoice8.gameObject.SetActive(false);
        ShowChoice9.gameObject.SetActive(false);
        ShowChoice10.gameObject.SetActive(false);
        ShowChoice11.gameObject.SetActive(false);
        ShowChoice12.gameObject.SetActive(false);
        ShowChoice13.gameObject.SetActive(false);
        ShowChoice14.gameObject.SetActive(false);

        KatieNeutral.gameObject.SetActive(false);
        KatieAngry.gameObject.SetActive(false);
        AminaHappy.gameObject.SetActive(false);
        AminaNeutral.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(false);
        JasonNeutral.gameObject.SetActive(false);
        RichardHappy.gameObject.SetActive(false);
        //phone.gameObject.SetActive(false);
        BarInterior.gameObject.SetActive(false);
        //BarExterior.gameObject.SetActive(false);
        WaiterSpeech.gameObject.SetActive(false);
        EndScreen.gameObject.SetActive(false);

        RobinName.gameObject.SetActive(true);

        Button robin1 = RobinSpeech1.GetComponent<Button>();
        robin1.onClick.AddListener(KSpeech1);
        Button K1 = KatieSpeech1.GetComponent<Button>();
        K1.onClick.AddListener(EnviroChange1);
        Button Co = CoworkerSpeech.GetComponent<Button>();
        Co.onClick.AddListener(KSpeech2);
        Button K2 = KatieSpeech2.GetComponent<Button>();
        K2.onClick.AddListener(JSpeech1);
        Button r1 = response1.GetComponent<Button>();
        r1.onClick.AddListener(ShowResponse1);
        Button r7 = response7.GetComponent<Button>();
        r7.onClick.AddListener(ShowResponse7);
        Button r8 = response8.GetComponent<Button>();
        r8.onClick.AddListener(ShowResponse8);
        Button r2 = response2.GetComponent<Button>();
        r2.onClick.AddListener(ShowResponse2);
        Button r9 = response9.GetComponent<Button>();
        r9.onClick.AddListener(ShowResponse9);
        Button r10 = response10.GetComponent<Button>();
        r10.onClick.AddListener(ShowResponse10);
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
        r3.onClick.AddListener(ShowResponse3);
        Button r11 = response11.GetComponent<Button>();
        r11.onClick.AddListener(ShowResponse11);
        Button r12 = response12.GetComponent<Button>();
        r12.onClick.AddListener(ShowResponse12);
        Button JS5 = JasonSpeech5.GetComponent<Button>();
        JS5.onClick.AddListener(KSpeech4);
        Button JS6 = JasonSpeech4.GetComponent<Button>();
        JS6.onClick.AddListener(JSpeech6);
        Button K4 = KatieSpeech4.GetComponent<Button>();
        K4.onClick.AddListener(JSpeech5);
        Button r4 = response4.GetComponent<Button>();
        r4.onClick.AddListener(ShowResponse4);
        Button r13 = response13.GetComponent<Button>();
        r13.onClick.AddListener(ShowResponse13);
        Button r14 = response14.GetComponent<Button>();
        r14.onClick.AddListener(ShowResponse14);
        Button r5 = response5.GetComponent<Button>();
        r5.onClick.AddListener(ShowResponse5);
        Button r6 = response6.GetComponent<Button>();
        r6.onClick.AddListener(ShowResponse6);
        Button SC1 = ShowChoice1.GetComponent<Button>();
        SC1.onClick.AddListener(Choice2);
        Button SC7 = ShowChoice7.GetComponent<Button>();
        SC7.onClick.AddListener(Choice2);
        Button SC8 = ShowChoice8.GetComponent<Button>();
        SC8.onClick.AddListener(Choice2);
        Button SC2 = ShowChoice2.GetComponent<Button>();
        SC2.onClick.AddListener(BS1);
        Button SC9= ShowChoice9.GetComponent<Button>();
        SC9.onClick.AddListener(BS1);
        Button SC10 = ShowChoice10.GetComponent<Button>();
        SC10.onClick.AddListener(BS1);
        Button SC3 = ShowChoice3.GetComponent<Button>();
        SC3.onClick.AddListener(JSpeech4);
        Button SC11 = ShowChoice11.GetComponent<Button>();
        SC11.onClick.AddListener(JSpeech7);
        Button SC12 = ShowChoice12.GetComponent<Button>();
        SC12.onClick.AddListener(JSpeech7);
        Button SC4 = ShowChoice4.GetComponent<Button>();
        SC4.onClick.AddListener(JSpeech6);
        Button SC13 = ShowChoice13.GetComponent<Button>();
        SC13.onClick.AddListener(JSpeech6);
        Button SC14 = ShowChoice14.GetComponent<Button>();
        SC14.onClick.AddListener(JSpeech6);
        Button SC5 = ShowChoice5.GetComponent<Button>();
        SC5.onClick.AddListener(End);
        Button SC6 = ShowChoice6.GetComponent<Button>();
        SC6.onClick.AddListener(End);
    }


    void Update()
    {
     
    }

    void KSpeech1()
    {
        KatieSpeech1.gameObject.SetActive(true);
        
    }

    void EnviroChange1()
    {
        KatieSpeech1.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(false);
        RobinName.gameObject.SetActive(false);
        Phone.gameObject.SetActive(false);
        BarExterior.gameObject.SetActive(false);
        BarInterior.gameObject.SetActive(true);
        CoworkerSpeech.gameObject.SetActive(true);
    }

    void KSpeech2()
    {
        KatieSpeech2.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(true);
        CoworkerSpeech.gameObject.SetActive(false);
    }

    void JSpeech1()
    {
        KatieSpeech2.gameObject.SetActive(false);
        KatieHappy.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(true);
        JasonSpeech1.gameObject.SetActive(true);
        response1.gameObject.SetActive(true);
        response7.gameObject.SetActive(true);
        response8.gameObject.SetActive(true);

        Handheld.Vibrate();
    }

    void ShowResponse1()
    {
        JasonHappy.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        ShowChoice1.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(true);

    }

    void ShowResponse7()
    {
        JasonHappy.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        ShowChoice7.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(true);

    }

    void ShowResponse8()
    {
        JasonHappy.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);
        response1.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        ShowChoice8.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(true);

    }
    void Choice2()
    {
        ShowChoice1.gameObject.SetActive(false);
        ShowChoice7.gameObject.SetActive(false);
        ShowChoice8.gameObject.SetActive(false);
        KatieHappy.gameObject.SetActive(false);
        response2.gameObject.SetActive(true);
        response9.gameObject.SetActive(true);
        response10.gameObject.SetActive(true);
   
        BossSpeech1.gameObject.SetActive(true);
        AminaNeutral.gameObject.SetActive(true);
        JasonHappy.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);

        Handheld.Vibrate();
    }

    void ShowResponse2()
    {
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(false);
        AminaNeutral.gameObject.SetActive(false);
        KatieNeutral.gameObject.SetActive(true);
        ShowChoice2.gameObject.SetActive(true);
    }

    void ShowResponse9()
    {
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(false);
        AminaNeutral.gameObject.SetActive(false);
        KatieNeutral.gameObject.SetActive(true);
        ShowChoice9.gameObject.SetActive(true);
    }

    void ShowResponse10()
    {
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(false);
        AminaNeutral.gameObject.SetActive(false);
        KatieNeutral.gameObject.SetActive(true);
        ShowChoice10.gameObject.SetActive(true);
    }

    void BS1()
    {
        KatieNeutral.gameObject.SetActive(false);
        ShowChoice2.gameObject.SetActive(false);
        ShowChoice9.gameObject.SetActive(false);
        ShowChoice10.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech2.gameObject.SetActive(true);
        AminaNeutral.gameObject.SetActive(true);
        BossSpeech1.gameObject.SetActive(false);
    }

    void Waiter()
    {
        BossSpeech2.gameObject.SetActive(false);
        AminaNeutral.gameObject.SetActive(false);
        WaiterSpeech.gameObject.SetActive(true);
    }

    void KSpeech3()
    {
      WaiterSpeech.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(true);
    }

    void RichSpeech1()
    {
        KatieSpeech3.gameObject.SetActive(false);
        KatieHappy.gameObject.SetActive(false);
        RichardHappy.gameObject.SetActive(true);
        RichardSpeech1.gameObject.SetActive(true);
    }

    void JSpeech2()
    {
        RichardHappy.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(true);
        JasonSpeech2.gameObject.SetActive(true);
    }

    void RichSpeech2()
    {
        JasonSpeech2.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(false);
        RichardHappy.gameObject.SetActive(true);
        RichardSpeech2.gameObject.SetActive(true);
    }

    void BS2()
    {
        RichardHappy.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(false);
        BossSpeech3.gameObject.SetActive(true);
        AminaHappy.gameObject.SetActive(true);
    }

    void RaA()
    {
        BossSpeech3.gameObject.SetActive(false);
        RichardandAminaSpeech.gameObject.SetActive(true);
    }

    void JaKS()
    {
        AminaHappy.gameObject.SetActive(false);
        RichardandAminaSpeech.gameObject.SetActive(false);
        KatieHappy.gameObject.SetActive(true);
        JasonAndKatieSpeech.gameObject.SetActive(true);
    }

    void JSpeech3()
    {
        KatieHappy.gameObject.SetActive(false);
        JasonAndKatieSpeech.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(true);
        JasonSpeech3.gameObject.SetActive(true);
        response3.gameObject.SetActive(true);
        response11.gameObject.SetActive(true);
        response12.gameObject.SetActive(true);

        Handheld.Vibrate();
    }

    void ShowResponse3()
    {
        JasonHappy.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
        ShowChoice3.gameObject.SetActive(true);
        KatieNeutral.gameObject.SetActive(true);
    }

    void ShowResponse11()
    {
        JasonHappy.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
        ShowChoice11.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(true);
    }

    void ShowResponse12()
    {
        JasonHappy.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
        ShowChoice12.gameObject.SetActive(true);
        KatieHappy.gameObject.SetActive(true);
    }

    void JSpeech4()
    {
        ShowChoice3.gameObject.SetActive(false);
        KatieNeutral.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(true);
        JasonSpeech5.gameObject.SetActive(true);
        
    }

    void KSpeech4()
    {
        JasonSpeech5.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        KatieHappy.gameObject.SetActive(true);
        KatieSpeech4.gameObject.SetActive(true);
        JasonHappy.gameObject.SetActive(false);
    }

    void JSpeech5()
    {
        KatieHappy.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(true);
        JasonHappy.gameObject.SetActive(true);
        response4.gameObject.SetActive(true);
        response13.gameObject.SetActive(true);
        response14.gameObject.SetActive(true);

        Handheld.Vibrate();
    }

    void ShowResponse4()
    {
        JasonSpeech6.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response13.gameObject.SetActive(false);
        response14.gameObject.SetActive(false);
        ShowChoice4.gameObject.SetActive(true);
        KatieNeutral.gameObject.SetActive(true);
    }

    void ShowResponse13()
    {
        JasonSpeech6.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response13.gameObject.SetActive(false);
        response14.gameObject.SetActive(false);
        ShowChoice13.gameObject.SetActive(true);
        KatieNeutral.gameObject.SetActive(true);
    }

    void ShowResponse14()
    {
        JasonSpeech6.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        response13.gameObject.SetActive(false);
        response14.gameObject.SetActive(false);
        ShowChoice14.gameObject.SetActive(true);
        KatieNeutral.gameObject.SetActive(true);
    }

    void JSpeech6()
    {
        ShowChoice4.gameObject.SetActive(false);
        ShowChoice13.gameObject.SetActive(false);
        KatieNeutral.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(true);
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

    void ShowResponse5()
    {
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        KatieAngry.gameObject.SetActive(true);
        ShowChoice5.gameObject.SetActive(true);
        JasonSpeech7.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(false);
    }

    void ShowResponse6()
    {
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        KatieAngry.gameObject.SetActive(true);
        ShowChoice6.gameObject.SetActive(true);
        JasonSpeech7.gameObject.SetActive(false);
        JasonHappy.gameObject.SetActive(false);
    }
    void End()
    {
        Email.gameObject.SetActive(false);
        SocialMedia.gameObject.SetActive(false);
        Messages.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        ShowChoice6.gameObject.SetActive(false);
        KatieAngry.gameObject.SetActive(false);
        ShowChoice5.gameObject.SetActive(false);
        JasonSpeech7.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        BarExterior.gameObject.SetActive(false);
        EndScreen.gameObject.SetActive(true);
        JasonHappy.gameObject.SetActive(false);
       
    }

    void JSpeech7()
    {
        JasonHappy.gameObject.SetActive(true);
        ShowChoice11.gameObject.SetActive(false);
        ShowChoice12.gameObject.SetActive(false);
        KatieHappy.gameObject.SetActive(false);
        JasonSpeech4.gameObject.SetActive(true);
        JasonSpeech3.gameObject.SetActive(false);
        
    }
}