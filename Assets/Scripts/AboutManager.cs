using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AboutManager : MonoBehaviour {
	public Button BtnBack;
	public void goBack(){
		SceneManager.LoadScene(0);
	}
}
