using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JasonValueStatic : MonoBehaviour
{
    static public float JValue = 0;
    public Slider JasonSlider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        JasonSlider.value = JValue;
        // RValue += Time.deltaTime * 1.5f;
        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log(JValue + "Jason");
        }
    }
}
