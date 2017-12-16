using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {
	private int P1 = 0;
	private int P2 = 0;

	public Text Ply1Score;
	public Text Ply2Score;
	public GameObject ball;

	void Update () {
		if (ball.transform.position.x >= 22){
			checkScore (1);
		}else if (ball.transform.position.x <= -22){
			checkScore (2);
		}
	}

	public void checkScore(int pl){
		if (pl == 1) {
			P1++;
			Ply1Score.text = P1.ToString();
		} else {
			P2++;
			Ply2Score.text = P2.ToString();
		}
		string sceneName = SceneManager.GetActiveScene().name;
		switch (sceneName) {
		case "Scene1":
			if (P1 >= 3 || P2 >= 3) {
				SceneManager.LoadScene (3);
			}
			break;
		case "Scene2":
			if (P1 >= 4 || P2 >= 4) {
				SceneManager.LoadScene (4);
			}
			break;
		case "Scene3":
			if (P1 >= 5 || P2 >= 5) {
				SceneManager.LoadScene (5);
			}
			break;
		default:
			break;
		}
	}
}
