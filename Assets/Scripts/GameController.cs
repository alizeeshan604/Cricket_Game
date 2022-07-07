using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController: MonoBehavior
{
	public GameObject About;
	public GameObject StartButton;	


    void Start()
    {
	    SetGameControllerReferenceForButtons();
	    About.SetActive(true);
        StartButton.SetActive(true);	
    }

    void LoadAboutUs()
    {	
	    About.SetActive("false");
	    StartButton.SetActive("false");
	    SceneManager.LoadScene("AboutUs");
    }

    void LoadMainGame()
    {
	    About.SetActive("false");
        StartButton.SetActive("false");
	    //SceneManager.LoadScene("SampleScene");		
    }

}
