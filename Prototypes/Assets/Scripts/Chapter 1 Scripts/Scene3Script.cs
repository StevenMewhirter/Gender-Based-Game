using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Scene3Script : MonoBehaviour
{
    public Button[] buttons;

    private UnityAction[] functionsToCall;

    public RawImage MC;
    public Texture KatieHappy;
    public Texture KatieNeutral;
    public Texture KatieAngry;
    public GameObject KatieImage;
    public DiaryTexts introScreen;
    public Button introImage;

    bool canClick = false;

    public RawImage Robin;
    public Texture RobinHappy;
    public Texture RobinNeutral;
    public GameObject RobinImage;

    public RawImage Jason;
    public Texture JasonAngry;
    public Texture JasonNeutral;
    public GameObject JasonImage;

    public RawImage Richard;
    public Texture RichardNeutral;
    public Texture RichardAngry;
    public GameObject RichardImage;




    //all the main images for the characters -SD
    //public GameObject MC;
    //public GameObject MChappy;
    //public GameObject MCangry;



    // public GameObject RichardAngry;


    //  public GameObject RobinHappy;


    // public GameObject JasonAngry;

    public GameObject Background;

    //all the animators for the characters - AB

    //public Animator animatorKatieHappy;
    //public Animator animatorKatieAngry;
    //public Animator animatorKatieNeutral;
    //public Animator animatorJasonNeutral;
    //public Animator animatorJasonAngry;
    //public Animator animatorRobinNeutral;
    //public Animator animatorRobinHappy;
    //public Animator animatorRichardNeutral;
    //public Animator animatorRichardAngry;

    public Animator animatorKatie;
    public Animator animatorJason;
    public Animator animatorRobin;
    public Animator animatorRichard;


    // Start is called before the first frame update
    public void Start()
    {

        StartCoroutine(introPanel());

        //Debug.Log("Start called in scene 3");
        for (int responseIndex = 0; responseIndex < buttons.Length; ++responseIndex)
        {
            buttons[responseIndex].gameObject.SetActive(false);
        }

        functionsToCall = new UnityAction[]
        {
            /*RSpeech,*/ Choices1, KSpeech1, RSpeech2, KSpeech2, RSpeech3, Choices2, KSpeech3, RSpeech4, Choices3,
            KSpeech4, RSpeech5, JSpeech1, RSpeech6, JSpeech2, Choices4, KSpeech5, JSpeech3,
            RISpeech1, JSpeech4, RISpeech2, JSpeech5
        };

        //gets rid of all the objects we don't want to appear on the screen at the start of the game -SD
        MC.gameObject.SetActive(false);

        Richard.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);

        Background.gameObject.SetActive(false);

        /*
		int[] arrayOfInts = new int[] { 22, 55, 66, 11, 0, 25 };
		arrayOfInts[2];
		functionsToCall[2];
		*/

        Handheld.Vibrate();

        Button Intro = introImage.GetComponent<Button>();
        Intro.onClick.AddListener(RSpeech);
        //RSpeech();

        for (int responseIndex = 0; responseIndex < buttons.Length - 1; ++responseIndex)
        {
            AddListenerToButton(buttons[responseIndex], functionsToCall[responseIndex]);
            //buttons[responseIndex].onClick.AddListener(OnButtonClick);
        }

    }

    private void AddListenerToButton(Button button, UnityEngine.Events.UnityAction functionToCall)
    {
        button.onClick.AddListener(functionToCall);
    }

    /*
	private void OnButtonClick()
	{
		AdvanceButton();//insert parameters
	}

	void AdvanceButton(RawImage image1, RawImage image2, bool displayImage1, bool displayImage2, int currentButtonIndex, GameObject imageToChange, Texture texture,
	Animator animatorCharacter, string animationName)
	{
		image1.gameObject.SetActive(displayImage1);
		image2.gameObject.SetActive(displayImage2);

		buttons[currentButtonIndex].gameObject.SetActive(true);
		if (currentButtonIndex > 0)
		{
			buttons[currentButtonIndex - 1].gameObject.SetActive(false);
		}

		imageToChange.GetComponent<RawImage>().texture = texture;

		animatorCharacter.SetBool(animationName, true);
	}
	*/

    // Update is called once per frame
    void Update()
    {

    }


    void RSpeech()
    {
        if (canClick)
        {
            Debug.Log("RSpeech called");

            introScreen.gameObject.SetActive(false);
            buttons[0].gameObject.SetActive(true);
            Robin.gameObject.SetActive(true);
            animatorRobin.SetBool("RobinNeutral", true);
        }
    }

    IEnumerator introPanel() //panel timer
    {
        yield return new WaitForSeconds(1f);
        canClick = true;
    }

    //when each method is called, it will run. The appropriate assets will be added to the screen or removed from the screen depending on the method that's called - SD
    void Choices1()
    {
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
        buttons[1].gameObject.SetActive(true);
        buttons[0].gameObject.SetActive(false);
        Background.gameObject.SetActive(true);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        animatorKatie.SetBool("KatieNeutral", true);

    }


    void KSpeech1()
    {
        //Katie will appear on screen and say "It's great" as the user has previously selected that option - SD
        MC = (RawImage)KatieImage.GetComponent<RawImage>();

        MC.texture = (Texture)KatieHappy;

        buttons[2].gameObject.SetActive(true);
        buttons[1].gameObject.SetActive(false);
        Background.gameObject.SetActive(false);

        animatorKatie.SetBool("KatieNeutral", true);

    }


    void RSpeech2()
    {
        //Robin will appear on screen and say "I’m so happy we’re working together bestie!” - SD

        Robin.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        buttons[2].gameObject.SetActive(false);
        buttons[3].gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinHappy;

        animatorRobin.SetBool("RobinNeutral", true);

    }




    void KSpeech2()
    {
        //Katie will appear on screen and say "Me too! I wish I had something to do though…" - SD
        Robin.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        buttons[4].gameObject.SetActive(true);
        buttons[3].gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        animatorKatie.SetBool("KatieNeutral", true);


    }


    void RSpeech3()
    {
        //Robin will appear on screen and say "Well, you’re lucky babes! I have your first assignment” - SD

        Robin.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        buttons[4].gameObject.SetActive(false);
        buttons[5].gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinHappy;

        animatorRobin.SetBool("RobinNeutral", true);


        Handheld.Vibrate();
    }


    void Choices2()
    {
        Robin.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        buttons[5].gameObject.SetActive(false);
        buttons[6].gameObject.SetActive(true);
        Background.gameObject.SetActive(true);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        animatorKatie.SetBool("KatieNeutral", true);
    }


    void KSpeech3()
    {
        //Katie will appear on screen and say "Really? I am so excited!!!" as the user has previously selected that option - SD
        buttons[6].gameObject.SetActive(false);
        Background.gameObject.SetActive(false);
        buttons[7].gameObject.SetActive(true);
        // buttons[6].gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        animatorKatie.SetBool("KatieNeutral", true);
    }


    void RSpeech4()
    {
        //Robin will appear on screen and say "You should be, girl! You’ll be with Jason the manager... Lucky you!” -SD
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        buttons[7].gameObject.SetActive(false);
        buttons[8].gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;

        animatorRobin.SetBool("RobinNeutral", true);

        Handheld.Vibrate();
    }


    void Choices3()
    {
        buttons[8].gameObject.SetActive(false);
        Robin.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        buttons[9].gameObject.SetActive(true);
        Background.gameObject.SetActive(true);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;


        animatorKatie.SetBool("KatieNeutral", true);


    }


    void KSpeech4()
    {
        //MC.gameObject.SetActive(true);
        //Katie will appear on screen and say "Can you not sexualize everything for once, Robin?" as the user has previously selected that option - SD
        buttons[10].gameObject.SetActive(true);
        Background.gameObject.SetActive(false);
        buttons[9].gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieAngry;


        animatorKatie.SetBool("KatieNeutral", true);
    }


    void RSpeech5()
    {
        //Robin will appear on screen and say "Shhhh!!! He is coming!" -SD
        Robin.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        buttons[10].gameObject.SetActive(false);
        buttons[11].gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinNeutral;

        animatorRobin.SetBool("RobinNeutral", true);
    }


    void JSpeech1()
    {
        //Jason will appear on screen and say "Morning ladies. Robin you look great as always" -SD
        Jason.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
        buttons[12].gameObject.SetActive(true);
        buttons[11].gameObject.SetActive(false);

        Jason = (RawImage)JasonImage.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonNeutral;


        animatorJason.SetBool("JasonNeutral", true);


    }

    /*
	int testFunction()
	{
		return 0;
	}

	void testFunction2(int i1, float f1){}
	*/

    void RSpeech6()
    {
        //Robin will appear on screen and say "Aw, thanks Jason! I believe you haven’t met Katie..." -SD
        Robin.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        buttons[12].gameObject.SetActive(false);
        buttons[13].gameObject.SetActive(true);

        Robin = (RawImage)RobinImage.GetComponent<RawImage>();
        Robin.texture = (Texture)RobinHappy;

        animatorRobin.SetBool("RobinNeutral", true);
    }


    void JSpeech2()
    {   //Jason will appear on screen and say "Nice to meet you Katie. My name is Jason. I am the manager on this floor." -SD
        buttons[14].gameObject.SetActive(true);
        buttons[13].gameObject.SetActive(false);

        Robin.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);

        Jason = (RawImage)JasonImage.GetComponent<RawImage>();

        Jason.texture = (Texture)JasonNeutral;

        // Jason.gameObject.SetActive(true);
        // Robin.gameObject.SetActive(false);
        animatorJason.SetBool("JasonNeutral", true);
        Handheld.Vibrate();
    }


    void Choices4()
    {
        Jason.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Background.gameObject.SetActive(true);
        buttons[15].gameObject.SetActive(true);
        buttons[14].gameObject.SetActive(false);

        MC = (RawImage)KatieImage.GetComponent<RawImage>();
        MC.texture = (Texture)KatieNeutral;

        animatorKatie.SetBool("KatieNeutral", true);

    }


    void KSpeech5()
    {
        //Katie will appear on screen and say "Nice to meet you too. I’ve heard a lot about you" as the user has previously selected that option - SD


        Background.gameObject.SetActive(false);
        buttons[15].gameObject.SetActive(false);
        buttons[16].gameObject.SetActive(true);

    }


    void JSpeech3()
    {
        //Jason will appear on screen and say "Oh, ok. I hope it’s all good stuff." -SD
        MC.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        buttons[16].gameObject.SetActive(false);
        buttons[17].gameObject.SetActive(true);

        Jason = (RawImage)JasonImage.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonNeutral;

        animatorJason.SetBool("JasonNeutral", true);
    }


    void RISpeech1()
    {
        //Richard will appear on screen and say "What are you two little lovebirds doing?" -SD
        Richard.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        buttons[17].gameObject.SetActive(false);
        buttons[18].gameObject.SetActive(true);

        Richard = (RawImage)RichardImage.GetComponent<RawImage>();
        Richard.texture = (Texture)RichardNeutral;

        animatorRichard.SetBool("RichardNeutral", true);
    }


    void JSpeech4()
    {
        //Jason will appear on screen and say "Richie is grumpy today, but when isn’t he?" -SD
        Richard.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        buttons[19].gameObject.SetActive(true);
        buttons[18].gameObject.SetActive(false);

        Jason = (RawImage)JasonImage.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonNeutral;

        animatorJason.SetBool("JasonNeutral", true);


    }


    void RISpeech2()
    {
        //Richard will appear on screen and say "The poor girl is innocent and doesn’t know who to trust!" -SD
        Richard.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        buttons[19].gameObject.SetActive(false);
        buttons[20].gameObject.SetActive(true);

        Richard = (RawImage)RichardImage.GetComponent<RawImage>();
        Richard.texture = (Texture)RichardAngry;

        animatorRichard.SetBool("RichardNeutral", true);

    }


    void JSpeech5()
    {
        //Jason will appear on screen and say "Miss Anderson is not a girl, she is WOMAN and she can trust whoever she wants!" -SD
        Jason.gameObject.SetActive(true);
        Richard.gameObject.SetActive(false);
        buttons[21].gameObject.SetActive(true);
        buttons[20].gameObject.SetActive(false);

        Jason = (RawImage)JasonImage.GetComponent<RawImage>();
        Jason.texture = (Texture)JasonAngry;




        //  Richard.gameObject.SetActive(false);
        animatorJason.SetBool("JasonNeutral", true);
    }
}
