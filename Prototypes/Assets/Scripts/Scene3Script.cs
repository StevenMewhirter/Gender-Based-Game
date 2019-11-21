﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Scene3Script : MonoBehaviour
{
    //declares all the buttons for Katie's Speech -SD
    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
   public Button KatieSpeech5;
    // public Button KatieSpeech6;

    //declares all the buttons for Robin's Speech -SD
    public Button RobinSpeech;
    public Button RobinSpeech1;
    public Button RobinSpeech2;
    public Button RobinSpeech3;
    public Button RobinSpeech4;
    public Button RobinSpeech5;

    //declares all the buttons for Jason's Speech -SD
    public Button JasonSpeech1;
    public Button JasonSpeech2;
    public Button JasonSpeech3;
    public Button JasonSpeech5;
    public Button JasonSpeech4;

    //declares all the buttons for Richard's Speech -SD
    public Button RichardSpeech1;
    public Button RichardSpeech2;

    //declares all the buttons for the player's choices -SD
    public Button Choice1;
    public Button Choice2;
    public Button Choice3;
    public Button Choice4;

    //all the main images for the characters -SD
    public RawImage MC;
    public RawImage Richard;
    public RawImage Robin;
    public RawImage Jason;

   
    // Start is called before the first frame update
    void Start()
    {
        //gets rid of all the objects we don't want to appear on the screen at the start of the game -SD
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        KatieSpeech5.gameObject.SetActive(false);
        //KatieSpeech6.gameObject.SetActive(false);
        Choice2.gameObject.SetActive(false);
        Choice3.gameObject.SetActive(false);
        Choice4.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(false);
        RobinSpeech3.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(false);
        JasonSpeech1.gameObject.SetActive(false);
        JasonSpeech2.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(false);
        JasonSpeech4.gameObject.SetActive(false);
        JasonSpeech5.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(false);




        //When each specified button is pressed, it will call the specified method from below and run the appropriate actions accordingly -SD
        Button c1 = Choice1.GetComponent<Button>();
        c1.onClick.AddListener(RSpeech);
        Button c2 = Choice2.GetComponent<Button>();
        c2.onClick.AddListener(RSpeech2);
        Button c3 = Choice3.GetComponent<Button>();
        c3.onClick.AddListener(RSpeech3);
        Button c4 = Choice4.GetComponent<Button>();
        c4.onClick.AddListener(JSpeech2);

        Button RS1  = RobinSpeech1.GetComponent<Button>();
        RS1.onClick.AddListener(RSpeech1);
       
        Button RS4 = RobinSpeech4.GetComponent<Button>();
        RS4.onClick.AddListener(RSpeech4);
        Button RS5 = RobinSpeech5.GetComponent<Button>();
        RS5.onClick.AddListener(RSpeech5);
        Button KS = KatieSpeech1.GetComponent<Button>();
        KS.onClick.AddListener(KSpeech);
        Button KS2 = KatieSpeech2.GetComponent<Button>();
        KS2.onClick.AddListener(KSpeech1);
        Button KS3 = KatieSpeech3.GetComponent<Button>();
        KS3.onClick.AddListener(KSpeech2);
        Button KS4 = KatieSpeech4.GetComponent<Button>();
        KS4.onClick.AddListener(KSpeech3);
        Button KS5 = KatieSpeech5.GetComponent<Button>();
        KS5.onClick.AddListener(KSpeech4);

        Button JS1 = JasonSpeech1.GetComponent<Button>();
        JS1.onClick.AddListener(JSpeech1);
        Button JS3 = JasonSpeech3.GetComponent<Button>();
        JS3.onClick.AddListener(JSpeech3);
        Button JS4 = JasonSpeech4.GetComponent<Button>();
        JS4.onClick.AddListener(JSpeech4);

        Button RIS1 = RichardSpeech1.GetComponent<Button>();
        RIS1.onClick.AddListener(RISpeech1);
        Button RIS2 = RichardSpeech2.GetComponent<Button>();
        RIS2.onClick.AddListener(RISpeech2);

    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    //when each method is called, it will run. The appropriate assets will be added to the screen or removed from the screen depending on the method that's called - SD
     void RSpeech()
    {
        //Katie will appear on screen and say "It's great" as the user has previously selected that option - SD
        KatieSpeech1.gameObject.SetActive(true);
        RobinSpeech.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
        Choice1.gameObject.SetActive(false);
    }

    void KSpeech()
    {
        //Robin will appear on screen and say "I’m so happy we’re working together bestie!” - SD
        KatieSpeech1.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
    }
    void RSpeech1()
    {
        //Katie will appear on screen and say "Me too! I wish I had something to do though…" - SD
        KatieSpeech2.gameObject.SetActive(true);
        RobinSpeech1.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void KSpeech1()
    {
        //Robin will appear on screen and say "Well, you’re lucky babes! I have your first assignment” - SD
        KatieSpeech2.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        Choice2.gameObject.SetActive(true);
    }
    void RSpeech2()
    {
        //Katie will appear on screen and say "Really? I am so excited!!!" as the user has previously selected that option - SD
        Choice2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(true);
        RobinSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void KSpeech2()
    {
        //Robin will appear on screen and say "You should be, girl! You’ll be with Jason the manager... Lucky you!” -SD
        KatieSpeech3.gameObject.SetActive(false);
        RobinSpeech3.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
        Choice3.gameObject.SetActive(true);


    }
    void RSpeech3()
    {
        //Katie will appear on screen and say "Can you not sexualize everything for once, Robin?" as the user has previously selected that option - SD
        KatieSpeech4.gameObject.SetActive(true);
        RobinSpeech3.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
        Choice3.gameObject.SetActive(false);
    }
    void KSpeech3()
    {
        //Robin will appear on screen and say "Shhhh!!! He is coming!" -SD
        KatieSpeech4.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
    }
    void RSpeech4()
    {
        //Jason will appear on screen and say "Morning ladies. Robin you look great as always" -SD
        JasonSpeech1.gameObject.SetActive(true);
        RobinSpeech4.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void JSpeech1()
    {
        //Robin will appear on screen and say "Aw, thanks Jason! I believe you haven’t met Katie..." -SD
        JasonSpeech1.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
    }
    void RSpeech5()
    {   //Jason will appear on screen and say "Nice to meet you Katie. My name is Jason. I am the manager on this floor." -SD
        JasonSpeech2.gameObject.SetActive(true);
        Choice4.gameObject.SetActive(true);
        RobinSpeech5.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void JSpeech2()
    {
        //Katie will appear on screen and say "Nice to meet you too. I’ve heard a lot about you" as the user has previously selected that option - SD
        Choice4.gameObject.SetActive(false);
        JasonSpeech2.gameObject.SetActive(false);
        KatieSpeech5.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
    }
    void KSpeech4()
    {
        //Jason will appear on screen and say "Oh, ok. I hope it’s all good stuff." -SD
        KatieSpeech5.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
    }
    void JSpeech3()
    {
        //Richard will appear on screen and say "What are you two little lovebirds doing?" -SD
        JasonSpeech3.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
    }

    void RISpeech1()
    {
        //Jason will appear on screen and say "Richie is grumpy today, but when isn’t he?" -SD
        JasonSpeech4.gameObject.SetActive(true);
        RichardSpeech1.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        Richard.gameObject.SetActive(false);
    }

    void JSpeech4()
    {
        //Richard will appear on screen and say "The poor girl is innocent and doesn’t know who to trust!" -SD
        JasonSpeech4.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
    }
    void RISpeech2()
    {
        //Jason will appear on screen and say "Miss Anderson is not a girl, she is WOMAN and she can trust whoever she wants!" -SD
        JasonSpeech5.gameObject.SetActive(true);
        RichardSpeech2.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        Richard.gameObject.SetActive(false);
    }
}
