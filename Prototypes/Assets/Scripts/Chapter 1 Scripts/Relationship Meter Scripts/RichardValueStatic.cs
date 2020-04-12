using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RichardValueStatic : MonoBehaviour
{
    static public float RichValue = 0;
    public Slider RichardSlider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        RichardSlider.value = RichValue;
        // RValue += Time.deltaTime * 1.5f;
        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log(RichValue + "Richard");
        }
    }
}
