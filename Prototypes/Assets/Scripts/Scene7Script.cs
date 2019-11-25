using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scene7Script : MonoBehaviour
{
    public Slider RobinSlide;
    // Start is called before the first frame update
    void Start()
    {
       // RelationshipSlider.RobinMeter = RobinSlide.value; // saving data
        RobinSlide.value = RelationshipSlider.RobinMeter; // load stuff
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
