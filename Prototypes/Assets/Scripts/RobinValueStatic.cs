using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobinValueStatic : MonoBehaviour
{
  public float RobinValue = 50;
  public Slider RobinSlider;
    // Start is called before the first frame update
    void Start()
    {

        RobinSlider.value = RobinValue;
    }

    // Update is called once per frame
    void Update()
    {
        // RobinSlider.value;
        RobinValue += Time.deltaTime * 1.5f;
        if (Input.GetKeyDown(KeyCode.T))
        {
            Debug.Log(RobinValue);
        }
    }
}
