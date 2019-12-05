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


    void Update()
    {
        if (!functionCalled)
        {
            functionCalled = true;
            StartCoroutine(ShowText());

        }
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
