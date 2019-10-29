using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{
    public GameObject txtBox;//Text box to hold text
    public GameObject response1;
    public GameObject response2;
    public GameObject response3;
    public GameObject response4;

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
    }

    // Update is called once per frame
    void Update()
    {
        theText.text = dialogue[currentLine]; //checks current line 

        if(Input.GetKeyDown(KeyCode.A))
        {
            currentLine = 1; //goes to the next line
            response1.SetActive(false);
            response2.SetActive(false);
            response3.SetActive(false);
            response4.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            currentLine = 2; //goes to the next line
            response1.SetActive(false);
            response2.SetActive(false);
            response3.SetActive(false);
            response4.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            currentLine = 3; //goes to the next line
            response1.SetActive(false);
            response2.SetActive(false);
            response3.SetActive(false);
            response4.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            currentLine = 4; //goes to the next line
            response1.SetActive(false);
            response2.SetActive(false);
            response3.SetActive(false);
            response4.SetActive(false);
        }

        if (currentLine > endLine)
        {
            txtBox.SetActive(false);
        }
    }
}
