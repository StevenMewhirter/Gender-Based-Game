using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RobinValueStatic : MonoBehaviour
{
  static public float RValue = 0;
  public Slider RobinSlider;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        RobinSlider.value = RValue;
       // RValue += Time.deltaTime * 1.5f;
        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log(RValue +"Robin");
        }
    }
}
