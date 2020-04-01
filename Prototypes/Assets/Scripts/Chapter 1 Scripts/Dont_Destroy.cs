using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dont_Destroy : MonoBehaviour
{
    public int Test;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    public void SwapScenes()
    {
        SceneManager.LoadScene("Test");
    }
}
