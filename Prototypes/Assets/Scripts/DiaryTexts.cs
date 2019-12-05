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

    // Start is called before the first frame update
    void Start()
    {
        dear.gameObject.SetActive(false);
        main.gameObject.SetActive(false);
        main1.gameObject.SetActive(false);
        main2.gameObject.SetActive(false);
        sign.gameObject.SetActive(false);
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
        yield return new WaitForSeconds(3.5f);
        main1.gameObject.SetActive(true);
        yield return new WaitForSeconds(3.5f);
        main2.gameObject.SetActive(true);
        yield return new WaitForSeconds(3f);
        sign.gameObject.SetActive(true);
    }
}
