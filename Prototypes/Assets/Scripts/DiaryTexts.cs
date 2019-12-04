using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiaryTexts : MonoBehaviour
{
    public TypeWriting dear;
    public TypeWriting main;
    public TypeWriting main1;
    public TypeWriting main2;
    public TypeWriting sign;
    //public TypeWriting katie;
    //bool dearT = false;
    //bool mainT = false;
    //bool signT = false;
    //bool start = true;
    // Start is called before the first frame update
    void Start()
    {
        dear.gameObject.SetActive(false);
        main.gameObject.SetActive(false);
        main1.gameObject.SetActive(false);
        main2.gameObject.SetActive(false);
        sign.gameObject.SetActive(false);
        //katie.gameObject.SetActive(false);
        StartCoroutine(waitForZoom());
        
    }

    // Update is called once per frame
    void Update()
    {
       // StartCoroutine(waitForDear());
        
    }

    IEnumerator waitForZoom()
    {
        yield return new WaitForSeconds(4f);
        dear.gameObject.SetActive(true);
        yield return new WaitForSeconds(1f);
        main.gameObject.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        main1.gameObject.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        main2.gameObject.SetActive(true);
        yield return new WaitForSeconds(4.5f);
        sign.gameObject.SetActive(true);
        //yield return new WaitForSeconds(0.8f);
        //katie.gameObject.SetActive(true);
        //start = false;
    }
    //IEnumerator waitForDear()
    //{
    //    yield return new WaitForSeconds(4.2f);
    //    main.gameObject.SetActive(true);
    //    //start = false;
    //}
    //IEnumerator waitForMain()
    //{
       
    //    //start = false;
    //}
}
