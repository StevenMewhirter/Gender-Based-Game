using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour
{
    public GameObject mainMenuScreen;
    public GameObject newGameScreen;
    public GameObject chapterSelectScreen;
    public GameObject optionsScreen;

    public RawImage logo;
    public Text header;

    public Button back;
    public Button options;

    public Button newGameButton;
    public Button LoadGameButton;

    public Button newStoryButton;
    public Button chapterSelectButton;

    public Button katieButton;
    public Button robinButton;
    public Button aminaButton;

    public Canvas warningOverlay;
    public Button yesButton;
    public Button noButton;


    void Awake()
    {
        // Resets menu to main screen
        mainMenuScreen.SetActive(true);
        newGameScreen.SetActive(false);
        chapterSelectScreen.SetActive(false);
        optionsScreen.SetActive(false);

        logo.gameObject.SetActive(true);
        header.gameObject.SetActive(true);

        back.gameObject.SetActive(false);
        options.gameObject.SetActive(true);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Enables relevant buttons for each screen
   public void MainMenuScreen()
    {
        mainMenuScreen.SetActive(true);
        newGameScreen.SetActive(false);
        chapterSelectScreen.SetActive(false);
        optionsScreen.SetActive(false);

        logo.gameObject.SetActive(true);
        header.gameObject.SetActive(true);

        back.gameObject.SetActive(false);
        options.gameObject.SetActive(true);
    }

   public void NewGameScreen()
    { 
        // If there is a save game, the WarningOverlay canvas will display on top of the screen 
        
        mainMenuScreen.SetActive(false);
        newGameScreen.SetActive(true);
        chapterSelectScreen.SetActive(false);
        optionsScreen.SetActive(false);

        logo.gameObject.SetActive(true);
        header.gameObject.SetActive(false);

        back.gameObject.SetActive(true);
        options.gameObject.SetActive(true);
    }

   public void ChapterSelectScreen()
    {
        mainMenuScreen.SetActive(false);
        newGameScreen.SetActive(false);
        chapterSelectScreen.SetActive(true);
        optionsScreen.SetActive(false);

        logo.gameObject.SetActive(false);
        header.gameObject.SetActive(false);

        back.gameObject.SetActive(true);
        options.gameObject.SetActive(false);
    }

   public void OptionsScreen()
    {
        mainMenuScreen.SetActive(false);
        newGameScreen.SetActive(false);
        chapterSelectScreen.SetActive(false);
        optionsScreen.SetActive(true);

        logo.gameObject.SetActive(false);
        header.gameObject.SetActive(false);

        back.gameObject.SetActive(true);
        options.gameObject.SetActive(false);
    }
}
