using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void singlePlayerScene(){
        
        SceneManager.LoadScene("Main");
        
    }


    public void multiplayerScene()
    {
         
        SceneManager.LoadScene("Multiplayer");

    }

    public void aboutUs(){
        SceneManager.LoadScene("aboutUs");
        
    }

    public void exitTheGame(){
        Application.Quit();
    }




}
