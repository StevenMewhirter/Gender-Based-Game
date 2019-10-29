using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MediaPlayer : MonoBehaviour
{

    public GameObject ImageOnPanel;  ///set this in the inspector
    public Texture NewTexture;
    public Texture NewTexture1;
    public Texture NewTexture2;
    public Texture NewTexture3;
    private RawImage img;
    public GameObject Response1;
    public GameObject Response2;

    void Start()
    {
        Response1.gameObject.SetActive(false);// hides the panel on canvas
        Response2.gameObject.SetActive(false);//hides the panel on canvas
        img = (RawImage)ImageOnPanel.GetComponent<RawImage>();
            StartCoroutine(Time());

       // img.texture = (Texture)NewTexture;
    }

  
    IEnumerator Time()
    {
        yield return new WaitForSeconds(3); // waits 3 seconds
        img.texture = (Texture)NewTexture;
        yield return new WaitForSeconds(3); // waits 3 seconds
        img.texture = (Texture)NewTexture1;
        yield return new WaitForSeconds(3); // waits 3 seconds
        Response1.gameObject.SetActive(true);// Shows the panel on canvas
        Response2.gameObject.SetActive(true);// Shows the panel on canvas
        
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
             Response1.gameObject.SetActive(false);// hides the panel on canvas
             Response2.gameObject.SetActive(false);//hides the panel on canvas
            img.texture = (Texture)NewTexture2;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            Response1.gameObject.SetActive(false);// hides the panel on canvas
            Response2.gameObject.SetActive(false);//hides the panel on canvas
            img.texture = (Texture)NewTexture3;
        }
    }
}

