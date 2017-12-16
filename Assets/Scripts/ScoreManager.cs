using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	public static int P1 = 0;
	public static int P2 = 0;
	public static string Level1 = "";
	public static string Level2 = "";
	public static string Level3 = "";
	public static int P1Wins = 0;
	public static int P2Wins = 0;

	public static void checkScore(int pl){
		if (pl == 1) {
			P1++;
		} else {
			P2++;
		}
		string sceneName = SceneManager.GetActiveScene().name;
		switch (sceneName) {
		case "Scene1":
			if (P1 >= 3 || P2 >= 3) {
				if (P1 > P2) {
					P1Wins += 1;
				} else {
					P2Wins += 1;
				}
				Level1 = "Level 1: "+P1.ToString () + " - " + P2.ToString ();
				resetScores ();
				SceneManager.LoadScene (3);
			}
			break;
		case "Scene2":
			if (P1 >= 4 || P2 >= 4) {
				if (P1 > P2) {
					P1Wins += 1;
				} else {
					P2Wins += 1;
				}
				Level2 = "Level 2: "+P1.ToString()+" - "+P2.ToString();
				resetScores ();
				SceneManager.LoadScene (4);
			}
			break;
		case "Scene3":
			if (P1 >= 5 || P2 >= 5) {
				if (P1 > P2) {
					P1Wins += 1;
				} else {
					P2Wins += 1;
				}
				Level3 = "Level 3: "+P1.ToString()+" - "+P2.ToString();
				resetScores ();
				SceneManager.LoadScene (5);
			}
			break;
		default:
			break;
		}
	}

	public static void resetScores(){
		P1 = 0;
		P2 = 0;
	}

	public static void resetGame(){
		P1Wins = 0;
		P2Wins = 0;
		P1 = 0;
		P2 = 0;
	}

	public static int getWinner(){
		if (P1Wins > P2Wins) {
			return 1;
		} else {
			return 2;
		}
	}
}
