using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextImport : MonoBehaviour
{
    public TextAsset textFile; //stores the text file
    public string[] dialogue; //creates a list of each text line
    // Start is called before the first frame update
    void Start()
    {
        if(textFile != null) // checks if there is text
        {
            dialogue = (textFile.text.Split('\n'));// retreiving the dialogue from file and split it into spaces
        }
    }

    
}
