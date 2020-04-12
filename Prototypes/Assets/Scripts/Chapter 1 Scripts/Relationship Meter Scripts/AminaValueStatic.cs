using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AminaValueStatic : MonoBehaviour
{
    static public float AValue = 0;
    public Slider AminaSlider;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        AminaSlider.value = AValue;
        // RValue += Time.deltaTime * 1.5f;
        if (Input.GetKey(KeyCode.T))
        {
            Debug.Log(AValue + "Amina");
        }
    }
}
