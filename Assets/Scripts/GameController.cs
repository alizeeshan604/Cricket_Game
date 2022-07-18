using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController: MonoBehaviour
{
	public GameObject About;
	public GameObject StartButton;
    public GameObject BackButton;

    void Start()
    {
	    //SetGameControllerReferenceForButtons();
	    About.SetActive(true);
        StartButton.SetActive(true);
        BackButton.SetActive(true);
    }

    public void LoadAboutUs()
    {	
	    About.SetActive(false);
	    StartButton.SetActive(false);
	    SceneManager.LoadScene("AboutUs");
    }

    public void LoadMainGame()
    {
	    About.SetActive(false);
        StartButton.SetActive(false);
	    SceneManager.LoadScene("GamePlay");		
    }

    public void GoBackToHomeScreen()
    {
        About.SetActive(true);
        StartButton.SetActive(true);
        BackButton.SetActive(false);
        SceneManager.LoadScene("MainMenuScene");
    }

}
