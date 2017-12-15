using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {
	public Button BtnPlay;
	public Button BtnQuit;
	public Button BtnAbout;

	public void startGame(){
		SceneManager.LoadScene(2);
	}
	public void quitGame(){
		Application.Quit ();
	}
	public void aboutGame(){
		SceneManager.LoadScene (1);
	}
}
