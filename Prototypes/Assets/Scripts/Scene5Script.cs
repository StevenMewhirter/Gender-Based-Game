using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class Scene5Script : MonoBehaviour
{
    public Button KatieSpeech;
    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
    public Button KatieSpeech5;

    public Button RobinSpeech;
    public Button RobinSpeech1;
    public Button RobinSpeech2;
    public Button RobinSpeech3;
    public Button RobinSpeech4;
    public Button RobinSpeech5;
    public Button RobinSpeech6;
    public Button RobinSpeech7;

    public Button Choice1;
    public Button Choice2;
    public Button Choice3;

    public GameObject BackgroundBox;

    public GameObject KatieImage;
    public Texture KatieNeutral;
    public Texture KatieSad;
    public Texture KatieHappy;
    public Texture KatieAngry;
    public RawImage MC;

    public GameObject RobinImage;
    public Texture RobinNeutral;
    public Texture RobinSad;
    public RawImage Robin;


    //animators for the characters
    //public Animator RobinNeutralAnimator;
    //public Animator RobinSadAnimator;
    //public Animator RobinHappyAnimator;
    //public Animator KatieNeutralAnimator;
    //public Animator KatieSadAnimator;
    //public Animator KatieHappyAnimator;
    //public Animator KatieAngryAnimator;

    public Animator RobinAnimator;
    public Animator KatieAnimator;

    // Start is called before the first frame update
    void Start()
    {
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinSad;

        RobinAnimator.SetBool("RobinNeutral", true);
      //  Robin.gameObject.SetActive(false);

        BackgroundBox.gameObject.SetActive(false);

        KatieSpeech.gameObject.SetActive(false);
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

        RobinSpeech7.gameObject.SetActive(false);
        Choice1.gameObject.SetActive(false);
        Choice2.gameObject.SetActive(false);
        Choice3.gameObject.SetActive(false);

        Button C1 = Choice1.GetComponent<Button>();
        C1.onClick.AddListener(KSpeech);
        Button C2 = Choice2.GetComponent<Button>();
        C2.onClick.AddListener(RSpeech4);
        Button C3 = Choice3.GetComponent<Button>();
        C3.onClick.AddListener(RSpeech5);

        Button ch1 = RobinSpeech.GetComponent<Button>();
        ch1.onClick.AddListener(Choices1);
        Button ch2 = RobinSpeech4.GetComponent<Button>();
        ch2.onClick.AddListener(Choices2);
        Button ch3 = RobinSpeech5.GetComponent<Button>();
        ch3.onClick.AddListener(Choices3);

        Button RS1 = RobinSpeech1.GetComponent<Button>();
        RS1.onClick.AddListener(RSpeech1);
        Button RS2 = RobinSpeech2.GetComponent<Button>();
        RS2.onClick.AddListener(RSpeech2);
        Button RS3 = RobinSpeech3.GetComponent<Button>();
        RS3.onClick.AddListener(RSpeech3);
        
     
        Button RS6 = RobinSpeech6.GetComponent<Button>();
        RS6.onClick.AddListener(RSpeech6);

        Button KS = KatieSpeech.GetComponent<Button>();
        KS.onClick.AddListener(RSpeech);
        Button KS1 = KatieSpeech1.GetComponent<Button>();
        KS1.onClick.AddListener(KSpeech1);
        Button KS2 = KatieSpeech2.GetComponent<Button>();
        KS2.onClick.AddListener(KSpeech2);
        Button KS3 = KatieSpeech3.GetComponent<Button>();
        KS3.onClick.AddListener(KSpeech3);
        Button KS4 = KatieSpeech4.GetComponent<Button>();
        KS4.onClick.AddListener(KSpeech4);
        Button KS5 = KatieSpeech5.GetComponent<Button>();
        KS5.onClick.AddListener(KSpeech5);

        Handheld.Vibrate();
    }

    void Update()
    {

    }

    //Katie - "I hate to see you like this. You should ask for a couple days off"

        void Choices1()
    {


        Choice1.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);
        
        BackgroundBox.gameObject.SetActive(true);
        RobinSpeech.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        KatieAnimator.SetBool("KatieNeutral", true);
    }

    void KSpeech()
        {
        Choice1.gameObject.SetActive(false);
        BackgroundBox.gameObject.SetActive(false);
        KatieSpeech.gameObject.SetActive(true);
        RobinSpeech.gameObject.SetActive(false);

        Robin.gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieSad;
        KatieAnimator.SetBool("KatieNeutral", true);
    }

    //Robin - "You're right, ill just ask amina for a week or so off"
    void RSpeech()
    {
        KatieSpeech.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);
    }

    //Robin - "That's enough whining. What do you think of your first month in the company"
    void RSpeech1()
    {
        RobinSpeech2.gameObject.SetActive(true);
        RobinSpeech1.gameObject.SetActive(false); 
    }

    //Katie - "I love the projects I've been doing"
    void RSpeech2()
    {
        KatieSpeech1.gameObject.SetActive(true);
        RobinSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieHappy;

        KatieAnimator.SetBool("KatieNeutral", true);

    }

    //Robin - "So everything is fine. Cant believe you were so stressed. Is richard still bothering you?
    void KSpeech1()
    {
        KatieSpeech1.gameObject.SetActive(false);
        RobinSpeech3.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);
    }

   
    //Katie - "Bit weird at the beginning, but only person that annoys him is Jason. I can totally understand why"
    void RSpeech3()
    {
        KatieSpeech2.gameObject.SetActive(true);
        RobinSpeech3.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        KatieAnimator.SetBool("KatieNeutral", true);

    }

    //Robin - "What do you mean?"
    void KSpeech2()
    {
        KatieSpeech2.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);



        Handheld.Vibrate();
    }

    void Choices2()
    {
        Robin.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        RobinSpeech4.gameObject.SetActive(false);
        BackgroundBox.gameObject.SetActive(true);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        KatieAnimator.SetBool("KatieNeutral", true);


        Choice2.gameObject.SetActive(true);
    }

    //Katie - "He makes fun of everyone and is so self centered"
    void RSpeech4()
    {
        BackgroundBox.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(true);
        RobinSpeech4.gameObject.SetActive(false);
        Choice2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Choice3.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieAngry;

        KatieAnimator.SetBool("KatieNeutral", true);


    }

    //Robin - "Boys will be boys. Are you sure thats all?"
    void KSpeech3()
    {
        KatieSpeech3.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(true);
       
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);

        Handheld.Vibrate();
    }

    void Choices3()
    {
       BackgroundBox.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(false);
        Choice3.gameObject.SetActive(true);
        MC.gameObject.SetActive(true);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        KatieAnimator.SetBool("KatieNeutral", true);
    }

    //Katie - "He's (Jason's) been a bit inappropriate at work"
    void RSpeech5()
    {
        BackgroundBox.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(true);
        RobinSpeech5.gameObject.SetActive(false);
        Choice3.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
    }

    //Robin - "Wasnt expecting that. Thought he was a good guy"
    void KSpeech4()
    {
        KatieSpeech4.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);
    }

    //Katie - "Lets change subject. How's david?"
    void RSpeech6()
    {
        KatieSpeech5.gameObject.SetActive(true);
        RobinSpeech6.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
        KatieAnimator.SetBool("KatieNeutral", true);

    }

    //Robin - "Leg's pretty bad, but hes in one piece. I wont let him buy a new motorcycle"
    void KSpeech5()
    {
        KatieSpeech5.gameObject.SetActive(false);
        RobinSpeech7.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;

        RobinAnimator.SetBool("RobinNeutral", true);
    }
}