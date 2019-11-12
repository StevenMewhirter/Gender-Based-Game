using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Scene3Script : MonoBehaviour
{
    public Button KatieSpeech1;
    public Button KatieSpeech2;
    public Button KatieSpeech3;
    public Button KatieSpeech4;
   public Button KatieSpeech5;
   // public Button KatieSpeech6;

    public Button RobinSpeech;
    public Button RobinSpeech1;
    public Button RobinSpeech2;
    public Button RobinSpeech3;
    public Button RobinSpeech4;
  public Button RobinSpeech5;

    public Button JasonSpeech1;
    public Button JasonSpeech2;
    public Button JasonSpeech3;
    public Button JasonSpeech5;
    public Button JasonSpeech4;

    public Button RichardSpeech1;
    public Button RichardSpeech2;

    public RawImage MC;
    public RawImage Richard;
    public RawImage Robin;
    public RawImage Jason;

   
    // Start is called before the first frame update
    void Start()
    {
        MC.gameObject.SetActive(false);
        Richard.gameObject.SetActive(false);
        Jason.gameObject.SetActive(false);
        KatieSpeech1.gameObject.SetActive(false);
        KatieSpeech2.gameObject.SetActive(false);
        KatieSpeech3.gameObject.SetActive(false);
        KatieSpeech4.gameObject.SetActive(false);
        KatieSpeech5.gameObject.SetActive(false);
        //KatieSpeech6.gameObject.SetActive(false);
       
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





        Button RS = RobinSpeech.GetComponent<Button>();
        RS.onClick.AddListener(RSpeech);
        Button RS1  = RobinSpeech1.GetComponent<Button>();
        RS1.onClick.AddListener(RSpeech1);
        Button RS2 = RobinSpeech2.GetComponent<Button>();
        RS2.onClick.AddListener(RSpeech2);
        Button RS3 = RobinSpeech3.GetComponent<Button>();
        RS3.onClick.AddListener(RSpeech3);
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
        Button JS2 = JasonSpeech2.GetComponent<Button>();
        JS2.onClick.AddListener(JSpeech2);
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
     void RSpeech()
    {
        KatieSpeech1.gameObject.SetActive(true);
        RobinSpeech.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }

    void KSpeech()
    {
        KatieSpeech1.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
    }
    void RSpeech1()
    {
        KatieSpeech2.gameObject.SetActive(true);
        RobinSpeech1.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void KSpeech1()
    {
        KatieSpeech2.gameObject.SetActive(false);
        RobinSpeech2.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
    }
    void RSpeech2()
    {
        KatieSpeech3.gameObject.SetActive(true);
        RobinSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void KSpeech2()
    {
        KatieSpeech3.gameObject.SetActive(false);
        RobinSpeech3.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
    }
    void RSpeech3()
    {
        KatieSpeech4.gameObject.SetActive(true);
        RobinSpeech3.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void KSpeech3()
    {
        KatieSpeech4.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
    }
    void RSpeech4()
    {
        JasonSpeech1.gameObject.SetActive(true);
        RobinSpeech4.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void JSpeech1()
    {
        JasonSpeech1.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        Robin.gameObject.SetActive(true);
    }
    void RSpeech5()
    {
        JasonSpeech2.gameObject.SetActive(true);
        RobinSpeech5.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        Robin.gameObject.SetActive(false);
    }
    void JSpeech2()
    {
        JasonSpeech2.gameObject.SetActive(false);
        KatieSpeech5.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
    }
    void KSpeech4()
    {
        KatieSpeech5.gameObject.SetActive(false);
        JasonSpeech3.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
    }
    void JSpeech3()
    {
        JasonSpeech3.gameObject.SetActive(false);
        RichardSpeech1.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
    }

    void RISpeech1()
    {
        JasonSpeech4.gameObject.SetActive(true);
        RichardSpeech1.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        Richard.gameObject.SetActive(false);
    }

    void JSpeech4()
    {
        JasonSpeech4.gameObject.SetActive(false);
        RichardSpeech2.gameObject.SetActive(true);
        Jason.gameObject.SetActive(false);
        Richard.gameObject.SetActive(true);
    }
    void RISpeech2()
    {
        JasonSpeech5.gameObject.SetActive(true);
        RichardSpeech2.gameObject.SetActive(false);
        Jason.gameObject.SetActive(true);
        Richard.gameObject.SetActive(false);
    }
}
