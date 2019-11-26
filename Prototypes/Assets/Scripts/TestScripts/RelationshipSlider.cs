using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RelationshipSlider : MonoBehaviour
{
    public Slider RobinSlider;
    public Button RobinB;
    public static float RobinMeter;
    void Start()
    {
        RobinMeter = 50f;
        RobinSlider.value = RobinMeter;
        
        Button response = RobinB.GetComponent<Button>();
        response.onClick.AddListener(RelationshipR);
    }

  

    // Update is called once per frame
    void Update()
    {
        RobinSlider.value = RobinMeter;

    }
    void RelationshipR()
    {
        RobinMeter += 10f;

    }
}
