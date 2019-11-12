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

    public RawImage MC;
    public RawImage CoWorker;
    // Start is called before the first frame update
    void Start()
    {
        MC.gameObject.SetActive(false);
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


        Button RS = RobinSpeech.GetComponent<Button>();
        RS.onClick.AddListener(RSpeech);
        Button RS1 = RobinSpeech1.GetComponent<Button>();
        RS1.onClick.AddListener(RSpeech1);
        Button RS2 = RobinSpeech2.GetComponent<Button>();
        RS2.onClick.AddListener(RSpeech2);
        Button RS3 = RobinSpeech3.GetComponent<Button>();
        RS3.onClick.AddListener(RSpeech3);
        Button RS4 = RobinSpeech4.GetComponent<Button>();
        RS4.onClick.AddListener(RSpeech4);
        Button RS5 = RobinSpeech5.GetComponent<Button>();
        RS5.onClick.AddListener(RSpeech5);
        Button RS6 = RobinSpeech6.GetComponent<Button>();
        RS6.onClick.AddListener(RSpeech6);

        Button KS = KatieSpeech.GetComponent<Button>();
        KS.onClick.AddListener(KSpeech);
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
    }

    void Update()
    {

    }
    void RSpeech()
        {
        KatieSpeech.gameObject.SetActive(true);
        RobinSpeech.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech()
    {
        KatieSpeech.gameObject.SetActive(false);
        RobinSpeech1.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void RSpeech1()
    {
        RobinSpeech2.gameObject.SetActive(true);
        RobinSpeech1.gameObject.SetActive(false); 
    }
    void RSpeech2()
    {
        KatieSpeech1.gameObject.SetActive(true);
        RobinSpeech2.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech1()
    {
        KatieSpeech1.gameObject.SetActive(false);
        RobinSpeech3.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void RSpeech3()
    {
        KatieSpeech2.gameObject.SetActive(true);
        RobinSpeech3.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech2()
    {
        KatieSpeech2.gameObject.SetActive(false);
        RobinSpeech4.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void RSpeech4()
    {
        KatieSpeech3.gameObject.SetActive(true);
        RobinSpeech4.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech3()
    {
        KatieSpeech3.gameObject.SetActive(false);
        RobinSpeech5.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void RSpeech5()
    {
        KatieSpeech4.gameObject.SetActive(true);
        RobinSpeech5.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech4()
    {
        KatieSpeech4.gameObject.SetActive(false);
        RobinSpeech6.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
    void RSpeech6()
    {
        KatieSpeech5.gameObject.SetActive(true);
        RobinSpeech6.gameObject.SetActive(false);
        MC.gameObject.SetActive(true);
        CoWorker.gameObject.SetActive(false);
    }
    void KSpeech5()
    {
        KatieSpeech5.gameObject.SetActive(false);
        RobinSpeech7.gameObject.SetActive(true);
        MC.gameObject.SetActive(false);
        CoWorker.gameObject.SetActive(true);
    }
}