using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour {
	private int P1 = 0;
	private int P2 = 0;
	public Text Ply1Score;
	public Text Ply2Score;
	public GameObject ball;
	void Start () {
			
	}

	void Update () {
		if (ball.transform.position.x >= 22){
			P1++;
			Ply1Score.text = P1.ToString();
		}else if (ball.transform.position.x <= -22){
			P2++;
			Ply2Score.text = P2.ToString();
		}
	}
}
