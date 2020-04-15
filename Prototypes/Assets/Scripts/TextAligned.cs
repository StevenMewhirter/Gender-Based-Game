using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextAligned : MonoBehaviour
{
    //this an empty gameobject (child of the text box gameobject) where the text is going to be moved to, so it always appears in the correct position
    public GameObject textBoxCenter;
    public Text thisText;
    int thisFontSize = 25;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        thisText.fontSize = thisFontSize;
        thisText.alignment = TextAnchor.UpperLeft;
        gameObject.transform.position = textBoxCenter.transform.position;
    }
}
