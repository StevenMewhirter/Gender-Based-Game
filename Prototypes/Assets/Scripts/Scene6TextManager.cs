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

    public Texture KatieAngry;
    public Texture KatieNeutral;
    public Texture KatieHappy;
    public GameObject ImageOfKatie;

    public Texture AminaNeutral;
    public Texture AminaHappy;
    public GameObject ImageOfAmina;

    public Texture RichardNeutral;
    public Texture RichardHappy;
    public GameObject ImageOfRichard;

    public Texture JasonNeutral;
    public Texture JasonHappy;
    public GameObject ImageOfJason;

    public Texture Bar1;
    public Texture Bar2;
    public Texture Bar3;
    public GameObject ImageOfBar;

    public RawImage MC;
    public RawImage Amina;
    public RawImage Richard;
    public RawImage Jason;
    public RawImage Bar;

    public Button BottomBackground;
   
    public RawImage Phone;

   
    public RawImage EndScreen;
    public Button Email;
    public Button SocialMedia;
    public Button Messages;
    public Button Options;
    public RawImage RobinName;

    public Animator KatieAnimator;
    public Animator RichardAnimator;
    public Animator JasonAnimator;
    public Animator AminaAnimator;
  
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
        BottomBackground.gameObject.SetActive(false);

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
        //phone.gameObject.SetActive(false);
     
       
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
        SC1.onClick.AddListener(ASpeech1);
        Button SC7 = ShowChoice7.GetComponent<Button>();
        SC7.onClick.AddListener(ASpeech1);
        Button SC8 = ShowChoice8.GetComponent<Button>();
        SC8.onClick.AddListener(ASpeech1);
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
        Button JS7 = JasonSpeech1.GetComponent<Button>();
        JS7.onClick.AddListener(Selection1);
        Button JS8 = JasonSpeech3.GetComponent<Button>();
        JS8.onClick.AddListener(Selection3);
        Button JS9 = JasonSpeech6.GetComponent<Button>();
        JS9.onClick.AddListener(Selection4);
        Button JS10 = JasonSpeech7.GetComponent<Button>();
        JS10.onClick.AddListener(Selection5);
        Button A3 = BossSpeech1.GetComponent<Button>();
        A3.onClick.AddListener(Selection2);
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
     
        Bar.gameObject.SetActive(true);
        ImageOfBar.gameObject.SetActive(true);
        Bar = (RawImage)ImageOfBar.GetComponent<RawImage>();

        Bar.texture = (Texture)Bar1;
        CoworkerSpeech.gameObject.SetActive(true);
    }

    void KSpeech2()
    {
        KatieSpeech2.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        CoworkerSpeech.gameObject.SetActive(false);
    }

    void JSpeech1()
    {
        KatieSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        ImageOfJason.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();

        Jason.texture = (Texture)JasonHappy;
        JasonSpeech1.gameObject.SetActive(true);
       
    }

    void Selection1()
    {
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);
        response1.gameObject.SetActive(true);
        response7.gameObject.SetActive(true);
        response8.gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(true);
        Handheld.Vibrate();
    }

    void ShowResponse1()
    {
      
      
        response1.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        ShowChoice1.gameObject.SetActive(true);
      
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse7()
    {
        
        response1.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        ShowChoice7.gameObject.SetActive(true);
     
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse8()
    {
      
        response1.gameObject.SetActive(false);
        response7.gameObject.SetActive(false);
        response8.gameObject.SetActive(false);
        ShowChoice8.gameObject.SetActive(true);
   
        BottomBackground.gameObject.SetActive(false);
    }

    void ASpeech1()
    {
        ShowChoice1.gameObject.SetActive(false);
        ShowChoice7.gameObject.SetActive(false);
        ShowChoice8.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(true);
        
        Amina.gameObject.SetActive(true);
        ImageOfAmina.gameObject.SetActive(true);
        AminaAnimator.SetBool("AminaMove", true);
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Amina.texture = (Texture)AminaNeutral;
    }
    void Selection2()
    {

        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;
        response2.gameObject.SetActive(true);
        response9.gameObject.SetActive(true);
        response10.gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(true);

        BossSpeech1.gameObject.SetActive(false);
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);


        Handheld.Vibrate();
    }

    void ShowResponse2()
    {
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(false);
     
     
        ShowChoice2.gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse9()
    {
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(false);
  
       
        ShowChoice9.gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse10()
    {
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech1.gameObject.SetActive(false);
       
       
        ShowChoice10.gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(false);
    }

    void BS1()
    {
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        ShowChoice2.gameObject.SetActive(false);
        ShowChoice9.gameObject.SetActive(false);
        ShowChoice10.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response9.gameObject.SetActive(false);
        response10.gameObject.SetActive(false);
        BossSpeech2.gameObject.SetActive(true);
        Amina.gameObject.SetActive(true);
        AminaAnimator.SetBool("AminaMove", true);
        ImageOfAmina.gameObject.SetActive(true);
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Amina.texture = (Texture)AminaNeutral;
        BossSpeech1.gameObject.SetActive(false);
    }

    void Waiter()
    {
        BossSpeech2.gameObject.SetActive(false);
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        WaiterSpeech.gameObject.SetActive(true);
    }

    void KSpeech3()
    {
      WaiterSpeech.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(true);

        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
    }

    void RichSpeech1()
    {
        Bar.gameObject.SetActive(true);
        ImageOfBar.gameObject.SetActive(true);
        Bar = (RawImage)ImageOfBar.GetComponent<RawImage>();

        Bar.texture = (Texture)Bar2;
        KatieSpeech3.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
        RichardAnimator.SetBool("RichardMove", true);
        ImageOfRichard.gameObject.SetActive(true);
        Richard = (RawImage)ImageOfRichard.GetComponent<RawImage>();

        Richard.texture = (Texture)RichardHappy;
        RichardSpeech1.gameObject.SetActive(true);
    }

    void JSpeech2()
    {
        Richard.gameObject.SetActive(false);
        ImageOfRichard.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();

        Jason.texture = (Texture)JasonHappy;
        JasonSpeech2.gameObject.SetActive(true);
    }

    void RichSpeech2()
    {
        JasonSpeech2.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        
        Richard.gameObject.SetActive(true);
        RichardAnimator.SetBool("RichardMove", true);
        ImageOfRichard.gameObject.SetActive(true);
        Richard = (RawImage)ImageOfRichard.GetComponent<RawImage>();

        Richard.texture = (Texture)RichardHappy;
        RichardSpeech2.gameObject.SetActive(true);
    }

    void BS2()
    {
        Richard.gameObject.SetActive(false);
        ImageOfRichard.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(false);
        BossSpeech3.gameObject.SetActive(true);
        Amina.gameObject.SetActive(true);
        AminaAnimator.SetBool("AminaMove", true);
        ImageOfAmina.gameObject.SetActive(true);
        Amina = (RawImage)ImageOfAmina.GetComponent<RawImage>();

        Amina.texture = (Texture)AminaHappy;
    }

    void RaA()
    {
        BossSpeech3.gameObject.SetActive(false);
        RichardandAminaSpeech.gameObject.SetActive(true);
    }

    void JaKS()
    {
        Amina.gameObject.SetActive(false);
        ImageOfAmina.gameObject.SetActive(false);
        RichardandAminaSpeech.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        JasonAndKatieSpeech.gameObject.SetActive(true);
    }

    void JSpeech3()
    {
      
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        JasonAndKatieSpeech.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();

        Jason.texture = (Texture)JasonHappy;
        JasonSpeech3.gameObject.SetActive(true);
       
    }

    void Selection3()
    {
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(false);
        response3.gameObject.SetActive(true);
        response11.gameObject.SetActive(true);
        response12.gameObject.SetActive(true);
        BottomBackground.gameObject.SetActive(true);
        Handheld.Vibrate();
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
    }

    void ShowResponse3()
    {
        
        JasonSpeech3.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
        ShowChoice3.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse11()
    {
     
        JasonSpeech3.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
        ShowChoice11.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse12()
    {
      
        JasonSpeech3.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response11.gameObject.SetActive(false);
        response12.gameObject.SetActive(false);
        ShowChoice12.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        BottomBackground.gameObject.SetActive(false);
    }

    void JSpeech4()
    {
        ShowChoice3.gameObject.SetActive(false);

        Jason.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();

        Jason.texture = (Texture)JasonHappy;
        JasonSpeech5.gameObject.SetActive(true);

        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
    }

    void KSpeech4()
    {
        JasonSpeech5.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;
        KatieSpeech4.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
    }

    void JSpeech5()
    {
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(true);
        Jason.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();

        Jason.texture = (Texture)JasonHappy;
    }

    void Selection4()
    {
        JasonSpeech6.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        response4.gameObject.SetActive(true);
        response13.gameObject.SetActive(true);
        response14.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;
        BottomBackground.gameObject.SetActive(true);

        Handheld.Vibrate();
    }

    void ShowResponse4()
    {
        JasonSpeech6.gameObject.SetActive(false);
        
        response4.gameObject.SetActive(false);
        response13.gameObject.SetActive(false);
        response14.gameObject.SetActive(false);
        ShowChoice4.gameObject.SetActive(true);
       
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse13()
    {
        JasonSpeech6.gameObject.SetActive(false);
     
        response4.gameObject.SetActive(false);
        response13.gameObject.SetActive(false);
        response14.gameObject.SetActive(false);
        ShowChoice13.gameObject.SetActive(true);
        
        BottomBackground.gameObject.SetActive(false);

    }

    void ShowResponse14()
    {
        JasonSpeech6.gameObject.SetActive(false);
        
        response4.gameObject.SetActive(false);
        response13.gameObject.SetActive(false);
        response14.gameObject.SetActive(false);
        ShowChoice14.gameObject.SetActive(true);
      
        BottomBackground.gameObject.SetActive(false);
    }

    void JSpeech6()
    {
        ShowChoice4.gameObject.SetActive(false);
        ShowChoice13.gameObject.SetActive(false);
        ShowChoice14.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();

        Jason.texture = (Texture)JasonHappy;
        JasonSpeech4.gameObject.SetActive(false);
        JasonSpeech6.gameObject.SetActive(false);
        JasonSpeech7.gameObject.SetActive(true);
       
       
        Bar.gameObject.SetActive(true);
        ImageOfBar.gameObject.SetActive(true);
        Bar = (RawImage)ImageOfBar.GetComponent<RawImage>();

        Bar.texture = (Texture)Bar3;


    }

    void Selection5()
    {
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        JasonSpeech7.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieNeutral;
        response5.gameObject.SetActive(true);
        response6.gameObject.SetActive(true);
        Handheld.Vibrate();
        BottomBackground.gameObject.SetActive(true);
    }

    void ShowResponse5()
    {
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieAngry;
        ShowChoice5.gameObject.SetActive(true);
        JasonSpeech7.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        BottomBackground.gameObject.SetActive(false);
    }

    void ShowResponse6()
    {
        
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        KatieAnimator.SetBool("KatieMove", true);
        ImageOfKatie.gameObject.SetActive(true);
        MC = (RawImage)ImageOfKatie.GetComponent<RawImage>();

        MC.texture = (Texture)KatieAngry;
        ShowChoice6.gameObject.SetActive(true);
        JasonSpeech7.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        BottomBackground.gameObject.SetActive(false);
    }
    void End()
    {
        Email.gameObject.SetActive(false);
        SocialMedia.gameObject.SetActive(false);
        Messages.gameObject.SetActive(false);
        Options.gameObject.SetActive(false);
        ShowChoice6.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        ShowChoice5.gameObject.SetActive(false);
        JasonSpeech7.gameObject.SetActive(false);
        response5.gameObject.SetActive(false);
        response6.gameObject.SetActive(false);
   
        EndScreen.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        ImageOfJason.gameObject.SetActive(false);
        Bar.gameObject.SetActive(false);
        ImageOfBar.gameObject.SetActive(false);

    }

    void JSpeech7()
    {
        Jason.gameObject.SetActive(true);
        JasonAnimator.SetBool("JasonMove", true);
        ImageOfJason.gameObject.SetActive(true);
        Jason = (RawImage)ImageOfJason.GetComponent<RawImage>();

        Jason.texture = (Texture)JasonHappy;
        ShowChoice11.gameObject.SetActive(false);
        ShowChoice12.gameObject.SetActive(false);
        MC.gameObject.SetActive(false);
        ImageOfKatie.gameObject.SetActive(false);
        JasonSpeech4.gameObject.SetActive(true);
        JasonSpeech3.gameObject.SetActive(false);
        
    }
}