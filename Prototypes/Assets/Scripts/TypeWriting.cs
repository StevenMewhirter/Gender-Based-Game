using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TypeWriting : MonoBehaviour
{
    static public float typeTime = 0.005f;
    public string fullText;
    private string currentText = "";
    bool functionCalled = false;
    //float textSpeed;


    void Update()
    {
        if (!functionCalled)
        {
            functionCalled = true;
            StartCoroutine(ShowText());

        }
        //textSpeed = OptionsScript.textSpeedSetting;
        //if (textSpeed == 1)
        //{
        //    typeTime = 0.005f * 3;
        //}
        //else if (textSpeed == 2)
        //{
        //    typeTime = 0.005f;
        //}
        //else if (textSpeed == 3)
        //{
        //    typeTime = 0.005f / 3;
        //}
    }
    IEnumerator ShowText()
    {
        for (int i = 0; i <= fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            this.GetComponent<Text>().text = currentText;
            yield return new WaitForSeconds(typeTime);
        }
    }
}
