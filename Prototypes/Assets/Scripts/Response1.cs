using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Response2 : MonoBehaviour
{
    public Slider slider;
    public float trust = 50;
    public Button mybutton; 
    // Start is called before the first frame update
    void Start()
    {
        Button response = mybutton.GetComponent<Button>();
        response.onClick.AddListener(TaskOnClick);

    }

    void TaskOnClick()
    {
        trust += 50f;
        slider.value = trust;

    }
       
    // Update is called once per frame
    void Update()
    {
        
    }
}
