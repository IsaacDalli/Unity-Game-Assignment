using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinnerController : MonoBehaviour {
	public Text winnerText;
	public Text HistoryText;
	void Start () {
		winnerText.text = ScoreManager.getWinner ().ToString();
		ScoreManager.resetGame ();
		HistoryText.text = ScoreManager.Level1+"\n"+ScoreManager.Level2+"\n"+ScoreManager.Level3;
	}
}
