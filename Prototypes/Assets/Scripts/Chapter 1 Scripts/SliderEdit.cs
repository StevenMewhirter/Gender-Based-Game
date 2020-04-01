using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderEdit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject RobinValue = GameObject.Find("RobinSlider");
        Dont_Destroy dontDestroyScript = RobinValue.GetComponent<Dont_Destroy>();

        Slider slider = gameObject.GetComponent<Slider>();
        slider.value = dontDestroyScript.Test;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
