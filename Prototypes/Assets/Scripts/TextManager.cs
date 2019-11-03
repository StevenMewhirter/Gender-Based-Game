using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TextManager : MonoBehaviour
{
    public GameObject txtBox;//Text box to hold text
    public Button response1;
    public Button response2;
    public Button response3;
    public Button response4;
   
    public Text theText;

    public TextAsset textFile; //stores the text file
    public string[] dialogue; //creates a list of each text line

    public int currentLine;
    public int endLine;
    // Start is called before the first frame update
    void Start()
    {
        if (textFile != null) // checks if there is text
        {
            dialogue = (textFile.text.Split('\n'));// retreiving the dialogue from file and split it into spaces
 
        
        }

        if(endLine == 0) // stops the text at the last line
        {
            endLine = dialogue.Length - 1; 
        }

        Button r1 = response1.GetComponent<Button>();
        r1.onClick.AddListener(ResponseG);
        Button r2 = response2.GetComponent<Button>();
        r2.onClick.AddListener(ResponseB);
        Button r3 = response3.GetComponent<Button>();
        r3.onClick.AddListener(ResponseS);
        Button r4 = response4.GetComponent<Button>();
        r4.onClick.AddListener(ResponseA);

    }

    void Update()
    {
        theText.text = dialogue[currentLine]; //checks current line  
    }
    void ResponseG()
    {
        theText.text = dialogue[currentLine]; //checks current line 
        currentLine = 1; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
    }

    void ResponseB()
    {
        theText.text = dialogue[currentLine]; //checks current line 
        currentLine = 2; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
    }
    void ResponseS()
    {
        theText.text = dialogue[currentLine]; //checks current line 
        currentLine = 3; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
    }
    void ResponseA()
    {
        theText.text = dialogue[currentLine]; //checks current line 
        currentLine = 4; //goes to the next line
        response1.gameObject.SetActive(false);
        response2.gameObject.SetActive(false);
        response3.gameObject.SetActive(false);
        response4.gameObject.SetActive(false);
    }
   
}
